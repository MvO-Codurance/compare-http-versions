# Compare HTTP Versions
Sample projects to compare/contrast HTTP v1.1 and v2 and v3 in ASP.NET Core

## Browsers
- At the time of writing, Chrome does not allow HTTP/3 with a self-signed certificate. 
- So use Firefox instead when running this code locally.
  - It complains about the self-signed certificate but just click "Advanced.." and "Allow...".
  - You will also need to manually access the images from each of the WebResource project urls in order to accept the self-signed certificate. See the links below.
- Use the F12 browser tools "Network" tab to view the protocol used to server the content.
- You may have to right-click the column headers to select and show the "Protocol" column.
- Note the following: 
  - HTTP/3 is discovered as an upgrade from HTTP/1.1 or HTTP/2 via the alt-svc header. That means the first request will normally use HTTP/1.1 or HTTP/2 before switching to HTTP/3.
  - Also, doing a CTRL+F5 in the browser will restart this process.

## Links serving an image over different HTTP versions
- HTTP/1.1 http://localhost:5001/
- HTTPS/1.1 https://localhost:5002/
- HTTP/2 https://localhost:5003/
- HTTP/3 https://localhost:5004/

## Doc Links
- https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/http2
- https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/http3