using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SlackWebAPI.Data_Access_Layer;
using SlackWebAPI.Models;

namespace SlackWebAPI.Controllers
{
    public class CompanyController : ApiController
    {

        private CompanyRepository _ourCompanyRepository;

        public CompanyController()
        {
            _ourCompanyRepository = new CompanyRepository();
        }


        // GET: api/Company
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Company/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Company
        [Route("company")] 
        [HttpPost]
        public bool Post([FromBody]Company ourCompany)
        {
            return _ourCompanyRepository.InsertCompany(ourCompany);
        }

        // PUT: api/Company/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Company/5
        public void Delete(int id)
        {
        }
    }
}
