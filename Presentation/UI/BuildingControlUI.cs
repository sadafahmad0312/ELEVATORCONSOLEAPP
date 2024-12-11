
using ELEVATORCONSOLEAPP.Domain.Interfaces;

namespace ELEVATORCONSOLEAPP.Presentation.UI{
public class BuildingControlUI{

    private List<IBuilding> _buildings;

    public BuildingControlUI()
    {

        _buildings= new List<IBuilding>{
              new Building("Sandton City", 2,5),
              new Building("BowMans", 4,8),
              new Building("Sandton Convention Center", 4,6)
        };



    }

    public  IBuilding SelectBuilding(){

        Console.WriteLine("Available Buildings:");
        for(int i=0; i<_buildings.Count; i++){
            Console.WriteLine($"{i+1}, {_buildings[i].BuildingName}");
        }

        while(true){
            Console.WriteLine("Select a building by entering the corresponding number");
            if(int.TryParse(Console.ReadLine(), out int buildingChoice) && buildingChoice>=1 && buildingChoice<=_buildings.Count)
            {
                var selectedBuilding = _buildings[buildingChoice-1];
                Console.WriteLine($"You selected {selectedBuilding.BuildingName}");
                return selectedBuilding;
            }else{
                Console.WriteLine("Invalid Selection Please Select again");
            }
        }
    } 


}
}
