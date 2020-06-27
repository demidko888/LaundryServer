using Loundry.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Loundry.Requests
{
    class DBRequests
    {
        public static void AddBooking(ApplicationContext database,Booking booking)
        {
            database.bookings.Add(booking);
        }

        public static void AddLaundry(ApplicationContext database,Laundry laundry)
        {
            database.laundries.Add(laundry);
        }

        public static void AddCustomer(ApplicationContext database, Customer customer)
        {
            database.customers.Add(customer);
        }

        public static void DeleteBooking(ApplicationContext database,Booking booking)
        {
            database.bookings.Remove(database.bookings.Where(x=>x.CustomerId==booking.CustomerId).FirstOrDefault());
        }

        public static void DeleteLaundry(ApplicationContext database, string laundryToDelete)
        {
            var tmp = database.laundries.Where(x => x.LaundryName == laundryToDelete).FirstOrDefault();
            database.laundries.Remove(tmp);
        }

        public static void DeleteCustomer(ApplicationContext database, Customer customer)
        {
            database.customers.Remove(database.customers.Where(x => x.Id == customer.Id).FirstOrDefault());
        }

        public static bool CheckCustomer(ApplicationContext database, Customer customer)
        {
           return database.customers.Where(x => x.Full_name == customer.Full_name).FirstOrDefault() != null;
        }

        public static bool? CheckBooking(ApplicationContext database, Booking booking)
        {
            var flag = false;
            if (!(booking.MachinesCount <= Settings.LaundrySettings.MAX_MASHINES_COUNT
                && booking.MachinesCount >= Settings.LaundrySettings.MIN_MASHINES_COUNT))
            {
                Console.WriteLine("Неправильное количество машинок");
                return false;
            }
            return true;
            //проверять в бд наличие записи (добавить)
        }

    }
}
