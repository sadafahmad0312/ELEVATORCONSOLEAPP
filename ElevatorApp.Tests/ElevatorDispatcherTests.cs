using ELEVATORCONSOLEAPP.Domain.Interfaces;
using Moq;
using ELEVATORCONSOLEAPP.ElevatorApplication.UseCases.ElevatorUserControl;
using ELEVATORCONSOLEAPP.Domain.Entities;

public class ElevatorDispatcherTests{


    private readonly Mock<IElevatorDispatcher> _mockElevatorDispatcher;
     private readonly ElevatorUserControl _userControl;

     public ElevatorDispatcherTests(){

        //Mocking the Elevator Dispatcher
        _mockElevatorDispatcher= new Mock<IElevatorDispatcher>();

        //Creating a sample building with elevators
        var building = new Building("Test Building",5, 10);
        _userControl= new ElevatorUserControl(_mockElevatorDispatcher.Object);
     }

    [Fact]
    public void Dispatch_Nearest_Elevator()
    {
        // Arrange
        var targetFloor= 5;

        var passengers=4;

        //creating multiple elevators with different current floor positions
        var elevatorOne = new PassengerElevator(1,10) {CurrentFloor=3};
        var elevatorTwo = new PassengerElevator(2,10) {CurrentFloor=8};
        var elevatorThree = new PassengerElevator(3,10) {CurrentFloor=1};

        //Mock GetNearestAvailbleElevator to return the closest elevator
        //This setup is for mocking the behaviour of selecting the nearest elevator

        _mockElevatorDispatcher.Setup(x=>x.GetNearestElevator(targetFloor)).Returns(elevatorOne);


        //Act

        _userControl.RequestElevator(targetFloor, passengers);

        //Assert
        //Verifying the GetNearestAvailableElevator was called once and the correct elevator was selected
        _mockElevatorDispatcher.Verify(x=>x.GetNearestElevator(targetFloor), Times.Once);
        _mockElevatorDispatcher.Verify(x=>x.DispatchElevator(elevatorOne, targetFloor), Times.Once);

        //Verify if other elevators were not selected

        _mockElevatorDispatcher.Verify(x=>x.DispatchElevator(elevatorTwo, targetFloor), Times.Never);
        _mockElevatorDispatcher.Verify(x=>x.DispatchElevator(elevatorThree, targetFloor), Times.Never);

       




    
     
    }
}