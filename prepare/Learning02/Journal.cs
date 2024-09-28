using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries; 

    public Journal()
    {
        _entries = new List<Entry>(); 
    }

    // Método para adicionar uma nova entrada
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Método para exibir todas as entradas
    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        Console.WriteLine("Journal Entries:");
        foreach (var entry in _entries)
        {
            Console.WriteLine($"{entry._date} - {entry._promptText}: {entry._entryText}");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                // Formato: date|promptText|entryText
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine($"Entries saved to {filename}.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File {filename} not found.");
            return;
        }

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length == 3) // Para verificar se a linha contém todos os campos necessários.
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2]
                    };
                    _entries.Add(entry);
                }
            }
        }
        Console.WriteLine($"Entries loaded from {filename}.");
    }
}
