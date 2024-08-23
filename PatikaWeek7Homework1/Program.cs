namespace PatikaWeek7Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rastgele 10 adet sayıdan oluşan bir liste oluşturuluyor..

            Random random = new Random();
            List<int> numbers = new List<int>();

            Console.WriteLine("Listedeki Sayılar----------");
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(random.Next(-50, 50));// -50 ile 50 arasında rastgele sayılar
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine("\n\n");

            // LINQ kütüphanesinin Query ve Method adı verilen iki farklı söz dizimi bulunmaktadır.

            //Method Syntax  ile oluşturulan
            MethodLinq(numbers);

            //Query Syntax ile oluşturulan
            QueryLinq(numbers);

        }
         

        /// <summary>
        /// Pratikde istenilen Linq Method Syntax ile oluşturuldu..
        /// </summary>
        /// <param name="numbers"></param>
        static void MethodLinq(List<int> numbers)
        {
            //Çift sayılar
            Console.WriteLine("Listedeki Çift Sayılar----------");

            var numbersEven = numbers.Where(number => number % 2 == 0);
            PrintNumber(numbersEven);

            //Tek sayılar
            Console.WriteLine("Listedeki Tek Sayılar----------");
            var numbersOdd = numbers.Where(number => number % 2 != 0);
            PrintNumber(numbersOdd);


            //Negatif sayılar
            Console.WriteLine("Listedeki Negatif Sayılar----------");
            var numbersNegative = numbers.Where(number => number < 0);
            PrintNumber(numbersNegative);

            // Pozitif sayılar
            Console.WriteLine("Listedeki Pozitif Sayılar----------");
            var numbersPositive = numbers.Where(number => number > 0);
            PrintNumber(numbersPositive);

            //15 ile 25 arası sayılar
            Console.WriteLine("Listedeki 15 ile 22 Arası Sayılar----------");
            var numbersBigSmall = numbers.Where(number => number > 15 && number < 22);
            PrintNumber(numbersBigSmall);

            //Listedeki her bir sayının karesi
            Console.WriteLine("Listedeki Sayıların Karesi----------");
            var numberSquare = numbers.Select(number => number * number).ToList();
            PrintNumber(numberSquare);

        }

        /// <summary>
        /// Pratikde istenilen Linq Query Syntax oluşturuldu..
        /// </summary>
        /// <param name="numbers"></param>
        static void QueryLinq(List<int> numbers)
        {
            

            //Çift sayılar
            Console.WriteLine("Listedeki Çift Sayılar----------");

            var numbersEven = from number in numbers
                              where number%2==0
                              select number;

            PrintNumber(numbersEven);



            //Tek sayılar
            Console.WriteLine("Listedeki Tek Sayılar----------");
            var numbersOdd = from number in numbers
                             where number % 2 != 0
                             select number;

            PrintNumber(numbersOdd);




            //Negatif sayılar
            Console.WriteLine("Listedeki Negatif Sayılar----------");
            var numbersNegative = from number in numbers
                                  where number < 0
                                  select number;

            PrintNumber(numbersNegative);



            // Pozitif sayılar
            Console.WriteLine("Listedeki Pozitif Sayılar----------");
            var numbersPositive = from number in numbers
                                  where number > 0
                                  select number;

            PrintNumber(numbersPositive);



            //15 ile 25 arası sayılar
            Console.WriteLine("Listedeki 15 ile 22 Arası Sayılar----------");
            var numbersBigSmall = from number in numbers
                                  where number > 15 && number < 22
                                  select number;

            PrintNumber(numbersBigSmall);


            //Listedeki her bir sayının karesi
            Console.WriteLine("Listedeki Sayıların Karesi----------");
            var numberSquare = from number in numbers
                               select number * number;

            PrintNumber(numberSquare);

        }

        /// <summary>
        /// IEnumerable olarak gönderilen sonucu ekrana yazar
        /// </summary>
        /// <param name="numbers"></param>

        static void  PrintNumber(IEnumerable<int> numbers) 
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number + "\n");
            }

        }
    }
}
