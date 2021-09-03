using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age;
            //int dogAge;

            //Console.WriteLine("Skriv in din ålder: ");
            //age = int.Parse(Console.ReadLine());
            //dogAge = age * 7;

            //Console.WriteLine("Din ålder i hundår är: " + dogAge);




            //string firstName;
            //string middleName;
            //string surName;
            //int length;

            //Console.WriteLine("Vad heter du i förnamn?");
            //firstName = Console.ReadLine();

            //Console.WriteLine("Vad heter du i mellannamn?");
            //middleName = Console.ReadLine();

            //Console.WriteLine("Vad heter du i efternamn?");
            //surName = Console.ReadLine();

            //length = firstName.Replace(" ", " ").Length + middleName.Replace(" ", " ").Length + surName.Replace(" ", " ").Length;

            //Console.WriteLine("Ditt fulla namn har " + length + " bokstäver.");



            //bool needUmberella;
            //bool willRain = true;
            //bool rain = false;

            //if (rain || willRain)
            //{
            //    needUmberella = true;
            //    Console.WriteLine("Plocka fram PARAFLAXET din häxa!");
            //}
            //else
            //{
            //    Console.WriteLine("Solen skiner!");
            //}




            Console.WriteLine("Vilken temperaturskala vill du ange? (K för Kelvin, C för Celsius eller F för Farenheit)");
            string input = Console.ReadLine();


            if (input == "K")

            {
                Console.WriteLine("Hur många grader Kelvin?");
                float graderKelvin = float.Parse(Console.ReadLine());
                float kelvinToFarenheit = (graderKelvin * 1.8f) - 459.67f;
                float kelvinToCelsius = graderKelvin - 273.15f;
                Console.WriteLine(graderKelvin + " är lika med " + kelvinToFarenheit + " i Farenheit och " + kelvinToCelsius + " i Celsius.");
            }

            else if (input == "C")
            {
                Console.WriteLine("Hur många grader Celsius?");
                float graderCelsius = float.Parse(Console.ReadLine());
                float celsiusToFarenheit = (graderCelsius * 1.8f) + 32;
                float celsiusToKelvin = graderCelsius + 273.15f;
                Console.WriteLine(graderCelsius + "grader Celsius är lika med " + celsiusToFarenheit + " i Farenheit och " + celsiusToKelvin + " i Kelvin.");
            }
            else if (input == "F")
            {
                Console.WriteLine("Hur många grader Farenheit?");
                float graderFarenheit = float.Parse(Console.ReadLine());
                float farenheitToKelvin = (graderFarenheit + 459.67f) / 1.8f;
                float farenheitToCelsius = (graderFarenheit - 32) / 1.8f;
                Console.WriteLine(graderFarenheit + " är lika med " + farenheitToKelvin + " i Kelvin och " + farenheitToCelsius + " i Celsius.");
            }

            else
            {
                Console.WriteLine("Var god skriv in antingen K, C eller F, för helvede...");
            }

            //float gbgPrice = 7200;
            //float vbgPrice = 6999 * 0.85f;
            //float gasPrice = 16.53f;
            //float distanceVbg = 76;
            //float gasPerKm = 8 / 100f;
            //float vbgTotPrice;
            //float gasLitres = gasPerKm * distanceVbg;
            //float costVbgDrive = gasLitres * gasPrice;
            //float costVbgDriveTimesTwo = costVbgDrive * 2;

            //vbgTotPrice = vbgPrice + costVbgDriveTimesTwo;

            //Console.WriteLine("Priset i Göteborg är " + gbgPrice + "kr." + " Det totala priset för Varbergs-TVn blir " + vbgTotPrice + "kr.");


        }
    }
}
