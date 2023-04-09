int a = new Random().Next(5,10);
int[] array =new int[a];

void FillArray(int[] array)
{
    int index = 0;
    while(index < array.Length)
    {
        array[index] = new Random().Next(0,10);
        index++;
    }
}
void PrintArray(int[] array)
{
    int index = 0;
    while(index < array.Length)
    {
        Console.WriteLine(array[index]);
        index+=1;
    }
}
int ExistInArray(int[] array, int find)
{
    int index = 0;
    int position = -1;
    while(index < array.Length)
    {
        if(array[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
FillArray(array);
PrintArray(array);
int pos = ExistInArray(array, 4);
Console.WriteLine();
Console.WriteLine(pos);

