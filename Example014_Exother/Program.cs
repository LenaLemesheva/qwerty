using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)" // возьмите текст
               .Replace("(", "")  // замените в нем скобочки
               .Replace(")", "")  // замените в нем вторые скобочки
               ;
Console.WriteLine(text);

var data = text.Split(" ") // возьмите текст разделите пробелом
                .Select(item => item.Split(',')) //сделайте выборку таких элементов с разделителем запятая
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))//сделайте выборку из текущего массива(первый элемент коорд. х, вторая -у)
                .Where (e => e.x % 2 == 0) //проверка, что первая координата четная
                .Select(point => (point.x * 10, point.y))//хотим делать изменение первой координаты
                .ToArray();//превратить в явный массив

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}
