# IslandStranded
Choose your own adventure text based game

The game is up and running. 

## Requirements

### Packages

1. [EntityFrameworkCore SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/)
2. [EntityFrameworkCore Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/7.0.0-preview.7.22376.2)
3. [Spectre.Console](https://www.nuget.org/packages/Spectre.Console/0.44.1-preview.0.42)

### Get Started Links

1. [EntityFrameworkCore SqlServer](https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=visual-studio)
2. [Spectre.Console](https://spectreconsole.net/quick-start)

## Steps moving forward

1. We need to add more story events.
2. Save the users progress to be able to use the continue feature. 
  - The storyevent tracker is already hardcoded into the User object as 0.
4. The ability to exit or go back to welcome view when creating an account or logging in.
5. Erase the intial log in text when the game starts.
6. Implement Unit Tests
