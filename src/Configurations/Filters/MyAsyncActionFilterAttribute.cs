using Microsoft.AspNetCore.Mvc.Filters;

namespace src.Configurations.Filters;

public class MyAsyncActionFilterAttribute : Attribute, IAsyncActionFilter, IOrderedFilter
{
    private readonly string _callerName;

    public int Order { get; set;} 

    public MyAsyncActionFilterAttribute (string callerName, int order)
    {
        _callerName = callerName;
        Order = order;
    }

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        Console.WriteLine($" {_callerName} - Async Filter : During Execution");
        await next();
        Console.WriteLine($" {_callerName} - Async Filter : After Execution");
    }
}