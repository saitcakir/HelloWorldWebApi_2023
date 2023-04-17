var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddControllers().AddNewtonsoftJson();
var app = builder.Build();

app.UseRouting(); /*add this line and following lines*/
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
//app.MapGet("/", () => "Hello World!"); /*comment out this line*/
app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
