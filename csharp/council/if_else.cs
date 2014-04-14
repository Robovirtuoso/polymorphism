"type_checking.cs"

class SithInDisguiseDecorator
{
  public SithInDisguiseDecorator(Jedi jedi)
  {
    JediToPresent = jedi;
  }

  public Jedi JediToPresent { get; set; }

  public string AlteriorMotives() {}
  public int CountOfPeopleBeingManipulated() {}
}

class HighCouncilController : Controller
{
  public ActionResult Index()
  {
    List<Jedi> list = db.Jedi.ToList();

    list.Select(presented => PrepareForMeeting(jedi));

    return View();
  }

  private PrepareForMeeting(Jedi jedi)
  {
    if(jedi.IsPalpatine())
    {
      return new SithInDisguiseDecorator(jedi);
    } else {
      return jedi;
    }
  }
}
