using CompanySln.Entities;

namespace CompanySln.Interface
{
    public interface ICompanyInterface
    {
        Task<bool> CreateCompany(Company model);
        Task<Company> GetSingle(long Id);
        Task<List<Company>> GetAll();
        Task<bool> UpdateCompany(Company model);
        Task<bool> DeleteCompany(long Id);
    }
}
