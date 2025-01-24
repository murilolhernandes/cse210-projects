public class Scripture
{
  private Reference _reference;
  private List<Word> _words;
  
  public Scripture(Reference Reference, string text)
  {
    _reference = Reference;
    _words = new List<Word>();

    string[] words = text.Split(" ");
    foreach (string word in words)
    {
      _words.Add(new Word(word));
    }
  }

  public void HideRandomWords(int numberToHide) 
  {
    Random random = new Random();
    HashSet<int> hiddenIndices = new HashSet<int>();
    for (int i = 0; i < numberToHide; i++)
    {
      int index;
      do
      {
        index = random.Next(0, _words.Count);
      } while (hiddenIndices.Contains(index) || _words[index].IsHidden());
      hiddenIndices.Add(index);
      _words[index].Hide();
    }
  }

  public string GetDisplayText() 
  {
    string displayText = $"{_reference.GetDisplayText()} ";
    foreach (Word word in _words)
    {
      displayText += word.GetDisplayText() + " ";
    }
    return displayText;
  }

  public bool IsCompletelyHidden() 
  {
    if (_words.All(w => w.IsHidden()))
    {
      return true;
    }
    return false;
  }
}