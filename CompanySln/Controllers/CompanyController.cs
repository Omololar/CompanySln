using CompanySln.Entities;
using CompanySln.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanySln.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyInterface _companyInterface;
        public CompanyController(ICompanyInterface companyInterface)
        {
            _companyInterface = companyInterface;
        }
        ///


        //create a company
        [HttpPost("create-company")]
        public async Task<IActionResult> CreateCompany([FromBody] Company model)
        {
            if (!ModelState.IsValid) { return BadRequest("invalid data"); }

            var createcompany = await _companyInterface.CreateCompany(model);
            return Ok(createcompany);
        }
        //get list of companies

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var getCompanies = await _companyInterface.GetAll();

            return Ok(getCompanies);
        }
        //delete a company

        [HttpDelete("{id}")]
        public async Task <IActionResult> Delete(long id)
        {
            var deleteCompany = await _companyInterface.DeleteCompany(id);
            return Ok(deleteCompany);
        }


        //edit a company
        [HttpPut("edit-company")]
        public async Task<IActionResult> EditCompany([FromBody] Company model)
        {
            var edit = await _companyInterface.UpdateCompany(model);
            return Ok(edit);
        }
        //get a single company

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleCompany(long id)
        {
            var company = await _companyInterface.GetSingle(id);
            return Ok(company);
        }
    }
}
