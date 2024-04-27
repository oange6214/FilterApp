using Microsoft.AspNetCore.Mvc.Filters;

namespace src.Configurations.Filters;

public class MyFilter : IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine($"This Filter Executed on: OnActionExecuted");
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine($"This Filter Executed on: OnActionExecuting");
    }
}
