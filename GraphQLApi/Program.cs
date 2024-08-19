using GraphQLApi.GraphQL;
using GraphQLApi.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddType<Book>()
    .AddType<Student>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapControllers();
app.MapGraphQL();

app.Run();
