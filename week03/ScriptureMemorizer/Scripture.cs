public class Scripture
{
  private Reference _reference = new Reference();
  private List<Word> _words = new List<Word>();
  
  public string GetDisplayText() 
  {
    return "";
  }

  private void HideRandomWords(int numberToHide) 
  {

  }

  public bool IsCompletelyHidden() 
  {
    return true;
  }

  public Scripture(string reference, string _text)
  {
    
  }
}