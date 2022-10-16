string[] InputArray() 
{
    Console.WriteLine("Enter elements devided by spaces: ");
    return Console.ReadLine().Split(" ");
}

int Count(string[] inArray) 
{
    int count = 0;
    for(int i = 0; i < inArray.Length; i++) {
        if(inArray[i].Length <= 3) 
        {
            count++;
        }
    }

    return count;
}

string[] OutputArray(string[] inArray) 
{
    string[] output = new string[Count(inArray)];
    for(int i = 0, j = 0; i < inArray.Length; i++) 
    {
        if(inArray[i].Length <= 3) 
        {
            output[j] = inArray[i];
            j++;
        }
    }

    return output;
}
string[] inArray = InputArray();
string[] outArray = OutputArray(inArray);
Console.WriteLine($"3 or less symbols elements are: {string.Join(", ", outArray)}");