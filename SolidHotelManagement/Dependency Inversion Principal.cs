using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidHotelManagement
{
  // DIP - Dependency Inversion Principal
     public interface IHotelData
     {
         void Adminstration();
     }
     public class HotelDataManagement : IHotelData
     {
        public void Adminstration()
        {
            Console.WriteLine("The admin handle the Adminstration Department");

            Console.ReadLine();
        }
     }

     public class EmployeeData
     {
        private readonly IHotelData _dataManagement;
        public EmployeeData(IHotelData HotelDataManagement)
        {
            _dataManagement = HotelDataManagement;
        }
        public void Adminstration()
        {
            _dataManagement.Adminstration();
        }
     }
       
}





