namespace Madlib.Models
{
  public class WordVariables
  {
    private string _exclamation;
    private string _adverb;
    private string _noun;
    private string _adjective;

    public void SetExclamation(string newExclamation)
    {
      _exclamation = newExclamation;
    }
    public void SetAdverb(string newAdverb)
    {
      _adverb = newAdverb;
    }
    public void SetNoun(string newNoun)
    {
      _noun = newNoun;
    }
    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }

    public string GetExclamation()
    {
      return _exclamation;
    }
    public string GetAdverb()
    {
      return _adverb;
    }
    public string GetNoun()
    {
      return _noun;
    }
    public string GetAdjective()
    {
      return _adjective;
    }


  }
}