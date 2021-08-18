using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data_Base.Clases.process_module
{
    public class ImputsData
    {
        StoreEntities store = new StoreEntities();        
        void insertData(Inputs data)
        {
            store.Inputs.Add(data);
            store.SaveChanges();
        }
    }
}
