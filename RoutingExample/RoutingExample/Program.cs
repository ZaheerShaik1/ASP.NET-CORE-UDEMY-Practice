using Microsoft.AspNetCore.Authentication;
using RoutingExample.CustomeConstraints;
using System.ComponentModel.Design.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRouting(options =>
{
    options.ConstraintMap.Add("months", typeof(MonthCustomConstraint));
});
var app = builder.Build();


app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.Map("files/{filename}.{extension}", async
        context =>
    {
        string? filename = Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
        await context.Response.WriteAsync($"In the file {filename} . {extension}");
    });

    endpoints.Map("employee/profile/{employeeid}", async
        context =>
    {
        int empid = Convert.ToInt32(context.Request.RouteValues["employeeid"]);
        await context.Response.WriteAsync($" The employee id is {empid}");
    });

    // Eg : product/details/{id}
    //
    //default parameter
    endpoints.Map("product/details/{id=1}", async
        context =>
    {
        int product_id = Convert.ToInt32(context.Request.RouteValues["id"]);
        await context.Response.WriteAsync($"The id of the product is : {product_id}");
    });


    //optional parameters
    endpoints.Map("school/student/{name?}", async
        context =>
    {
        if (context.Request.RouteValues.ContainsKey("name"))
        {
            string? name = Convert.ToString(context.Request.RouteValues["name"]);

            await context.Response.WriteAsync($"student name is {name}");
        }

        else
        {
            await context.Response.WriteAsync("student name is  not provided");
        }

    });

    //constraints

    endpoints.Map("dailyDigestreport/{reportdate:datetime}", async
        context =>
    {
         DateTime reportdate = Convert.ToDateTime(context.Request.RouteValues["reportdate"]);
        await context.Response.WriteAsync($"In daily digest report {reportdate}");
    });

    //guid

    endpoints.Map("cities/{cityid:guid}", async
        context =>
    {
        Guid cityId = Guid.Parse(Convert.ToString(context.Request.RouteValues["cityId"]));

        await context.Response.WriteAsync($"city information - {cityId}");

    });

    //sales-report
    endpoints.Map("salesreport/{year:int:min(1900)}/{month:regex(^(apr|nov|jun|jul)$)}", async
        context =>
    {
        int year = Convert.ToInt32(context.Request.RouteValues["year"]);
        string? month = Convert.ToString(context.Request.RouteValues["month"]);

        await context.Response.WriteAsync($"sales report -{year}-{month}");
    });
 });



app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
}); 


app.Run();
