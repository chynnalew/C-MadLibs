using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route ("/")]
    public ActionResult Home() {return View();}
    
    [Route("/pbform")]
    public ActionResult PBForm() {return View();}

    [Route("/pbmadlib")]
    public ActionResult PBMadLib(string color1, string noun1, string food1, string adj1, string adj2, string num1, string noun2, string verb1, string verb2, string noun3) 
    { 
      Words userWords = new Words();
      userWords.Color1 = color1;
      userWords.Noun1 = noun1;
      userWords.Food1= food1;
      userWords.Adj1 = adj1;
      userWords.Adj2 = adj2;
      userWords.Num1 = num1;
      userWords.Noun2 = noun2;
      userWords.Verb1 = verb1;
      userWords.Noun3 = noun3;

      return View(userWords); 
    }

    [Route("/nurseform")]
    public ActionResult NurseForm() {return View();}

    [Route("/nursemadlib")]
    public ActionResult NurseMadLib(string silly1, string lname, string illness, string nouns, string adj1, string adj2, string silly2, string place, string num1, string adj3) 
    { 
      Words userWords = new Words();
      userWords.Silly1 = silly1;
      userWords.Lname = lname;
      userWords.Illness = illness;
      userWords.Nouns = nouns;
      userWords.Adj1 = adj1;
      userWords.Adj2 = adj2;
      userWords.Silly2 = silly2;
      userWords.Place = place;
      userWords.Num1 = num1;
      userWords.Adj3 = adj3;


      return View(userWords); 
    }


    // add additional paths with the format:
  
    // [Route("/pathName")]
    // public string PathName() 
    //  {
    //    add code here! add variables, use Models elements, etc.
    //    return "Always return something!"
    //  }
  }
}