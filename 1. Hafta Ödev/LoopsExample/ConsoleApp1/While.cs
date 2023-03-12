
Console.WriteLine("Hello. Welcome to array calculator with WHILE loop!");
bool WhileFlag = false;

while(WhileFlag == false) { 
    try
    {
        Console.Write("Please input your array size: ");
        int ArrSize = Convert.ToInt32(Console.ReadLine());
        int[] Arr = new int[ArrSize];

        string UserRandomChoice = String.Empty;
        while(UserRandomChoice != "Y" && UserRandomChoice != "N") {
            Console.Write("Would you like to choose your array values by yourself? Otherwise it will be selected randomly by computer. (Y/N): ");
            UserRandomChoice = Console.ReadLine();
            UserRandomChoice = UserRandomChoice.ToUpper();
        }

        switch (UserRandomChoice)
        {
            case "Y":
                Console.WriteLine("The values must be between 0 and 100.");
                int tempSizeFlag = 0;
                while(tempSizeFlag < ArrSize)
                {
                    int TempInput = Convert.ToInt32(Console.ReadLine());
                    if(TempInput > 0 && TempInput < 100) { 
                        Arr[tempSizeFlag] = TempInput;
                        tempSizeFlag++;
                    }
                    else
                    {
                        Console.WriteLine("Your value must be between 0 and 100! Please enter again...");
                    }
                }
                break;
            case "N":
                Random Rand = new Random();
                int tempSizeFlag2 = 0;
                Console.Write("Random Values: ");
                while (tempSizeFlag2 < ArrSize)
                {
                    Arr[tempSizeFlag2] = Rand.Next(100);
                    Console.Write(Arr[tempSizeFlag2] + " ");
                    tempSizeFlag2++;
                }
                break;
        }
        //Toplamı, Ortalaması, Standart Sapması, Modu, Minimum, Maksimum, Medyan
        int Sum = 0, Min = Int32.MaxValue, Max = 0;
        double Avg = 0;
        int TempSizeFlag = 0;

        while(TempSizeFlag < ArrSize)
        {
            checked { 
                Sum += Arr[TempSizeFlag];
            }
            if(Max < Arr[TempSizeFlag])
                Max = Arr[TempSizeFlag];
            if(Min > Arr[TempSizeFlag])
                Min = Arr[TempSizeFlag];
            TempSizeFlag++;
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
