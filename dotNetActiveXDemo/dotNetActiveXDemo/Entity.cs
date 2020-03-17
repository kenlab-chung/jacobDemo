using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotNetActiveXDemo
{
    public class Product
    {
        public string name { set; get; }
        public double price { set; get; }
    }
   public  class Entity
   {
       public Entity()
       {
           this.product = new List<Product>();
       }
       public int id { set; get; }
       public string firstname { set; get; }
       public string lastname { set; get; }
       public string context { set; get; }
       public double cost { set; get; }
       public float charge { set; get; }
       public List<Product> product { set; get; }
      
    }
}
