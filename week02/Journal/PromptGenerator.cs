public class PromptGenerator
{
  public static List<string> _prompts = new List<string>()
  {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "Who was the funniest person I interacted with today?",
    "What was the worst part of my day?",
    "What was the most challenging thing I did today?",
    "What was the most exciting thing I did today?",
    "What was the most beautiful thing I did today?",
    "What was the most beautiful thing I learned today?",
    "What was the most important thing I learned today?",
    "What was the most challenging thing I learned today?",
    "What was the most exciting thing I learned today?"
  };
  // Random _random = new Random();

  // public string PromptGenerator()
  // {
  // _prompts.Add("Who was the most interesting person I interacted with today?");
  // _prompts.Add("What was the best part of my day?");
  // _prompts.Add("How did I see the hand of the Lord in my life today?");
  // _prompts.Add("What was the strongest emotion I felt today?");
  // _prompts.Add("If I had one thing I could do over today, what would it be?");
  // _prompts.Add("Who was the funniest person I interacted with today?");
  // _prompts.Add("What was the worst part of my day?");
  // _prompts.Add("What was the most challenging thing I did today?");
  // _prompts.Add("What was the most exciting thing I did today?");
  // _prompts.Add("What was the most beautiful thing I did today?");
  // _prompts.Add("What was the most beautiful thing I learned today?");
  // _prompts.Add("What was the most important thing I learned today?");
  // _prompts.Add("What was the most challenging thing I learned today?");
  // _prompts.Add("What was the most exciting thing I learned today?");

  // }

  public static string GetRandomPrompt()
  {
    // return _prompts[_random.Next(_prompts.Count)];
    return _prompts.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
  }
}