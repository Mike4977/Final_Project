string[] arrayStr = new string[] {"world", "d2", "hello", ":-)"};

void PrintArray(string[] arrStr)
{
     Console.Write("[");
    for (int i = 0; i < arrStr.Length; i++)
    {
         if (i < arrStr.Length - 1) Console.Write($"\"{arrStr[i]}\", ");
		else Console.Write($"\"{arrStr[i]}\"");
    }
    Console.Write("]");
}


string[] ArrayElementLength(string[] arr)
{
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if(arr[j].Length <= 3) 
        {
            arr[count] = arr[j];
            count++;
        }   
    }
    string[] newArr = new string[count];
    for (int i = 0; i < count; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
} 

PrintArray(arrayStr);
Console.Write(" -> ");
PrintArray(ArrayElementLength(arrayStr));
