using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data_Base.Clases
{
    public class VendorsData
    {
        StoreEntities store = new StoreEntities();

        public void insertData(Vendors vendor)
        {
            store.Vendors.Add(vendor);
            store.SaveChanges();
        }
    }
}
