using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Models
{
    class Car : IBuilder
    {
        private string brandName;
        private Product product;

        public Car(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public void AddHeadlights()
        {
            product.Add("Headlights Added");
        }

        public void BuildBody()
        {
            product.Add("Car Body Built");
        }

        public void EndOperations()
        {
           
        }

        public Product GetVehicle()
        {
            return product;
        }

        public void InsertWheels()
        {
            product.Add("Wheels Added");
        }

        public void StartUp()
        {
            product.Add(string.Format("Car Model: {0}", this.brandName));
        }
    }
}
