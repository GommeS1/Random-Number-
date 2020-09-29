using System;
using System.IO;
using Anemonis;
using AutoMapper;
using System.Text.Json;
using Anemonis.RandomOrg;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            var client = new RandomOrgClient("e6e6aa51-22d1-461d-9126-41761f9334f2");
            string stop;


            do
            {
                Console.WriteLine("Indtast det mindste tal: ");
                int minTal = int.Parse(Console.ReadLine());
                Console.WriteLine("Indtast det højste tal");
                int maxTal = int.Parse(Console.ReadLine());

                Console.WriteLine("Henter tal fra Random.org");
                var randomTal = client.GenerateIntegersAsync(1, minTal,maxTal, false);

                Console.WriteLine("Random tal: " + randomTal.Result.Random.Data[0]);

                Console.WriteLine("Klik på enhver tast for at prøve igen eller klik på q for at stoppe");
                stop = Console.ReadLine();
            } while (stop.ToUpper() != "Q");
        }
    }
}
