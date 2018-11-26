using Microsoft.AspNetCore.Mvc;
using Madlib.Models;

namespace Madlib.Controllers
{
  public class HomeController : Controller
  {
    public string Home() 
    { 
      return "This is a madlib"; 
    }

    [Route("/input")]
    public ActionResult Input()
    {
      return View();
    }

    [Route("/story")]
    public ActionResult Story(string exclamation, string adverb, string noun, string adjective)
    {
      WordVariables newWordVariable = new WordVariables();
      newWordVariable.SetExclamation(exclamation);
      newWordVariable.SetAdverb(adverb);
      newWordVariable.SetNoun(noun);
      newWordVariable.SetAdjective(adjective);

      return View(newWordVariable);

    }


  }
}