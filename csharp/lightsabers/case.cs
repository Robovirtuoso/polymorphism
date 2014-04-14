"refactor.cs"

// General Grevous
class Kaleesh {
}

class Lightsaber
{
  string[] JediColors = { "green", "blue", "purple" };
  string[] KaleeshColors = { "green", "blue" };
  string SithColors = "red";

  public void AfterAdd (object klass)
  {
    switch(klass.getType())
    {
      case Jedi:
        this.color = JediColors[random.Next(0, JediColors.length)];
        break;
      case Sith:
        this.color = SithColors;
        break;
      case Kaleesh:
        this.color = KaleeshColors[random.Next(0, KaleeshColors.length)];
        break;
    }
  }
}
