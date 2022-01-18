using System;

namespace additionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var addressObj = new Address();

            addressObj.Index = "08105";
            addressObj.Country = "Украина";
            addressObj.City = "Буча";
            addressObj.Street = "Энергетиков";
            addressObj.House = "101б";
            addressObj.Apartment = 513;

            Console.WriteLine("address: " + addressObj.Index + ", " + addressObj.Country + ", " + addressObj.City + ", " + addressObj.Street + ", " + addressObj.House + ", " + addressObj.Apartment + ".");
            Console.ReadKey();
        }
    }
}
