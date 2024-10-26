namespace Gizza.MessageBroker;

public enum RpcResponseStatus : byte
{
    Success = 1,
    Failure = 2,
    Timeout = 3,
}