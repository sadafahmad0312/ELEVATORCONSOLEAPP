using ELEVATORCONSOLEAPP.Domain.Interfaces;



namespace ELEVATORCONSOLEAPP.Domain.Entities{

    public enum Direction{
        Up,
        Down,
        Stationery
    }

    public enum ElevatorState{
        Stationery, //Elevator is idle
        MovingUp,  // Elevator is moving up
        MovingDown //Elevator is moving down
    }
    

    public class PassengerElevator: IPassengerElevator{


        public int Id { get; private set; }

        public int CurrentFloor { get; internal set; }

        

        public int PassengerCount { get; private set; }

        public int MaxCapacity { get; private   set; }

        public ElevatorState ElevatorState { get; set; }
       
       
        public PassengerElevator(int id, int maxCapacity)
        {
         Id= id;
         MaxCapacity= maxCapacity;
         ElevatorState = ElevatorState.Stationery;
         CurrentFloor=0;
         PassengerCount=0;
        
        }
         internal void SetState(ElevatorState state){
            ElevatorState=state;
          }
        public async Task MoveToFloor(int targetFloor){

            if(targetFloor<0){
                throw new ArgumentException("Invalid Floor");
            } 
            if( ElevatorState!= ElevatorState.Stationery)
            {
             throw new InvalidOperationException("Elevator is already moving");
            }

            if(CurrentFloor==targetFloor){
                Console.WriteLine($"Elevator with {Id} is at the floor{targetFloor}.No Movement required");
                ElevatorState= ElevatorState.Stationery;
                return;
            }

           try
           {
             ElevatorState = targetFloor> CurrentFloor? ElevatorState.MovingUp: ElevatorState.MovingDown;
             
 
             Console.WriteLine($"Elevator with {Id} starting at {CurrentFloor} and Heading {ElevatorState}");
            
             
             await Task.Delay(3000);// Simulating time taken to move the elevator
             CurrentFloor= targetFloor; //setting the currentfloor as targetfloor
            // ElevatorState=ElevatorState.Stationery; //Elevator Stops at target Floor
             
 
             Console.WriteLine($"Elevator with {Id} has reached floor {CurrentFloor} and is now Stationery");
           }
           catch (Exception ex)
           {
            
            Console.WriteLine($"Error Moving to floor {targetFloor}: {ex.Message}");
            throw;
           }

           finally{

            ElevatorState=ElevatorState.Stationery; //Elevator Stops at target Floor

           }

        }

        public void AddPassengers(int passengers){

            if(PassengerCount+passengers> MaxCapacity)
            {
                throw new InvalidOperationException("Passenger Limit is exceeded");
            }
            PassengerCount+=passengers;
            Console.WriteLine($"Passsengers added succesfully: Current Passenger Count {PassengerCount}");

        }

        public void RemovePassengers(int passengers){
            if(PassengerCount<passengers){
                throw new InvalidOperationException("Not Enough Passengers to be removed");
            }

            PassengerCount-= passengers;
            Console.WriteLine($"Passengers removed Succesfully: Current Passenger count {PassengerCount}");

        }

     

    }
}