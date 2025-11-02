var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();
builder.Services.AddAWSLambdaHosting(LambdaEventSource.RestApi);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseHealthChecks("/health");

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello World!");
app.MapGet("/test", () => "This is a test endpoint.");
app.MapGet("/demo-web-api", () => "Hello from /demo-web-api!");

app.Run();