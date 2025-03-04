using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CRUD_API.Models;

namespace CRUD_API.Controllers
{
    public class CompanyController : ApiController
    {
        MVCEntities dc=new MVCEntities();
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetCompanies()
        {
            return Json(dc.CompanyDetails.ToList());
        }
        [HttpGet]
        [Route("{companyCode}")]
        public IHttpActionResult GetCompanyByCode(string companyCode)
        {
            var company = dc.CompanyDetails.FirstOrDefault(c => c.CompanyCode == companyCode);
            if (company == null)
                return NotFound();

            return Json(company);
        }
        [HttpPost]
        [Route("")]
        public IHttpActionResult CreateCompany([FromBody] CompanyDetail company)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            dc.CompanyDetails.Add(company);
            dc.SaveChanges();
            return Created($"api/companies/{company.CompanyCode}", company);
        }
        [HttpPut]
        [Route("{companyCode}")]
        public IHttpActionResult UpdateCompany(string companyCode, [FromBody] CompanyDetail updatedCompany)
        {
            var existingCompany = dc.CompanyDetails.FirstOrDefault(c => c.CompanyCode == companyCode);
            if (existingCompany == null)
                return NotFound();

            existingCompany.CompanyName = updatedCompany.CompanyName;
            existingCompany.CompanyAddress = updatedCompany.CompanyAddress;
            existingCompany.CompanyGSTN = updatedCompany.CompanyGSTN;
            existingCompany.CompanyUserId = updatedCompany.CompanyUserId;
            existingCompany.CompanyStatus = updatedCompany.CompanyStatus;
            existingCompany.CompanyStartDate = updatedCompany.CompanyStartDate;
            existingCompany.CompanyNatureOfWork = updatedCompany.CompanyNatureOfWork;

            dc.SaveChanges();
            return Ok(existingCompany);
        }
        [HttpDelete]
        [Route("{companyCode}")]
        public IHttpActionResult DeleteCompany(string companyCode)
        {
            var company = dc.CompanyDetails.FirstOrDefault(c => c.CompanyCode == companyCode);
            if (company == null)
                return NotFound();

            dc.CompanyDetails.Remove(company);
            dc.SaveChanges();
            return Ok();
        }
    }
}
