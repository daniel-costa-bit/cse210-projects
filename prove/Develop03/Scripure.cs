public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Esse é o construtor que recebe a referência e o texto da escritura
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Oculta palavras aleatórias
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        
        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Remove da lista de visíveis
        }
    }

    // Retorna a escritura formatada com as modificações
    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    // Verifica se todas as palavras estão escondidas
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}