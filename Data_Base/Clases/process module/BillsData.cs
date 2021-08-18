using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data_Base.Clases.process_module
{
    public class BillsData
    {
        StoreEntities store = new StoreEntities();
        void insertData(Bills data)
        {
            store.Bills.Add(data);
            store.SaveChanges();
        }
    }
}
