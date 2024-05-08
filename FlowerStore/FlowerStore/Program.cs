using MediatR;
using Microsoft.EntityFrameworkCore;
using FlowerStore.Core.IRepository;
using FlowerStore.Infrastructure.Repository;
using FlowerStore.Infrastructure.Persistence;
using FlowerStore.Infrastructure.Persistence.Repository;
using FlowerStore.Application.Commands;
using FlowerStore.Application.Commands.CreateAddress;
using FlowerStore.Application.Queries.GetUser;
using FlowerStore.Application.Queries.GetCartProducts;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var connectionString = builder.Configuration.GetConnectionString("mySampleDatabase");

        builder.Services.AddDbContext<FlowerStoreDbContext>(options => options.UseMySQL(connectionString));

        builder.Services.AddScoped<IFlower, FlowerRepository>();
        builder.Services.AddScoped<IUser, UserRepository>();
        builder.Services.AddScoped<IAddress, AddressRepository>();
        builder.Services.AddScoped<ICart, CartRepository>();

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddMediatR(typeof(Program));
        builder.Services.AddMediatR(typeof(CreateUserCommand));
        builder.Services.AddMediatR(typeof(CreateAddressCommand));
        builder.Services.AddMediatR(typeof(LoginQuery));
        builder.Services.AddMediatR(typeof(GetCartProductsQuery));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}