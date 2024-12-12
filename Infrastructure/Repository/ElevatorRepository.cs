using ELEVATORCONSOLEAPP.Domain.Interfaces;

namespace ELEVATORCONSOLEAPP.Infrastructure.Repository{


public class ElevatorRepository:IElevatorDispatcher{


    private readonly IBuilding _building;

    public ElevatorRepository(IBuilding building){

        _building= building ?? throw new ArgumentNullException(nameof(building));

    }

    public IPassengerElevator GetNearestElevator(int targetFloor){

            //Logic For nearest Elevator

            try{

            if(targetFloor<0||targetFloor>+_building.NumberOfFloors) throw new ArgumentOutOfRangeException(nameof(targetFloor), "Target Floor is out of range");
              var nearestElevator= _building.Elevators.OrderBy(e => Math.Abs(e.CurrentFloor - targetFloor)).FirstOrDefault();
              if(nearestElevator==null) throw new InvalidOperationException("No elevators available");
              return nearestElevator;
            }
            catch(Exception ex){

                Console.WriteLine($"Error while getting nearest elevator: {ex.Message}");
                throw;

            }
           


    }

    public  void DispatchElevator(IPassengerElevator elevator, int targetFloor){
         try
         {
            elevator.MoveToFloor(targetFloor);
         }
         catch (Exception ex)
         {
             Console.WriteLine($"error while dispatching elevator: {ex.Message}");
            throw;
         }
    }

}
}