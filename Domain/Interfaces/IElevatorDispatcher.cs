using ELEVATORCONSOLEAPP.Domain.Interfaces;
public interface IElevatorDispatcher{

    IPassengerElevator GetNearestElevator(int targetFloor);
    void DispatchElevator(IPassengerElevator elevator, int targetFloor);
}