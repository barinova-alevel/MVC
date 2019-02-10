using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCNext.Models
{
    public class SquareModel
    {
        [DisplayName("Enter A")]
        public double A { get; set; }

        [DisplayName("Enter B")]
        public double B { get; set; }

        [DisplayName("Enter C")]
        public double C { get; set; }
        public List<double>  Result { get; set; }

        public SquareModel() {
            Result = new List<double>();
        }
        //
    }
}