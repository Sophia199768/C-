using Itmo.ObjectOrientedProgramming.Lab3.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public interface ITopikSenderBuilder
{
    public ITopikMessageBuilder Sender(ISender sender);
}