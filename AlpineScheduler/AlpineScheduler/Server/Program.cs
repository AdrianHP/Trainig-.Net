using Microsoft.AspNetCore.ResponseCompression;
using AlpineScheduler.Server.Hubs;
using AlpineScheduler.Server.Models;
using Microsoft.EntityFrameworkCore;
using AlpineScheduler.Server.Services;
using AlpineScheduler.Shared.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSignalR();
builder.Services.AddDbContext<ApplicationDbContext>(opts => {
    opts.UseSqlServer(
    builder.Configuration["ConnectionStrings:AlpineConnection"]);
});
builder.Services.AddTransient<IJobRepository, JobRepository>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("PolicyName", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});


builder.Services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        new[] { "application/octet-stream" });
});


var app = builder.Build();



// Configure the HTTP request pipeline.

app.UseResponseCompression();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();
app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin  
    .AllowCredentials());

app.MapRazorPages();
app.MapControllers();
app.MapHub<ChatHub>("/chathub");
app.MapHub<APIHub>("/apihub");

app.MapFallbackToFile("index.html");

app.Run();


