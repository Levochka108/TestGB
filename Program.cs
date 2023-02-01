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
    
    int count = 0;

    Console.WriteLine("Заполните массив данными. Внимание, должнобыть хотябы 2 значения с длинной не больше 3 символов.");
    Thread.Sleep(1000);
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write("Enter: ");
        testArray[i] = Console.ReadLine()!;
        if (testArray[i].Length <= 3)
        {
            count++;
        }
    }

    Console.WriteLine("Происходит обработка нового массива.");
    Thread.Sleep(1000);
    Console.WriteLine("Подождите.");

    string[] newArray = new string[count];
  
    Console.WriteLine($"{ "Создано"} {newArray.Length } {"ячейки под массив."} ");


    for (int i = 0; i < 10; i++)
    {
        if (i == 0)
        {
            Console.Write("Загрузка: ");
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

    Console.WriteLine($"Запись произведина!");
    
    for (int j = 0, k =0; j < arrayLength; j++, k++)
    {
        if (testArray[j].Length <= 3)
        {
            newArray[k] = testArray[j];        
            Console.Write($"[{newArray[k]} новый массив index => {k}, старый index => {j}]");
                    
        }
        else if (testArray[j].Length > 3)
        {
           k--; 
        } 
                   
        
    }
}
Main(args);