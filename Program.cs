/* Написать программу, которая из имеющегося массива *строк* 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо ***задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

string[] inputArray = new string[7] { "all", "you", "need", "is", "mnogo", "ochen mnogo", "deneg" };

// var ssttrr = string.Join(" ", inputArray);
// Console.WriteLine($"{ssttrr}");

// var ssttrr = string.Join(" ", inputArray);
Console.WriteLine($"{string.Join(" ", inputArray)}");

int count=0;
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length<=3)
    {
        count++;
        Console.WriteLine($"Pos: {i} - Length: {inputArray[i].Length} - Count: {count}"); // немного статистики :)
    }
}
 
string[] outputArray = new string[count];

Console.WriteLine($"output length: {outputArray.Length}");


for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length<=3)
    {
        count--;
        outputArray[count]=inputArray[i];
    }
}

Console.WriteLine($"{string.Join(" ", outputArray)}");

