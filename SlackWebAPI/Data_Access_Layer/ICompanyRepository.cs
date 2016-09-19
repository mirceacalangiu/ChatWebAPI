using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlackWebAPI.Models;

namespace SlackWebAPI.Data_Access_Layer
{
    interface ICompanyRepository
    {
        List<Company> GetCompanies(int amount, string sort);

        bool InsertCompany(Company ourCompany);

        bool DeleteCompany(int companyId);

        bool UpdateCompany(Company ourCompany);
           
    }
}
