
//Declare Variables
using System.Text;

///<summary>
/// Dragon Hatchery Simulator
/// This is meant to answer how many dragons will be in the Hatchery after a certian time period is provided, as well as a rate that the dragons produce.
/// Created By: Chris Malone
/// Date: Sept 10, 2025
/// </summary>

//Declare Variables
int initialDragons;
int rate;
double totalRate;
int weeks;
double totalTime;
double dragonRateTime;
double totalDragons;
double roundedDragons;

//Display Title
Console.WriteLine("/t/t***********************************");
Console.WriteLine("/t/t*****Dragon Hatchery Simulator*****");
Console.WriteLine("/t/t***********************************");

//Prompt for inputs
//Prompt for Initial Amount of Dragons (intialDragons)
Console.Write("How Many Dragons at the beginning of the Hatchery Period?: ");
initialDragons = int.Parse(Console.ReadLine());
//Prompt for Rate of Dragon's increase Rate. totalRate = (100 + Rate)/100
Console.Write("How fast do the Dragons increase in population per day? (enter as a whole number): ");
rate = int.Parse(Console.ReadLine());
totalRate = (100 + rate) / 100;
//Prompt for Time of production (in weeks). totalTime = 7*weeks
Console.Write("How Many weeks in the Hatchery Period? (enter as a whole number): ");
weeks = int.Parse(Console.ReadLine());
totalTime = 7*weeks;
//Calculate how many dragons at end of provided time. totalDragons = initialDragons + (totalRate)^totalTime
//Calculate dragonRateTime = (totalRate)^totalTime
dragonRateTime = Math.Pow(totalRate, totalTime);
//Calculate totalDragons = initialDragon+dragonRateTime
totalDragons = initialDragons*dragonRateTime;
//Get totalDragons rounded.
roundedDragons = Math.Round(0.5,MidpointRounding.AwayFromZero));
//Diplay amount of Dragons rounded to whole number. 
Console.WriteLine($"At the end of {weeks} weeks ({totalTime} days), you would have a total of {totalDragons} (Approximated to be {roundedDragons}).");
//End
Console.WriteLine("Press Any Key to Exit the Simulation");
Console.ReadKey();