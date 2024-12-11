

namespace ELEVATORCONSOLEAPP.Domain.Interfaces
{
    public interface IPassengerElevator: IElevator{
         
         int PassengerCount { get;  }
         void AddPassengers(int passengers);//Moved  to Ipassenger elevator Interface
         void RemovePassengers(int passengers);// Moved  to Ipassenger Elevator

    }

}