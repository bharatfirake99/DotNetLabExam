using System.Linq;
namespace DaysOfWeek
{
    internal class Program
    {
        public static void Main()
        {
            string[] daysOfWeek = {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
        };

            var dayNames = from day 
                           in daysOfWeek
                           select day;
            Console.WriteLine("Days of Week are : ");    
            foreach (var name in dayNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}