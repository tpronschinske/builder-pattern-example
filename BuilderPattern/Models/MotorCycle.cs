using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Models
{
    class MotorCycle : IBuilder
    {
        private string brandName;
        private Product product;

        public MotorCycle(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public void AddHeadlights()
        {
            product.Add("Headlight Added");
        }

        public void BuildBody()
        {
            product.Add("Body Built");
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
            product.Add(string.Format("MotorCycle Model: {0}", this.brandName));
        }
    }
}
