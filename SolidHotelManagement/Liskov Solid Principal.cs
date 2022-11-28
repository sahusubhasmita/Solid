using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidHotelManagement
{
    // LSP - Liskov Substitution Principal -we should use Abstract class, both method and property of Abstract class should be override by other classin LSP.
    abstract class HotelManagement
    {
        public abstract void newGuest();

        public void HotelRoom()
        {
            Console.WriteLine("Total Gusets are 5 and total 5 rooms are available");
        }

    }
    class FoodCounter : HotelManagement  // Inheritance
    {
        public override void newGuest()
        {
            Console.WriteLine("Total NewGusets are 10 and they enjoy the food in the food counter");

            Console.ReadLine();
        }
    }
    
    class Entertainment : HotelManagement 
    {
        public override void newGuest()
        {
            Console.WriteLine("Guests sastisfied this hotel's hospitality");

            Console.ReadLine();
        }
    }
   
}
