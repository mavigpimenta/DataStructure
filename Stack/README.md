# Stack

This repository contains solutions to a list of X programming exercises written in C#. Each exercise is implemented in its own class (Ex1 + ExA, ExB, ExV and ExR) and follows a common interface for execution.

## Project Structure

- `Program.cs`: Entry point of the application. It dynamically loads and runs the specified exercise class.
- `Interfaces/IExercise.cs`: Interface that all exercises implement.
- `Exercises/Ex1 to Exercises/ExX`: Individual exercise classes.

## How to run
If you want to run the exercise outside the menu, use the command below in the terminal:
```
dotnet run Ex1
```
Replace `Ex1` depending on the exercise you want to execute.

> When entering floating-point numbers (e.g., double values), please ensure that you use the dot (.) as the decimal separator, as required in the American format (e.g., 12.5 instead of 12,5).