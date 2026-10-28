
int choise;
while (true)
{
    Console.WriteLine("Что хотите сделать?\n0 - Выйти из приложения\n1 - Сумма двух чисел\n2 - Вычитание двух чисел");
    choise = int.Parse(Console.ReadLine());
    switch (choise)
    {
        case 0:
            break;
        case 1:
            break;
        case 2:
            break;
        default:
            Console.WriteLine("\nВведен неккоректный ввод.");
            Console.ReadLine();
            break;
    }
    Console.Clear();
}