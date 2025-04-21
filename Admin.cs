using System.Runtime.Intrinsics.Arm;
using System.Transactions;

public class Admin{

private List<Student> students = new List<Student>();

public void AddNewStudent()
{
    try{
         Console.WriteLine("Enter student Id");
        int id = Int16.Parse(Console.ReadLine());

        Console.WriteLine("Enter student Id");
        string name = Console.ReadLine();

        Console.WriteLine("Enter student Id");
        int age = Int16.Parse(Console.ReadLine());

        students.Add(new Student{Id = id, Name = name , Age = age});
        Console.WriteLine("Successfully Entered the Student Id");

    }
     catch(Exception e){
        Console.WriteLine(e.Message);
     }
}

public void ViewAllStudent()
{

if(students.Count ==0){
    Console.WriteLine("Students No Found");
    return;
}

Console.WriteLine("Student List");
foreach(var Student in students){
    Student.DisplayDetails();
}
}

public void SearchById(){
    Console.WriteLine("Enter student Id");
    int id = Int16.Parse(Console.ReadLine());

var foundId = students.Find(s => s.Id == id);
if(foundId != null){
    foundId.DisplayDetails();// foundId is single object here
}
 else{
    Console.WriteLine("Student id is not Found");
 }
}


public void Delete(){
    Console.WriteLine("Enter student Id");
    int id = Int16.Parse(Console.ReadLine());

var found = students.Find(s => s.Id == id);
if(found != null){
    students.Remove(found);// foundId is single object here
    Console.WriteLine("Student deleted successfully");
}
 else{
    Console.WriteLine("Student id is not Found");
 }
}
}