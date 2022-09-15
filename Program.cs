string [] array = {"hellow", "2", "world", ":-)", "Russia", "Kazan","-2"};
Console.WriteLine($"Задан массив: {String.Join(", ",  array)}");
Console.WriteLine();
Console.WriteLine("Новый массив из строк длина которых меньше или равна 3:");
CreateArray(array);

void CreateArray (string [] newArray)
{   string [] array = new string [newArray.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i].Length<=3)
        {
            array[i]=newArray[i];
            Console.Write($"{newArray[i]} ");
        }
    }
}





