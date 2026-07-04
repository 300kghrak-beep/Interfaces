using System.Collections.Immutable;
// 1
#region IOutput
interface IOutput
{
    void Show();
    void Show(string info);
}
#endregion
// 2
#region IMath
interface IMath
{
    int Max();
    int Min();
    float Avg();
    bool Search(int valueToSearch);
}
#endregion
// 3
#region ISort
interface ISort
{
    void SortAsc();
    void SortDesc();
    void SortByParam(bool isAsc);
}
#endregion
#region Array
class MyArray : IOutput, IMath, ISort
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


    public int Max()
    {
        return array.Max();
    }

    public int Min() 
    {
        return array.Min();
    }

    public float Avg()
    {
        return (float)array.Average();
    }

    public bool Search(int valueToSearch)
    {
       for (int i = 0; i <  this.array.Length; i++)
       {
            if (array[i] == valueToSearch) return true;
       }
        return false;
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


    public void SortAsc()
    {
        Array.Sort(array);
    }

    public void SortDesc()
    {
        Array.Sort(array);
        Array.Reverse(array);
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc)
        {
            SortAsc();
        }
        else
        {
            SortDesc();
        }
    }
}
#endregion


// 4
#region IShape
interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}
#endregion
#region Shapes
class Circle : IShape
{
    public double radius;

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Rectangle : IShape
{
    public double length;
    public double width;

    public double CalculateArea()
    {
        return length * width;
    }

    public double CalculatePerimeter()
    {
        return 2 * (length + width);
    }
}

class Triangle : IShape
{
    public double side1;
    public double side2;
    public double side3;

    public double CalculateArea()
    {
        double p = CalculatePerimeter() / 2;
        return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
    }

    public double CalculatePerimeter()
    {
        return side1 + side2 + side3;
    }
}
#endregion

// 5
#region IDrivable
interface IDrivable
{
    void StartEngine();
    void StopEngine();
    void Drive();
}
#endregion
#region Vehicles
class Automobile : IDrivable
{
    public void StartEngine()
    {
        Console.WriteLine("Automobile engine started!");
    }

    public void StopEngine() { 
        Console.WriteLine("Automobile engine stopped!"); 
    }

    public void Drive()
    {
        Console.WriteLine("Automibile is driving!");
    }
}


class Motorbike: IDrivable
{
    public void StartEngine()
    {
        Console.WriteLine("Motorbike engine started!");
    }

    public void StopEngine()
    {
        Console.WriteLine("Motorbike engine stopped!");
    }

    public void Drive()
    {
        Console.WriteLine("Motorbike is driving!");
    }
}
#endregion

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