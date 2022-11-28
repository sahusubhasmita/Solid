using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidHotelManagement
{
    // Open and closed principal - class,methods and properties should be opened for extension but closed for modification and
    // basically abstract or and interface class are used .

    abstract class HotelRooms
    {
        public abstract void newGuest();

        public void HotelRoom()
        {
            Console.WriteLine("Total Gusets are 5 and total 5 rooms are available");
        }

    }
    class HotelGuest : HotelRooms // Inheritance
    {
        public override void newGuest()
        {
            Console.WriteLine("Total NewGusets are 10 and there is no room available for new Guest");

            Console.ReadLine();
        }
    }


}
