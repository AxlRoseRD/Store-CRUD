using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data_Base.Clases
{
    public class CustomerData
    {
        StoreEntities store = new StoreEntities();
        public void insertData(Customers customer)
        {
            store.Customers.Add(customer);
            store.SaveChanges();
        }
    }
}
