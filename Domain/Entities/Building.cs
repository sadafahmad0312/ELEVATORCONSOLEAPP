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

        // if(string.IsNullOrWhiteSpace(BuildingName)) throw new ArgumentException("Building Name Cannot be Empty");
        // if(NumberOfFloors<=0) throw new ArgumentException("Number of floors must be grater than zero");
        // if(NumberOfElevators<=0) throw new ArgumentException("Number of elevators must be greater than Zero");
        
        BuildingName = name;
        NumberOfElevators= numberOfElevators;
        NumberOfFloors= numberOfFloors;

        //Initialize Elevators
        Elevators = new List<IPassengerElevator>();
        for(int i=0; i<=NumberOfElevators; i++){
            Elevators.Add(new PassengerElevator(i, 10));
        }
    }
}