using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SlackWebAPI.Models;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace SlackWebAPI.Data_Access_Layer
{

    public class CompanyRepository : ICompanyRepository
    {


        private IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public List<Company> GetCompanies(int amount, string sort)
        {
            throw new NotImplementedException();
        }

        public bool InsertCompany(Company ourCompany)
        {
            int rowsAffected = this._db.Execute(@"INSERT INTO companies([CompanyName]) values (@CompanyName)", new { CompanyName = ourCompany.CompanyName });

            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteCompany(int companyId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCompany(Company ourCompany)
        {
            throw new NotImplementedException();
        }
    }

}
