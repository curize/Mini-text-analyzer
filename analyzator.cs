using System;

class TextAnalyzer
{
    public static (int wordCount, int characterCount) AnalyzeText(string text)
    {
        // убираем лишние пробелы и подсчитываем количество символов
        string cleanedText = text.Trim();
        
        // подсчёт количества символов (включая пробелы)
        int characterCount = cleanedText.Length;
        
        // подсчёт количества слов
        string[] words = cleanedText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;

        return (wordCount, characterCount);
    }

    static void Main()
    {
        string text = "I watched you dance.";
        var result = AnalyzeText(text);
        
        Console.WriteLine($"Word count: {result.wordCount}");
        Console.WriteLine($"Number of characters: {result.characterCount}");
    }
}