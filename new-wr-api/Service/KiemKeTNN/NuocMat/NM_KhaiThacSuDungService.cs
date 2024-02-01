using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Models;
using System.Security.Claims;

namespace new_wr_api.Service
{
    public class NM_KhaiThacSuDungService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public NM_KhaiThacSuDungService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public async Task<List<KKTNN_NuocMat_KhaiThacSuDungDto>> GetAllAsync()
        {
            var items = await _context.CT_ThongTin!.Where(d => d.DaXoa == false)
                .Include(d => d.Xa)
                .Include(d => d.Huyen)
                .Include(d => d.LoaiCT)
                .Include(d => d.ThongSo)
                .Include(d => d.LuuLuongTheoMucDich)
                .AsQueryable().ToListAsync();

            var newData = new List<CT_ThongTin>();

            var hochua_dapdang = items
                .Where(c => c.LoaiCT != null && new List<int> { 4, 5 }.Contains(c.LoaiCT.Id)
                            && c.ThongSo != null && c.ThongSo.DungTichToanBo != null && c.ThongSo.DungTichToanBo <= 0.01);

            newData.AddRange(hochua_dapdang);

            var dtos = _mapper.Map<List<KKTNN_NuocMat_KhaiThacSuDungDto>>(newData);

            foreach (var dto in dtos)
            {
                dto.tinh = "Quảng Ngãi";
            }

            return dtos;
        }

    }
}
