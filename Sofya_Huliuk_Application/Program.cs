//Console.WriteLine("Hello, World!");
//Console.ReadLine();


using System.Text;

//new Homework().Task_8();
new Homework_2().Task_1();

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
        string lyrics = string.Join("", firstPart , secondPart);
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

    public void Task_8()
    {
        Console.WriteLine("write tf coior");
        var i = 1;
       while(i<= 10) 
        {

            Console.WriteLine(i);

            i = i + 2;
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


    }

    public void Task_3()
    {


    }

    public void Task_4()
    {


    }

    public void Task_5()
    {


    }

    public void Task_6()
    {


    }

    public void Task_7()
    {


    }

    public void Task_8()
    {


    }

    public void Task_9()
    {


    }





}
