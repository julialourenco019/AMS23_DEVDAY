using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevDayApi;
using Microsoft.EntityFrameworkCore;
using  DevDayApi.Model;

namespace DevDayApi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Customer>? Customer {get; set;}
        //public DbSet<Product> Tabela {get; set;}
    }
}