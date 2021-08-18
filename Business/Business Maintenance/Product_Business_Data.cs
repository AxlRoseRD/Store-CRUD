using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Base;
using Entities;

namespace Business.Business_Maintenance
{    
   public class Product_Business_Data
    {
        ProductData data = new ProductData();

        public void insertBusinessData(Products product) 
        {            
            data.insertData(product);
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