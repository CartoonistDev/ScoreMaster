# ScoreMaster Console Application
The ScoreMaster Console Application calculates a total score based on user-provided input and configurable scoring rules. This README provides instructions on how to use the application and what is expected from the user.

## Table of Contents
- Getting Started
- Prerequisites
- Installation
- Usage
- Configuration
- Contributing

## Getting Started
### Prerequisites
Before using the ScoreMaster Console Application, ensure you have the following prerequisites installed:

- .NET SDK (compatible with .NET 7)

## Installation
Clone or download this repository to your local machine.

Open a command prompt or terminal in the project directory.

Build the application by running the following command:

    ```bash    
    dotnet build

Run the application with the following command:

	```bash    
    dotnet run

## Usage
Launch the ScoreMaster Console Application by following the installation steps above.

The application will prompt you to enter an array of integers separated by spaces. For example, you can enter:

	```mathematica    
	Enter an array of integers separated by spaces:
	1 2 3 4 5

Press Enter after entering the values.

The application will calculate the total score based on the provided array and the configured scoring rules and display the result. For example:

	```mathematica    
    Total Score: 11

You can run the application multiple times with different input arrays to calculate scores.

Configuration
The ScoreMaster Console Application allows you to configure scoring rules in the appsettings.json file. By default, the file contains the following configuration:

	```json
	{
	  "ScoringRules": {
		"EvenPoints": 1,
		"OddPoints": 3,
		"EightPoints": 5
	  }
	}
You can adjust the values of EvenPoints, OddPoints, and EightPoints to change the scoring rules. The application will read these values from the configuration file.

Contributing
Contributions to this project are welcome. To contribute, follow these steps:

## Fork the repository.

Create a new branch for your changes.

Make your changes and test them.

Submit a pull request with a clear description of your changes.
