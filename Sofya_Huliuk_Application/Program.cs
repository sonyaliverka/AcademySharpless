//Console.WriteLine("Hello, World!");
//Console.ReadLine();


using System.Text;

//new Homework().Task_1();

//new Homework_2().Task_10();
new Homework_3().Task_3();
new Additional().Task_1();
new Homework_2().Task_5();



class Homework
{
    public void Task_1()
    {
        int a = 96;
        double b = 12.6;
        char c = 'x';
        bool d = false;
        string e = @"
                    Roses are red,
                    My husband is dead,
                    Does anyone want to buy a 2 person bed?";

        Console.WriteLine($"{a}\n{b}\n{c}\n{d}\n{e}");
    }

    public void Task_2()
    {
        int num1 = 25;
        int num2 = 25;

        string king1 = "Ozymandias";
        string king2 = "Ozymandias";

        Console.WriteLine("Using == operator and equals() method with value types:");
        Console.WriteLine(num1 == num2);
        Console.WriteLine(num1.Equals(num2));

        Console.WriteLine("Using == operator and equals() method with reference types:");
        Console.WriteLine(king1 == king2);
        Console.WriteLine(king1.Equals(king2));
    }

    public void Task_3()
    {
        // Tom, Benenson, 23
        string phrase = Console.ReadLine();
        string[] words = phrase.Split(", ");
        string dialogue = $"“How old are you”, -policemen asked. \n“{words[2]}”, -{words[0]} {words[1]} answered.";

        Console.WriteLine(dialogue);
    }

    public void Task_4()
    {
        // My sweet prince
        Console.WriteLine("enter the words of the best song one by one");
        Console.Write("First word:");
        string word1 = Console.ReadLine();
        Console.Write("Second word:");
        string word2 = Console.ReadLine();
        Console.Write("Third word:");
        string word3 = Console.ReadLine();

        string lyrics = string.Join(" ", word1, word2, word3);
        Console.WriteLine(lyrics + "\nYou are the one");

        string lyrics2 = String.Concat(word1, word2, word3);
        Console.WriteLine(lyrics2);
    }

    public void Task_5()
    {
        Console.Write("Write your sentence:");
        string sentence = Console.ReadLine();

        string firstPart = sentence.Substring(0, 3);
        string secondPart = sentence.Substring(3);

        Console.WriteLine("Result:");
        string lyrics = string.Join("", firstPart, secondPart);
        Console.WriteLine(lyrics);
    }

    public void Task_6()
    {
        Console.Write("Write your sentence:");
        string sentence = Console.ReadLine();

        Console.Write("Write old adjective:");
        string oldAdj = Console.ReadLine();

        Console.Write("Write new adjective:");
        string newAdj = Console.ReadLine();

        Console.WriteLine("Modified sentence:");
        Console.WriteLine(sentence.Replace(oldAdj, newAdj));
    }

    public void Task_7()
    {
        // бесконечное цукиеми(цикл) позволяет посмотреть на любые
        // буковки в верхнем регистре без перезапуска программы 
        while (true)
        {
            string letter = Console.ReadLine();

            Console.WriteLine(letter.ToUpper());
        }
    }

    public void Task_Additional()
    {

        Console.WriteLine("enter free lines one by one");
        Console.Write("First line:");
        string line1 = Console.ReadLine();
        Console.Write("Second line:");
        string line2 = Console.ReadLine();
        Console.Write("Third line:");
        string line3 = Console.ReadLine();

        StringBuilder sb = new StringBuilder();
        sb.Append(line1);
        sb.Append(line2);
        sb.Append(line3);
        Console.WriteLine(sb.ToString());
    }
}

