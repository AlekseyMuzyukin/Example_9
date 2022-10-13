Console.Write("Введите число M:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

int summNumbers = SummNumbers(num1,num2);
Console.WriteLine(summNumbers);
int SummNumbers(int num1, int num2)

{
    if (num1 < num2)
    {
        num2 = num2 + SummNumbers(num1,num2-1);
        return num2;
    }
    if (num1 > num2)
    {
         num1 = num1 + SummNumbers(num1-1,num2);
         return num1;
    }
    if (num1 == num2)
    {
        return num2;
    }
    return 0;
}