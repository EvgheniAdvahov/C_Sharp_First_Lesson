Console.Clear();

int [] array = {11,21,132,45,45,36,27,89};

int n = array.Length;
int find = 45;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}