class Additional
{
    public void Task_1()
    {
        while (true)
        {
            Console.WriteLine("Enter the bool:");
            string input1 = (Console.ReadLine());
            bool result1 = bool.TryParse(input1, out var boolian1);
            if (!result1)

            {
                Console.WriteLine("incorrect value, please try again");
                continue;
            }

            Console.WriteLine("Enter the another bool:");
            string input2 = (Console.ReadLine());
            bool result2 = bool.TryParse(input2, out var boolian2); 
            if (!result2)
            {
                Console.WriteLine("incorrect value, please try again");
                continue;
            }

            if (boolian1 || boolian2)
            {
                Console.WriteLine($"logical comparison operation with ||: success");
            }
            else 
            {
                Console.WriteLine($"logical comparison operation with ||: failure");
                

            }
            if (boolian1 && boolian2)
            {
                Console.WriteLine($"logical comparison operation with &&: success");

            }
            else
            {
                Console.WriteLine($"logical comparison operation with &&: failure");

            }

        }
    }
}
 

class Homework_2
{
    public void Task_1()
    {
        Console.Write("enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter a decimal with dot:");
        double decimaL = Convert.ToDouble(Console.ReadLine());

        Console.Write("enter a letter:");
        char letter = Convert.ToChar(Console.ReadLine());

        Console.Write("enter a boolean:");
        bool boolean = Convert.ToBoolean(Console.ReadLine());


        Console.WriteLine($"number={number}  decimal={decimaL} letter={letter} boolean={boolean}");
    }

    public void Task_2()
    {
        Console.Write("enter a number:");
        int number = int.Parse(Console.ReadLine());

        Console.Write("enter a letter:");
        char letter = char.Parse(Console.ReadLine());

        Console.WriteLine($"number={number} letter={letter}");
    }
    public void Task_3()
    {
        Console.WriteLine("enter the number:");
        string input = Console.ReadLine();

        bool result = int.TryParse(input, out var number);
        if (result == true)
            Console.WriteLine($"the conversion was successful. number: {number}");
        else
            Console.WriteLine("conversion failed");
    }

    public void Task_4()
    {
        int num1 = 2;
        int num2 = num1 + 3;
        int num3 = num2 + num1;

        Console.WriteLine($"result: {num3}");
    }

    public void Task_5()
    {
        double fish = 12.0;
        double milk = 8.0;
        double salt = 4.0;
        double soap = 5.0;
        double lotion = 16.0;
        double meat = 15.0;

        int fishCount = 15;
        int milkCount = 1;
        int saltCount = 5;
        int soapCount = 2;
        int lotionCount = 10;
        int meatCount = 11;

        double sum = fish * fishCount + meat * meatCount + milk * milkCount
            + salt * saltCount + soap * soapCount + lotion * lotionCount;
        double discount = 15.0;
        double finalPrice = sum * (100 - discount) / 100;

        Console.WriteLine($"check: {sum}");
        Console.WriteLine($"discount check:{finalPrice}");
    }

    public void Task_6()
    {
        double a = 4;
        double b = 5;

        double result1 = ++a + b * 2;
        /* 1) ++a=5
           2) b*2=5*2=10
           3) 5+10=15
        */
        Console.WriteLine(result1);

        int c = 6;
        int l = 4;

        int result2 = (--c * (++l + c) + c);
        /*
         1) --c=t
         2) ++l=5
         3) l+c=5+5=10
         4) --c*10=5*10=50
         5) 50+5=55
         */
        Console.WriteLine(result2);
    }

    public void Task_7()
    {
        //int a = 42;
        //int b = 42;
        //Console.WriteLine(a == b); // true
        //Console.WriteLine(a > b); // false

        //bool a = true;
        //bool b = true;
        //bool c = true;
        //Console.WriteLine(a && b == c); // true
        //Console.WriteLine(a && b != c); // false

        //bool a = true;
        //int b = 12;
        //int c = 10;

        //Console.WriteLine(a || b > c); // true
        //Console.WriteLine(a && b < c); // false

        //int a = 1;
        //int b = 2;
        //Console.WriteLine(a != b); // true
        //Console.WriteLine(a == b); // false

        //int a = 3;
        //int b = 4;
        //Console.WriteLine(a <= b); // true
        //Console.WriteLine(a > b); // false



        //int a = 34;
        //int c = 33;
        //bool b = true;
        //bool d = false;
        //Console.WriteLine(a > c == b || d); // true
        //Console.WriteLine(a > c == b && d); // false

        //int a = 20;
        //int c = 22;
        //int b = 45;
        //int d = 0;
        //Console.WriteLine(a > c == b < d); // true
        //Console.WriteLine(a > c == b > d); // false
    }

