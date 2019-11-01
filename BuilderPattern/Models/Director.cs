using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Models
{
    class Director
    {
        IBuilder builder;

        public void Construct(IBuilder _builder)
        {
            this.builder = _builder;
            builder.StartUp();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadlights();
            builder.EndOperations();
        }
    }
}
