public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    { //Padrão 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numeroTodo)
    { //Todo número com denominador 1
        _top = numeroTodo;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    { //1 parâmetro para numerador e 1 para denominador
        _top = top;
        _bottom = bottom;
    }

    public string GetFraction()
    {
        string fração = $"{_top}/{_bottom}";
        return fração;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}