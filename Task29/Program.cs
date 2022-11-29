int [] array = new int [8];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        arr[i] = rnd.Next(0,200);
    }
}
FillArray(array);
void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        Console.Write($"{arr[i]}, ");
        else
        Console.Write(arr[i]);
    }
}
PrintArray(array);
