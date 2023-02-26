void PrintString(string[] str) // Фунция, принимающая на вход строку и выводящий в консоль значения <=3;
{
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3) // Сортировка строк, выводятся только <=3;
        {
            System.Console.Write("[" + string.Join("  ", str[i]) + "]");
        }
    }
}

void FillString(string [] stri) // Функция заполнения строк пользователем с клавиатуры;
{
for (int i = 0; i < stri.Length; i++)
{
    System.Console.WriteLine($"Введите {i} строку");
    stri[i] = Console.ReadLine();
}
}

System.Console.WriteLine("Введите кол-во строк");
int n = Convert.ToInt32(Console.ReadLine()); // Ввод кол-ва строк;
string[] str = new string[n]; // Инициализация строкового массива;
FillString(str);
System.Console.WriteLine();
PrintString(str);


