using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_5._2
{
    class money
    {
        private double now;
        private string val;
        public money()
        {
            Random rnd = new Random();
           now =rnd.Next(1000, 10000);
            int y = rnd.Next(0, 3);
            if (y == 0) val = "RUB";
            else if(y == 1){
                val = "CNY";
            }
            else
            {
                val = "MDL";
            }
        }
        public double showM()
        {
            return now;
        }
        public string showV()
        {
            return val;
        }
        public void upd(double t)
        {
            this.now += t;
        }
    }
}
