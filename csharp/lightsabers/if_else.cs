"case.cs"

class Jedi
{
  ICollection _lightsabers = new Collection();

  ICollection public lightsabers
  {
    get { return _lightsabers }
    set {
     _lightsabers.Add(lightsaber);
     lightsaber.AfterAdd();
     return _lightsabers;
    }
  }
}

class Sith {
}

class Lightsaber
{
  string[] JediColors = { "green", "blue", "purple" };

  public void AfterAdd (object klass)
  {
    if (klass is Jedi) {
      this.color = JediColors[random.Next(0, JediColors.length)];
    } else {
      this.color = "red";
    }
  }
}
