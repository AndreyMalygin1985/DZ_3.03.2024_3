using static System.Console;

// Напишите метод, фильтрующий массив на основании переданных параметров.
// Метод принимает параметры: оригинальный_массив, массив_с_данными_для_фильтрации.
// Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
// Например:
//  1 2 6 - 1 88  7 6 — оригинальный массив;
//  6 88 7 — массив для фильтрации;
//  1 2 - 1 — результат работы метода.

class Program
{
    static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        List<int> result = new List<int>();

        foreach (int number in originalArray)
        {
            if (!filterArray.Contains(number))
            {
                result.Add(number);
            }
        }

        return result.ToArray();
    }

    static void Main(string[] args)
    {
        int[] originalArray = [1, 2, 6, -1, 88, 7, 6];
        int[] filterArray = [6, 88, 7];

        int[] filteredArray = FilterArray(originalArray, filterArray);

        WriteLine("Оригинальный массив:");
        WriteLine(string.Join(" ", originalArray));

        WriteLine("Массив для фильтрации:");
        WriteLine(string.Join(" ", filterArray));

        WriteLine("Получившийся массив после фильтрации:");
        WriteLine(string.Join(" ", filteredArray));
    }
}