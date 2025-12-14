///<summary>
/// Program created to allow staff at "Thrilladelphia" to store and manage details about each ride.
/// Storing details such as: How thrilling a ride is, how many visitors it had, how profitable it is, and/or how terrifying it is.
/// Created By: Chris Malone
/// Created for: CPSC1012 - Abhilash Hareendranathan
/// Created: Dec 12th, 2025
/// Last updated: Dec 13, 2025
/// </summary>
internal class Program
{
    private Program()
    {
    }



    private static void Main()
    {


        Menu();


        static void Menu()
        {
            bool userQuit = false;
            int userInput = 0;

            do
            {
                // 1) Display All Rides
                Console.WriteLine("1) Display All Rides");
                // 2) Search for a Ride by Name
                Console.WriteLine("2) Search for a Ride by Name");
                // 3) Add a New Ride
                Console.WriteLine("3) Add a New Ride");
                // 4) Edit a Ride
                Console.WriteLine("4) Edit a Ride");
                // 5) Remove a Ride
                Console.WriteLine("5) Remove a Ride");
                // 6) Quit and Save
                Console.WriteLine("6) Quit and Save");
                Console.Write("Enter a letter to select a menu option: ");

                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    switch (userInput)
                    {
                        case 1:

                            //DisplayAllRides();
                            Console.WriteLine("DisplayAllRides()");
                            break;

                        case 2:

                            //SearchRideName();
                            Console.WriteLine("SearchRideName()");
                            break;
                        case 3:

                            //AddNewRide();
                            Console.WriteLine("AddNewRide()");
                            break;
                        case 4:

                            //EditARide();
                            Console.WriteLine("EditARide()");
                            break;
                        case 5:

                            //RemoveARide();
                            Console.WriteLine("RemoveARide()");
                            break;
                        case 6:

                            //SaveAndQuit();
                            userQuit = true;
                            Console.WriteLine("SaveAndQuit()");
                            break;

                        default:
                            try
                            {
                                Console.WriteLine("Input must be a number between 1-6. Examples: 1,2,3,4,5, or 6");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Input must be a number between 1-6. Examples: 1,2,3,4,5, or 6");
                            }
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input must be a number between 1-6. Examples: 1,2,3,4,5, or 6");

                }
            } while (userQuit == false);


        }
    }






  

    //Ride Class


    class Ride
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _frightfactor;
        public int FrightFactor
        {
            get { return _frightfactor; }
            set { _frightfactor = value; }
        }
        private double _cost;
        public double CostToEnter
        {
            get { return _cost; }
            set { _cost = value; }
        }
        private int _visitors;
        public int VisitorsToday
        {
            get { return _visitors; }
            set { _visitors = value; }
        }


        public Ride() { }

        // 6) - A [**greedy constructor**] (https://dagilleland.hashnode.dev/greedy-constructors)  that requires the name, fright factor, cost, and number of visitors as parameters.
        //   -Use the properties in the constructor for setting the fields to take advantage of any validation checks already coded.
        public Ride(string name, int frightfactor, double cost, int visitors)
        {
            _name = name;
            _frightfactor = frightfactor;
            _cost = cost;
            _visitors = visitors;
        }
        //     - A `string` field to store the ride’s** name** and a corresponding `Name` property with both `get` and `set` functionality.
        //   - This field cannot be empty, null, or whitespace. Ensure that the stored value is trimmed of leading and trailing whitespace.
        public void SetName(string name)
        {
            _name = name;
            bool nameValid = false;
            bool intParse = false;
            bool doubleParse = false;
            int testInt;
            double testDouble;
            do
            {
                Console.WriteLine("What is the name of the Ride?: ");
                _name = Console.ReadLine();
                intParse = int.TryParse(_name, out testInt);
                doubleParse = double.TryParse(_name, out testDouble);

                try
                {
                    if (_name == string.Empty)
                    {
                        nameValid = false;
                        Console.WriteLine("Name cannot be empty or null");
                    }
                    else if (_name == null)
                    {
                        nameValid = false;
                        Console.WriteLine("Name cannot be empty or null");
                    }
                    else if (intParse == true | doubleParse == true)
                    {
                        nameValid = false;
                        Console.WriteLine("Enter a valid name");
                    }
                    else
                    {
                        nameValid = true;
                        _name = _name.Trim();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a valid name for the ride.");
                    nameValid = false;
                }
            } while (nameValid == false);

        }
        // 2) - An `int` field for **fright factor** and a corresponding `FrightFactor` property with both `get` and `set` functionality.
        //   - The fright factor must be between 0 and 100.

        public void SetFrightFactor(int frightFactor)
        {
            _frightfactor = frightFactor;
            bool frightFactorValid = false;

            do
            {
                Console.WriteLine("Enter a Fright Factor integer of 0-100: ");
                _frightfactor = int.Parse(Console.ReadLine());
                try
                {


                    if (_frightfactor < 0 | _frightfactor > 100)
                    {
                        Console.WriteLine("Please enter a whole number between 0 and 100");
                        frightFactorValid = false;
                    }
                    else
                    {
                        frightFactorValid = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a whole number between 0 and 100");
                    frightFactorValid = false;
                }
            } while (frightFactorValid == false);
        }



        // 3) - A `double` field for the **cost** to enter and a `CostToEnter` property with both `get` and `set` functionality.
        //   - The cost must be at least 1.00.
        public void SetCostToEnter(double cost)
        { _cost = cost; }

        // 4) - An `int` field for **visitors** today and a `VisitorsToday` property with both `get` and `set` functionality.
        //   - The value for this field must be 0 or greater.
        public void SetVistorsToday(int vistorsToday)
        { _visitors = vistorsToday; }

        public string GetName()
        { return _name; }

        public int GetFrightFactor()
        { return _frightfactor; }

        public double GetCostToEnter()
        { return _cost; }

        public int GetVisitorsToday()
        { return _visitors; }

        // 8) -A read - only property named `ThrillLevel` that will return as a `string` the thrill level based on the `FrightFactor` value.
        //   | Fright Factor |	Thrill Level |
        //   | ------------- | ------------ |
        //   | 0–20          |	Mild         |
        //   | 21–60	        | Exciting     |
        //   | 61–90	        | Thrilling    |
        //   | 91–100	      | Extreme      |
        //public int ThrillLevel()
        //{
        //    
        //}

        // 9) - A `public` method named `RideDetails()` that returns a `string` with the Name, Fright Factor, Cost, Visitors, Thrill Level, and Popularity Score with labels and appropriate padding.
        // 
        //public string RideDetails(string name, int frightfactor, double cost, int visitors, string thrillLevel, )

    }

    // Menu Options
    //1
    // static void DisplayRides()
    //{
    //
    //}
    //2
    // static void SearchRidesName()
    //{
    //
    //}
    //3
    // static void AddNewRide()
    //{
    //
    //}
    //4
    // static void EditARide()
    //{
    //
    //}
    //5
    // static void RemoveARide()
    //{
    //
    //}
    //6
    // static void SaveAndQuit()
    //{
    //
    //}


}
