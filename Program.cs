using System;

namespace Activity5._1._2
{
    class Program
    {
        static void Main(string [] args)
        {
            var dataSet = new MySearch();
            int val;
            int n;
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Please enter a command: ");
                Console.WriteLine("Example: ");
                Console.WriteLine("To add 5 random values: addrandom 5");
                Console.WriteLine("To add a single values: add 75");
                Console.WriteLine("To find a value in the sorted Dataset: search or find");
                Console.WriteLine("To view all array content: display");
                Console.WriteLine("To exit from the program: exit");

                command = Console.ReadLine();
                var cmdArgs = command.Split();
                if (cmdArgs.Length == 0)
                    continue;
                if (cmdArgs[0] == "addrandom")
                {
                    n = int.Parse(cmdArgs[1]);
                    dataSet.AddRandomItems(n);
                    Console.WriteLine("\nRandom Value(s) added successfully");
                }
                else if (cmdArgs[0] == "add")
                {
                    val = int.Parse(cmdArgs[1]);
                    dataSet.AddItem(val);
                    Console.WriteLine("\nValue {0} added successfully", val);
                }
                else if (cmdArgs[0] == "display")
                {
                    dataSet.DataSort();
                    dataSet.ShowArray();
                }
                else if (cmdArgs[0] == "search" || cmdArgs[0] == "find")
                {
                    int comparison = 0, pos;
                    val = int.Parse(cmdArgs[1]);
                    pos = dataSet.BinarySearch(val, ref comparison);
                    if (pos != -1)
                    {
                        Console.WriteLine("\nSearch value found at index position: {0} with {1} search comparisons.", pos, comparison);
                    }
                    else
                    {
                        Console.WriteLine("\nUnsuccessful search with {0} search comparisons.", comparison);
                    }
                }
                else if (cmdArgs[0] == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nUnknown Command!. Please enter command in proper format.");
                }

                Console.ReadKey();
            }
        }
    }
}
