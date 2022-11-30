int CounterArrayStringShorter4Symbols(string[] arrayCount)
{
    int count = default;

    for (int i = 0; i < arrayCount.Length; i++)
    {
        if (arrayCount[i].Length <= 3)
        {
            count++;
        }
    }

    return count;
}

string[] ArrayStringShorter4Symbols(string[] arrayIn, int count)
{
    string[] arrayOut = new string[count];
    int index = default;

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
int counterElems = CounterArrayStringShorter4Symbols(arrayCheck);
string[] arrayVerified = ArrayStringShorter4Symbols(arrayCheck, counterElems);

if (arrayVerified.Length == 0)
{
    Console.WriteLine("[]");
}
else PrintStringArray(arrayVerified);