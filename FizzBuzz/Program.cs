namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the FizzBuzz Counter!");
            string repeat = "yes";
            while (repeat != "no")
            {
                CountFizzBuzz();
                Console.Write("Would you like to continue counting? [type 'no' to exit] ");
                repeat = Console.ReadLine();
            }
        }
        
        static void CountFizzBuzz()
        {
            int min = RequestInteger("Choose a starting integer: ", 1);
            int max = RequestInteger("Choose a finishing integer: ", min);
            int ruleProduct = 1;
            int rule = 1;
            Console.WriteLine("(3)Fizz  (5)Buzz  (7)Bang  (11)Bong  (13)Fezz  (17)Reverse");
            do
            {
                ruleProduct *= rule;
                rule = RequestInteger("Please enter the integer corresponding to a rule you would like to implement," +
                                      " or enter 0 if there are no further rules you would like to add: ", -1);
            } while (rule != 0);
            
            for (int i = min; i <= max; i++)
            {
                string display = "";
                if (i % 3 == 0 & ruleProduct % 3 == 0)
                {
                    display += "Fizz";
                }
                if (i % 5 == 0 & ruleProduct % 5 == 0)
                {
                    display += "Buzz";
                }
                if (i % 7 == 0 & ruleProduct % 7 == 0)
                {
                    display += "Bang";
                }
                if (i % 11 == 0 & ruleProduct % 11 == 0)
                {
                    display = "Bong";
                }

                if (i % 13 == 0 & ruleProduct % 13 == 0)
                {
                    string tempFezzDisplay = display;
                    for (int j = 0; j < tempFezzDisplay.Length; j++)
                    {
                        if (tempFezzDisplay[j] == 'B')
                        {
                            display = tempFezzDisplay.Substring(0,j) + "Fezz" + tempFezzDisplay.Substring(j);
                        }
                    }
                    if (display == tempFezzDisplay)
                    {
                        display += "Fezz";
                    }
                }

                if (i % 17 == 0 & ruleProduct % 17 == 0)
                {
                    string tempRevDisplay = display;
                    display = "";
                    for (int k = tempRevDisplay.Length; k > 0; k -= 4)
                    {
                        display += tempRevDisplay.Substring(k-4, 4);
                    }
                }
                
                
                if (display == "")
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(display);
                }
            }
        }
        
        static int RequestInteger(string text, int minimum)
        {
            int n = -1;
            string success = "no";
            while (success == "no")
            {
                Console.Write(text);
                string input = Console.ReadLine();
                if (int.TryParse(input, out n))
                {
                    if (n >= minimum)
                    {
                        success = "yes";
                    }
                    else
                    {
                        text = "That integer is too low, please choose another: ";
                    }
                }
                else
                {
                    text = "That is not a valid integer. Please enter a valid integer: ";
                }
                
            }
            return n;
        }
    }
}