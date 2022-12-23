// /Написать программу, которая из имеющегося массива формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении пользоваться массивами.

Console.Write("Введите количество элеметов массива: ");
int count = Convert.ToInt32(Console.ReadLine());
string?[] array = new string[count];
Console.WriteLine();
for (int i = 0; i < count; i++)
{
    Console.Write($"Введите {i + 1}-ый элемент массива: ");
    array[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();
Console.Write("Элементы массива, в которых число символов меньше или равно трем: ");

for (int i = 0; i < array.Length; i++)
{
    if (array[i]!.Length<= 3)
    {
        Console.Write( array[i] + ", ");
    }
}

