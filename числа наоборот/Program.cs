using System;
/*Дано целое число N, найти число, полученное при
прочтении числа N справа налево. Например, если было
введено число 345, то программа должна вывести число 543.*/
namespace числа_наоборот
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            Console.WriteLine("введите заданное число ");
             N = Int32.Parse(Console.ReadLine());
            string s = N.ToString();  //переводим число в строку
            char[] arr = s.ToCharArray(); //переводим в массив символов
            Array.Reverse(arr);  // а теперь все написанно за нас нам только использовать 
            s = new String(arr); //создаем новую строку и передаем наш массив
            N = Convert.ToInt32(s); // обратно из строки в число
            Console.WriteLine(s); // ну и выводим на экран 
        }
    }
}
