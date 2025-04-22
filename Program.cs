class Program{

static void Main (string[] args)
{
 Admin admin = new Admin();
  bool running = true;

  while(true)
  {
    
    Console.WriteLine("~ ~ Student Quiz ~ ~");
    Console.WriteLine(" 1. Add Student");
    Console.WriteLine(" 2. View all Student");
    Console.WriteLine(" 3. Delete Student");
    Console.WriteLine(" 4. Search Student");
    Console.WriteLine(" 5. Exit");
    Console.WriteLine();
    Console.Write("Choose the option 1-5 : ");
    
    int choice = Int16.Parse(Console.ReadLine());
    
    switch(choice){
    case 1:
    admin.AddNewStudent();
    break;

    case 2:
    admin.ViewAllStudent();
    break;

    case 3:
    admin.Delete();
    break;

    case 4:
    admin.SearchById();
    break;

    case 5:
    running= false;
    Console.WriteLine("You have decided to Exit...!!");
    break;

    default:
    Console.WriteLine("Please choose correct option..!");
    break;

    }

  }



}




}
