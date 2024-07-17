System.Console.Write ("Введите первое число");
int firstNumber = Convert.ToInt32 (Console.ReadLine());

System.Console.Write ("Введите второе число");
int secondNumber = Convert.ToInt32 (Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine ($"a = {firstNumber}, b = {secondNumber} => да");
}
else
{
    Console.WriteLine ($"a = {firstNumber}, b = {secondNumber} => нет");
}