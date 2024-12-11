namespace ELEVATORCONSOLEAPP.Domain.Interfaces{
public interface IBuilding{

    public string BuildingName { get;}
    public int NumberOfElevators { get;}

    public int NumberOfFloors { get; }

    List<IPassengerElevator> Elevators {get;}

   



}
}