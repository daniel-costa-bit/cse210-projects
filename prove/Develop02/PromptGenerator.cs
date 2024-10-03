using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;
    private readonly Random _random; // Instância de Random

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What are you grateful for today?",
            "Describe a challenging moment and how you overcame it.",
            "What made you smile today?",
            "What do you want to accomplish this week?",
            "Reflect on a recent success you've had."
        };
        _random = new Random(); // Inicializa a instância de Random
    }

    // Método que gera um prompt aleatório
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count); // Gera um índice aleatório
        return _prompts[index]; // Retorna um prompt aleatório
    }
}
