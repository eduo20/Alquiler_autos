# Project Overview: Alquiler de Autos

This project is a Windows Forms application built with .NET Framework 4.7.2, designed to manage car rental operations. It handles clients, vehicles, and rental transactions, providing reporting capabilities and simple data persistence through local text files.

## Core Architecture

The application follows a standard Windows Forms structure where `Form1.cs` serves as the primary controller and user interface. Data is modeled using dedicated classes and managed in-memory using `List<T>` collections.

### Data Models
- **Clientes.cs**: Stores client information (NIT, Name, Address).
- **Vehiculos.cs**: Represents available cars (License plate, Brand, Model, Price per kilometer).
- **Alquiler.cs**: Records rental transactions (Client NIT, Vehicle plate, Rental/Return dates, Kilometers traveled).
- **Reporte.cs**: A DTO (Data Transfer Object) used to aggregate data from the three entities above for display and cost calculation.

## Building and Running

### Prerequisites
- .NET Framework 4.7.2 SDK.
- Visual Studio 2017 or later (recommended).

### Key Commands
- **Build**: Use `msbuild Alquiler_autos.csproj` or build through Visual Studio.
- **Run**: Execute the generated `Alquiler_autos.exe` from the `bin/Debug` or `bin/Release` folder.

## Data Persistence

The system uses flat text files for storage. Note that the file paths are currently hardcoded to specific local directories in `Form1.cs`:
- `Clientes.txt`
- `vehiculos.txt`
- `alquileres.txt`

## Development Conventions

- **Language**: Business logic, variable names, and UI elements are primarily in Spanish (e.g., `LeerVehiculo`, `Placa`, `Alquiler`).
- **Data Access**: Simple `StreamReader` and `StreamWriter` implementations are used to load and save data line-by-line.
- **UI Interaction**: Standard WinForms event handlers (e.g., `button_Click`, `Form_Load`).
- **Logic**: Reporting logic is implemented using nested loops to join related entities based on keys like `Nit` and `Placa`.

## TODO / Improvement Areas
- [ ] Refactor hardcoded file paths to use relative paths or configuration settings.
- [ ] Implement error handling for file I/O and data conversion (e.g., `try-catch` blocks).
- [ ] Consider using LINQ for more efficient data joining in the report generation phase.
- [ ] Add validation for user input in the forms.
