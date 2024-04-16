namespace poe_partt1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stay = true;
            // declaring a boolean value to true to keep the programm running 
            while (stay)
            // using a while loop to make the programme running until the user is done with storing his ingredient
            {
                string[] ingredientNamesArray;
                double[] ingredientQuantitiesArray;
                string[] ingredientUnitsArray;
                string[] stepDescriptionsArray;
                // declaring our arrays

                Console.WriteLine("Hi welcome to our storing ingredient app");

                GetTheIngredients(out ingredientNamesArray, out ingredientQuantitiesArray, out ingredientUnitsArray);
                GetTheStepsMethods(out stepDescriptionsArray);
                // calling methods to allow the user to imput the datas

                double[] ingredientQuantitiesOriginalValues = new double[ingredientQuantitiesArray.Length];

                for (int i = 0; i < ingredientQuantitiesArray.Length; i++)
                {
                    ingredientQuantitiesOriginalValues[i] = ingredientQuantitiesArray[i];
                }
                // here i declared another array to store the original quantities values using a for loop according as a copy of the first quantitiesarray

                Console.WriteLine("here is the recipe saved:");
                DisplayTheRecipe(ingredientNamesArray, ingredientQuantitiesArray, ingredientUnitsArray, stepDescriptionsArray);
                // Displaying the recipe
                bool menu = true;
                while (menu)
                //using a while loop to maintain the menu
                {
                    Console.WriteLine("\n press 1 if you would like to Scale the recipe by a factor of 0.5, 2, or 3");
                    Console.WriteLine("\n press 2 if you would like to reset the quantities to the initial values");
                    Console.WriteLine("\n press 3 if you would like to clear all the data");
                    // menu
                    int response = int.Parse(Console.ReadLine());
                    if (response == 1)
                    {
                        Console.WriteLine("by how many would you like your quantities to be changed?:");
                        double factor = double.Parse(Console.ReadLine());
                        ScaleTheRecipe(ref ingredientQuantitiesArray, factor);
                        Console.WriteLine("the quantities has been updated here the new quantities:");
                        DisplayTheRecipe(ingredientNamesArray, ingredientQuantitiesArray, ingredientUnitsArray, stepDescriptionsArray);
                        // scaling the quantities
                    }
                    if (response == 2)
                    {

                        for (int i = 0; i < ingredientQuantitiesOriginalValues.Length; i++)
                        {
                            ingredientQuantitiesArray[i] = ingredientQuantitiesOriginalValues[i];
                        }

                        Console.WriteLine("\n The quantities values has been reseted");
                        Console.WriteLine("\n here is the original values:");
                        DisplayTheRecipe(ingredientNamesArray, ingredientQuantitiesArray, ingredientUnitsArray, stepDescriptionsArray);
                        // reseting the values to the original state
                    }
                    if (response == 3)
                    {
                        ClearDataMethod(out ingredientNamesArray, out ingredientQuantitiesArray, out ingredientUnitsArray, out stepDescriptionsArray);

                        menu = false;
                        // clearing data
                    }
                    else if (response > 3)
                    {
                        Console.WriteLine("\n please select a number between 1 and 3 to proceed");
                    }

                }
                Console.WriteLine("\n you cleared all the data do you want to enter another recipe ? press 1 if so and any other key to exit ");
                string response_2;
                response_2 = Console.ReadLine();
                if (response_2.Equals("1"))
                {
                    Console.WriteLine("\nEnter details for a new recipe:");
                }
                else
                {
                    Environment.Exit(0);
                    // stop the program
                }

                /// <summary>
                /// main method where we are calling the instantiating the other classes and use their methods to run the app
                /// </summary>
                /// /// --------------------------------------------------------------------------------------------------------------------------------------------
                /// 
            }
        }

        static void GetTheIngredients(out string[] ingnames, out double[] quantities, out string[] units)
        {
            Console.WriteLine("please Enter the number of ingredients:");
            int ingredientCount = int.Parse(Console.ReadLine());

            // Initialize arrays for ingredients
            ingnames = new string[ingredientCount];
            quantities = new double[ingredientCount];
            units = new string[ingredientCount];

            // Get details for each ingredient
            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Enter details for ingredient {i + 1}:");
                Console.Write("Name: ");
                ingnames[i] = Console.ReadLine();
                Console.Write("Quantity: ");
                quantities[i] = double.Parse(Console.ReadLine());
                Console.Write("Unit: ");
                units[i] = Console.ReadLine();
                /// <summary>
                /// we are using this method to get the ingredients details
                /// </summary>
                /// /// --------------------------------------------------------------------------------------------------------------------------------------------
                /// 
            }
        }

        static void GetTheStepsMethods(out string[] DescriptionsOfSteps)
        {
            Console.WriteLine("Enter the number of steps:");
            int stepCount = int.Parse(Console.ReadLine());

            // Initialize array for steps
            DescriptionsOfSteps = new string[stepCount];

            // Get descriptions for each step
            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Enter description for step {i + 1}:");
                DescriptionsOfSteps[i] = Console.ReadLine();
                /// <summary>
                /// we are using this method to get the steps for the recipe
                /// </summary>
                /// /// --------------------------------------------------------------------------------------------------------------------------------------------
                /// 
            }
        }

        static void DisplayTheRecipe(string[] Ingrnames, double[] quantities, string[] units, string[] DescriptionsOfSteps)
        {
            // Display the recipe method
            Console.WriteLine("\nRecipe:");
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < Ingrnames.Length; i++)
            {
                Console.WriteLine($"-{quantities[i]} {units[i]} of {Ingrnames[i]}");
            }
            Console.WriteLine("\nSteps:");
            for (int i = 0; i < DescriptionsOfSteps.Length; i++)
            {
                Console.WriteLine($"-{i + 1}. {DescriptionsOfSteps[i]}");

                /// <summary>
                /// we are using this method to display the recipe
                /// </summary>
                /// /// --------------------------------------------------------------------------------------------------------------------------------------------
                /// 
            }
        }

        static void ScaleTheRecipe(ref double[] quantities, double factor)
        {
            for (int i = 0; i < quantities.Length; i++)
            {
                quantities[i] *= factor;


                /// <summary>
                /// we are using this method to scal up the engredients
                /// </summary>
                /// /// --------------------------------------------------------------------------------------------------------------------------------------------
                /// 
            }
        }

        static void ClearDataMethod(out string[] Ingnames, out double[] quantities, out string[] units, out string[] DescriptionsOfSteps)
        {
            // Clearing all the data to enter a new recipe
            Ingnames = null;
            quantities = null;
            units = null;
            DescriptionsOfSteps = null;

            /// <summary>
            /// method to clear the datas
            /// </summary>
            /// /// --------------------------------------------------------------------------------------------------------------------------------------------
            /// 
        }
    }
}
