
Console.WriteLine("Hello. Welcome to array calculator with FOREACH loop!");
bool WhileFlag = false;

while (WhileFlag == false)
{
    try
    {
        Console.Write("Please input your array size: ");
        int ArrSize = Convert.ToInt32(Console.ReadLine());
        int[] Arr = new int[ArrSize];

        string UserRandomChoice = String.Empty;
        while (UserRandomChoice != "Y" && UserRandomChoice != "N")
        {
            Console.Write("Would you like to choose your array values by yourself? Otherwise it will be selected randomly by computer. (Y/N): ");
            UserRandomChoice = Console.ReadLine();
            UserRandomChoice = UserRandomChoice.ToUpper();
        }

        switch (UserRandomChoice)
        {
            case "Y":
                Console.WriteLine("The values must be between 0 and 100.");
                for (int i = 0; i < Arr.Length; i++)
                {
                    int TempInput = Convert.ToInt32(Console.ReadLine());
                    if (TempInput > 0 && TempInput < 100)
                    {
                        Arr[i] = TempInput;
                    }
                    else
                    {
                        Console.WriteLine("Your value must be between 0 and 100! Please enter again...");
                        i--;
                    }
                }
                break;
            case "N":
                Random Rand = new Random();
                Console.Write("Random Values: ");
                for (int i = 0; i < Arr.Length; i++)
                {
                    Arr[i] = Rand.Next(100);
                    Console.Write(Arr[i] + " ");
                }
                break;
        }
        int Sum = 0, Min = Int32.MaxValue, Max = 0;
        double Avg = 0;

        foreach (int i in Arr)
        {
            checked
            {
                Sum += Arr[i];
            }
            if (Max < Arr[i])
                Max = Arr[i];
            if (Min > Arr[i])
                Min = Arr[i];
        }
        Avg = (double)Sum / ArrSize;

        Console.WriteLine("\n---------------------------");
        Console.WriteLine($"Sum of Values: {Sum}\nAverage of Values: {Avg}\nMaximum Value: {Max}\nMinimum Value: {Min}");

        WhileFlag = true;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
