using CommitExplorerAplications.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<CommitExplorerService>(); //Se registra el servicio como dependencia del proyecto

#region Cors Configurations
/*
 ---------------------------Configuracion de Cors para Angular------------------------------------------
 */

//Nombre de la politica de Cors
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

//Aplicacion de Permisos
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          //Indicamos que permitimos peticiones de todos los origenes y a todos los metodos
                          policy.AllowAnyOrigin().
                          AllowAnyHeader()
                          .AllowAnyMethod();

                      });
});


#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseCors(MyAllowSpecificOrigins);  // Uso de la politica de Cors Creada

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
