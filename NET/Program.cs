using System.Runtime.CompilerServices;

interface IOutput
{
    void Show();
    void Show(string info);
}


class MyArray: IOutput
{
    public int[] array;
    public MyArray()
    {
        array = new int[0];
    }

    public MyArray(int[] array)
    {
        this.array = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            this.array[i] = array[i];
        }
    }

    public void Show()
    {
        for (int i = 0; i <  array.Length; i++)
        {
           Console.WriteLine(array[i]);
        }
    }

    public void Show(string info)
    {
        Console.WriteLine(info);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        int[] arr = {1, 2, 3, 4, 5};
        MyArray array = new MyArray(arr);
        array.Show();
        array.Show("Array: ");
    }
}