using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    public class ProRoom : Room
    {

        public double additionalArea;

        public void Init(double a, int p, double ad)
        {
            if (a >= 0)
            {
                area = a;
                people = p;
                additionalArea = ad;
            }
            else
            {
                Console.WriteLine("Площадь должна быть неотрицательной");
            }

        }

        public override double SizeForOnePeople()
        {
            return people == 0 ? 0 : (area + additionalArea) / people;
        }


    }
}
