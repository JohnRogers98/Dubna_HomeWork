namespace HomeWork
{
    internal static class Extensions
    {

        public static T WriteLog<T>(this T obj) 
        { 
            Console.WriteLine(obj);
            return obj; 
        }

        /// <summary>
        ///  1. Определить в какой четверти координатной плоскости лежит точка с координатами X, Y.
        /// </summary>
        public static Int32 QuarterOfPoint(this Exercises excercises, Int32 x, Int32 y)
        {
            if (x > 0 && y > 0) return 1;
            
            else if (x < 0 && y > 0) return 2;
            
            else if (x < 0 && y < 0) return 3;

            else if(x > 0 && y < 0) return 4;

            return 0;
        }

        /// <summary>
        ///  2. Написать программу нахождения корней квадратного уравнения.
        /// </summary>
        public static void QuadraticEquation(this Exercises exercises, Double a, Double b, Double c)
        {
            Double d = Math.Sqrt((b * b) - (4 * a * c));
            if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Result: discriminant = {d}; x = {x}");
            }
            else if (d > 0)
            {
                double x1, x2;
                x1 = (-b + d) / (2 * a);
                x2 = (-b - d) / (2 * a);
                Console.WriteLine($"Result: discriminant = {d}; x1 = {x1}, x2 = {x2}");
            }
            Console.WriteLine($"Result: discriminant = {d}");
        }

        /// <summary>
        /// 3. Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, … 7)
        ///         выводит на экран его название (понедельник, вторник, … воскресенье).
        /// </summary>
        public static String? DayByNumber(this Exercises exercises, Int32 day) => 
            Enum.GetName(typeof(DayOfWeek), day);


        /// <summary>
        /// 1.1. Даны две фамилии. Определить, какая из них длиннее.
        /// </summary>
        public static Int32 CompareTwoSurnamesLength(this Exercises excercises, String firstSurname, String secondSurname) =>
            firstSurname.Length.CompareTo(secondSurname.Length);

        /// <summary>
        /// 1.2. Дано слово. Определить, одинаковы ли второй и четвертый символы в нем.
        /// </summary>
        public static Boolean IsSecondAndForthCharEquals(this Exercises excercises, String word)
        {
            if (word.Length < 4)
                return false;

            if(word[1].CompareTo(word[3]) == 0)
                return true;
            else 
                return false;
        }

        /// <summary>
        /// 2.1. Дано название планеты. Напечатать его на экран столбиком.
        /// </summary>
        public static void ColumnPrint(this Exercises excercises, String word) =>
            word.ToList().ForEach(Console.WriteLine);

        /// <summary>
        /// 2.2. Составить программу, которая печатает заданное слово, начиная с последней буквы (в обратном порядке)
        /// </summary>
        public static void ReversePrint(this Exercises excercises, String word) =>
            word.Reverse().ToList().ForEach(Console.Write);


    }
}
