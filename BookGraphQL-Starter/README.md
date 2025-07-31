# BookGraphQL Starter - Workshop Boilerplate

## Overview

This is the **starter/boilerplate project** for the **Mindbody GraphQL Workshop** held at the **2025 PDE India Offsite in Goa**. 

This folder contains the basic project structure with TODO comments to guide you through building a GraphQL API step by step during the workshop.

## Workshop Goals

By the end of this workshop, you will have built a complete GraphQL API that can:
- Query books and authors from a library
- Add new books via mutations
- Work with nullable properties
- Implement proper GraphQL schema design

## Getting Started

### Prerequisites
- .NET 7.0 SDK or later
- Visual Studio Code or Visual Studio

### Setup Instructions

1. **Navigate to the starter project:**
   ```bash
   cd Starter
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

3. **Start following the workshop steps!**

## Workshop Steps Overview

### Step 1: Define Data Models
- [ ] Complete `Author.cs` - Create Author record
- [ ] Complete `Book.cs` - Create Book record with nullable description
- [ ] Complete `Library.cs` - Create static runtime cache

### Step 2: Implement GraphQL Queries
- [ ] Complete `Query.cs`
- [ ] Implement `GetBooks()` method
- [ ] Implement `GetAuthors()` method

### Step 3: Implement GraphQL Mutations
- [ ] Complete `Mutation.cs`
- [ ] Implement `AddBook()` method

### Step 4: Configure GraphQL Server
- [ ] Complete `Program.cs`
- [ ] Configure GraphQL services
- [ ] Register Query and Mutation types
- [ ] Map GraphQL endpoint

### Step 5: Test Your API
- [ ] Build and run the application
- [ ] Access GraphQL Playground
- [ ] Test queries and mutations

## File Structure

```
Starter/
├── Author.cs              # TODO: Define Author record
├── Book.cs                # TODO: Define Book record  
├── Library.cs             # TODO: Create static data cache
├── Query.cs               # TODO: Implement GraphQL queries
├── Mutation.cs            # TODO: Implement GraphQL mutations
├── Program.cs             # TODO: Configure GraphQL server
├── BookGraphQL-Starter.csproj  # Project file (complete)
└── README.md              # This file
```

## Hints and Tips

### Data Models
- Use C# `record` types for immutable data
- Author: `Id` (int), `Name` (string)
- Book: `Id` (int), `Title` (string), `Author` (Author), `Description` (string?)

### Library Cache
- Use a static class with a static `List<Book>` property
- Initialize with 2-3 sample books

### GraphQL Setup
- Use HotChocolate framework
- Register types with `.AddQueryType<Query>()` and `.AddMutationType<Mutation>()`
- Map endpoint with `app.MapGraphQL()`

### Testing
- Access GraphQL Playground at `/graphql` endpoint
- Start with simple queries before trying mutations

## Sample Data to Use

```csharp
new Book(1, "Clean Code", new Author(1, "Robert C. Martin"), "A guide to writing clean code")
new Book(2, "The Pragmatic Programmer", new Author(2, "Andrew Hunt"), "Your journey to mastery")
```

## Workshop Resources

- **Final Implementation**: See the parent folder for the complete solution
- **Documentation**: Each file contains TODO comments with specific guidance
- **GraphQL Playground**: Available once you complete Program.cs setup

## Need Help?

- Check the complete implementation in the parent `BookGraphQL` folder
- Ask your workshop instructor
- Review the TODO comments in each file for specific guidance

---

**Event:** 2025 PDE India Offsite - Mindbody GraphQL Workshop  
**Location:** Goa, India

*Happy coding! 🚀*
