/// <summary>
/// Entry point for the BookGraphQL application.
/// Configures and starts a GraphQL server with query and mutation capabilities for managing books and authors.
/// </summary>

// Create the web application builder
var builder = WebApplication.CreateBuilder(args);

// Configure GraphQL services
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()        // Register Query type for reading operations
    .AddMutationType<Mutation>(); // Register Mutation type for write operations

// Build and configure the application
var app = builder.Build();

// Map GraphQL endpoint
app.MapGraphQL();

// Start the application
app.Run();
