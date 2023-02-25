// Выбрать из массива строк те строки, длинна которых меньше или равна трем

string[] Array()  // Метод: создаем исходный массив 
{
    Console.Write("Введите количество строк, которые хотите ввести: ");
    int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
    string[] strs = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите строку №{0}:\r\n    ", i + 1);
        strs[i] = Console.ReadLine(); //Заполняем этот массив
    }
    Console.WriteLine("Вы ввели следующий массив:");
    return strs; // возвращаем заполненный массив
}

void PrintArray(string[] array) // Метод: распечатываем наш массив в фигурных скобках []
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, "); // чтобы после последнего символа не выводилась запятая
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

string[] MinArray(string[] array) // Метод: принимает массив и возвращает из него массив, все элементы котороко по длинне меньше или равны трем
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) // в исходном массиве считаем количество элементов, длинна которых меньше или равна трем
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] strs = new string[count]; // задаем новый массив с длинной равной кол-ву элементов, найденному в цикле выше
    int j = 0;
    for (int i = 0; i < array.Length; i++)  // заполняем элементы нового массива значениями элементов исходного массива, длинна которых меньше или равна трем
    {
        if (array[i].Length <= 3)
        {
            strs[j] = array[i];
            j++;
        }
    }
    return strs; // возвращаем заполненный массив
}

string[] arr = Array();
PrintArray(arr);
Console.WriteLine("Получаем массив из строк, длмнна которых меньше или равна 3 :");
string[] minArray = MinArray(arr);
PrintArray(minArray);
