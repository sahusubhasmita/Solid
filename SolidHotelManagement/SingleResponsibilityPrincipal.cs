using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidHotelManagement
{
    // SRP - Single Responsibility Principal - A class should have single responsibility , single reason for Encapsulated class
    
    public class HotelAdminstration // encapsulated class , This class is responsible for only hotels
    {
        string HotelName = "Taj";
        string GstNo = "A35555JK7890";
        string HotelLocation = "Bangalore";
        int Pin = 560066;
        string ShowHotelDetails;

        public void HotelDetails()
        {
            ShowHotelDetails = "Hotel name is " + " " + HotelName + " " + ",GST No is" + " " + GstNo

                               + " " + ",hotel location is" + " " + HotelLocation + " " + "and pin is" + " " + Pin;

            Console.WriteLine(ShowHotelDetails);

            Console.ReadLine();
        }

    }
    public class HotelGardenArea
    {
            public string Flowers;
            public void GetHotelGardenDetails()
            {
               Console.WriteLine("Nice Gardening in Taj Hotel and Total 100 different types of flowers are available in the garden and" + 
                    " " + Flowers + " " + "is very attractive." );

                Console.ReadLine();
            }
    }
    
}
