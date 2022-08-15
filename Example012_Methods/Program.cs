  // Вид 1
  // Ничего не возвращают, и ничего не принимают.

void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();



   // Вид 2
   // Ничего не возвращают, но принимают некоторые аргументы.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: "Новый текст");

   // Вид 3.
   // Что-то возвращают, но ничего не принимают.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

   // Вид 4.
   // Что-то принимают и что-то возвращают.

//string Method4(int count, string text)
//{
//    int i = 0;
//    string result = String.Empty;
    // Пустая строка
//
//    while (i < count)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}

   // Цикл for.
string Method4(int count, string text)
{
    string result = String.Empty;
    // Пустая строка
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
//Console.WriteLine(res);

   // Цикл в цикле.
   // Таблица умножения.

//for (int i = 2; i <= 10; i++)
//{
//    for(int j = 2; j <= 10; j++)
//    {
//        Console.WriteLine($"{i} x {j} = {i * j}");
//    }
//    Console.WriteLine();

   // Исскуственный разрыв, пустая строчка.
//}

   // Работа с текстом.
   // Дан текст. В тексте нужно все пробелы заменить на черточки,
   // маленькие буквы "к" заменить большими "К", а большие "С" 
   // заменить маленькими "с".

//string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//            + "ежели бы вас послали вместо нашего милого Винценгерода,"
//            + "вы бы взяли приступом согласие прусского короля. "
//            + "Вы так красноречивы. Вы дадите мне чаю?";

  // string s = "qwerty"
  //             012345
  // s [3] // r

//string Replace(string text, char oldValue, char newValue)
//{
//    string result = String.Empty;
    // пустая строка

//    int length = text.Length;
//    for (int i = 0; i < length; i++)
//    {
//        if(text[i] == oldValue) result = result + $"{newValue}";
//        else result = result + $"{text[i]}";
//    }

//    return result;
//}

//string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);

//Console.WriteLine();
   // Пустая строчка.

//newText = Replace(newText, 'к', 'К');
//Console.WriteLine(newText);

//Console.WriteLine();

//newText = Replace(newText, 'с', 'С');
//Console.WriteLine(newText);


   //Алгоритм сортировки методом выбора.
   //Алгоритм метода выбора max, min.

   //C минимального.
//int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

//void PrintArray(int[] array)
//{
//    int count = array.Length;

//    for (int i = 0; i < count; i++)
//    {
//        Console.Write($"{array[i]} ");
//    }
//    Console.WriteLine();
//}

//void SelectionSort(int[] array)
//{
//    for (int i = 0; i < array.Length -1; i++)
//    {
//        int minPosition = i;

//        for (int j = i + 1; j < array.Length; j++)
//        {
//            if(array[j] < array[minPosition]) minPosition = j;
//        }
//        int temporary = array[i];
//        array[i] = array[minPosition];
//        array[minPosition] = temporary;
//    }
//}

//PrintArray(arr);
//SelectionSort(arr);

//PrintArray(arr);

     //С максимального.

int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
