namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 200; i++)
            {
                string display = "";
                if (i % 3 == 0)
                {
                    display += "Fizz";
                }
                if (i % 5 == 0)
                {
                    display += "Buzz";
                }
                if (i % 7 == 0)
                {
                    display += "Bang";
                }

                if (i % 11 == 0)
                {
                    display = "Bong";
                }

                if (i % 13 == 0)
                {
                    string tempDisplay = display;
                    for (int j = 0; j < tempDisplay.Length; j++)
                    {
                        if (tempDisplay[j] == 'B')
                        {
                            display = tempDisplay.Substring(0,j) + "Fezz" + tempDisplay.Substring(j);
                        }
                    }
                    if (display == tempDisplay)
                    {
                        display += "Fezz";
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
    }
}