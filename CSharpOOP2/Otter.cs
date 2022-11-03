namespace CSharpOOP2
{
    public class Otter // Выдра
    {
        public static bool IsCute { get; set; }

        public string Name = "John Doe";
        public int Age { get; internal set; }
        public string Color;
        public bool IsHungry;

        private int height;
        public int Height
        {
            set
            {
                height = value;
            }
        }
        public int Weight { get; }


        public Otter()
        {
        }

        public Otter(string name, int age)
        {
            Name = name;
            Age = age;
            Weight = 1;
        }

        public Otter(string name, int age, string color, bool isHungry)
        {
            Name = name;
            Age = age;
            Color = color;
            IsHungry = isHungry;
            Weight = 1;
        }

        public string CheckHunger(int hoursAfterLastMeal)
        {
            if (hoursAfterLastMeal > 4)
            {
                IsHungry = true;
                return "It's time to take some food";
            }
            else if (hoursAfterLastMeal < 3)
            {
                IsHungry = false;
                return $"{Name} is't hungry yet";
            }
            else
            {
                IsHungry = false;
                return $"{Name} can take some snacks";
            }
        }

        private void PrintProfile()
        {
            Console.WriteLine($"Otter:{Name}\nAge:{Age} years\nColor{Color}.");
        }

        internal void PrintName()
        {
            Console.WriteLine($"Name: {Name}.");
        }

        public static void PrintOtterFact()
        {
            Console.WriteLine("Baby otters usually are called pups. They can also be called kits or kittens. Female otters are sows, and males are boars.");
        }

    }


}

