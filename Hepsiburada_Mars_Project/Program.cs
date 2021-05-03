using System;
using System.Linq;
using HepsiBurada_Mars_Control;

namespace Hepsiburada_Mars_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maksimum Düzlem Boyutu (Örn: 5 5 ) : ");
            var maxSize = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine("Aracı Düzlemde Konumlandır (Örn: 1 2 N ) : ");
            var startLocations = Console.ReadLine().Trim().Split(' ');
            HepsiBurada_Mars_Control.HepsiBurada_Mars_Control location = new HepsiBurada_Mars_Control.HepsiBurada_Mars_Control();

            if (startLocations.Count() == 3)
            {

                location.X = Convert.ToInt32(startLocations[0]);
                location.Y = Convert.ToInt32(startLocations[1]);
                location.Direction = (Directions)Enum.Parse(typeof(Directions), startLocations[2]);
            }
            Console.WriteLine("Geminin Hareketini Belirleyin (Örn: LMLMLMLMM) : ");
            var movement = Console.ReadLine().ToUpper();

            try
            {
                Console.WriteLine(" ");
                Console.WriteLine("===================================================");
                Console.WriteLine(" ");
                Console.WriteLine("Sonuç : ");
                Console.WriteLine(" ");

                location.StartMoving(maxSize, movement);
                Console.WriteLine($"{location.X} {location.Y} {location.Direction.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
