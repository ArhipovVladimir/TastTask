void PrintArray (string [] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
            if (i == 0) Console.Write ("[");
            if (i < array.Length - 1) Console.Write ($"{array[i],3},");
            else Console.Write ($"{array[i],3}]");
    } 
}


string [] array = {"Hellow", "tow", "Word", ":-)"};
PrintArray (array);
    


