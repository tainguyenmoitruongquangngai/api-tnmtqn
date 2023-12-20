using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using new_wr_api.Dto;

namespace new_wr_api.Service
{
    public class DoanSongService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<AspNetUsers> _userManager;

        // Constructor to initialize the service with required dependencies
        public DoanSongService(DatabaseContext context, IMapper mapper, IHttpContextAccessor httpContext, UserManager<AspNetUsers> userManager)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
            _userManager = userManager;
        }

        // Method to retrieve a list of DoanSong entities based on specified filters
        public async Task<List<DoanSongDto>> GetAllAsync(string? MucPLCLNuoc)
        {
            var query = _context.DoanSong!
                .Include(ct => ct.ThongSoLtd)
                .OrderBy(x => x.IdLVSong)
                .AsQueryable();

            // Apply filters based on input parameters

            var doansong = await query.ToListAsync();

            // Map the result to DTOs
            var doanSongDtos = _mapper.Map<List<DoanSongDto>>(doansong);
            var cqc = _context.ThongSoCLNSong!.FirstOrDefault(x => x.MucPLCLNuoc == MucPLCLNuoc);


            foreach (var item in doanSongDtos)
            {
                item.ThongSoLtd = new ThongSoLtdDto
                {
                    pHTd = cqc!.pH * item.Qs * 86.4,
                    BODTd = cqc!.BOD * item.Qs * 86.4,
                    CODTd = cqc!.COD * item.Qs * 86.4,
                    TSSTd = cqc!.TSS * item.Qs * 86.4,
                    TongNTd = cqc!.TongNito * item.Qs * 86.4,
                    TongPTd = cqc!.TongPhosphor * item.Qs * 86.4,
                    TongColiformTd = cqc!.TongColiform * item.Qs * 86.4,
                    AmoniTd = cqc!.Amoni * item.Qs * 86.4,
                };
            }
            
            // Return the list of DTOs
            return doanSongDtos;
        }
        // Method to retrieve a list of DoanSong entities based on specified filters
        //public async Task<bool> CaculatorData(CaculatorLtdDto dto)
        //{
        //    var cqc = _context.ThongSoCLNSong!.FirstOrDefault(x => x.MucPLCLNuoc == "B");
        //    var qs = _context.DoanSong!.Where(x => x.Id == dto.IdDoanSong).Select(x => x.Qs).FirstOrDefault();
        //    ThongSoLtdDto? ltd = null;
        //    if (qs != null)
        //    {
        //        ltd = new ThongSoLtdDto
        //        {
        //            Id = dto.Id,
        //            IdDoanSong = dto.IdDoanSong,
        //            pHTd = cqc.pH * qs * 86.4,

        //        }
        //    }
        //}
    }
}
