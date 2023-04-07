using CompanySln.DataContext;
using CompanySln.Entities;
using CompanySln.Interface;
using Microsoft.EntityFrameworkCore;

namespace CompanySln.Repositories
{
    public class CompanyRepository : ICompanyInterface
    {
        private readonly CompanyContext _context;
        public CompanyRepository(CompanyContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateCompany(Company model)
        {
            _context.Companies.Add(model);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteCompany(long Id)
        {
            var exist = await _context.Companies.Where(c => c.Id == Id).FirstOrDefaultAsync();
            if(exist != null)
            {
                _context.Companies.Remove(exist);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Company>> GetAll()
        {
            var companies = await _context.Companies.ToListAsync();

            if(companies.Count > 0) { return companies; }
            return null;
        }

        public async Task<Company> GetSingle(long Id)
        {
            var exist = await _context.Companies.Where(c => c.Id == Id).FirstOrDefaultAsync();
            if(exist != null)
            {
                return exist;
            }
            return null;
        }

        public async Task<bool> UpdateCompany(Company model)
        {
            var exist = await _context.Companies.Where(c => c.Id == model.Id).FirstOrDefaultAsync();
            if(exist != null)
            {
                exist.Name = model.Name;
                exist.Logo = model.Logo;
                exist.Location = model.Location;

                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }
    }
}
