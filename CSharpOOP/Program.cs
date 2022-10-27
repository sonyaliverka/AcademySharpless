#region Task_1
//Console.WriteLine("Enter the quantity, price and personal discount");
//int quantity = int.Parse(Console.ReadLine());
//double price = double.Parse(Console.ReadLine());
//int discount = int.Parse(Console.ReadLine());
//Console.WriteLine(Homework_1.CalculateFinalPrice(quantity, price, discount));
#endregion

#region Task_2
//Console.WriteLine("Enter personal discount");
//int discount = int.Parse(Console.ReadLine());

//string recipt = "";
//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine("Enter name, quantity, price");
//    string itemName = Console.ReadLine();
//    int quantity = int.Parse(Console.ReadLine());
//    double price = double.Parse(Console.ReadLine());
//    var reciptLine = Homework_1.GetReceiptLine(itemName, price, discount, quantity);
//    recipt = recipt + reciptLine + "\n";
//}
//Console.WriteLine(recipt);
#endregion

#region Task_3
//string recipt = "";
//recipt += Homework_1.GetReceiptLine(itemName: "Kisel", price: 10, discount: 5, quantity: 42) + "\n";
//recipt += Homework_1.GetReceiptLine(itemName: "SnejoK", price: 15.0, discount: 5);
//Console.WriteLine(recipt);
#endregion

#region Task_4
//Console.WriteLine("Enter five sides");
//int firstSide = int.Parse(Console.ReadLine());
//int secondSide = int.Parse(Console.ReadLine());
//int thirdSide = int.Parse(Console.ReadLine());
//int forthSide = int.Parse(Console.ReadLine());
//int fithSide = int.Parse(Console.ReadLine());

//Console.WriteLine($"Trianle perimeter: {Homework_1.CalculatePerimeter(firstSide, secondSide, thirdSide)}");
//Console.WriteLine($"Quadrangle perimeter: {Homework_1.CalculatePerimeter(firstSide, secondSide, thirdSide, forthSide)}");
//Console.WriteLine($"Pentagon perimeter: {Homework_1.CalculatePerimeter(firstSide, secondSide, thirdSide, forthSide, fithSide)}");
#endregion

#region Task_5
//Console.WriteLine($"Circle area: {Homework_1.CalculateArea(radius: 5)}");
//Console.WriteLine($"Triangele area: {Homework_1.CalculateArea(triangleBase: 5, triangleHeigh: 10)}");
#endregion

#region Task_6
/*
 Насладование.
 "Биологи́ческая эволю́ция (от лат. evolutio — «развёртывание») — естественный процесс развития живой природы, сопровождающийся изменением генетического состава популяций, формированием адаптаций, видообразованием и вымиранием видов, преобразованием экосистем и биосферы в целом." © Википедия
 *А вы знали, что крабы эволюционируют в раков, а раки - в крабов?*
 Инкапсуляция.
 Банально пользуясь компьютером мы не в курсе, как он обрабатывает информацию внутри себя.
 Полиморфизм.
 Тигры невидимы для своей добычи, потому что у любой их жертвы(за исключением человека) дихромное зрение, т.е. глаза не воспринимают красный спектр цветов, из-за чего тигр видится им зеленым и сливается с джунглями. 
 Абстракция.
 Всоздании логотипов требуется взять основные признаки бренда и максимально их упростить(абстрагироваться от деталей), но сохранить узнаваемость и читаемость логотипа.
*/
#endregion


public class Homework_1
{
    public static double CalculateFinalPrice(int quantity, double price, int discount)
    {
        return price * quantity * (1 - discount / 100.0);
    }

    public static string GetReceiptLine(string itemName, double price, int discount, int quantity = 1)
    {
        return $"{itemName} {quantity}*{price} -{discount}% = {CalculateFinalPrice(quantity, price, discount)}$";
    }

    public static int CalculatePerimeter(params int[] sides)
    {
        var perimeter = 0;
        foreach (var side in sides)
        {
            perimeter += side;
        }
        return perimeter;
    }

    public static double CalculateArea(int triangleBase, int triangleHeigh)
    {
        return 0.5 * triangleBase * triangleHeigh;
    }

    public static double CalculateArea(int radius)
    {
        return Math.PI * radius * radius;
    }
}
