namespace Gizza.MessageBroker;

public enum BrokerRole : byte
{
    RPC = 1,
    Queue = 2,
    Stream = 3,
}
