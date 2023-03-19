using Grpc.Core;
using Hello.Grpc.Server;

namespace Hello.Grpc.Server.Services
{
    public class HelloService: Greeter.GreeterBase
    {
        private readonly ILogger<HelloService> logger;
        public HelloService(ILogger<HelloService> logger) {
            this.logger = logger;
        }


        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            logger.LogInformation(request.Name);
            var reply = new HelloReply();
            reply.Message = $"Hello {request.Name}!";
            return Task.FromResult(reply);
        }
    }
}
