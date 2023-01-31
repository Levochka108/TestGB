/*
## Задача 1
## Написать программу!
---
Которая из имеющихся строк массива формирует массив из строк, дринна которых меньше либо равно  3 символам. 
Первоначальнаый массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
---
*/
static void Main(string[] args)
{
    string[] testArray = new string[4];

    int arrayLength = testArray.Length;

    string[] tempArray = new string[testArray.Length];

    int strLen2 = testArray.Length;

    Console.WriteLine("Заполните массив данными. Внимание должнобыть хотябы 2 значения с длинной не больше 3 символов.");
    Thread.Sleep(1000);
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write("Enter: ");
        testArray[i] = Console.ReadLine()!;
    }

    Console.WriteLine("Происходит обработка нового массива.");
    Thread.Sleep(1000);
    Console.WriteLine("Подождите.");

    for (int i = 0; i < 10; i++)
    {
        if (i == 0)
        {
            Console.WriteLine("Загрузка");
        }

        else
        {
            if (i == 9)
            {
                Console.Write(". 100%");
            }
        }
        Thread.Sleep(300);
        Console.Write($".");
    }

    Thread.Sleep(1000);
    Console.WriteLine();



    string[] tempArray2 = new string[arrayLength];

    int k = 0;

    Console.WriteLine($"Запись произведина");

    for (int j = 0; j < tempArray.Length; j++)
    {

        if (testArray[j].Length <= 3)
        {
            int countStart = 0;
            int countStop = 1;

            while (countStart < countStop)
            {
                tempArray2[k] = testArray[j];
                Console.Write($" {tempArray2[k]}");
                countStart++;
                k++;
            }

        }

    }
}
Main(args);

for()