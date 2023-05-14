using TasksOrderVert1000.Controller;

namespace TasksOrderVert1000;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            using (var _context = new Context.Context())
            {
                
                var _dispatcher = new Dispatcher(_context);
                switch (_dispatcher.Menu())
                {
                    case 1:                   
                        _dispatcher.CreateNewTask();
                        break;
                    case 2:
                        _dispatcher.UpdateTask();
                        break;
                    case 3:
                        _dispatcher.DeleteTask();
                        break;
                    case 4:
                        _dispatcher.ListAllTasks();
                        break;
                    case 5:
                        _dispatcher.DisplayTaskById();
                        break;
                    case 6:
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Error Input, Try again");
                        break;
                }
            }
        }
    }
}