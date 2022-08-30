/* Собрать строку с числами от a до b, a <= b */

/* string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10)); //1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); //1 2 3 4 5 6 7 8 9 10
*/

/* Собрать строку с числами от a до b, a >= b */

/* string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10)); //10 9 8 7 6 5 4 3 2 1
Console.WriteLine(NumbersRec(1, 10)); //10 9 8 7 6 5 4 3 2 1
*/

/* Сумма чисел от 1 до n */

/* int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i ++)
    result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10)); //55
Console.WriteLine(SumRec(10)); //55
*/

/* Факториал числа */

/* int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    result *= i;
    return result;
}

int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800
*/

/* Вычислить a в степени n */

/* int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    // return n == 0 ? 1 : PowerRec(a, n - 1) * a; // тоже самое
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024
*/

/* Перебор слов.
Например: В некотором машинном алфавите имеются четыре буквы "а", "и", "с" и "в". 
Покажите все слова, состоящие из Т букв, которые можно построить из букв этого
алфавита. */

/* char[] s = { 'а', 'и', 'с', 'в' }; // алфавит, который хранится в массиве символов
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++) // переберем все однобуквенные слова
{
    for (int j = 0; j < count; j++) // если нужны двубуквенные слова
    {
        for (int k = 0; k < count; k++) // если нужны трехбуквенные слова
        {
            for (int l = 0; l < count; l++) // если четырехбуквенные
            {
                for (int m = 0; m < count; m++)  //если пятибуквенные
                {
                    Console.WriteLine($"{n++,-5}{s[i]} {s[j]} {s[k]} {s[l]} {s[m]}");
                }
            }
        }
    }
}
*/

/* Есть 5 игроков. Нужно показать все разбиения игроков на две команды.
0 - игрок попадает в первую команду
1 - игрок попадает во вторую команду */

/* int n = 1; // счетчик слов
void FindWords(string alphabet, char[] word, int length = 0) // метод, который принимает алфавит строкой; массив из строк, которое составляет новое слово; длина слова
{
    if (length == word.Length) // условия из рекурсии: длина массива совпала с длиной слова
    {
        Console.WriteLine($"{n++} {new String(word)}"); // показывать это слово
        return;
    }
    for (int i = 0; i < alphabet.Length; i++) // пустить цикл по всем буквам алфавита
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1); // собрать новое очередное слово
    }
}

FindWords("аисв", new char[3]);
*/

/* Поиск папки в директории */

/* string path = "/home/dal90pc/Документы/Учеба/Знакомство с языками программирования/Лекция/Examples/Example002_HelloUser";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime); // время создания файла
FileInfo[] fi = di.GetFiles(); // какие содержат файлы

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
*/

/* Рекурсия будет ходить по папкам и смотреть, что там внутри */

/* void CatalogInfo(string path, string indent = "") // path - путь к текущей папки, "" - отступы, чтобы видеть структуру папки
{
    DirectoryInfo catalog = new DirectoryInfo(path); // директория, по которой мы зашли по пути path

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++) // цикл, пробегает по всем файлам
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}"); // выводя информацию по каталоги
        CatalogInfo(catalogs[i].FullName, indent + "  ");  // будем рекурсивно заныривать и смотреть все файлы
    }

    FileInfo[] files = catalog.GetFiles(); // получим весь список файлов, текущей директории

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}"); // и покажем их
    }
}
string path = @"/home/dal90pc/Документы/Учеба/Знакомство с языками программирования/Лекция/Examples/Example002_HelloUser";
CatalogInfo(path);
*/

/* Игра в пирамидки */

/* void Towers(string with = "1", string on = "3", string some = "2", int count = 4) // 1 - откуда, 3 - куда, 2 - промежуточная; count - сколько блинов всего
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();
*/

/* Обход разных структур */

/* string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" }; // массив этого дерева
//                 0    1    2     3    4     5    6    7    8    9   10   11
void InOrderTraversal(int pos = 1) // метод, с которого начнем обход, pos - место с которого начнем
{
    if (pos < tree.Length)  // делаем проверку, если позиция дощла до длины дерева, рекурсия закончилась
    {
        int left = 2 * pos; // позиция левой ветки
        int right = 2 * pos + 1;  // позиция правой ветки
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left); // если имеется левой ветки, и не пустой элемент emp, то рекурсивно проделать обход
        Console.WriteLine(tree[pos]); // выводим узел (значение)
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right); // также правая ветка
    }
}
InOrderTraversal();
*/

