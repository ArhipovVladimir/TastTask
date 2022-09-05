void PrintArray (string [] array)
{

    for (int i = 0; i < array.Length; i++)
    {
            if (i == 0) Console.Write ("[");
            if (i < array.Length - 1) Console.Write ($"{array[i]}, ");
            else Console.Write ($"{array[i]}]");
    } 
}

int CounrThreeCharacters (string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
            if (array[i].Length>=3) count++;
    }
    return count; 
}

string [] CreateNewArray (string [] array, int len)
{
    string [] newArray = new string [len];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length>=3)
        {
            newArray[count]=array[i];
            count ++;
        }
    }
    return newArray;
}


string [] array = {"Hellow", "tow", "Word", "-)"};
PrintArray (array);
int lenNewArray = CounrThreeCharacters(array);
string [] newArray = CreateNewArray (array, lenNewArray);
Console.Write (" -> ");
PrintArray (newArray);
    


