using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using new_wr_api.Data;
using new_wr_api.Dto;
using System.ComponentModel;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace new_wr_api.Service
{
    public class GP_ThongTinService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<AspNetUsers> _userManager;

        public GP_ThongTinService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext, UserManager<AspNetUsers> userManager)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
            _userManager = userManager;
        }
        public async Task<List<GP_ThongTinDto>> GetAllAsync(GPFilterFormDto filterDto)
        {
            var query = _context.GP_ThongTin!
                .Where(gp => gp.DaXoa == false)
                .Include(gp => gp.LoaiGP)
                .Include(gp => gp.ToChuc_CaNhan)
                .Include(gp => gp.CongTrinh)
                .Include(gp => gp.CongTrinh).ThenInclude(ct => ct!.HangMuc!).ThenInclude(hm => hm!.ThongSo)
                .Include(gp => gp.CongTrinh).ThenInclude(ct => ct!.ThongSo)
                .Include(gp => gp.CongTrinh).ThenInclude(ct => ct!.LoaiCT)
                .Include(gp => gp.GP_TCQ)
                .OrderBy(x => x.NgayKy)
                .AsQueryable();

            if (!string.IsNullOrEmpty(filterDto.so_gp))
            {
                query = query.Where(x => x.SoGP!.Contains(filterDto.so_gp));
            }

            if (!string.IsNullOrEmpty(filterDto.coquan_cp))
            {
                query = query.Where(x => x.CoQuanCapPhep!.Contains(filterDto.coquan_cp));
            }

            if (filterDto.tochuc_canhan > 0)
            {
                query = query.Where(x => x.IdTCCN == filterDto.tochuc_canhan);
            }

            if (filterDto.cong_trinh > 0)
            {
                query = query.Where(x => x.IdCT == filterDto.cong_trinh);
            }

            if (filterDto.loaihinh_cp > 0)
            {
                query = query.Where(x => x.IdLoaiGP == filterDto.loaihinh_cp);
            }

            if (filterDto.loai_ct > 0)
            {
                query = query.Where(gp => filterDto.loai_ct == 1 || filterDto.loai_ct == 2 || filterDto.loai_ct == 3 || filterDto.loai_ct == 24 ? gp.CongTrinh!.LoaiCT!.IdCha == filterDto.loai_ct : gp.CongTrinh!.LoaiCT!.Id == filterDto.loai_ct);
            }

            if (filterDto.huyen > 0)
            {
                query = query.Where(gp => gp.CongTrinh!.IdHuyen!.Contains(filterDto.huyen.ToString()!));
            }

            if (filterDto.xa > 0)
            {
                query = query.Where(gp => gp.CongTrinh!.IdXa!.Contains(filterDto.xa.ToString()!));
            }

            if (filterDto.tieuvung_qh > 0)
            {
                query = query.Where(gp => gp.CongTrinh!.IdTieuLuuVuc == filterDto.tieuvung_qh);
            }

            if (!string.IsNullOrEmpty(filterDto.hieuluc_gp))
            {
                switch (filterDto.hieuluc_gp.ToLower())
                {
                    case "sap-het-hieu-luc":
                        query = query
                            .Where(x => x.NgayHetHieuLuc.HasValue &&
                                        x.NgayHetHieuLuc >= DateTime.Today &&
                                        x.NgayHetHieuLuc < DateTime.Today.AddDays(160) &&
                                        x.DaBiThuHoi == false);
                        break;
                    case "het-hieu-luc":
                        query = query
                            .Where(x => x.NgayHetHieuLuc.HasValue &&
                                        x.NgayHetHieuLuc < DateTime.Today &&
                                        x.DaBiThuHoi == false);
                        break;
                    case "con-hieu-luc":
                        query = query
                            .Where(x => x.NgayHetHieuLuc.HasValue &&
                                        x.NgayHetHieuLuc > DateTime.Today.AddDays(160) &&
                                        x.DaBiThuHoi == false);
                        break;
                    case "da-bi-thu-hoi":
                        query = query.Where(x => x.DaBiThuHoi == true);
                        break;
                    default: break;
                }
            }

            var giayphep = await query.ToListAsync();

            var giayPhepDtos = _mapper.Map<List<GP_ThongTinDto>>(giayphep);

            foreach (var dto in giayPhepDtos)
            {
                if (dto.congtrinh != null)
                {
                    dto.congtrinh!.giayphep = null;
                    dto.congtrinh!.donvi_hanhchinh = _mapper.Map<DonViHCDto>(_context.DonViHC!.FirstOrDefault(x => x.IdXa!.Contains(dto.congtrinh.IdXa!)));
                }

                var gp_cu = await _context.GP_ThongTin!.Where(gp => gp.Id == dto.IdCon && gp.DaXoa == false).ToListAsync();
                if (gp_cu != null)
                {
                    dto.giayphep_cu = _mapper.Map<List<GP_ThongTinDto>>(gp_cu);
                }

                // Assuming this code is within an async method
                var tcqIds = dto.gp_tcq!.Select(x => x.IdTCQ).ToList();

                var tcqThongTinList = await _context.TCQ_ThongTin!
                    .Where(x => tcqIds.Contains(x.Id) && x.DaXoa == false)
                    .ToListAsync();

                dto.tiencq = _mapper.Map<List<TCQ_ThongTinDto>>(tcqThongTinList);

                dto.gp_tcq = null;
            }

            return giayPhepDtos;
        }

        public async Task<CountFolowLicensingAuthoritiesDto> CountFolowLicensingAuthoritiesAsync()
        {
            var totalCount = await _context.GP_ThongTin!
                .Where(gp => gp.DaXoa == false)
                .CountAsync();

            var btnmtCount = await _context.GP_ThongTin!
                .Where(gp => gp.DaXoa == false && gp.CoQuanCapPhep!.ToLower() == "btnmt")
                .CountAsync();

            var ubndtCount = await _context.GP_ThongTin!
                .Where(gp => gp.DaXoa == false && gp.CoQuanCapPhep!.ToLower() == "ubndt")
                .CountAsync();

            return new CountFolowLicensingAuthoritiesDto
            {
                Total = totalCount,
                Btnmt = btnmtCount,
                Ubndt = ubndtCount
            };
        }

        public async Task<CountFolowConstructionTypesDto> CountFolowConstructionTypesAsync()
        {
            var today = DateTime.Today;

            var query = _context.GP_ThongTin!
                .Where(gp => gp.DaXoa == false)
                .Include(gp => gp.CongTrinh).ThenInclude(ct => ct!.LoaiCT)
                .AsQueryable();

            var ktsd_nm = query.Where(gp => gp.CongTrinh!.LoaiCT!.IdCha == 1);
            var ktsd_ndd = query.Where(gp => gp.CongTrinh!.LoaiCT!.Id == 7);
            var thamdo_ndd = query.Where(gp => gp.CongTrinh!.LoaiCT!.Id == 8);
            var hnk_ndd = query.Where(gp => gp.CongTrinh!.LoaiCT!.Id == 9);
            var xathai = query.Where(gp => gp.CongTrinh!.LoaiCT!.IdCha == 3);

            return new CountFolowConstructionTypesDto
            {
                ktsd_nm = new CountFolowConsTypesData
                {
                    total = await ktsd_nm.CountAsync(),
                    con_hieuluc = await ktsd_nm.CountAsync(gp => gp.DaBiThuHoi == false && gp.NgayHetHieuLuc >= today),
                    bo_cap = await ktsd_nm.CountAsync(gp => gp.CoQuanCapPhep!.ToLower() == "btnmt"),
                    tinh_cap = await ktsd_nm.CountAsync(gp => gp.CoQuanCapPhep!.ToLower() == "ubndt"),
                },
                ktsd_ndd = new CountFolowConsTypesData
                {
                    total = await ktsd_ndd.CountAsync(),
                    con_hieuluc = await ktsd_ndd.CountAsync(gp => gp.DaBiThuHoi == false && gp.NgayHetHieuLuc >= today),
                    bo_cap = await ktsd_ndd.CountAsync(gp => gp.CoQuanCapPhep!.ToLower() == "btnmt"),
                    tinh_cap = await ktsd_ndd.CountAsync(gp => gp.CoQuanCapPhep!.ToLower() == "ubndt"),
                },
                thamdo_ndd = new CountFolowConsTypesData
                {
                    total = await thamdo_ndd.CountAsync(),
                    con_hieuluc = await thamdo_ndd.CountAsync(gp => gp.DaBiThuHoi == false && gp.NgayHetHieuLuc >= today),
                    bo_cap = await thamdo_ndd.CountAsync(gp => gp.CoQuanCapPhep!.ToLower() == "btnmt"),
                    tinh_cap = await thamdo_ndd.CountAsync(gp => gp.CoQuanCapPhep!.ToLower() == "ubndt"),
                },
                hnk_ndd = new CountFolowConsTypesData
                {
                    total = await hnk_ndd.CountAsync(),
                    con_hieuluc = await hnk_ndd.CountAsync(gp => gp.DaBiThuHoi == false && gp.NgayHetHieuLuc >= today),
                    bo_cap = await hnk_ndd.CountAsync(gp => gp.CoQuanCapPhep!.ToLower() == "btnmt"),
                    tinh_cap = await hnk_ndd.CountAsync(gp => gp.CoQuanCapPhep!.ToLower() == "ubndt"),
                },
                xathai = new CountFolowConsTypesData
                {
                    total = await xathai.CountAsync(),
                    con_hieuluc = await xathai.CountAsync(gp => gp.DaBiThuHoi == false && gp.NgayHetHieuLuc >= today),
                    bo_cap = await xathai.CountAsync(gp => gp.CoQuanCapPhep!.ToLower() == "btnmt"),
                    tinh_cap = await xathai.CountAsync(gp => gp.CoQuanCapPhep!.ToLower() == "ubndt"),
                },
            };
        }

        public async Task<LicenseStatisticsDto> LicenseStatisticsAsync(GPFilterFormDto formDto)
        {
            var query = _context.GP_ThongTin!
                .Where(gp => gp.DaXoa == false && gp.NgayKy != null)
                .Include(gp => gp.CongTrinh).ThenInclude(ct => ct!.LoaiCT)
                .AsQueryable();

            if (!string.IsNullOrEmpty(formDto.coquan_cp))
            {
                query = query.Where(x => x.CoQuanCapPhep!.Contains(formDto.coquan_cp));
            }

            if (!string.IsNullOrEmpty(formDto.hieuluc_gp))
            {
                switch (formDto.hieuluc_gp.ToLower())
                {
                    case "sap-het-hieu-luc":
                        query = query
                            .Where(x => x.NgayHetHieuLuc.HasValue &&
                                        x.NgayHetHieuLuc >= DateTime.Today &&
                                        x.NgayHetHieuLuc < DateTime.Today.AddDays(160) &&
                                        x.DaBiThuHoi == false);
                        break;
                    case "het-hieu-luc":
                        query = query
                            .Where(x => x.NgayHetHieuLuc.HasValue &&
                                        x.NgayHetHieuLuc < DateTime.Today &&
                                        x.DaBiThuHoi == false);
                        break;
                    case "con-hieu-luc":
                        query = query
                            .Where(x => x.NgayHetHieuLuc.HasValue &&
                                        x.NgayHetHieuLuc > DateTime.Today.AddDays(160) &&
                                        x.DaBiThuHoi == false);
                        break;
                    case "da-bi-thu-hoi":
                        query = query.Where(x => x.DaBiThuHoi == true);
                        break;
                    default: break;
                }
            }

            if (formDto.loaihinh_cp > 0)
            {
                query = query.Where(x => x.IdLoaiGP == formDto.loaihinh_cp);
            }

            if (formDto.tochuc_canhan > 0)
            {
                query = query.Where(x => x.IdTCCN == formDto.tochuc_canhan);
            }

            if (formDto.loai_ct > 0)
            {
                query = query.Where(gp => formDto.loai_ct == 1 || formDto.loai_ct == 2 || formDto.loai_ct == 3 || formDto.loai_ct == 24 ? gp.CongTrinh!.LoaiCT!.IdCha == formDto.loai_ct : gp.CongTrinh!.LoaiCT!.Id == formDto.loai_ct);
            }

            if (formDto.huyen > 0)
            {
                query = query.Where(gp => gp.CongTrinh!.IdHuyen!.Contains(formDto.huyen.ToString()!));
            }

            if (formDto.xa > 0)
            {
                query = query.Where(gp => gp.CongTrinh!.IdXa!.Contains(formDto.xa.ToString()!));
            }

            if (formDto.tieuvung_qh > 0)
            {
                query = query.Where(gp => gp.CongTrinh!.IdTieuLuuVuc == formDto.tieuvung_qh);
            }

            if (formDto.tang_chuanuoc > 0)
            {
                query = query.Where(gp => gp.CongTrinh!.IdTangChuaNuoc == formDto.tang_chuanuoc);
            }

            if (formDto.tu_nam > 0)
            {
                query = query.Where(x => x.NgayKy!.Value.Year >= formDto.tu_nam);
            }

            if (formDto.den_nam > 0)
            {
                query = query.Where(x => x.NgayKy!.Value.Year <= formDto.den_nam);
            }

            var categoryQueries = new List<(string, Func<IQueryable<GP_ThongTin>, IQueryable<GP_ThongTin>>)>
{
                ("Khai thác sử dụng nước mặt", q => q.Where(gp => gp.CongTrinh!.LoaiCT!.IdCha == 1)),
                ("Khai thác sử dụng nước dưới đất", q => q.Where(gp => gp.CongTrinh!.LoaiCT!.Id == 7)),
                ("Thăm dò nước dưới đất", q => q.Where(gp => gp.CongTrinh!.LoaiCT!.Id == 8)),
                ("Hành nghề khoan", q => q.Where(gp => gp.CongTrinh!.LoaiCT!.Id == 9)),
                ("Xả thải vào nguồn nước", q => q.Where(gp => gp.CongTrinh!.LoaiCT!.IdCha == 3))
            };

            var distinctYears = Enumerable.Range((int)formDto.tu_nam!, (int)(formDto.den_nam! - formDto.tu_nam! + 1)).ToArray();

            var color = new string[]
            {
            "rgb(106, 179, 230)",
            "rgb(0, 61, 126)",
            "rgb(125, 95, 58)",
            "rgb(0, 178, 151)",
            "rgb(244, 153, 23)"
            };

            var seriesList = new List<ApexChartSeriesDto>();

            foreach (var (categoryName, categoryQuery) in categoryQueries)
            {
                var categoryCounts = new int[distinctYears.Length];

                for (int j = 0; j < distinctYears.Length; j++)
                {
                    categoryCounts[j] = await categoryQuery(query)
                        .CountAsync(gp => gp.NgayKy!.Value.Year == distinctYears[j]);
                }

                seriesList.Add(new ApexChartSeriesDto
                {
                    name = categoryName,
                    data = categoryCounts.ToList() // Convert the array to a list
                });
            }

            return new LicenseStatisticsDto
            {
                color = color,
                year = distinctYears,
                series = seriesList
            };
        }



        public async Task<GP_ThongTinDto> GetByIdAsync(int Id)
        {
            var query = _context.GP_ThongTin!
                .Where(gp => gp.Id == Id && gp.DaXoa == false)
                .Include(gp => gp.LoaiGP)
                .Include(gp => gp.ToChuc_CaNhan)
                .Include(gp => gp.CongTrinh).ThenInclude(ct => ct!.HangMuc!).ThenInclude(hm => hm!.ThongSo)
                .Include(gp => gp.CongTrinh).ThenInclude(ct => ct!.ThongSo)
                .Include(gp => gp.GP_TCQ)
                .OrderBy(x => x.NgayKy)
                .AsQueryable();

            var giayphep = await query.FirstOrDefaultAsync();

            var giayPhepDto = _mapper.Map<GP_ThongTinDto>(giayphep);
            giayPhepDto.congtrinh!.donvi_hanhchinh = _mapper.Map<DonViHCDto>(_context.DonViHC!.FirstOrDefault(x => x.IdXa!.Contains(giayPhepDto.congtrinh.IdXa!)));

            // Assuming this code is within an async method
            var tcqIds = giayPhepDto.gp_tcq!.Select(x => x.IdTCQ).ToList();

            var tcqThongTinList = await _context.TCQ_ThongTin!
                .Where(x => tcqIds.Contains(x.Id) && x.DaXoa == false)
                .ToListAsync();

            giayPhepDto.tiencq = _mapper.Map<List<TCQ_ThongTinDto>>(tcqThongTinList);

            giayPhepDto.gp_tcq = null;

            return giayPhepDto;
        }

        public async Task<int> SaveAsync(GP_ThongTinDto model)
        {
            int id = 0;
            var currentUser = await _userManager.GetUserAsync(_httpContext.HttpContext!.User);
            GP_ThongTin? item = null; // Declare item variable

            var existingItem = await _context.GP_ThongTin!.FirstOrDefaultAsync(d => d.Id == model.Id && d.DaXoa == false);

            if (existingItem == null || model.Id == 0)
            {
                item = _mapper.Map<GP_ThongTin>(model);
                item.DaXoa = false;
                item.ThoiGianTao = DateTime.Now;
                item.TaiKhoanTao = currentUser != null ? currentUser.UserName : null;

                _context.GP_ThongTin!.Add(item);
            }
            else
            {
                item = existingItem; // Assign existingItem to item

                _mapper.Map(model, item); // Map properties from model to item
                item.DaXoa = false;
                item.ThoiGianSua = DateTime.Now;
                item.TaiKhoanSua = currentUser != null ? currentUser.UserName : null;
                _context.GP_ThongTin!.Update(item);
            }

            var res = await _context.SaveChangesAsync();

            // Simplified assignment of id
            id = (int)(res > 0 ? item.Id : 0);

            return id;
        }

        public async Task<bool> DeleteAsync(int Id)
        {
            var existingItem = await _context.GP_ThongTin!.FirstOrDefaultAsync(d => d.Id == Id && d.DaXoa == false);

            if (existingItem == null) { return false; }

            existingItem!.DaXoa = true;
            _context.GP_ThongTin!.Update(existingItem);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
