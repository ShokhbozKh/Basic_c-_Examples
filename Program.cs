
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////
        //Masala 1: Sonni toq yoki juftligini aniqlash
        //Console.Write("Enter any number: ");
        //int number = int.Parse(Console.ReadLine());

        //string result = (number == 0) ? "Bu son 0 teng" : (number % 2 == 0) ? " Bu son juft son": "Toq son";

        //Console.WriteLine(result);

        ////////////////////////////////////////////////////////////////////////////////////////////////
        //Masala 2: Kvadrat tenglama yechimi
        //Ax^2+Bx + C = 0

        //Console.Write("A number enter:");
        //double a = double.Parse(Console.ReadLine());
        //Console.Write("B number enter:");
        //double b = double.Parse(Console.ReadLine());
        //Console.Write("C number enter:");
        //double c = double.Parse(Console.ReadLine());

        //double x_1, x_2, d;

        //d = Math.Pow(b, 2) - 4 * a * c;

        //if (a == 0)
        //{
        //    x_1 = -c / b;
        //    Console.WriteLine($"Natija: x_1={x_1}");
        //}
        //else if (d < 0)
        //{
        //    Console.WriteLine("D 0 ga teng bulishi mumkin emas");
        //}
        //else
        //{
        //    x_1 = (-b + Math.Sqrt(d)) / 2 * a;
        //    x_2 = (-b - Math.Sqrt(d)) / 2* a;

        //    Console.WriteLine($"x_1 = {x_1}");
        //    Console.WriteLine($"x_2 = {x_2}");
        // }

        /////////////////////////////////////////////////////////////////////////////////////////////////
        ///3- masala
        //Console.Write("First number:");
        //int a = int.Parse(Console.ReadLine());
        //Console.Write("Second number:");
        //int b = int.Parse(Console.ReadLine());

        //Console.Write("Please enter operation + ; - ; * ; / ==> ");
        //char operation = char.Parse(Console.ReadLine());

        //if(operation =='+')
        //{
        //    Console.WriteLine($"{a}+{b}={a+b}");
        //}
        //else if(operation=='-')
        //{
        //    Console.WriteLine($"{a}-{b}={a - b}");
        //}
        //else if (operation =='*')
        //{
        //    Console.WriteLine($"{a}*{b}={a * b}");
        //}
        //else if(operation == '/')
        //{
        //    Console.WriteLine($"{a}/{b}={a / b}");
        //}
        //else
        //{
        //    Console.WriteLine("Wrong enter operation !!!");
        //}

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///4- masala
        ///
        //Console.Write("Enter one number:");
        //double number = double.Parse(Console.ReadLine());

        //Console.WriteLine($" {number} ^2 = {Math.Pow(number,2)} ");
        //Console.WriteLine($" {number} ^3 = {Math.Pow(number, 3)} ");
        //Console.WriteLine($" {number} sqrt = {Math.Sqrt(number)} ");
        //Console.WriteLine($" {number} sin = {Math.Sin(number)} ");

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///5-masala
        ///string
        //Console.Write("Enter any Text: ");

        //string text = Console.ReadLine();

        //int result1 = text.Split(' ').Length;
        //int result2 = text.Replace(" ","").Length;// all space remove 
        //int result3 = 0;

        //foreach (char i in text.ToLower())
        //{
        //    if( char.IsLetter(i))
        //    {
        //        if(i=='a' || i=='e' || i=='i' || i=='o' || i=='u')
        //        {
        //            result3++;
        //        }
        //    }
        //}

        //Console.WriteLine($"Suzlar soni:{result1}");
        //Console.WriteLine($"Harflar soni: {result2}");
        //Console.WriteLine($"Unli harflar soni: {result3}");

        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        ///6-masala
        ///
        //Console.Write("Enter any word:");
        //string word = Console.ReadLine();

        //string resultWord = "";

        //for(int i = word.Length; i > 0; i--)
        //{
        //    resultWord += word[i-1];
        //}

        //Console.WriteLine($"Result: {resultWord}");\

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///7-masala
        ///
        //Console.Write("Enter any number please: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //bool result = (number % 2 == 0) ? true: false;
        //Console.WriteLine($"result: {result}");

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///8-masala
        ///
        //Console.Write("Enter three numbers: (For example 1 2 3) :");

        //string[] numbersString = Console.ReadLine().Split(" ");

        //if(numbersString.Length != 3 )
        //{
        //    Console.WriteLine("Ortiqcha son bor iltimos 3 ta son kiriting");
        //    return;
        //}

        //int[] numbers =  new int[numbersString.Length];

        //for (int i=0; i<numbersString.Length; i++)
        //{
        //    numbers[i] = int.Parse(numbersString[i]);
        //}

        //if (numbers[0] < numbers[1]+numbers[2] && numbers[1] < numbers[0] + numbers[2] && numbers[2] < numbers[1] + numbers[0])
        //{
        //    Console.WriteLine("yasab buladi uchburchak");
        //}
        //else
        //{
        //    Console.WriteLine("Yasab bulmaydi uchburchak");
        //}

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 9-masala
        /// 90-100: A, 80-89: B, 70-79: C, 60-69: D, 0-59: F
        /// 
        //Console.Write("Enter Number: ");
        //try
        //{
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    if (num < 0 || num > 100)
        //    {
        //        Console.WriteLine("Raqam odan kichik yoki 100 dan katta bulishi mumkin");
        //        return;
        //    }

        //    if (num >= 0 || num <= 59)
        //    {
        //        Console.WriteLine("F");
        //    }
        //    else if (num >= 60 || num <= 69)
        //    {
        //        Console.WriteLine("D");
        //    }
        //    else if (num >= 70 || num <= 79)
        //    {
        //        Console.WriteLine("C");
        //    }
        //    else if (num >= 80 || num <= 89)
        //    {
        //        Console.WriteLine("B");
        //    }
        //    else if (num >= 90 || num <= 100)
        //    {
        //        Console.WriteLine("A");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Nimadur xato bor");
        //    }

        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Xatolik xabari:" + ex.Message);
        //}
        //finally
        //{
        //    Console.WriteLine("Dastur tugadi");
        //}

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///10-masala
        ///
        //Console.Write("Enter number:");

        //try
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    if (n >= 100 && n <= 999)
        //    {
        //        Console.WriteLine("3 xonali son:" + n);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Notug'ri son kiritildi");
        //    }
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine("Wrong message:" + e);
        //}

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        




    }
}