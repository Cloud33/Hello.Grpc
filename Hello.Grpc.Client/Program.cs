// See https://aka.ms/new-console-template for more information

using Hello.Grpc.Client;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

var hello = new HelloTest();
hello.GetHelloInfo();
await hello.GetHelloInfoAsync();
