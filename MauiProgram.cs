/*
 * Andrew Zarling
 * 10/9/2022
 * Lab 3 Adding remote database functionality to a .NET MAUI project
 * 
 * Bugs: There seems to be one minor bug in the program, but it doesn't cause any running issues. The program is able to
 * sort the entries by clue, for some reason it doen't do it in real time when an entry gets added. The program
 * needs to be closed and reopened for the entries to appear sorted.
 * 
 * Relflection: I believe I found the bug that needed to be fixed. The edit entry was not appearing. The Grid.Row value
 * needed to be changed to 2 instead of 1 so the third button (edit entry could appear). Also I decided to leave the UI
 * mostly unchanged except have the buttons moved near the clue entry for easy access to the user.
 * 
 */

namespace Lab2Solution;

public static class MauiProgram
{
    public static IBusinessLogic ibl = new BusinessLogic();

    public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}

