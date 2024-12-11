using System;
using ELEVATORCONSOLEAPP.Domain.Entities;
using ELEVATORCONSOLEAPP.Domain.Interfaces;
using ELEVATORCONSOLEAPP.Infrastructure.Repository;
using ELEVATORCONSOLEAPP.ElevatorApplication.UseCases.ElevatorUserControl;
namespace ELEVATORCONSOLEAPP.Presentation.UI
{
    public class Program
    {
        // Entry point of the application
        public static void  Main(string[] args)
        {
            Console.WriteLine("Welcome to the Elevator Simulation Application!");

            var buildingControlUI= new BuildingControlUI();
            var selectedBuilding = buildingControlUI.SelectBuilding();

           

           
         

            var elevatorRepository = new ElevatorRepository(selectedBuilding);
            var elevatorUserControl = new ElevatorUserControl(elevatorRepository);
            var elevatorControlUI = new ElevatorControlUI(elevatorUserControl);

            elevatorControlUI.Run();
          
        }
    }
}