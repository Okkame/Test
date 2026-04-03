using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STP_2._1._4
{
    public class RoomAdapter
    {
        public double Calc(ProRoom r)
        {
            Room temp = new Room();
            temp.people = r.people;
            temp.area = r.area+ r.additionalArea+temp.area;

            return temp.SizeForOnePeople();
        }
    }
}
