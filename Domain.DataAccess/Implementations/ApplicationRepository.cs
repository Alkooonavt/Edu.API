using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.DataAccess.DTO;
using Domain.DataAccess.Interfaces;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Profile = Domain.Model.Profile;

namespace Domain.DataAccess.Implementations
{
    public class ApplicationRepository : IRepository<ApplicationDTO>
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public ApplicationRepository(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _context.Applications.Add(new Application
            {
                Iin = "dasda",
                College = College.ENU,
                Profile2 = Profile.chemistry,
                Profile1 = Profile.biology,
                Score = 45
            });
            _context.SaveChanges();
        }
        public async Task<ApplicationDTO> GetById(int id)
        {
            var application = await _context.Applications.FindAsync(id);
            if (application == null) return null;
            var applicationDto = _mapper.Map<ApplicationDTO>(application);
            return applicationDto;
        }

        public async Task<IList<ApplicationDTO>> GetAll()
        {
            var applicationList = await _context.Applications.ToListAsync();
            var applicationListDto = _mapper.Map<List<ApplicationDTO>>(applicationList);
            return applicationListDto;
        }

        public async Task<ApplicationDTO> Create(ApplicationDTO entity)
        {
            var application = _mapper.Map<Application>(entity);
            var savedApplicationEntry = await _context.Applications.AddAsync(application);
            var result = await _context.SaveChangesAsync();
            var createdApplicationDto = _mapper.Map<ApplicationDTO>(savedApplicationEntry.Entity);
            return createdApplicationDto;
        }

        public async Task<ApplicationDTO> Update(int id, ApplicationDTO applicationDto)
        {
            var application = await _context.Applications.FindAsync(id);
            application.Iin = applicationDto.Iin;
            application.College = applicationDto.College;
            application.Profile1 = applicationDto.Profile1;
            application.Profile2 = applicationDto.Profile2;
            _context.Applications.Update(application);
            await _context.SaveChangesAsync();
            return _mapper.Map<ApplicationDTO>(application);
        }

        public async Task<ApplicationDTO> Remove(int id)
        {
            var application = await _context.Applications.FindAsync(id);
            _context.Applications.Remove(application);
            await _context.SaveChangesAsync();
            return _mapper.Map<ApplicationDTO>(application);
        }
    }
}