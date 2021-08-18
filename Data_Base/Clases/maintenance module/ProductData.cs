using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data_Base
{
    public class ProductData
    {
        StoreEntities store = new StoreEntities();

        public void insertData(Products product)
        {
            store.Products.Add(product);
            store.SaveChanges();
        }
    }
}
/*
|--------------------------------------|
|-----A--------X-------X----L----------|
|----A A---------X---X------L----------|
|---A---A----------X--------L----------|
|--A A A A-------X---X------L----------|
|-A-------A----X-------X----L----------| 
|A---------A X-----------X -L-L-L-L-L--|
|--------------------------------------|
*/