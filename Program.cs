using System;
using System.Collections.Generic;

namespace JurasicPark
{
    class Dinosaur
    {
        public string Name { get; set; }

        public DateTime WhenAquired { get; set; } = DateTime.Now;
        public int Weight { get; set; }
        public string Diet { get; set; }
        public int EnclosureNumber { get; set; }

        public string Description()
        {

            var description = $"{Name} is a {Diet} that weighs {Weight} pounds In pen {EnclosureNumber} came in the park {WhenAquired}";

            return description;
        }




    }




    class Program
    {
        static void Main(string[] args)
        {
            var dinosaurs = new List<Dinosaur>()
          {
              new Dinosaur {
                Name = "David",
                Weight = 200,
                Diet = "Carnivore",
                EnclosureNumber = 2,
                WhenAquired = "",
              },

              new Dinosaur {
                Name = "John",
                Weight = 163,
                Diet = "Herbivore",
                EnclosureNumber = 3,
                WhenAquired = "",
              },

          };





            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Welcome to Jurasic Park");
            Console.WriteLine();
            Console.WriteLine();

            var hasQuitTheApplication = false;
            while (hasQuitTheApplication == false)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine(" View - All the Dinosaurs");
                Console.WriteLine(" Add - Add Dinosaur");
                Console.WriteLine(" Remove - Remove Dinosaur");
                Console.WriteLine(" Transfer - Transfer pen");
                Console.WriteLine(" Summary - number of carnivores and the number of herbivores");
                Console.WriteLine(" Quit - Quit the program");
                Console.WriteLine();
                Console.Write("Choice: ");
                var choice = Console.ReadLine();

                if (choice == "View")
                {
                    foreach (var dinosaur in dinosaurs)
                    {

                        Console.WriteLine(dinosaur.Description());
                    }
                }





                if (choice == "Add")
                {
                    Console.Write("Name: ");
                    var name = Console.ReadLine();

                    Console.Write("Weight: ");
                    var weightString = Console.ReadLine();
                    var weight = int.Parse(weightString);

                    Console.Write("Diet: ");
                    var diet = Console.ReadLine();

                    Console.Write("EnclosureNumber: ");
                    var enclosurenumberString = Console.ReadLine();
                    var enclosurenumber = Console.ReadLine();

                    Console.Write("WhenAquired: ");
                    var whenAquired = Console.ReadLine();
                    Console.WriteLine($"{whenAquired}");



                    var dinosaur = new Dinosaur()
                    {
                        Name = name,
                        Weight = weight,
                        Diet = diet,
                        EnclosureNumber = enclosurenumber,
                        WhenAquired = whenaquired,
                    };
                    dinosaurs.Add(dinosaur);
                }

                if (choice == "Remove")
                {
                    Console.Write("Name: ");
                    var nameOfDinosaur = Console.ReadLine();
                    var foundDinosaur = dinosaurs.FirstOrDefault(dinosaur => dinosaur.Name == nameOfDinosaur);
                    Console.WriteLine($"Are you sure you would like to remove {foundDinosaur}? YES or NO: ");
                    var answer = Console.ReadLine();
                    if (answer == "YES")
                    {
                        dinosaurs.Remove(foundDinosaur);
                    }
                    else
                    {
                        Console.WriteLine($"There is no dinosaur named {nameOfDinosaur}");
                    }
                }

                if (choice == "Transfer")
                {
                    Console.Write("Name: ");
                    var nameOfDinosaur = Console.ReadLine();
                    var foundDinosaur = dinosaurs.FirstOrDefault(dinosaur => dinosaur.Name == nameOfDinosaur);
                    if (foundDinosaur != null)
                        Console.WriteLine(foundDinosaur.Description());
                    Console.Write("Are you sure, YES or NO: ");
                    var answer = Console.ReadLine();

                    if (answer == "YES")
                    {
                        Console.Write("New enclosure number: ");
                        var newEnclosureNumber = Console.ReadLine()
                            foundDinosaur.Size = newEnclosureNumber;

                    }
                }

                if (choice == "Summary")
                {

                    // FROM SDG HANDBOOK
                    // Console.WriteLine($"There are {movies.Count()} total movies");


                }
                if (choice == "Quit")
                {
                    hasQuitTheApplication = true;
                }

            }
        }



















    }
}