    public void Task_8()
    {
        int num = 1;
        object o = num;
        num = (int)o;
        int j = (int)o;
    }

    public void Task_9()
    {
        uint a = 15;
        ulong b = 12;
        // явное преобразование
        ulong с = a;
        // неявное преобразование
        uint d = (uint)b;
    }

    public void Task_10()
    {

    }





}

class Homework_3
{
    public void Task_1()
    {
        while (true)
        {
            Console.WriteLine("Enter the integer:");
            string input = Console.ReadLine();
            bool result = int.TryParse(input, out var num);
            if (!result)

            {
                Console.WriteLine("incorrect value, please try again");
            }

            else if (num % 10 == 0)
            {
                Console.WriteLine("tutti-frutti");
            }

            else if (num % 2 == 0)
            {
                Console.WriteLine("tutti");
            }

            else if (num % 5 == 0)
            {
                Console.WriteLine("frutti");
            }
        }

    }
    public void Task_2()
    {
        Console.WriteLine("Enter the first number:");
        string inputFirst = Console.ReadLine();
        bool resultFirst = int.TryParse(inputFirst, out var firstNum);
        if (!resultFirst)
        {
            Console.WriteLine("incorrect value, please try again");
        }

        Console.WriteLine("enter the second number, it must be greater than the first:");
        string inputSecond = Console.ReadLine();
        bool resultSecond = int.TryParse(inputSecond, out var secondNum);
        if (!resultSecond)
        {
            Console.WriteLine("incorrect value, please try again");
        }
        else if (secondNum <= firstNum)
        {
            Console.WriteLine("the second number must be greater than the first, please try again");
        }


        for (int value = firstNum; value <= secondNum; value++)
        {
            if (value % 10 == 0)
            {
                Console.WriteLine("tutti-frutti");
            }

            else if (value % 2 == 0)
            {
                Console.WriteLine("tutti");
            }

            else if (value % 5 == 0)
            {
                Console.WriteLine("frutti");
            }

            else
            {
                Console.WriteLine($"Number {value} can’t be divided on 2 or 5");
            }
        }
    }

    public void Task_3()
    {
        Console.WriteLine("Enter the first number:");
        string inputFirst = Console.ReadLine();
        bool resultFirst = int.TryParse(inputFirst, out var firstNum);
        if (!resultFirst)
        {
            Console.WriteLine("incorrect value, please try again");
        }

        Console.WriteLine("enter the second number, it must be greater than the first:");
        string inputSecond = Console.ReadLine();
        bool resultSecond = int.TryParse(inputSecond, out var secondNum);
        if (!resultSecond)
        {
            Console.WriteLine("incorrect value, please try again");
        }
        else if (secondNum <= firstNum) // 5&66

        {
            int intermediate = firstNum; // i=66
            firstNum = secondNum; // 5=5 
            secondNum = intermediate; // 66
        }


        for (int value = firstNum; value <= secondNum; value++)
        {
            if (value % 10 == 0)
            {
                Console.WriteLine("tutti-frutti");
            }

            else if (value % 2 == 0)
            {
                Console.WriteLine("tutti");
            }

            else if (value % 5 == 0)
            {
                Console.WriteLine("frutti");
            }

            else
            {
                Console.WriteLine($"Number {value} can’t be divided on 2 or 5");
            }
        }
    }
}




