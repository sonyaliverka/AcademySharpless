//#region Classwork
//var allAnimals = new List<string> { "Zebra", "Elephant", "Cat", "Dog", "Lion", "Giraffe", "Parrot" };

//var sortedAnimalsLinq = allAnimals.Where(name => name.Contains('a')).Select(name => name.Replace('a', 'o')).ToList();

//var sortAnimals=new LinqHelper().SortAnimals(allAnimals);


//Console.WriteLine(String.Join(',', sortedAnimals));

//var sortedAnimalsQuery = from animal in allAnimals
//                         where animal.Contains('a')
//                         select animal.Replace('a', 'o');
//public class LinqHelper
//{

//    public List<string> SortAnimals(List<string>initialAnimals, char initialSimbol = 'a', char newSymbol = 'o')
//    {
//        var sortedAnimals = new List<string>();
//        foreach (var animal in initialAnimals)
//        {
//            if(animal.Contains(initialSimbol))
//            {
//                var newAnimal=animal.Replace (initialSimbol, newSymbol );
//                sortedAnimals.Add(newAnimal);
//            }
//        }

//        return sortedAnimals;
//    }

//}
//#endregion

class Homework
{
    //#region Task_1
    //public void Array()
    //{
    //    int[] array = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };


    //    Console.WriteLine("odd array:");

    //    for (int i = 0; i < array.Length; i ++ )
    //    {
    //        Console.Write(array[i] + " ");
    //        i++; // делает нечетные числа, возможно некорректно, зато кратко и работает 
    //    }


    //    Console.WriteLine("\neven array:");

    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        if (array[i] % 2 == 0)
    //        Console.Write(array[i] + " ");
    //    }
    //}
    //#endregion

    #region Task_2
    public void ArrayMinMax()
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
                imax = i;
            if (array[i] < array[imin])
                imin = i;
        }
        Console.WriteLine("min in your array : array[" + imin + "] = " + array[imin]);
        Console.WriteLine("max in your array : array[" + imax + "] = " + array[imax]);

        int difference = array[imax] - array[imin];

        Console.WriteLine($"difference of numbers: {difference}");
    }
    #endregion 
}




