// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 


Console.Write("Введите 8 чисел: ");

string str = Console.ReadLine();
char[] arr = new char[str.Length]; 
if (str.Length != 8) 
{
Console.WriteLine($"Нужно вводить 8 чисeл");
}
else   
       { 
        for (int i = 0; i < str.Length; i++)
         { 
            arr[i] = str[i]; 
         } 
        Console.WriteLine(string.Join(", ", arr)); 
    }
