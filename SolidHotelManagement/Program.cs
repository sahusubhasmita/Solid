using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidHotelManagement
{
   
    class Program 
    {
       
        static void Main(string[] args)
        {
            // SRP (Single Resoponsible Principal)

            HotelAdminstration hotelAdminstration = new HotelAdminstration();
           
            hotelAdminstration.HotelDetails();

            HotelGardenArea hotelGardenArea = new HotelGardenArea();

            hotelGardenArea.Flowers = "Red Rose";

            hotelGardenArea.GetHotelGardenDetails();

            // OCP (Open Closed Principal )

            HotelGuest hotelGuest = new HotelGuest();

            hotelGuest.newGuest();

            // LSP - Liskov Substitution Principal

            FoodCounter foodCounter = new FoodCounter();

            foodCounter.newGuest();

            Entertainment entertainment = new Entertainment();

            // ISP - Interface Segregation Principal

            TotalStaff totalStaff = new TotalStaff();

            totalStaff.Manager();

            Cleanness cleanness = new Cleanness();

            cleanness.Supervisor();

            //DSP - Dependency Inversion Principal

            EmployeeData employeeData = new EmployeeData(new HotelDataManagement());

            employeeData.Adminstration();
        }
    }
}
