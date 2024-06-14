using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp
{
    public class Product
    {
        //attributes
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public double Price { get; set; }

        public double Stock { get; set; }


        public int PdtID
        {
            get { return ProductID; }
            set { ProductID = value; }
        }

        public string PdtName
        {
            get { return ProductName; }
            set { ProductName = value; }
        }

        public double PdtPrice
        {
            get { return Price; }
            set { Price = value; }
        }

        public double PdtStock
        {
            get { return Stock; }

            set { Stock = value; }
        }
        //default constructor

        public Product()
        {
            ProductID = 1;
            ProductName = "Laptop";
            Price = 250.0;
            Stock = 5;


        }

        //Non-default constructor

        public Product(int pdtId, string pdtName, double price, double stock)
        {
            ProductID = pdtId;
            ProductName = pdtName;
            Price = price;
            Stock = stock;

        }
        //method to increase the stock

        public void IncreaseStock(double count)
        {



            Stock = Stock + count;

        }
        //method to decrease stock
        public void DecreaseStock(double count)
        {
            if (Stock - count >= 0)
            {
                Stock = Stock - count;
            }
            else
            {
                throw new Exception("Stock cannot be Negative value");
            }
        }
        //method to set pdt id
        public void GetPdtId(int pdtId)
        {
            ProductID = pdtId;
        }
        //method to set pdt name
        public void GetPdtName(string pdtName)
        {
            ProductName = pdtName;
        }
        //method to set pdt price
        public void GetPrice(double price)

        {
            Price = price;
        }
        //method to set pdtstock
        public void GetStock(double stock)
        {
            Stock = stock;
        }


    }
}
