# PYTHON TO .NET MIGRATION TOOLKIT

## Overview

A cross-platform integration toolkit demonstrating how Python business logic can be converted into .NET services with equivalent outputs.

This project simulates enterprise modernization where legacy Python services are migrated into scalable .NET Core microservices using REST APIs.

------------------------------------------------------------

## Architecture

Python FastAPI Service
        ↓ (REST API / JSON)
ASP.NET Core Web API
        ↓
Client Applications (Browser / Postman)

------------------------------------------------------------

## Features

### Python Service
- FastAPI-based REST API
- Business logic simulation
- JSON response handling
- Logging and error handling

### .NET Service
- ASP.NET Core Web API
- HTTP client integration with Python service
- Equivalent business logic implementation
- Clean architecture design

### Integration Layer
- Python ↔ .NET communication
- REST API data exchange
- JSON serialization/deserialization
- Cross-service validation

------------------------------------------------------------

## Technology Stack

### Python Service
- FastAPI
- Uvicorn
- Python 3.10+

### .NET Service
- ASP.NET Core Web API
- C#
- HttpClient
- Dependency Injection

### Communication
- REST APIs
- JSON

------------------------------------------------------------

## How to Run & Test

### 1. Run Python Service
cd python-service
pip install -r requirements.txt
uvicorn app.main:app --reload --port 8000

Expected:
Uvicorn running on http://127.0.0.1:8000

------------------------------------------------------------

### 2. Test Python API
http://localhost:8000/process-data

Response:
{
  "status": "success",
  "source": "python",
  "data": {
    "score": 95,
    "message": "Business logic executed successfully"
  }
}

------------------------------------------------------------

### 3. Run .NET Service
cd dotnet-service
dotnet run

Expected:
Now listening on: http://localhost:52xx

------------------------------------------------------------

### 4. Test Integration API
http://localhost:52xx/api/bridge

Response:
{
  "status": "success",
  "source": "python",
  "data": {
    "score": 95,
    "message": "Business logic executed successfully"
  }
}

------------------------------------------------------------

## Resume Highlights

- Converted Python utilities into .NET Core services
- Built cross-platform API integration architecture
- Implemented REST-based service communication
- Designed JSON interoperability between Python and C#
- Built enterprise-style migration simulation toolkit

------------------------------------------------------------

## Project Status
Active Development
