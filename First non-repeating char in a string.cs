using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) return;

        char[] inputArray = input.ToCharArray();
        int inputLength = inputArray.Length;
        int index = -1;

        for (int i = 0; i < inputLength; i++)
        {
            bool isUnique = true;

            for (int j = 0; j < inputLength; j++)
            {
                if (i != j && inputArray[i] == inputArray[j]) // Check if character repeats
                {
                    isUnique = false;
                    break;
                }
            }

            if (isUnique)
            {
                index = i;
                break;
            }
        }

        Console.WriteLine(index);
    }
}
