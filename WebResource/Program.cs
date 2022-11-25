using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel((context, options) =>
{
    // HTTP/1.1 on port 5001
    options.ListenAnyIP(5001, listenOptions =>
    {
        listenOptions.Protocols = HttpProtocols.Http1;
    });
    
    // HTTPS/1.1 on port 5002
    options.ListenAnyIP(5002, listenOptions =>
    {
        listenOptions.Protocols = HttpProtocols.Http1;
        listenOptions.UseHttps();
    });
    
    // HTTP/2 on port 5003
    options.ListenAnyIP(5003, listenOptions =>
    {
        listenOptions.Protocols = HttpProtocols.Http1AndHttp2;
        listenOptions.UseHttps();
    });
    
    // HTTP/3 on port 5004
    options.ListenAnyIP(5004, listenOptions =>
    {
        listenOptions.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
        listenOptions.UseHttps();
    });
});

var app = builder.Build();

app.MapGet("/", (context) =>
{
    context.Response.Headers[HeaderNames.CacheControl] = "no-store";
    return Results.File(
            path: Path.Combine(app.Environment.ContentRootPath, @"images/jimmi.jpg"), 
            contentType: "image/jpeg")
        .ExecuteAsync(context);
});

app.Run();