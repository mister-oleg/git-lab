
int choise;
while (true)
{
    Console.WriteLine("Что хотите сделать?\n0 - Выйти из приложения\n1 - Сумма двух чисел\n2 - Вычитание двух чисел");
    choise = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    switch (choise)
    {
        case 0:
            Console.WriteLine("Производится выход");
            return;
        case 1:
            var number1 = InputFloat();
            var number2 = InputFloat();
            var sum = number1 + number2;
            Console.WriteLine($"Сумма чисел = {sum}");
            break;
        case 2:
            break;
        default:
            Console.WriteLine("Введен неккоректный ввод.");            
            break;
    }
    Console.ReadLine();
    Console.Clear();
}

static float InputFloat()
{
    Console.WriteLine("Введите число");
    string input = Console.ReadLine();
    while (true)
    {
        if (float.TryParse(input, out float number))
        {
            return number;
        }
        else 
        {
            Console.WriteLine("Введено не число. Повторите попытку");
        }
    }
}
