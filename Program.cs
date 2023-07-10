//Задание №2 "Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее"
void Task_2()
{
   Console.WriteLine("Введите первое число");
   string input1 = Console.ReadLine();
   int number1 = Convert.ToInt32(input1);

   Console.WriteLine("Введите второе число");
   string input2 = Console.ReadLine();
   int number2 = Convert.ToInt32(input2);

   Console.WriteLine("Результат:");

   if (number1 > number2)
   {
       Console.WriteLine("Большее число = " + number1 + "(Первое число)");
       Console.WriteLine("Меньшее число = " + number2 + "(Второе число)");
   }
   else 
   {
       Console.WriteLine("Большее число = " + number2 + "(Второе число)");
       Console.WriteLine("Меньшее число = " + number1 + "(Первое число)");
   }
}
//Task_2();


//Задание №4 "Программа, которая принимает на вход три числа и выдает максимальное из этих чисел"

void Task_4()
{
   Console.WriteLine("Введите первое число");
   string input1 = Console.ReadLine();
   int number1 = Convert.ToInt32(input1);

   Console.WriteLine("Введите второе число");
   string input2 = Console.ReadLine();
   int number2 = Convert.ToInt32(input2);

   Console.WriteLine("Введите третье число");
   string input3 = Console.ReadLine();
   int number3 = Convert.ToInt32(input3);

   int max = number1;

   if (max < number2)
   {
       max = number2; 
   }
   if (number3 > max)
   {
       max = number3;
   }

   Console.WriteLine("Результат:");
   Console.WriteLine("Максимальным числом является " + max);
}
//Task_4();

//Задание №6 "Программа, которая на вход принимает число и выдает, является ли число четным (Делится ли оно на два без остатка)"

void Task_6()
{
   Console.WriteLine("Введите число");
   string input = Console.ReadLine();
   int number = Convert.ToInt32(input);

   if (number % 2 == 0)
   {
       Console.WriteLine("Число " + number + " является четным");
   }
   else
   {
       Console.WriteLine("Число " + number + " не является четным");
   }
}
//Task_6();

//Задание №8 "Программа, которая на вход принимает число (N>0), а на входе показывает все четные числа от 1 до N"

void Task_8()
{
   Console.WriteLine("Введите число");
   string input = Console.ReadLine();
   int number = Convert.ToInt32(input);
   int number1 = 1;

   if (number <= 0)
   {
       while (number <= 0)
       {
           Console.WriteLine("Число не является положительным");
           Console.Write("Введите число, которое будет больше нуля: ");
           string input1 = Console.ReadLine();
           int number_ = Convert.ToInt32(input1);
           number = number_;
       }
   }

   else
   {
       Console.WriteLine("Результат:");
   }
   Console.WriteLine("Результат:");
   if (number < 2)
   {
       Console.WriteLine("Между 1 и заданным числом нет целых четных чисел");
   }
   else
   {    
       while (number1 <= number)
       {
           if (number1 % 2 == 0)
           {
              Console.Write(number1 + " "); 
              number1 = number1 + 2;
           }
           else 
           {
               number1 = number1 + 1;
           }
       }
   }
}
//Task_8();