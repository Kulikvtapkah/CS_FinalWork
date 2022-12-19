// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int EnterSmth(string request)
{
    System.Console.Write($" {request} >> ");
    int response = Convert.ToInt32(Console.ReadLine());
    return (response);
}

void NaturalNumbersSum(int min, int max, int sum)
{
      if (min < max)
    {
        min++;
        sum +=min;
       NaturalNumbersSum(min, max, sum);
    }
    else System.Console.Write(sum);
}

int M = EnterSmth("Введите М");
int N = EnterSmth("Введите N");

if (N < M) { int k = M; M = N; N = k; }
if (M < 1) M = 1; 

if (N < 1) System.Console.Write("К сожалению, нечего выводить(");
else
{
    System.Console.Write("Сумма натуральных чисел между М и N: ");
    NaturalNumbersSum(M, N, M);
}
