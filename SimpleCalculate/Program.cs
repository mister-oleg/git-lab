
string choise;
float number1;
float number2;
while (true)
{
    Console.WriteLine("Что хотите сделать?\n0 - Выйти из приложения\n1 - Сумма двух чисел\n2 - Вычитание двух чисел");
    choise = Console.ReadLine();
    Console.WriteLine("");
    switch (choise)
    {
        case "0":
            Console.WriteLine("Производится выход");
            return;
        case "1":
            number1 = InputFloat();
            number2 = InputFloat();
            var sum = number1 + number2;
            Console.WriteLine($"Сумма чисел = {sum}");
            break;
        case "2":
            number1 = InputFloat();
            number2 = InputFloat();
            var sub = number1 - number2;
            Console.WriteLine($"Вычитание чисел = {sub}");
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
    while (true)
    {
        string input = Console.ReadLine();
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
