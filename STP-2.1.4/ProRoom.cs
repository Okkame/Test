using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STP_2._1._4
{
    public class ProRoom
    {
        public double area;
        public int people;
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

        public void Read()
        {
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine("Введите площадь и количество человек:");
                if (double.TryParse(Console.ReadLine(), out double a) &&
                    int.TryParse(Console.ReadLine(), out int p)&& 
                    double.TryParse(Console.ReadLine(), out double ad))
                {
                    string n = Console.ReadLine();
                    if (a >= 0)
                    {
                        area = a;
                        people = p;
                        additionalArea = ad;
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Площадь должна быть неотрицательной");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                }
            }
        }

        public void Display()
        {
            Console.WriteLine($"Площадь: {area}, Количество человек: {people}");
        }

        public double SizeForOnePeople()
        {
            return people == 0 ? 0 : area / people;
        }

        public double GetArea() {
            return area;
        }
        public int GetPeople()
        {
            return people;
        }
    }
}
