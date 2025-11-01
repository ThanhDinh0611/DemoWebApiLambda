# DemoWebApiLambda

A .NET 8 Web API with health check service for AWS Lambda deployment.

## Features

- **.NET 8 Web API**: Built on the latest .NET 8 framework
- **Health Check Service**: Includes a `/health` endpoint for monitoring and orchestration
- **Swagger/OpenAPI**: Interactive API documentation available in development mode
- **Weather Forecast API**: Sample endpoint demonstrating API functionality

## Health Check Endpoint

The API includes a health check endpoint at `/health` that returns:
- **Status Code**: 200 OK when healthy
- **Response**: "Healthy" text
- **Headers**: Cache-Control headers to prevent caching of health status

This endpoint can be used for:
- Kubernetes liveness and readiness probes
- AWS ECS/ELB health checks
- Load balancer health monitoring
- Container orchestration platforms

## Running the Application

```bash
cd DemoWebApiLambda
dotnet run
```

The application will start and listen on `http://localhost:5092` by default.

## Testing the Health Check

```bash
curl http://localhost:5092/health
```

Expected response:
```
Healthy
```

## API Endpoints

- `GET /health` - Health check endpoint
- `GET /weatherforecast` - Sample weather forecast data
- `GET /swagger` - Swagger UI (development only)
