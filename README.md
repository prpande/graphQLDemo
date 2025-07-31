# GraphQL Workshop: HotChocolate with .NET and Apollo Federation

This repository contains code examples used in a 1-hour internal workshop introducing GraphQL using [HotChocolate](https://chillicream.com/) and Apollo Federation concepts.

## 📁 Projects

### 1. BookGraphQL

A basic GraphQL server built with HotChocolate demonstrating query and mutation.

**Setup Instructions**:

```bash
cd BookGraphQL
dotnet restore
dotnet run
```

**Try It Out**:  
Visit: `https://localhost:5001/graphql` (or Banana Cake Pop UI)

**Example Query**:

```graphql
query {
  books {
    id
    title
    author
  }
}
```

**Example Mutation**:

```graphql
mutation {
  addBook(title: "GraphQL in Action", author: "Samer Buna") {
    id
    title
  }
}
```

---

### 2. BooksSubgraph

A minimal subgraph for use with Apollo Federation. Built with HotChocolate's Apollo Federation support.

**Setup Instructions**:

```bash
cd BooksSubgraph
dotnet restore
dotnet run
```

**Visit**: `https://localhost:5001/graphql`

**Apollo Federation SDL**:

```graphql
query {
  _service {
    sdl
  }
}
```

## 🧠 Concepts Covered

- GraphQL Schema, Types, Queries, Mutations
- GraphQL Resolvers in C#
- Using Banana Cake Pop for testing
- Apollo Federation (Supergraph / Subgraph)
- [Key], [Provides], [Requires] attributes in HotChocolate

## 🔗 Resources

- HotChocolate Docs: https://chillicream.com/docs
- Apollo Federation: https://www.apollographql.com/docs/federation
- Banana Cake Pop: https://chillicream.com/docs/bananacakepop

## 🤝 License

MIT License