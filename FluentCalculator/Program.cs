var result = FluentCalculator.One.Operation.Plus(FluentCalculator.Two)
    .Operation.Plus(FluentCalculator.Three)
    .Operation.Minus(FluentCalculator.One)
    .Operation.Minus(FluentCalculator.Two)
    .Operation.Minus(FluentCalculator.Four); 

Console.WriteLine(result);

public class FluentCalculator
{
    private int _value;
    private bool _isOperation;

    private FluentCalculator(int number, bool isOperation)
    {
        _value = number;
        _isOperation = isOperation;
    }

    public static FluentCalculator Zero => new FluentCalculator(0, false);
    public static FluentCalculator One => new FluentCalculator(1, false);
    public static FluentCalculator Two => new FluentCalculator(2, false);
    public static FluentCalculator Three => new FluentCalculator(3, false);
    public static FluentCalculator Four => new FluentCalculator(4, false);
    public static FluentCalculator Five => new FluentCalculator(5, false);
    public static FluentCalculator Six => new FluentCalculator(6, false);
    public static FluentCalculator Seven => new FluentCalculator(7, false);
    public static FluentCalculator Eight => new FluentCalculator(8, false);
    public static FluentCalculator Nine => new FluentCalculator(9, false);
    public static FluentCalculator Ten => new FluentCalculator(10, false);

    public FluentCalculator Plus(FluentCalculator fc)
    {
        if (!_isOperation || fc._isOperation)
            throw new InvalidOperationException();
        _value += fc._value;
        _isOperation = true;
        return this;
    }

    public FluentCalculator Minus(FluentCalculator fc)
    {
        if (!_isOperation || fc._isOperation)
            throw new InvalidOperationException();
        _value -= fc._value;
        _isOperation = true;
        return this;
    }

    public FluentCalculator Times(FluentCalculator fc)
    {
        if (!_isOperation || fc._isOperation)
            throw new InvalidOperationException();
        _value *= fc._value;
        _isOperation = true;
        return this;
    }

    public FluentCalculator DividedBy(FluentCalculator fc)
    {
        if (!_isOperation || fc._isOperation)
            throw new InvalidOperationException();
        if (fc._value == 0)
            throw new DivideByZeroException();
        _value /= fc._value;
        _isOperation = true;
        return this;
    }

    public static implicit operator int(FluentCalculator calculator) => calculator._value;

    // Операции возвращают объект класса FluentCalculator с флагом _isOperation
    public FluentCalculator Operation => new FluentCalculator(_value, true);
}
