
namespace ELEVATORCONSOLEAPP.ElevatorApplication.UseCases.ElevatorUserControl{


public class ElevatorUserControl{

    private IElevatorDispatcher  _elevatorDispatcher;

    public ElevatorUserControl(IElevatorDispatcher elevatorDispatcher){

        _elevatorDispatcher=elevatorDispatcher;


    }

    public void RequestElevator(int targetFloor, int Passengers){

       try
       {
         var elevator = _elevatorDispatcher.GetNearestElevator(targetFloor);
 
         if(elevator !=null){
           _elevatorDispatcher.DispatchElevator(elevator,targetFloor);
           elevator.AddPassengers(Passengers);
         }

          else{
            Console.WriteLine("No available elevators");
        }
       }
       catch (InvalidOperationException ex)
       {
        Console.WriteLine($"Error: {ex.Message}");
        
       }
       catch (Exception ex)
       {
        Console.WriteLine($"An unexpected error occured: {ex.Message}");
        
       }

       
    }
}

}