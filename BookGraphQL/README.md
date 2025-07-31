# BookGraphQL - Demo Project

## Overview

This is a demo project for the **Mindbody GraphQL Workshop** held at the **2025 PDE India Offsite in Goa**. This project demonstrates the fundamentals of building a GraphQL API using ASP.NET Core and HotChocolate.

## Project Description

BookGraphQL is a simple library management system that allows you to:
- Query books and authors
- Add new books to the library
- Manage a runtime cache of book data

## Technologies Used

- **.NET 7.0** - Core framework
- **ASP.NET Core** - Web framework
- **HotChocolate** - GraphQL server implementation
- **C# Records** - For immutable data models

## Project Structure

```
BookGraphQL/
├── Author.cs          # Author data model
├── Book.cs            # Book data model with nullable description
├── Library.cs         # Static runtime cache for book storage
├── Query.cs           # GraphQL query resolvers
├── Mutation.cs        # GraphQL mutation resolvers
├── Program.cs         # Application entry point
└── README.md          # This file
```

## Features

### GraphQL Queries
- **`books`** - Retrieve all books in the library
- **`authors`** - Retrieve all unique authors

### GraphQL Mutations
- **`addBook`** - Add a new book with title, author name, and optional description

### Data Models
- **Book** - Contains ID, Title, Author, and optional Description
- **Author** - Contains ID and Name
- **Library** - Static runtime cache for storing book data

## Getting Started

### Prerequisites
- .NET 7.0 SDK or later
- Visual Studio Code or Visual Studio

### Running the Application

1. **Clone or navigate to the project directory:**
   ```bash
   cd BookGraphQL
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

3. **Build the project:**
   ```bash
   dotnet build
   ```

4. **Run the application:**
   ```bash
   dotnet run
   ```

5. **Access GraphQL Playground:**
   Open your browser and navigate to `https://localhost:5001/graphql` (or the port shown in the console)

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

**Example 1: Complete book with description**
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

**Example 2: Book without description**
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

**Example 3: Technical book with detailed description**
```graphql
mutation {
  addBook(
    title: "Domain-Driven Design"
    authorName: "Eric Evans"
    description: "Tackling Complexity in the Heart of Software"
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

## Initial Data

The application comes pre-loaded with sample books:
1. **Clean Code** by Robert C. Martin
2. **The Pragmatic Programmer** by Andrew Hunt

## Event Information

**Workshop:** Mindbody GraphQL Workshop  
**Event:** 2025 PDE India Offsite  
**Location:** Goa, India  
**Year:** 2025  

---

*This project serves as a hands-on introduction to GraphQL development and demonstrates key concepts covered during the workshop.*
