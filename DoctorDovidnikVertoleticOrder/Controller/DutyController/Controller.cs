using TasksOrderVert1000.Model;
using TasksOrderVert1000.Repository;

namespace TasksOrderVert1000.Controller.DutyController;

public class Controller
{
    private View.View _view;
    private DutyRepository _dutyRepository;
    public Controller(View.View view, DutyRepository dutyRepository)
    {
        _view = view;
        _dutyRepository = dutyRepository;
    }

    public IEnumerable<Tip> SortedByPriority(IEnumerable<Tip> inList)
    {
        return inList.OrderBy(d => d.Major);
    }

    public IEnumerable<Tip> SortedByDate(IEnumerable<Tip> inList)
    {
        return inList.OrderBy(d => d.Date);
    }
    
    

    public string ValidateNameInput()
    {
        string input = _view.WriteNewTaskName();
        if (input.Length <= 30)
        {
            return input;
        }
        ValidateNameInput();
        return "";
    }

    public string ValidateDescriptionInput()
    {
        string input = _view.WriteNewTaskDescription();
        if (input.Length <= 300)
        {
            return input;
        }
        ValidateDescriptionInput();
        return "";
    }

    public int ValidatePriorityView()
    {
        int input = _view.ChooseTasksPriority();
        for (int i = 0; i <= 10; i++)
        {
            if (input == i)
            {
                return input;
            }
        }

        ValidatePriorityView();
        return -1;
    }

    public int ValidateId(int id)
    {
        var result = id > 0 ? id : -404;
        return result;
    }

    public int ValidateListMenu()
    {
        int input = _view.SuggestSorting();
        for (int i = 1; i <= 3; i++)
        {
            if (input == i)
            {
                return input;
            }
        }

        ValidateListMenu();
        return -1;
    }
    
}