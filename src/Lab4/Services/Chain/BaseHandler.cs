namespace Itmo.ObjectOrientedProgramming.Lab4.Services.Chain;

public class BaseHandler : IHandler
   {
       public IHandler? Next { get; private set; }
       public IHandler? SubNode { get; private set; }

       public void SetNext(IHandler handler)
       {
           Next = handler;
       }

       public void SetSubNode(IHandler handler)
       {
           SubNode = handler;
       }

       public virtual Result Handle(string[] command, int index)
       {
           if (Next is null)
           {
               return new Result.NoMatching("No such command");
           }

           return Next.Handle(command, index);
       }
  }
