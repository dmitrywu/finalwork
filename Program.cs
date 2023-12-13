/* Написать программу, которая из имеющегося массива *строк* 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо ***задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

string[] inputArray = new string[9] { "all", "you", "need", "is", "mnogo", "ochen", ",", "mnogo", "deneg" };

int count = 0;
for (int i = 0; i < inputArray.Length; i++) if (inputArray[i].Length <= 3) count++;

string[] outputArray = new string[count];
int outputArrayLength = outputArray.Length;


for (int i = 0; i < inputArray.Length; i++)
    if (inputArray[i].Length <= 3)
    {
        count--;
        outputArray[outputArray.Length - count - 1] = inputArray[i];
    }


Console.WriteLine($"IN: Length: {inputArray.Length}, Content: {string.Join(" ", inputArray)}");
Console.WriteLine($"OUT: Length: {outputArray.Length}, Content: {string.Join(" ", outputArray)}");

