"council/if_else.cs"

interface IWieldable
{
  public string EnergyColor();
}

class Jedi : IWieldable
{
  string[] colors = { "green", "blue", "purple" };
  public string EnergyColor()
  {
    return colors[random.Next(0, colors.length)];
  }
}

class Sith : IWieldable
{
  public string EnergyColor()
  {
    return "red";
  }
}

class Lightsaber
{
  public void AfterAdd(IWieldable klass)
  {
    this.color = klass.EnergyColor();
  }
}
