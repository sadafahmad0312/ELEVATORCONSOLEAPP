using Xunit;
using ELEVATORCONSOLEAPP.Domain.Entities;


public class ElevatorTests{
  
  [Fact]
  public async Task Elevator_Should_Not_Move_While_In_Motion(){

    //Arrange

    var elevator = new PassengerElevator(1,10); //Assume Maximum Passengers is 10
    var targetFloor=5;

    //Simulate the Elevator already Moving(e.g Moving Up or Down)
   elevator.SetState(ElevatorState.MovingUp);// Simulating the elevator motion

    //Assert
   
    var exception = await Assert.ThrowsAsync<InvalidOperationException>(()=>elevator.MoveToFloor(8));
    Assert.Equal("Elevator is already moving", exception.Message);
   
  }
   [Fact]
  public async void Elevator_Should_Move_To_Target_Floor(){

    var elevator = new PassengerElevator(1, 10);
    var targetFloor=5;

    await elevator.MoveToFloor(targetFloor);

    Assert.Equal(targetFloor, elevator.CurrentFloor);

  }

  


}