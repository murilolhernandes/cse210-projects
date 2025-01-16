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
    "What was the most exciting thing I learned today?",
    "If I had one thing I could do over today, what would it be?"
  };
  public static string GetRandomPrompt()
  {
    return _prompts.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
  }
}