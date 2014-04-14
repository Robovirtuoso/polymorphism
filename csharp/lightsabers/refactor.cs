"polymorphism.cs"

class Lightsaber
{
  public void AfterAdd(object klass)
  {
    this.color = PickColor(klass.getType());
  }

  private const Dictionary<string, string[]> warriors = return new Dictionary<string, string[]>()
  {
    { "Jedi", { "green", "blue", "purple" } },
    { "Sith", { "red" } },
    { "Kaleesh", { "green", "blue" } }
  }

  private string PickColor(string klass_name)
  {
    string[] colors = warriors[klass_name];
    return colors[random.Next(0, colors.length)]
  }
}
