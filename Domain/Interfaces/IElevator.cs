using ELEVATORCONSOLEAPP.Domain.Entities;
namespace ELEVATORCONSOLEAPP.Domain.Interfaces
{
    public interface IElevator{
         int CurrentFloor { get;  }

         Task MoveToFloor(int targetFloor);
         
    }


}