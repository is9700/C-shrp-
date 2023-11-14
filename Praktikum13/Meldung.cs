
 namespace Praktikum13;

public class Meldung
{

    public delegate void melddel(string msg);

    public event melddel evnt;

    public void meldefehler(string meldung)
    {

        evnt(meldung);
    }


}