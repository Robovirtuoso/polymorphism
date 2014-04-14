"controller.cs"

class Jedi : ICouncilMember {
}

interface ICouncilMember {
  public string CouncilStatus()
}

namespace HighCouncil
{
  class Factory
  {
    public static ICouncilDecorator build(Jedi member)
    {
      factory = new Factory(member);
      Type type = factory.Decorator(member);
      Activator.CreateInstance(type, member);
    }

    public Factory(Jedi member)
    {
      member = member;
    }

    public Type Decorator()
    {
      // 'sith in disguise'
      // HighCouncil.Decorator.SithInDisguise
      Type type = Type.GetType("HighCouncil.Decorator." + member.CouncilStatus);
    }
  }

  namespace Decorator
  {
    class SithInDisguise : ICouncilDecorator {
    }

    class Guest : ICouncilDecorator {
    }

    class Yoda : ICouncilDecorator {
    }

    interface ICouncilDecorator {
    }

  }
}
