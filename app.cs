string[] array_1 = new string[5] {"string1", "string2", "string3", "string4", "string5"};
string[] array_2 = new string[array_1.Length];
void SecondArrayWithIF(string[] array_1, string[] array_2)
{
    int count = 0;
    for (int i = 0; i < array_1.Length; i++)
    {
    if(array_1[i].Length <= 3)
        {
        array_2[count] = array_1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array_1, array_2);
PrintArray(array_2);