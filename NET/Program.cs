abstract class Device
{
    public string? Name { get; protected set; }
    public string? Description { get; protected set; }
    protected Device(string? name, string? description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Sound() { }
    public virtual void Show() { }
    public virtual void Desc() { }
}

class Kettle : Device
{
    public Kettle(string? name, string? description) : base(name, description)
    {
    }
    public override void Sound()
    {
        Console.WriteLine("Kettle is boiling water...");
    }
    public override void Show()
    {
        Console.WriteLine($"Kettle Name: {Name}");
    }
    public override void Desc()
    {
        Console.WriteLine($"Kettle Description: {Description}");
    }
}
class Microwave : Device
{
    public Microwave(string? name, string? description) : base(name, description)
    {
    }
    public override void Sound()
    {
        Console.WriteLine("Microwave is heating food...");
    }

    public override void Show()
    {
        Console.WriteLine($"Microwave Name: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Microwave Description: {Description}");
    }
}

class Automobile : Device
{
    public Automobile(string? name, string? description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Automobile is moving...");
    }
    public override void Show()
    {
        Console.WriteLine($"Automobile Name: {Name}");
    }
    public override void Desc()
    {
        Console.WriteLine($"Automobile Description: {Description}");
    }
}


class Steamship : Device
{
    public Steamship(string? name, string? description) : base(name, description)
    {
    }
    public override void Sound()
    {
        Console.WriteLine("Steamship is sailing...");
    }
    public override void Show()
    {
        Console.WriteLine($"Steamship Name: {Name}");
    }
    public override void Desc()
    {
        Console.WriteLine($"Steamship Description: {Description}");
    }
}


#region Musical Instruments

abstract class MusicalInstrument
{
    public string? Name { get; protected set; }
    public string? Description { get; protected set; }
    public string? History { get; protected set; }

    protected MusicalInstrument(string? name, string? description, string? history)
    {
        Name = name;
        Description = description;
        History = history;  
    }

    public virtual void Sound() { }
    public virtual void Show() { }
    public virtual void Desc() { }
    public virtual void Hist() { }
}

class Violin : MusicalInstrument
{
    public Violin(string? name, string? description, string? history) : base(name, description, history)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Violin is playing...");
    }

    public override void Show()
    {
        Console.WriteLine($"Violin Name: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Violin Description: {Description}");
    }
    public override void Hist() {
        Console.WriteLine($"Violin History: {History}");
    }
}

class Trombone : MusicalInstrument
{
    public Trombone(string? name, string? description, string? history) : base(name, description, history)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Trombone is playing...");
    }

    public override void Show()
    {
        Console.WriteLine($"Trombone Name: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Trombone Description: {Description}");
    }

    public override void Hist()
    {
        Console.WriteLine($"Trombone History: {History}");
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele(string? name, string? description, string? history) : base(name, description, history)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Ukulele is playing...");
    }

    public override void Show()
    {
        Console.WriteLine($"Ukulele Name: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Ukulele Description: {Description}");
    }

    public override void Hist()
    {
        Console.WriteLine($"Ukulele History: {History}");
    }
}

class Cello : MusicalInstrument
{
    public Cello(string? name, string? description, string? history) : base(name, description, history)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Cello is playing...");
    }

    public override void Show()
    {
        Console.WriteLine($"Cello Name: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Cello Description: {Description}");
    }
    
    public override void Hist()
    {
        Console.WriteLine($"Cello History: {History}");
    }
}

#endregion

class Program
{
    static void Main()
    {
    }
}