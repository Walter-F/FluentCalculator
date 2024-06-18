SomeBool someBool = new SomeBool();
bool result = someBool == true && someBool == false; // True
Console.WriteLine(result);
public class SomeBool
{
    public static bool operator ==(SomeBool a, bool b)
    {
        return true;
    }

    public static bool operator !=(SomeBool a, bool b)
    {
        return true;
    }

    public override bool Equals(object obj)
    {
        return true;
    }

    public override int GetHashCode()
    {
        return 0;
    }
}
