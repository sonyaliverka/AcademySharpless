using CSharpCollections1;

new Homework().Task_4();


class Homework
{
    #region Task_1
    public void Task_1()
    {
        int[] array = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        Console.WriteLine("odd array:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
            i++; // делает нечетные числа, возможно некорректно, зато кратко и работает 
        }

        Console.WriteLine("\neven array:");

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
    #endregion

    #region Task_2
    public void Task_2()
    {
        Console.Write("enter the length of your array: ");

        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];

        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next() % 100 - 50;
        }

        Console.Write("your array: ");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(" ");

        int imin = 0, imax = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[imax])
            {
                imax = i;
            }
            if (array[i] < array[imin])
            {
                imin = i;
            }
        }
        Console.WriteLine("min in your array : array[" + imin + "] = " + array[imin]);
        Console.WriteLine("max in your array : array[" + imax + "] = " + array[imax]);

        int residual = array[imax] - array[imin];
        Console.WriteLine($"difference of numbers:  {residual} ");
    }
    #endregion

    #region Task_3
    public void Task_3()
    {
        List<string> firstNames = new List<string>
        {
            "Lecter",
            "Hobbs",
            "Graham"
        };

        firstNames.Sort();

        foreach (string str in firstNames)
        {
            Console.WriteLine(str);
        }

        Console.ReadLine();
    }

    #endregion

    #region Task_4
    public void Task_4()
    {
        List<Citizen> citizens = new List<Citizen>
        {
            new Citizen { Name = "Hannibal Lecter", BirthDate = "07.08.1944", Address = "687 Bayshore Avenue - Suite 200" },
            new Citizen { Name = "Will Graham ", BirthDate = "20.01.1975", Address = "Wolf Trap 1" },
            new Citizen { Name = "Bedelia Du Maurier", BirthDate = "09.08.1968", Address = "Wolf Trap 2" }
        };

        var result = citizens
            .Where(x => x.Address.Contains("Wolf Trap"))
            .OrderBy(x => x.Name);


        Console.ReadLine();
    }
    #endregion

    #region Task_5
    public void Task_5()
    {
        var countries = new Dictionary<string, string>()
        {
            ["Afghanistan"] = "Kabul",
            ["Republic of South Africa"] = "Cape Town",
            ["Kosovo"] = "Pristina",
            ["Pridnestrovian Moldavian Republic"] = "Tiraspol",
            ["Belarus"] = "Minsk"
        };

        foreach (var print in countries)
        {
            Console.WriteLine(print);
        }

        var capitals = new Dictionary<string, string>();

        foreach (var countri in countries)
        {
            capitals.Add(countri.Value, countri.Key);
        }

        foreach (var capital in capitals)
        {
            Console.WriteLine(capital);
        }
    }
    #endregion
}
