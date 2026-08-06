namespace Elements.Style.Test;

public class TestWithWarnings
{
    public string cheese = "cheese";
    public bool Test()
    {
        try {
            throw new Exception("Cheese");
        } catch (Exception ex) {
            Console.WriteLine("Cheese");
        }

        var Cheese = cheese;
        if (Cheese == cheese) {
            return true;
        } else {
            return false;
        }
    }
}
