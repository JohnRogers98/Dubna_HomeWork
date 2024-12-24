namespace HomeWork
{
    /*
    8. 
    Определить класс «Животное», содержащий следующие поля:
        • номер животного
        • вес животного
        • год рождения животного
        • количество еды, необходимое для питания на 1 кг веса животного
    Определить методы класса:
        • возраст животного
        • рассчитать количество еды, необходимое животному
    Создать три экземпляра класса «Животное»
     */
    internal class Animal
    {
        public Guid Id { get; set; }
        public Double Weight { get; set; }
        public DateTime BornDate { get; set; }
        public Double NutritionPerKilo { get; set; }

        /// <summary>
        /// Возраст животного
        /// </summary>
        /// <returns>Years of animal with NO regard about leap year</returns>
        public Int32 Year() => DateTime.Now.Year - BornDate.Year;

        /// <summary>
        /// Рассчитать количество еды, необходимое животному
        /// </summary>
        /// <returns>Nutrition needed per day</returns>
        public Double NutritionNeeded() => NutritionPerKilo * Weight;

        /// <summary>
        /// Test factory
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Animal> CreateAnimals()
        {
            return new List<Animal>
            {
                new Animal { Id = Guid.NewGuid(), Weight = 1.1, BornDate = new DateTime(1998, 4, 17), NutritionPerKilo = 0.1 },
                new Animal { Id = Guid.NewGuid(), Weight = 5, BornDate = new DateTime(1999, 4, 18), NutritionPerKilo = 10 },
                new Animal { Id = Guid.NewGuid(), Weight = 3, BornDate = new DateTime(2012, 10, 18), NutritionPerKilo = 1 }
            };
        }

    }
}
