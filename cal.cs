using System;
using System.IO;
using System.Text;

namespace cal
{
   public class main_class
   {
      static System.Random random_generator = new System.Random();
      public static void Main(string[] args)
      {
         string raptor_prompt_variable_zzyz;
         ?? x;
         ?? y;
         ?? op;
      
         raptor_prompt_variable_zzyz ="Enter x value";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         x= Double.Parse(Console.ReadLine());
         raptor_prompt_variable_zzyz ="enter th ey value";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         y= Double.Parse(Console.ReadLine());
         raptor_prompt_variable_zzyz ="Enter the operator";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         op= Double.Parse(Console.ReadLine());
         if (op=="+")
         {
            Console.WriteLine("x + y = "+(x+y));
         }
         else
         {
            if (op=="-")
            {
               Console.WriteLine("x - y = "+(x-y));
            }
            else
            {
               if (op=="*")
               {
                  Console.WriteLine("x * y = "+(x*y));
               }
               else
               {
                  if (op=="/")
                  {
                     Console.WriteLine("x / y = "+(x/y));
                  }
                  else
                  {
                     if (op=="%")
                     {
                        Console.WriteLine("x % y = "+(x % y));
                     }
                     else
                     {
                        if (op=="^")
                        {
                           Console.WriteLine("x ^ y = "+(x ** y));
                        }
                        else
                        {
                        }
                     }
                  }
               }
            }
         }
      }
   }
}
