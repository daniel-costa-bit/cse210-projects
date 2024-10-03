public class Word
{
    private string _text;
    private bool _isHidden;

    // Construtor que recebe o texto da palavra
    // Como padrão a palavra não está escondida
    public Word(string text)
    {
        _text = text;
        _isHidden = false; 
    }

    // Transformo em true para esconder a palavra
    public void Hide()
    {
        _isHidden = true;
    }

    // Uso esse construtor para mostrar a palavra
    public void Show()
    {
        _isHidden = false;
    }

    // Verifico se a palavra está escondida
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Retorna o texto a ser exibido (escondido ou visível)
    public string GetDisplayText()
    {
        return _isHidden ? "____" : _text;
    }
}