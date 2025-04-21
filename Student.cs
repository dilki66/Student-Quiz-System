

class Student{

public int Id{get; set;}
public string Name{get; set;}
public int Age{get; set;}

public void DisplayDetails()
{
Console.WriteLine($"Id: {Id} | Name: {Name} | Age: {Age}");
}
}



