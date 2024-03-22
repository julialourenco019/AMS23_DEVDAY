using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevDayApi.Model;
using DevDayApi.Model.Interface;

namespace DevDayApi.Data.Repository
{
    public class CustomerRepository : ICustomer
    {
       public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Customer> ICustomer.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}