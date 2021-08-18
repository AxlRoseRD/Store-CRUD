using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data_Base.Clases.process_module
{
    public class StockData
    {
        StoreEntities store = new StoreEntities();
        void insertData(Stock data)
        {
            store.Stock.Add(data);
            store.SaveChanges();
        }
    }
}
