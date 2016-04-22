using HGPS.Core.Models;
using HGPS.Data;
using HGPS.Data.ModelsEF;
using System.Collections.Generic;
using System.Linq;

namespace HGPS.Core.Services
{
    public class CustomerService
    {
        private CustomerRepository repo()
        {
            HGPS_Entities dbContext = new HGPS_Entities();
            CustomerRepository repo = new CustomerRepository(dbContext);
            return repo;
        }

        public List<CustomerModel> GetCustomers()
        {
            var query = this.repo().GetCustomers().ToList();
            var rtn = AutoMapper.Mapper.Map<List<CustomerModel>>(query);
            return rtn;
        }
    }
}