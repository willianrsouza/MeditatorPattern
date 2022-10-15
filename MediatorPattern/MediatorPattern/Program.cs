
using Application.Queries.Clients.DataObjectTransfer;
using Application.Queries.Clients.SearchClient;
using AutoMapper;
using Core.Dto;
using Core.Interfaces.Database;
using Infrastructure.Persistence.DbRepository;
using MediatR;
using Swashbuckle.Swagger;
using System.Reflection;

internal static class Program {

    public static void Main(String[] args)
    {
        
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<IClientRepository, ClientRepository>();
        builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
        builder.Services.AddMediatR(typeof(GetClientQuery).GetTypeInfo().Assembly);

        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<ClienteQueryResult, ClientDto>().ReverseMap();
        });

        IMapper mapper = config.CreateMapper();
        builder.Services.AddSingleton(mapper);

        var app = builder.Build();

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