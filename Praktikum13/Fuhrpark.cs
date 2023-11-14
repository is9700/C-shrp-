
namespace Praktikum13;
using System;
public class Fuhrpark
{

    private LinkedList<Auto> fuhrpark;
    private int size;
//event 

    public delegate void AutoEventdelegeteArgs(object sender, AutoEventArgs a);

    public event AutoEventdelegeteArgs AutoEvent;

    public Fuhrpark()
    {
        fuhrpark = new LinkedList<Auto>();
        size = 0;
    }

    public void Aufnehmen(Auto auto)
    {
        fuhrpark.Append(auto);
        size++;
      //EVENT
      AutoEvent(this,new AutoEventArgs(auto));//declenchina event

    }
    
    
    /*public void Aufnehmen(Auto auto)
    {
        fuhrpark.Append(auto);
        size++;
      //EVENT
       //NewCarEvent?.Invoke(this, new AutoEventArgs(a));
    NewCarEvent(this,new AutoEventArgs(auto));
    
    }*/
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