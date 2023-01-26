// Программа из имеющегося массива строк формирует массив из строк, 
// длина которых меньше, либо равна 3 символа






string [] array = {"hello", "2", "world", ":-)"};
string [] newArray = CreateNewArray(array);
Console.Write($"[{String.Join(", ",newArray)}]");
