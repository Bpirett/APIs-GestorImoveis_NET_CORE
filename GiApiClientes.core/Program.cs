using GiApiClientes.core.Data;
using GiApiClientes.core.Models;
using GiApiClientes.core.ViewModels;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();


app.MapGet("v1/Clientes", (AppDbContext context) =>
{
    var clientes = context.Clientes.ToList();
    return Results.Ok(clientes);

}).Produces<Cliente>();


app.MapPost("v1/Clientes", (AppDbContext context, CreateClienteViewModels model) =>
{
    var cliente = model.MapTo();

    if (!model.IsValid)
        Results.BadRequest(model.Notifications);

    context.Clientes.Add(cliente);
    context.SaveChanges();

    Results.Created($"/v1/Clientes/{cliente.Codigo}", cliente);

});

app.Run();


