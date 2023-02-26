int[] array = { 21, 24, 31, 48, 25, 16, 57, 48 };

int n = array.Length;
int find = 48;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}