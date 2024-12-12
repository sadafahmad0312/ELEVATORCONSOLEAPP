using ELEVATORCONSOLEAPP.Domain.Entities;
using ELEVATORCONSOLEAPP.Domain.Interfaces;

public class Building : IBuilding
{
    public string BuildingName{get;} 

    public int NumberOfElevators{get;}

    public int NumberOfFloors{get;} 

    public List<IPassengerElevator> Elevators {get; set;} 

    public  Building(string name, int numberOfElevators, int numberOfFloors)
    {
        
        BuildingName = name;
        NumberOfElevators= numberOfElevators;
        NumberOfFloors= numberOfFloors;

        //Initialize Elevators
        Elevators = new List<IPassengerElevator>();
        for(int i=0; i<=NumberOfElevators; i++){
            Elevators.Add(new PassengerElevator(i+1, 10));
        }
    }
}