

namespace Praktikum13;

public class Autodisplay
{
    
    public Autodisplay(Meldung ml)
    {
        ml.evnt+=this.printer;
    }

    public void printer(string message)
    {
        Console.WriteLine(message);
    }
}