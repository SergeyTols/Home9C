int m = InputNumbers("Введите число (m): ");
int n = InputNumbers("Введите число (n): ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int sum = 0;
if (m <= n && n > 0)
{    
    Console.Write("Натуральные числа от m до n: \"\"");
    
        for(int i = m; i < n; i++)
        {
            if(i > 0)
            {
                Console.Write(i + ", ");
                sum += i;
            } 
        } 
    sum += n;    
    Console.Write(n + "\"\"");
    Console.Write($"\nСумма натуральных чисел между {m} и {n} : {sum}");
}
else Console.Write("Натуральных чисел нет между ними");

