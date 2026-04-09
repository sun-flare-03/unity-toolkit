# unity-toolkit

[![Build](https://img.shields.io/github/actions/workflow/status/user/unity-toolkit/ci.yml?branch=main)]()
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)]()
[![License: MIT](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)

> Unity editor toolkit with custom inspectors, gizmos, and build pipeline

A C# project focused on solving real-world engineering problems.

## Features

- **Async/Await** — Fully async pipeline with cancellation token propagation
- **Clean Architecture** — Layered design with clear separation of concerns
- **Nullable Annotations** — Full nullable reference type annotations
- **Dependency Injection** — Built-in Microsoft.Extensions.DependencyInjection support
- **Strong Typing** — Record types and pattern matching for domain modeling

## Installation

```bash
dotnet add package unity-toolkit
```

## Usage

```csharp
using UnityToolkit;

var client = new UnityToolkitClient(new UnityToolkitOptions
{
    Timeout = TimeSpan.FromSeconds(30),
    Retries = 3,
});

var result = await client.RunAsync();
Console.WriteLine(result);
```

## Configuration

Configuration can be provided via environment variables, a config file, or programmatically.

| Variable | Description | Default |
|----------|-------------|--------|
| `UNITY_TOOLKIT_TIMEOUT` | Request timeout in seconds | `30` |
| `UNITY_TOOLKIT_RETRIES` | Number of retry attempts | `3` |
| `UNITY_TOOLKIT_LOG_LEVEL` | Log verbosity (debug, info, warn, error) | `info` |

## License

This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.
