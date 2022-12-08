string[] Array(string[] array)
{
    Console.WriteLine("Введите первый элемент массива: ");
    string a = Console.ReadLine();
    Console.WriteLine("Введите второй элемент массива: ");
    string b = Console.ReadLine();
    Console.WriteLine("Введите третий элемент массива: ");
    string c = Console.ReadLine();
    Console.WriteLine("Введите четвертый элемент массива: ");
    string d = Console.ReadLine();

    array[0] = a;
    array[1] = b;
    array[2] = c;
    array[3] = d;

    return array;
}

void PrintArray(string[] array)
{
    foreach (string item in array)
    {
        Console.Write($"{item}, ");

    }
}

string[] NewArray(string[] array, string[] newArray)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }

    return array;
}

string[] array = new string[4];

Array(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();

string[] newArray = new string[4];

NewArray(array, newArray);
Console.WriteLine();
PrintArray(newArray);
Console.WriteLine();