using TasksOrderVert1000.Model;

namespace TasksOrderVert1000.View;

public class View
{
    public int DisplayMainMenu()
    {
        Console.WriteLine("\nHello>. .<, Tip manager for doctors.\n" +
                          "Choose action which u want to do:\n" +
                          "1-Create new Tip\n" +
                          "2-Update existing Tip\n" +
                          "3-Delete existing Tip\n" +
                          "4-Check all Tips\n" +
                          "5-Display tip by id\n" +
                          "6-Exit");
        var choosed = Console.ReadLine();
        int ch;
        bool check = false;
        int.TryParse(choosed, out ch);
        return ch;
    }

    public int ChooseTasksId()
    {
        Console.WriteLine("Please enter tip`s Id");
        var choosed = Console.ReadLine();
        int ch;
        int.TryParse(choosed, out ch);
        return ch;
    }

    public string WriteNewTaskName()
    {
        Console.WriteLine("Please enter tip`s Name");
        var choosed = Console.ReadLine();
        return choosed;
    }

    public string WriteNewTaskDescription()
    {
        Console.WriteLine("Please enter tip`s Description");
        var choosed = Console.ReadLine();
        return choosed;
    }

    public int ChooseTasksPriority()
    {
        {
            Console.WriteLine("Please choose ur doctors`s major (0-10)");
            var choosed = Console.ReadLine();
            int ch;
            bool check = false;
            int.TryParse(choosed, out ch);
            return ch;
        }
    }

    public void DisplayTask(Tip tip)
    {
        Console.WriteLine($"\n//////////////////////////////////////////////\n " +
                          $"Tip ID - {tip.TipId}\n" +
                          $"Tip Name - {tip.TipName}\n" +
                          $"Tip Description - {tip.Description}\n" +
                          $"Tip Date - {tip.Date}\n" +
                          $"Tip Major - {tip.Major}\n//////////////////////////////////////////////\n");
    }

    public int SuggestSorting()
    {
        Console.WriteLine("\nU also can sort by date and major as u wish:\n" +
                          "1- Sort by Date\n" +
                          "2- Sort by Major\n" +
                          "3- Back to the menu\n");
        var choosed = Console.ReadLine();
        int ch;
        int.TryParse(choosed, out ch);
        return ch;
    }
    
}