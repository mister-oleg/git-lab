
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
            break;
        case 2:
            break;
        default:
            Console.WriteLine("Введен неккоректный ввод.");
            Console.ReadLine();
            break;
    }
    Console.Clear();
}