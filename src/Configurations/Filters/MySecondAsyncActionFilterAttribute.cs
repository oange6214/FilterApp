using Microsoft.AspNetCore.Mvc.Filters;

namespace src.Configurations.Filters;

public class MySecondAsyncActionFilterAttribute : Attribute, IAsyncActionFilter
{
    private readonly string _callerName;

    public MySecondAsyncActionFilterAttribute (string callerName)
    {
        _callerName = callerName;
    }

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        Console.WriteLine($" {_callerName} - Async Filter : During Execution");
        await next();
        Console.WriteLine($" {_callerName} - Async Filter : After Execution");
    }
}