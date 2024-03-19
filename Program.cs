using System.Diagnostics.Metrics;

namespace CarSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation of sortedlist  
            SortedList<string, string> carList = new SortedList<string, string>();
            //add the elements in sortedlist  
            carList.Add("Ford", "Explorer");
            carList.Add("Chevrolet", "Equinox");
            carList.Add("Toyota", "Tacoma");
            carList.Add("Subaru", "Crosstrek");
            carList.Add("Jeep", "Wrangler");
            //display the elements of the sortedlist  
            Console.WriteLine("The cars in my list are:");
            foreach (KeyValuePair<string, string> car in carList)
            {
                Console.WriteLine($"Key = {car.Key}  Value={car.Value}");
            }
            Console.WriteLine("What make of car would you like to add?");
            string carMake = Console.ReadLine();

            Console.WriteLine("What model of car would you like to add?");
            string carModel = Console.ReadLine();
            
            //check for value in list
            if (carList.ContainsValue(carModel))
                Console.WriteLine($"{carModel} is one of the car models in your list");
            else
            {
                // check for country key in list (can't have dups)
                if (carList.ContainsKey(carMake))
                {
                    Console.WriteLine($"You can only enter 1 option from {carMake}. Enter y to change model.");

                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        carList.Remove(carMake);
                        carList.Add(carMake, carModel);
                        Console.WriteLine($"Your new car model {carModel} has been has been added");
                        
                    }
                    if (answer!= "y")
                    {
                        Console.WriteLine("You have entered an invalid choice.");
                        return;
                    
                    }
                   

                }
                else
                {
                    carList.Add(carMake, carModel);
                    Console.WriteLine($"{carMake} {carModel} was added to your list");
                }
                Console.WriteLine("The cars in my new list are:");
                
            }
            foreach (KeyValuePair<string, string> car in carList)
            {
                Console.WriteLine($"Key = {car.Key}  Value={car.Value}");
            }


        }
    }
}