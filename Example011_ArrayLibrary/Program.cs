void FillArray(int[] collection)             // Метод заполнения массива непустыми элементами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)                   // Метод вывода массива в консоль
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int indexOf(int[] collection, int find)      // Поиск индекса элемента find
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;

}

int[] array = new int[10];                   // Генер. массива из 10 эл-в. Все равны 0.

FillArray(array);
PrintArray(array);

Console.WriteLine();
int pos = indexOf(array, 4);                // pos содержит индекс эл-та find. 
Console.WriteLine(pos);