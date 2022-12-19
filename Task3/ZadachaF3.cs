// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// границы дозволенного        n   0,            1,             2,     3,   4,   5
//   на ввод                   m  4000 000 000   12000         5300    10   0    -

// Хотела увидеть эти жутко большие числа, поставила тип данных ulong
// В итоге, увидела только stack overflow, вернула все на int. Немного жаль(


int EnterUnsigned(string request)
{
    int response = 0;
    bool f = false;
    while (f != true)
    {
        System.Console.Write($" {request} >> ");
        response = Convert.ToInt32(Console.ReadLine());
        if (response < 0)
            System.Console.Write("Число должно быть неотрицатльными, попробуйте еще раз...");
        else
            f = true;
    }
    return response;
}

int Ackermans(int ackermans, int n, int m)
{
    if (n == 0) ackermans = m + 1;
    else
    {
        if (m == 0) ackermans = Ackermans( ackermans, (n - 1) , 1);
        else ackermans = Ackermans(ackermans, (n - 1), Ackermans(ackermans, n, (m - 1)));
    }
   return ackermans;
}

System.Console.WriteLine("Вычисляем функцию Аккермана A(m,n). Как говорится, кто не рискует... ");

int n = EnterUnsigned("Введите n");
int m = EnterUnsigned("Введите m");

System.Console.Write($"Значение функции Аккермана A({n},{m}) = {Ackermans(0, n, m)}.");






