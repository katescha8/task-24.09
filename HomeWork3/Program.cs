using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Задание 1");
            //Console.Write("Введите сторону а ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите сторону b ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите диаметр головы d ");
            //double d = Convert.ToDouble(Console.ReadLine());
            //double c;
            //if (a <= b)
            //{ c = a; }
            //else 
            //{ c = b; }
            //if (c >= d + 2)
            //{ Console.WriteLine("Пролезет"); }
            //else
            //{ Console.WriteLine("Не пролезет"); }
            //Console.WriteLine("задание 2");
            //Console.Write("Введите число n ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int n1;
            //for (int i = 1; i <= 10; i++)
            //{
            //    n1 = n * i;
            //    Console.WriteLine($"{n} x {i} = " + n1);
            //}
            //Console.WriteLine("Задание 3");
            //Console.Write("Введите число ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n % 3 == 0 && n % 5 == 0)
            //{ Console.WriteLine("БэнгБум"); }
            //else if (n % 3 == 0 && n % 5 != 0)
            //{ Console.WriteLine("Бэнг"); }
            //else if (n % 3 != 0 && n % 5 == 0)
            //{ Console.WriteLine("Бум"); }
            //else
            //{ Console.WriteLine("Мимо"); }
            //Console.WriteLine("Задание 4");
            //Console.Write("Введите строку ");
            //string s1 = Console.ReadLine();
            //char[] char1 = s1.ToCharArray();
            //int n = 0;
            //for (int i = 0; i < char1.Length; i++)
            //{
            //    if (char.IsUpper(char1[i]))
            //    {
            //        n++;
            //    }
            //}
            //if (n == char1.Length)
            //{ Console.WriteLine($"\"{s1}\" -> True"); }
            //else 
            //{ Console.WriteLine($"\"{s1}\" -> False"); }
            //Console.WriteLine("Задание 5");
            //Console.Write("Введите число ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write(i + " овца... ");
            //Console.WriteLine("Задание 6");
            //Console.Write("Введите последовательность ");
            //string s1 = Console.ReadLine();
            //char[] char1 = s1.ToCharArray();
            //int sum = 0;
            //int n = 0;
            //int j = 0;
            //try
            //{
            //    for (int i = 0; i < char1.Length - 2; i++)
            //    {
            //        n = Convert.ToInt32(char1[i]) - 48;
            //        sum += n;
            //        j++;
            //        n = 0;
            //    }
            //    double armean = sum / j;
            //    Console.WriteLine("Среднее арифметическое равно " + armean);
            //}
            //catch (Exception)
            //{ Console.WriteLine("Error!!!"); }
            //finally
            //{ Console.WriteLine("Спасибо за попытку <3"); }
            //Console.WriteLine("Задание 7");
            //Console.Write("Введите порядковый номер ");
            //try
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    switch (n)
            //    {
            //        case 6: Console.WriteLine("шестёрка"); break;
            //        case 7: Console.WriteLine("семёрка"); break;
            //        case 8: Console.WriteLine("восьмёрка"); break;
            //        case 9: Console.WriteLine("девятка"); break;
            //        case 10: Console.WriteLine("десятка"); break;
            //        case 11: Console.WriteLine("валет"); break;
            //        case 12: Console.WriteLine("дама"); break;
            //        case 13: Console.WriteLine("король"); break;
            //        case 14: Console.WriteLine("туз"); break;
            //        default: Console.WriteLine("Неверный ввод"); break;
            //    }
            //}
            //catch (Exception)
            //{ Console.WriteLine("Error!!!"); }
            //finally
            //{ Console.WriteLine("Спасибо за попытку! <3");}
            //Console.WriteLine("Задание 8");
            //string[] bag = { "money","keys","Hello Kitty","Barbie doll","dinosaur" };
            //int inbag = 0;
            //foreach (string bagItem in bag)
            //{
            //    if (bagItem == "Hello Kitty" || bagItem == "Barbie doll")
            //    { inbag++; }
            //}
            //Console.WriteLine(inbag + " кукол");
            //Console.WriteLine("Задание 9");
            //Console.Write("Введите n ");
            //byte n = Convert.ToByte(Console.ReadLine());
            //switch(n)
            //{
            //    case 1: Console.WriteLine(DayofWeek.Понедельник); break;
            //    case 2: Console.WriteLine(DayofWeek.Вторник); break;
            //    case 3: Console.WriteLine(DayofWeek.Среда); break;
            //    case 4: Console.WriteLine(DayofWeek.Четверг); break;
            //    case 5: Console.WriteLine(DayofWeek.Пятница); break;
            //    case 6: Console.WriteLine(DayofWeek.Суббота); break;
            //    case 7: Console.WriteLine(DayofWeek.Воскресенье); break;
            //}
            Console.WriteLine("Задание 10");
            int[] array = { 11, 2, 31,44,4 };
            int min = 100;
            int max = 0;
            int n = 0;
            int n2,n3,n4;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                { min = array[i]; }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                { max = array[i]; }
            }
            int min1 = max - min;
            for (int i = 0; i < array.Length; i++)
            {
                if (max - array[i] < min1 && array[i] != max)
                { 
                    min1 = max - array[i];
                    n4 = array[i];
                }
            }
            (int, int,int,int, int) t = (min,0,0,0 , max);
            t.Item4 = n4;

            
            //Console.WriteLine("Задание 11");
        }
        enum DayofWeek
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
    }
}
