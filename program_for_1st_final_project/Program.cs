// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не пользоваться коллекциями.


int FindNewSize(string [] stringArray)  //метод для нахождения размера нового массива
{

    int newsize = 0;
    for (int i = 0; i < stringArray.Length; i++)
        {
            if (stringArray[i].Length <= 3)
            {
                newsize ++;
            }
    }
    return newsize;
}
void ShowArray(string [] array) //метод для отображения массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine();
}

string [] FindNewStringArray(string [] stringArray, int  NewSize) // создаем новый массив
{
    int iNew = 0;
    string [] newStrArray = new string[NewSize];
    for (int i = 0; i < stringArray.Length; i++)
    if (stringArray[i].Length <= 3)
        {
            newStrArray[iNew] = stringArray[i];
            iNew ++;
        }
        return newStrArray;
}

string [] stringArray = {"452", "qerty", "-1","computer sie", "02"}; 
int NewSize = (FindNewSize(stringArray)); 
Console.WriteLine($"We had an array of strings: ");
ShowArray(stringArray);

Console.WriteLine($"Array of strings with a length of no more than 3 is: ");
string [] NewstringArray = FindNewStringArray(stringArray, NewSize); 
ShowArray(NewstringArray);