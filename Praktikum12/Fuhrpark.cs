
namespace Praktikum12;
using System;
public class Fuhrpark
{

    private LinkedList<Auto> fuhrpark;
    private int size;


    public Fuhrpark()
    {
        fuhrpark = new LinkedList<Auto>();
        size = 0;
    }

    public void Aufnehmen(Auto a)
    {
        fuhrpark.Append(a);
        size++;
    }
    public LinkedList<Auto> getfuhrpark()
    {
        return fuhrpark;
    }
    public void Inventur()
    {
        Iterator<Auto> it = fuhrpark.Iterator();

        while ((bool)it.hasNext())
        {
            it.Next().DruckeDaten();
        }
        
    }

    public int BerechneFlottenalter()
    {
        Iterator<Auto> it = fuhrpark.Iterator();
        int sum = 0;

        while ((bool)it.hasNext())
        {
            sum += (int)it.Next().Alter();
        //(int)it !!!!
        }

        return sum / size;
    }
}