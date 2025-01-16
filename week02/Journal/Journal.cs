using System.Runtime.CompilerServices;

public class Journal
{
  public static List<string> _entries = new List <string>();

  public static void AddEntry(Entry newEntry)
  {
    // _entries.Add(newEntry.ToString());
    // _entries.Add(newEntry._entryText);
  }

  public static void DisplayAll()
  {

  }

  public static void SaveToFile(string file)
  {
    
  }

  public static void LoadFromFile(string file)
  {
    
  }
}