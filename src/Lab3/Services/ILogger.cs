using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public interface ILogger
{
    public void AddLog(IMessage message);
    public IEnumerable<IMessage> ShowLog();
}