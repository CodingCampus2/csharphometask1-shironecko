# Task 1

## Prerequisites:
Read Chapter 5 of .NET Book Zero and https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated

## Description:
There is a city in Programland with the name [task.City.Name] and [task.City.Population] people living in it.
There are [task.City.SickPercentage] people that are sick with a deadly virus with the name [task.Virus.Name].
The probability of death is [task.Virus.KillProbability].

## Goal:
Compose a string that tells how many people were killed by the virus in the city.

## Example input: 
[task.City.Name] = "Virtualiev"  
[task.City.Population] = 1400  
[task.City.SickPercentage] = 0.3  
[task.Virus.Name] = "Hlomanda"  
[task.Virus.KillProbability] = 0.2  

## Example output:
"There are 420 people sick with Hlomanda in the city of Virtualiev, 84 of which died"

## Task clarifications:
Input variables that contains only numbers should be parsed to _floats_.  
Use _floats_ in all your floating-point calculations.  
Numbers, if needed, should be rounded by casting to int. (For this task only).
