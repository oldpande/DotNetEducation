using Greet;
using Grpc.Core;

namespace GrpcServiceSpace.Services;

public class GreeterService(ILogger<GreeterService> _logger) : Greeter.GreeterBase
{
    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        _logger.LogInformation(request.Name);
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }

    public override Task<SendRocketReply> SendRocket(SendRocketRequest request, ServerCallContext context)
    {
        _logger.LogInformation("Start {RocketName} at {StartTime}", request.Name, request.Date);
        return Task.FromResult(new SendRocketReply
        {
            IsSuccess = true
        });
    }
}
