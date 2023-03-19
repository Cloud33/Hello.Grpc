using Grpc.Core;
using Grpc.Net.Client;
using Hello.Grpc.Server;


namespace Hello.Grpc.Client
{
    public class HelloTest
    {
        public async void GetHelloInfo()
        {
            System.Console.WriteLine($"GetHelloInfo Start");
            string url = "http://localhost:50051";
            //string url_https = "https://localhost:7194";
            using (var channel = GrpcChannel.ForAddress(url))
            {
                var client = new Greeter.GreeterClient(channel);
                try
                {
                    var request = client.SayHello(new HelloRequest
                    {
                        Name = "World"
                    });
                    System.Console.WriteLine($"Greeting: {request.Message}");
                }
                catch (Exception ex)
                {

                    System.Console.WriteLine($"GetHelloInfo Error: {ex.Message}");
                }
               
            }
            System.Console.WriteLine($"GetHelloInfo End");
        }
        public async void GetHelloInfoAsync()
        {
            System.Console.WriteLine($"GetHelloInfoAsync Start");
            string url = "http://localhost:50051";
            //string url_https = "https://localhost:7194";
            using (var channel = GrpcChannel.ForAddress(url))
            {
                var client = new Greeter.GreeterClient(channel);
                try
                {
                    var request = await client.SayHelloAsync(new HelloRequest
                    {
                        Name = "World"
                    });
                    System.Console.WriteLine($"Greeting: {request.Message}");
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine($"GetHelloInfoAsync Error: {ex.Message}");
                }
            }
            System.Console.WriteLine($"GetHelloInfoAsync End");
        }
    }
}
