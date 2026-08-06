namespace Elements.Style.Test;

public class TestFixed
{
    public string Cheese = "cheese";
    public bool Test()
    {
        try
        {
            throw new Exception("Cheese");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Cheese");
        }

        var cheese = Cheese;
        if (Cheese == cheese)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
