using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ClassWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Упражнение 4.1");
            //Console.Write("Введите номер дня в году ");
            //int jan = 31;
            //int feb = 28;
            //int march = 31;
            //int april = 30;
            //int may = 31;
            //int june = 30;
            //int jule = 31;
            //int august = 31;
            //int sept = 30;
            //int oct = 31;
            //int nov = 30;
            //int dec = 31;
            //int day = Convert.ToInt32(Console.ReadLine());
            //if (day >= 1 && day <= 31)
            //{
            //    Console.WriteLine(day + " января");
            //}
            //else if (day >= 32 && day <= 59)
            //{
            //    Console.WriteLine(day - jan + " февраля");
            //}
            //else if (day >= 60 && day <= 90)
            //{
            //    Console.WriteLine(day - jan - feb + " марта");
            //}
            //else if (day >= 91 && day <= 120)
            //{
            //    Console.WriteLine(day - jan - feb - march + " апреля");
            //}
            //else if (day >= 121 && day <= 151)
            //{
            //    Console.WriteLine(day - jan - feb - march - april + " мая");
            //}
            //else if (day >= 152 && day <= 181)
            //{
            //    Console.WriteLine(day - jan - feb - march - april - may + " июня");
            //}
            //else if (day >= 182 && day <= 212)
            //{
            //    Console.WriteLine(day - jan - feb - march - april - may - june + " июля");
            //}
            //else if (day >= 213 && day <= 243)
            //{
            //    Console.WriteLine(day - jan - feb - march - april - may - june - jule + " августа"); ;
            //}
            //else if (day >= 244 && day <= 273)
            //{
            //    Console.WriteLine(day - jan - feb - march - april - may - june - jule - august + " сентября");
            //}
            //else if (day >= 274 && day <= 304)
            //{
            //    Console.WriteLine(day - jan - feb - march - april - may - june - jule - august - sept + " октября");
            //}
            //else if (day >= 305 && day <= 334)
            //{
            //    Console.WriteLine(day - jan - feb - march - april - may - june - jule - august - sept - oct + " ноября");
            //}
            //else if (day >= 335 && day <= 365)
            //{
            //    Console.WriteLine(day - jan - feb - march - april - may - june - jule - august - sept - oct - nov + " декабря");
            //}
            //Console.WriteLine("Упражнение 4.2");
            //Console.Write("Введите номер дня в году ");
            //int jan = 31;
            //int feb = 28;
            //int march = 31;
            //int april = 30;
            //int may = 31;
            //int june = 30;
            //int jule = 31;
            //int august = 31;
            //int sept = 30;
            //int oct = 31;
            //int nov = 30;
            //try
            //{
            //    ushort day = Convert.ToUInt16(Console.ReadLine());
            //    if (day >= 1 && day <= 31)
            //    {
            //        Console.WriteLine(day + " января");
            //    }
            //    else if (day >= 32 && day <= 59)
            //    {
            //        Console.WriteLine(day - jan + " февраля");
            //    }
            //    else if (day >= 60 && day <= 90)
            //    {
            //        Console.WriteLine(day - jan - feb + " марта");
            //    }
            //    else if (day >= 91 && day <= 120)
            //    {
            //        Console.WriteLine(day - jan - feb - march + " апреля");
            //    }
            //    else if (day >= 121 && day <= 151)
            //    {
            //        Console.WriteLine(day - jan - feb - march - april + " мая");
            //    }
            //    else if (day >= 152 && day <= 181)
            //    {
            //        Console.WriteLine(day - jan - feb - march - april - may + " июня");
            //    }
            //    else if (day >= 182 && day <= 212)
            //    {
            //        Console.WriteLine(day - jan - feb - march - april - may - june + " июля");
            //    }
            //    else if (day >= 213 && day <= 243)
            //    {
            //        Console.WriteLine(day - jan - feb - march - april - may - june - jule + " августа"); ;
            //    }
            //    else if (day >= 244 && day <= 273)
            //    {
            //        Console.WriteLine(day - jan - feb - march - april - may - june - jule - august + " сентября");
            //    }
            //    else if (day >= 274 && day <= 304)
            //    {
            //        Console.WriteLine(day - jan - feb - march - april - may - june - jule - august - sept + " октября");
            //    }
            //    else if (day >= 305 && day <= 334)
            //    {
            //        Console.WriteLine(day - jan - feb - march - april - may - june - jule - august - sept - oct + " ноября");
            //    }
            //    else if (day >= 335 && day <= 365)
            //    {
            //        Console.WriteLine(day - jan - feb - march - april - may - june - jule - august - sept - oct - nov + " декабря");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error!!!!!!!");
            //    }
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Error!!!!!!!");
            //}
            //finally
            //{
            //    Console.WriteLine("Спасибо за попытку!");
            //}
            //Console.WriteLine("Домашнее задание 4.1");
            //Console.Write("Введите год ");
            //ushort year = Convert.ToUInt16(Console.ReadLine());
            //Console.Write("Введите номер дня в году ");
            
            //try
            //{
                
            //    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //    {
            //        int jan = 31;
            //        int feb = 29;
            //        int march = 31;
            //        int april = 30;
            //        int may = 31;
            //        int june = 30;
            //        int jule = 31;
            //        int august = 31;
            //        int sept = 30;
            //        int oct = 31;
            //        int nov = 30;
            //        ushort day = Convert.ToUInt16(Console.ReadLine());
            //        if (day >= 1 && day <= 31)
            //        {
            //            Console.WriteLine(day + " января");
            //        }
            //        else if (day >= 32 && day <= 59 + 1)
            //        {
            //            Console.WriteLine(day - jan + " февраля");
            //        }
            //        else if (day >= 60 && day <= 90 + 1)
            //        {
            //            Console.WriteLine(day - jan - feb + " марта");
            //        }
            //        else if (day >= 91 && day <= 120 + 1)
            //        {
            //            Console.WriteLine(day - jan - feb - march + " апреля");
            //        }
            //        else if (day >= 121 && day <= 151 + 1)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april + " мая");
            //        }
            //        else if (day >= 152 && day <= 181 + 1)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april - may + " июня");
            //        }
            //        else if (day >= 182 && day <= 212 + 1)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april - may - june + " июля");
            //        }
            //        else if (day >= 213 && day <= 243 + 1)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april - may - june - jule + " августа"); ;
            //        }
            //        else if (day >= 244 && day <= 273 + 1)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april - may - june - jule - august + " сентября");
            //        }
            //        else if (day >= 274 && day <= 304 + 1)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april - may - june - jule - august - sept + " октября");
            //        }
            //        else if (day >= 305 && day <= 334 + 1)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april - may - june - jule - august - sept - oct + " ноября");
            //        }
            //        else if (day >= 335 && day <= 365 + 1)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april - may - june - jule - august - sept - oct - nov + " декабря");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error!!!!!!!");
            //        }
            //    }
            //    else
            //    {
            //        int jan = 31;
            //        int feb = 28;
            //        int march = 31;
            //        int april = 30;
            //        int may = 31;
            //        int june = 30;
            //        int jule = 31;
            //        int august = 31;
            //        int sept = 30;
            //        int oct = 31;
            //        int nov = 30;
            //        ushort day = Convert.ToUInt16(Console.ReadLine());
            //        if (day >= 1 && day <= 31)
            //        {
            //            Console.WriteLine(day + " января");
            //        }
            //        else if (day >= 32 && day <= 59)
            //        {
            //            Console.WriteLine(day - jan + " февраля");
            //        }
            //        else if (day >= 60 && day <= 90)
            //        {
            //            Console.WriteLine(day - jan - feb + " марта");
            //        }
            //        else if (day >= 91 && day <= 120)
            //        {
            //            Console.WriteLine(day - jan - feb - march + " апреля");
            //        }
            //        else if (day >= 121 && day <= 151)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april + " мая");
            //        }
            //        else if (day >= 152 && day <= 181)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april - may + " июня");
            //        }
            //        else if (day >= 182 && day <= 212)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april - may - june + " июля");
            //        }
            //        else if (day >= 213 && day <= 243)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april - may - june - jule + " августа"); ;
            //        }
            //        else if (day >= 244 && day <= 273)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april - may - june - jule - august + " сентября");
            //        }
            //        else if (day >= 274 && day <= 304)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april - may - june - jule - august - sept + " октября");
            //        }
            //        else if (day >= 305 && day <= 334)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april - may - june - jule - august - sept - oct + " ноября");
            //        }
            //        else if (day >= 335 && day <= 365)
            //        {
            //            Console.WriteLine(day - jan - feb - march - april - may - june - jule - august - sept - oct - nov + " декабря");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error!!!!!!!");
            //        }
            //    }
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Error!!!!!!!");
            //}
            //finally
            //{
            //    Console.WriteLine("Спасибо за попытку!");
            //}
        }
    }
}