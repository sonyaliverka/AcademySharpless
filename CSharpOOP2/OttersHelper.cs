namespace CSharpOOP2
{
    public class OttersHelper
    {
        public static void GrowOldOtter(Otter otter, int years = 1)
        {
            otter.Age += years;
        }

        public static string GetStatus(Otter otter, int hoursAfterLastMeal)
        {
            return $"{otter.Name}: {otter.CheckHunger(hoursAfterLastMeal)}";
        }

        public static string GreetOtter(Otter otter)
        {
            return $"Hello {otter.Color} cutie otter {otter.Name}!!!";
        }
    }

}
