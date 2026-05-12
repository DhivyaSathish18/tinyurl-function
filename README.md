# Tiny URL Azure Function

Azure Function project used for serverless/background processing.

---

## Features

- Serverless execution
- HTTP trigger support
- Lightweight backend processing

---

## Tech Stack

- Azure Functions
- .NET 8
- C#

---

## Prerequisites

Install:

- .NET 8 SDK
- Azure Functions Core Tools

Install Functions Core Tools:

```bash
npm install -g azure-functions-core-tools@4 --unsafe-perm true
```

---

## Run Locally

Start Azure Function:

```bash
func start
```

Default local URL:

```txt
http://localhost:7071
```

---

## Deployment

Deployed using:

- Azure Function App

---

## Publish Function

```bash
func azure functionapp publish <function-app-name>
```

---

## Project Structure

```txt
FunctionApp/
 ├── Functions/
 ├── host.json
 ├── local.settings.json
 └── Program.cs
```

---

## Notes

Do not commit:

```txt
local.settings.json
```

because it may contain secrets.
