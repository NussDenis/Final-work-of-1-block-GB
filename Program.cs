void PrintArray(string[] nums)
{
    int length = nums.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"'{nums[i]}'");
        if (i == length - 1) Console.Write("");
        else Console.Write(", ");
    }
    Console.Write("]");
    Console.WriteLine("\n");
}

void Zadacha()
{
    string[] stringArray = { "text", ":-)", "Hello", "23", "Key", "Street", "One", "-17" };
    int length = stringArray.Length;
    Console.WriteLine();
    Console.Write("Вывод массива: ");
    PrintArray(stringArray);
    Console.Write("Масссив из строк, длина которых меньше либо равно 3 символа: [");
    for (int i = 0; i < length; i++)
    {
        int count = 0;
        for (int j = 0; j < stringArray[i].Length; j++)
        {
            count++;
        }
        if (count <= 3)
        {
            Console.Write($"'{stringArray[i]}'");
            if (i == length - 1) Console.Write("");
            else Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();

}
Zadacha();