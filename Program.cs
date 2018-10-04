using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)

        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> newPlanetList = new List<string>(){"Neptune", "Uranus"};
            planetList.AddRange(newPlanetList);
            planetList.Insert(2,"Earth");
            planetList.Insert(4,"Venus");
             planetList.Add("Pluto");
              List<string> rockyPlanets = new List<string>(){"Mercury", "Earth", "Venus"};
             planetList.AddRange(rockyPlanets);
             planetList.Remove("Pluto");
           // planetList.ForEach(planet => Console.WriteLine(planet));
            Dictionary<string, string> Mariner = new Dictionary<string, string>
        {
            { "Venus", "Mariner" },
            { "Mars", "Mariner" },
            {"Mercury", "Mariner"}
        };
            Dictionary<string, string> Venera = new Dictionary<string, string>
        {
            { "Venus", "Venera" },
        };
         List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();


            //all probes to list
            probes.Add(Venera);
            
            probes.Add(Mariner);


            // Iterate over your list of planets from above, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.

            foreach (string planet in planetList)
            {
                //build an initial list of sting to hold the matching probe names
                List<string> visitedProbes = new List<string>();
                //iterate over all probes
                foreach (Dictionary<string, string> probe in probes)
                {
                    //Does the current planet name in th dictionary match the name of the planet in planet list
                    if (probe.ContainsKey(planet))
                    {
                        visitedProbes.Add(probe[planet]);
                    }
                }
                //output the name of the planet and comma serparted list of mathcing probes
                Console.WriteLine($"{planet}: {String.Join(",", visitedProbes)}");
        }
    }
}
