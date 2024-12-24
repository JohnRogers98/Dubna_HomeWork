// See https://aka.ms/new-console-template for more information
using HomeWork;

Console.WriteLine("Hello, World!");


Exercises exercises = new Exercises();

#region 
exercises.QuarterOfPoint(-3, 1)
    .WriteLog();

exercises.DayByNumber(1)
    .WriteLog();
#endregion

#region 
exercises
    .CompareTwoSurnamesLength("zhuzhma", "petrov")
    .WriteLog();

exercises
    .IsSecondAndForthCharEquals("bada")
    .WriteLog();

exercises.ColumnPrint("The Moon");

exercises.ReversePrint("anaY");

Console.WriteLine();
#endregion

#region
var animals = Animal.CreateAnimals();

animals.ToList().ForEach(
    animal => Console.WriteLine($"Id - {animal.Id}; Year - {animal.Year()}; Nutrition needed - {animal.NutritionNeeded()}"));
#endregion

#region 
DishModelLine dishModelLine = new DishModelLine { Id = Guid.NewGuid(), Cup = 1, Plate = 2, Saucer = 5 };

dishModelLine.Estimate3CupsAndSaucers()
    .WriteLog();
#endregion