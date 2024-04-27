using Microsoft.AspNetCore.Mvc.Filters;

namespace src.Configurations.Filters;

public class MyActionFilterAttribute : Attribute, IActionFilter
{
    private readonly string _callerName;

    public MyActionFilterAttribute (string callerName)
    {
        _callerName = callerName;
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine($" {_callerName} - This Filter Executed on: OnActionExecuted");
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine($" {_callerName} - This Filter Executed on: OnActionExecuting");
    }
}
