//Задача: Написать программу, которая из имеющегося
// массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

//метод подсчета количества строк состоящих из 3-х и менее символов
int CountSimbol(string[] input, int n)
 {
    int count = 0;

    for(int i = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}

// создание массива размерностью = количества строк удовлетворяющих условию, подсчета
// сколько строк размерностью 3-х и менее символов

string[] ArraySimbol(string[] input, int n)
 {
    string[] output = new string[CountSimbol(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

Console.Clear();

string[] ArrayInput() // МЕтод ввода строк символов через консоль и получения массива
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
}
string[] array = ArrayInput(); //получили первый массив из разных строк символов
string[] result = ArraySimbol(array, 3);// новый массив из строк от 3-х и менее
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");
