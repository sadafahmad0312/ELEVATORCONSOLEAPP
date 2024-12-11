using ELEVATORCONSOLEAPP.Domain.Entities;
public class ElevatorPassengerCapacityTests{


    [Fact]
    public void Elevator_Should_Add_Passengers()
    {
        // Arrange

        var elevator = new PassengerElevator(1, 10);
        var passengersToAdd=5;
        //Action
        elevator.AddPassengers(passengersToAdd);
         //Assert
        Assert.Equal(passengersToAdd, elevator.PassengerCount);
    }

    [Fact]
    public void Elevator_Should_throw_Exception_When_OverLoaded()
    {
        // Arrange

        var elevator = new PassengerElevator(1,10); //Maximum Passenger limit is 10 and e id is 1
        var passengerToAdd=1;
        

        //Action
        elevator.AddPassengers(10);

        
        //Assert
        Assert.Throws<InvalidOperationException>(()=>elevator.AddPassengers(passengerToAdd));

    
    }
}