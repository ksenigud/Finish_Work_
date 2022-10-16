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
