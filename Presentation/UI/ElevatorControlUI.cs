
using ELEVATORCONSOLEAPP.ElevatorApplication.UseCases.ElevatorUserControl;
public class ElevatorControlUI{

  private readonly  ElevatorUserControl _userControl;

  public ElevatorControlUI(ElevatorUserControl userControl){

    _userControl= userControl;

  }

  public void Run(){
   while(true){

    Console.Clear();
    Console.WriteLine("Elevator System: Enter a command");
    Console.WriteLine("1.Choose from the building");
    Console.WriteLine("1. Request Elevator");
    Console.WriteLine("2. Exit");

    var input = Console.ReadLine();

    switch(input){

        case "1": 
        
         Console.Write("Enter Target Floor: ");
         int targetFloor=int.Parse(Console.ReadLine());
         Console.Write("Enter Number Of passengers");
         int passengers=int.Parse(Console.ReadLine());

         _userControl.RequestElevator(targetFloor, passengers);
         break;

        case "2":
         return;

        default:
         Console.WriteLine("InValid Command Try Again");
         break;


    }

    Console.WriteLine("Press Enter To Continue");
    Console.ReadLine();

   }

  }
}