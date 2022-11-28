using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidHotelManagement
{
    //ISP - Interface Segregation Principal - here we should interface 

    //Interface - An interface is a completely "abstract class", which can only contain abstract methods and properties
    public interface IHotelManagementStaff
    {
        void Manager();
    }

    public interface ICleaningStaff
    {
        void Supervisor();
    }
    public class TotalStaff: IHotelManagementStaff
    {
        public void Manager()
        {
            Console.WriteLine("Total Hotelstaffs are 100 and Manager is the head of the HotelManagement Staff");

            Console.ReadLine();
        }
    }

    public class Cleanness : ICleaningStaff
    {
        public void Supervisor()
        {
            Console.WriteLine("Total Cleaningstaffs are 50 and the supervisor is the head of the cleaning staff");

            Console.ReadLine();
        }
    }
}
