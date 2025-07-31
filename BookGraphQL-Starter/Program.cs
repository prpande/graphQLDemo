// TODO: Set up the GraphQL server
// Steps:
// 1. Create WebApplication builder
// 2. Add GraphQL services with AddGraphQLServer()
// 3. Register Query and Mutation types
// 4. Build the app
// 5. Map GraphQL endpoint
// 6. Run the application

var builder = WebApplication.CreateBuilder(args);

// TODO: Configure GraphQL services here

var app = builder.Build();

// TODO: Map GraphQL endpoint here

app.Run();
