#region Task_1
using CSharpOOP2;

new Otter();

Otter otterKotaro = new Otter();
otterKotaro.Name = "Kotaro";
otterKotaro.Age = 2;
otterKotaro.Color = "Glossy Brown";
otterKotaro.IsHungry = false;

Console.WriteLine(otterKotaro.CheckHunger(hoursAfterLastMeal: 2)); 

Otter otterHanna = new Otter
{
    Name = "Hanna",
    Age = 2,
    Color = "Deep Brown",
    IsHungry = true
};

Console.WriteLine(otterHanna.CheckHunger(hoursAfterLastMeal: 3));

Otter otterSeregga = new Otter
{
    Name = "Seregga",
    Age = 26,
    Color = "Bald",
    IsHungry = true
};

Otter otterHoodwink = new Otter
{
    Name = "Hoodwink",
    Age = 20,
    Color = "Squirrel Brown",

};
Console.WriteLine(otterHoodwink.CheckHunger(hoursAfterLastMeal: 1)); // in my method, the value of the variable parameter is assigned
//otterHoodwink.PrintProfile(); // Error Line 

Otter otterJohn = new Otter
{
    Age = 99,
    Color = "Very Bald",
    IsHungry = true
};

otterJohn.PrintName();

Console.WriteLine(otterJohn.Weight);
// otterJohn.Weight = 5; //  Error Line

//Console.WriteLine(otterJohn.Height); // Error Line
otterJohn.Height = 200;

Otter.IsCute = true;
Console.WriteLine(Otter.IsCute);

Otter.PrintOtterFact();

Console.WriteLine(OttersHelper.GreetOtter(otterSeregga));

Console.WriteLine(OttersHelper.GetStatus(otterHoodwink, 5));

OttersHelper.GrowOldOtter(otterJohn);
Console.WriteLine(otterJohn.Age);    

#endregion
