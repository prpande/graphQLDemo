# GraphQL Demo - Mindbody Workshop

## Overview

This repository contains demo projects for the **Mindbody GraphQL Workshop** held at the **2025 PDE India Offsite in Goa**. The projects demonstrate the fundamentals of building a GraphQL API using ASP.NET Core and HotChocolate.

## Repository Structure

```
graphQLDemo/
├── BookGraphQL/           # Complete implementation (finished example)
├── BookGraphQL-Starter/   # Workshop starter project with TODOs
├── .gitignore            # Git ignore file for C# projects
└── README.md             # This file
```

## Projects

### 1. BookGraphQL (Complete Implementation)

The **BookGraphQL** folder contains the complete, working implementation of a GraphQL library management system. This serves as the reference solution and demonstrates all the concepts covered in the workshop.

**Features:**
- Query books and authors
- Add new books via mutations
- Manage runtime cache of book data
- Handle nullable properties properly
- Complete GraphQL schema implementation

### 2. BookGraphQL-Starter (Workshop Boilerplate)

The **BookGraphQL-Starter** folder contains the starter project with TODO comments to guide you through building the GraphQL API step by step during the workshop.

**Workshop Goals:**
- Build a complete GraphQL API from scratch
- Learn GraphQL schema design principles
- Implement queries and mutations
- Work with nullable properties
- Understand GraphQL best practices

## Technologies Used

- **.NET 8.0** - Core framework
- **ASP.NET Core** - Web framework
- **HotChocolate** - GraphQL server implementation
- **C# Records** - For immutable data models

## Getting Started

### Prerequisites
- .NET 8.0 SDK or later
- Visual Studio Code or Visual Studio

### Quick Start (Complete Implementation)

1. **Navigate to the complete project:**
   ```bash
   cd BookGraphQL
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

3. **Build and run:**
   ```bash
   dotnet build
   dotnet run
   ```

4. **Access GraphQL Playground:**
   Open your browser and navigate to `https://localhost:5001/graphql`

### Workshop Start (Starter Project)

1. **Navigate to the starter project:**
   ```bash
   cd BookGraphQL-Starter
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

3. **Follow the workshop steps!**
   - Complete the TODO items in each file
   - Reference the complete implementation if needed

## Data Models

### Book
- **Id** (int) - Unique identifier
- **Title** (string) - Book title
- **Author** (Author) - Author information
- **Description** (string?) - Optional book description

### Author
- **Id** (int) - Unique identifier
- **Name** (string) - Author name

### Library
- Static runtime cache for storing book data
- Pre-loaded with sample books

## Sample GraphQL Operations

### Query all books:
```graphql
query {
  books {
    id
    title
    description
    author {
      id
      name
    }
  }
}
```

### Query a specific book by ID:
```graphql
query {
  book(id: 1) {
    id
    title
    description
    author {
      id
      name
    }
  }
}
```

### Query all authors:
```graphql
query {
  authors {
    id
    name
  }
}
```

### Add a new book:
```graphql
mutation {
  addBook(
    title: "Design Patterns"
    authorName: "Gang of Four"
    description: "Elements of Reusable Object-Oriented Software"
  ) {
    id
    title
    description
    author {
      id
      name
    }
  }
}
```

### Add a book without description:
```graphql
mutation {
  addBook(
    title: "Refactoring"
    authorName: "Martin Fowler"
  ) {
    id
    title
    description
    author {
      id
      name
    }
  }
}
```

## Workshop Learning Objectives

This demo project covers:
- ✅ Setting up a GraphQL server with HotChocolate
- ✅ Creating data models using C# records
- ✅ Implementing GraphQL queries and mutations
- ✅ Working with nullable properties
- ✅ Managing runtime data cache
- ✅ GraphQL schema design principles
- ✅ Best practices for GraphQL API development

## Workshop Steps (For Starter Project)

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

## Initial Sample Data

Both projects come pre-loaded with sample books:
1. **Clean Code** by Robert C. Martin
2. **The Pragmatic Programmer** by Andrew Hunt

## Tips for Workshop Participants

### Data Models
- Use C# `record` types for immutable data
- Keep nullable properties optional with `?` syntax

### Library Cache
- Use a static class with a static `List<Book>` property
- Initialize with sample data for testing

### GraphQL Setup
- Use HotChocolate framework
- Register types with `.AddQueryType<Query>()` and `.AddMutationType<Mutation>()`
- Map endpoint with `app.MapGraphQL()`

### Testing
- Access GraphQL Playground at `/graphql` endpoint
- Start with simple queries before trying mutations
- Use the complete implementation as reference

## Troubleshooting

### Common Issues
- **Port conflicts**: Check console output for the actual port
- **Build errors**: Ensure all TODO items are completed
- **GraphQL errors**: Verify schema registration in Program.cs

### Getting Help
- Check the complete implementation in `BookGraphQL/` folder
- Review TODO comments in starter project files
- Ask your workshop instructor

## Event Information

**Workshop:** Mindbody GraphQL Workshop  
**Event:** 2025 PDE India Offsite  
**Location:** Goa, India  
**Year:** 2025  

---

*This repository serves as a hands-on introduction to GraphQL development and demonstrates key concepts covered during the workshop. Happy coding! 🚀*
