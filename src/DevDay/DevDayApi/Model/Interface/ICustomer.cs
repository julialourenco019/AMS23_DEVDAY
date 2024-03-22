using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DevDayApi.Model.Interface
{
    public interface ICustomer
    {
         void Add(Customer customer);

         IEnumerable<Customer> GetAll();
    }
}