using System;
using System.Linq;

List<string> games = new List<String>() 
{
    "Minecraft",
    "Roblox",
    "Rocket League",
    "Call Of Duty",
    "Starcraft II",
    "Fall Guys",
    "Destiny 2",
    "Fortnite"
};

games
    .OrderBy(x => x.Length)
    .ThenBy(x => x)
    .ToList()
    .ForEach(x => Console.WriteLine(x));


//Create a new console app and name it PracticeLinq.
//Create a list of video game names...
//Order the list of games by length of the game name.
//Use the lambda expression in this exercise as well.
//use Method Syntax for this exercise