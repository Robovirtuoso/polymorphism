class HighCouncilController : Controller
{
  public ActionResult Index()
  {
    List<Jedi> jediList = db.Jedi.ToList();

    foreach(jedi in jediList)
    {
      HighCouncil.Factory.build(jedi);
    }

    return View();
  }
}
