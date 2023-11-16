using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_5._2
{
    class currency
    {
        private string name;
        private double ot;
        public currency(string s,double a)
        {
            name = s;
            ot = a;
        }
        public string seeName()
        {
            return this.name;
        }
        public double seeMoney(double a)
        {
            return a / ot;
        }
        public double cor()
        {
            return ot;
        }
    }
}
