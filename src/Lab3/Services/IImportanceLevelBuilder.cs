using Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public interface IImportanceLevelBuilder
{
    public IMessageBuilder MessageImportanceLevel(int level);
}