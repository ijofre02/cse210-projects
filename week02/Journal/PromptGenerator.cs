public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
        };
}
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random(); // randomGenerator is justh a variable name
        int index = randomGenerator.Next(_prompts.Count); //Count property get the size of the list
        return _prompts[index]; // I don't want return te number index instead I wan retur the string
    }                          //here we have te text _promts in that place [random]
}