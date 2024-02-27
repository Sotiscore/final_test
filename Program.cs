using static System.Console;

string ReadString()
{
    WriteLine("Введите слова через пробел");
    return ReadLine()!;
}

string[] StringToArray(string s)
{
    string[] stringArray = s.Split(" ");
    return stringArray;
}

string[] CreateMaxThreeDigitsArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] targetArray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            targetArray[count] = array[i];
            count++;
        }
    }
    return targetArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string str = ReadString();
string[] array = StringToArray(str);
string[] targetArray = CreateMaxThreeDigitsArray(array);
WriteLine();
PrintArray(targetArray);