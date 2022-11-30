string[] ArrayStringShorter4Symbols(string[] arrayIn)
{
    int count = default;
    int index = default;

    for (int i = 0; i < arrayIn.Length; i++)
    {
        if (arrayIn[i].Length <= 3)
        {
            count++;
        }
    }

    string[] arrayOut = new string[count];

    for (int j = 0; j < arrayIn.Length; j++)
    {
        if (arrayIn[j].Length <= 3) arrayOut[index++] = arrayIn[j];
    }

    return arrayOut;
}

void PrintStringArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

string[] arrayCheck = {"hello", "2", "world", ":-)"};
string[] arrayVerified = ArrayStringShorter4Symbols(arrayCheck);
PrintStringArray(arrayVerified);