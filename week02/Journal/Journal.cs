using System.Runtime.CompilerServices;
using System.IO;
using System.Threading.Tasks.Dataflow;

public class Journal
{
  public static List<string> _entries = new List <string>();
  public static List<string> _savedEntries = new List<string>();

  public static void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry._entryText);
  }

  public static void DisplayAll()
  {
    if (_entries.Count == 0)
    {
      Console.WriteLine("The journal is empty.");
    }
    else
    {
      foreach (string entry in _entries)
      {
        Console.WriteLine(entry);
      }
    }
  }

  public static void SaveToFile(string file)
  {
    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), file);
    HashSet<string> uniqueEntries = new HashSet<string>(_savedEntries);
    foreach (string entry in _entries)
    {
      if (!uniqueEntries.Contains(entry))
      {
        uniqueEntries.Add(entry);
      }
    }

    using (StreamWriter outputFile = new StreamWriter(filePath, false))
    {
      foreach (string entry in uniqueEntries)
      {
        outputFile.WriteLine(entry);
        outputFile.WriteLine();
      }
    }
    _savedEntries = new List<string>(uniqueEntries);
  }

  public static void LoadFromFile(string file)
  {
    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), file);
    _entries.Clear();
    if (File.Exists(filePath))
    {
      string[] lines = File.ReadAllLines(filePath);
      foreach (string line in lines)
      {
        _entries.Add(line.Trim());
      }
    }
    else
    {
      Console.WriteLine("File is not found. Please try again.");
    }
  }
}