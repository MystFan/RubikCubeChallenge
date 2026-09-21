# Rubik's Cube Challenge

A C# .NET implementation of a 3x3 Rubik's Cube simulator with interactive console interface.

## Project Structure

The solution consists of three projects:

- **RubikCubeChallenge.Cube** - Core library containing the cube model and printing logic
- **RubikCubeChallenge.Console** - Interactive console application for manipulating the cube
- **RubikCubeChallenge.Tests** - Unit tests for cube operations

## Features

- Full 3x3 Rubik's Cube simulation
- Support for all standard cube rotations:
  - **U, D** - Up and Down face rotations
  - **F, B** - Front and Back face rotations
  - **L, R** - Left and Right face rotations
  - **U', D', F', B', L', R'** - Counterclockwise rotations
- Interactive console interface
- Cube state visualization
- Reset functionality

## Getting Started

### Prerequisites

- .NET 10.0 or later

### Building

```bash
dotnet build
```

### Running the Console Application

```bash
dotnet run --project RubikCubeChallenge.Console
```

### Running Tests

```bash
dotnet test
```

## Usage

Once the console application is running:

1. The current cube state is displayed
2. Enter a command to rotate a face (e.g., `U`, `R'`, `F`)
3. Enter `reset` to return the cube to its initial solved state
4. Enter `exit` to quit the application

### Supported Commands

| Command | Action |
|---------|--------|
| U | Rotate Up face clockwise |
| U' | Rotate Up face counterclockwise |
| D | Rotate Down face clockwise |
| D' | Rotate Down face counterclockwise |
| F | Rotate Front face clockwise |
| F' | Rotate Front face counterclockwise |
| B | Rotate Back face clockwise |
| B' | Rotate Back face counterclockwise |
| L | Rotate Left face clockwise |
| L' | Rotate Left face counterclockwise |
| R | Rotate Right face clockwise |
| R' | Rotate Right face counterclockwise |
| RESET | Reset cube to solved state |
| EXIT | Exit the application |

## Architecture

### Core Components

- **RubiksCube** - Main cube model that handles state and rotation logic
- **ICubePrinter** - Interface for cube visualization
- **CubeConsolePrinter** - Console-based cube renderer
- **IPrintableCube** - Interface for cube printing capabilities

## License

This project is provided as-is for educational purposes.
