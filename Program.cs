// Программа из имеющегося массива строк формирует массив из строк, 
// длина которых меньше, либо равна 3 символа

string [] CreateNewArray(string [] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i].Length<=3) count++;
    }
    string [] newArray = new string [count];
    int newArrayIndex = 0;
    for(int i=0; i<array.Length; i++)
    {
        
        if(array[i].Length<=3)
        {
            newArray[newArrayIndex] = array[i];
            newArrayIndex++;
        } 
    }
    return newArray;
}

string [] array = {"hello", "2", "world", ":-)"};
string [] newArray = CreateNewArray(array);
Console.Write($"[{String.Join(", ",array)}] -> [{String.Join(", ",newArray)}]");
