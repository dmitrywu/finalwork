/* Написать программу, которая из имеющегося массива *строк* 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо ***задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

static int OutArraySizeCalculate(string[] array, int wordSize)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) if (array[i].Length <= wordSize) count++;
    return count;
}

static string[] OutArrayForming(string[] inputArray, int outArraySize, int wordSize)
{
    string[] outputArray = new string[OutArraySizeCalculate(inputArray, wordSize)];
    int count = outArraySize;

    for (int i = 0; i < inputArray.Length; i++)
        if (inputArray[i].Length <= wordSize)
        {
            outputArray[outputArray.Length - count] = inputArray[i];
            count--;
        }
    return outputArray;
}

string[] inputArray = new string[] {    "all", "you", "need", "is", "mnogo", "ochen", ",", 
                                        "mnogo", "deneg", "and", "other", "stuff", "!", "AAAaaa!", 
                                        "need", "more tests" };
int maxWordSize = 3;

Console.WriteLine($"IN: Length: {inputArray.Length}, Content: {string.Join(" ", inputArray)}");
Console.WriteLine($"OUT: Length: {OutArraySizeCalculate(inputArray, maxWordSize)}, Content: {string.Join(" ", OutArrayForming(inputArray, OutArraySizeCalculate(inputArray, maxWordSize), maxWordSize))}");