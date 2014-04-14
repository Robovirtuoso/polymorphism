"polymorphism.cs"

class HighCouncilController : Controller
{
  private IJedi PrepareForMeeting(Jedi jedi)
  {
    if (jedi.IsPalpatine() || jedi.IsApprenticeOfPalpatine())
    {
      return new SithInDisguiseDecorator(jedi);
    } else if (jedi.IsSmallAndGreen()) {
      return new YodaDecorator(jedi);
    } else if (jedi is Queen) {
      return new GuestDecorator(jedi);
    } else {
      return jedi;
    }
  }
}
