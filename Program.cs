using System.Runtime.InteropServices;
using System;

namespace Lesson4_10._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
          {
              //ДЗ 1
             double summa= Convert.ToDouble(Console.ReadLine());
             if(summa>1000)Console.WriteLine( summa*0.95);
             else if (summa>500)Console.WriteLine(summa*0.97);
               else Console.WriteLine(summa);
               Console.WriteLine();
          }
            {
           //ДЗ 2
        Console.WriteLine("Введите четыре числа:");
       double a= Convert.ToDouble(Console.ReadLine());
       double b= Convert.ToDouble(Console.ReadLine());
       double c= Convert.ToDouble(Console.ReadLine());
       double d= Convert.ToDouble(Console.ReadLine());
       if(a==b && b==c &&c==d) 
       Console.WriteLine($"Результат : {a*b*c*d}");
       else if(a<=b && b<=c && c<=d)
       Console.WriteLine("<<Числа расположены по возрастанию>>");
       else 
      {
         double result=Math.Min(a,Math.Min(b,Math.Min(c,d)));
         Console.WriteLine($"Минимальное число : {result}");
      }
      Console.WriteLine();
         }
          {
             //ДЗ 3
         Console.WriteLine("Введите три числа:");
        double num1=double.Parse(Console.ReadLine());
        double num2=double.Parse(Console.ReadLine());
        double num3=double.Parse(Console.ReadLine());
        double sum=num1+num2+num3;
        double a1=Math.Max(num1,Math.Max(num2,num3));
         num3=Math.Min(num1,Math.Min(num2,num3));
        num1=a1;
        num2=sum-a1-num3;
        Console.Write($"{num1} {num2} {num3}");
         }
        }
    }
}
