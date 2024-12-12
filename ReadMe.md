### **Elevator Simulation Application**

# Overview
This Elevator Simulation Application is a console-based program that simulates the behavior of an elevator system in a building. It includes functionality for requesting elevators, dispatching the nearest available elevator, handling passenger limits, 

The application is designed with a modular architecture, making it maintainable and extensible. It incorporates clean coding principles and unit tests to ensure reliability and scalability.

# Features

1. Building Configuration:

2. Define the number of floors and elevators in the building.

3. Elevator Simulation:

4. Request elevators to a specific floor.

5. Dispatch the nearest available elevator.

6. Handle passenger limits with the option to remove passengers or request another elevator.

7. Passenger Management:

8. Add or remove passengers from an elevator.

9. Display appropriate error messages if passenger limits are exceeded.

10. Elevator State Management:

11. Track the current floor of each elevator.

12. Update the elevator’s state (Moving Up, Moving Down, Stationery).

13. Prevent elevators from moving if already at the requested floor.

### Error Handling:

Gracefully handle invalid requests (e.g., floor out of range, no available elevators).

### Test Coverage:

Comprehensive unit tests to validate core functionalities such as requesting the nearest elevator, passenger management, and error scenarios.

### Prerequisites

Programming Language: C#

Framework: .NET Core

### Dependencies:

Moq (for unit testing)

xUnit (for testing framework)

### Setup Instructions

1. Clone the Repository:

  git clone https://github.com/sadafahmad0312/ELEVATORCONSOLEAPP.git
  cd ELEVATORCONSOLEAPP

2. Build the Application:

   cd ElevatorApplication 
   dotnet build

3. Run the Application:
    
    cd ElevatorApplication
    dotnet run

4. Run Unit Tests:

    cd ElevatorApp.Tests
    dotnet test

### Usage

Console Commands

Request an Elevator:

Enter the target floor.

Specify the number of passengers.

The system will dispatch the nearest available elevator.

Exit Application:

Enter 2 to exit the program.

### Project Structure
Domain: Contains the core business logic and interfaces (e.g., IBuilding, IElevator, IPassengerElevator).

Infrastructure: Implements repository classes and interaction logic.

ElevatorApplication: Contains the project file

UI: Handles console-based user interactions.

Test Project: Includes unit tests for critical functionality us

# License

This project is licensed under the MIT License. See the LICENSE file for more details.

# Contact

For questions or feedback, please contact:

Email:ahmadsadaf0312@gmail.com

GitHub: sadafahmad0312