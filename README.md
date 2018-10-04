Practice: Planet and Spaceships
Setup
mkdir -p ~/workspace/csharp/exercises/lists && cd $_
dotnet new console
Instructions
In the Main method, place the following code

List<string> planetList = new List<string>(){"Mercury", "Mars"};
Add() Jupiter and Saturn at the end of the list.
Create another List that contains that last two planet of our solar system.
Combine the two lists by using AddRange().
Use Insert() to add Earth, and Venus in the correct order.
Use Add() again to add Pluto to the end of the list.
Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
Iterating over planets
Ref: List of Solar System probes

Create another list containing dictionaries. Each dictionary will hold the name of a spacecraft that we have launched, and the name of the planet that it has visited. If it visited more than one planet, just pick one.
List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
Iterate over your list of planets from above, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.
foreach () // iterate planets
{
    List<string> matchingProbes = new List<string>();

    foreach() // iterate probes
    {
        /*
            Does the current Dictionary contain the key of
            the current planet? Investigate the ContainsKey()
            method on a Dictionary.

            If so, add the current spacecraft to `matchingProbes`.
        */
    }

    /*
        Use String.Join(",", matchingProbes) as part of the
        solution to get the output below. It's the C# way of
        writing `array.join(",")` in JavaScript.
    */
    Console.WriteLine($"{}: {}");
}
Example Output in the Terminal
Mars: Viking, Opportunity, Curiosity
Venus: Mariner, Venera# CSharpLists
