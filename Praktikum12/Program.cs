namespace Praktikum12;
using System;

public class main
{

    public static void Main(string[]args)
    {

        Fuhrpark fp =new Fuhrpark();
Auto b = new Auto("Fiat ",1960);
    fp.Aufnehmen(new Auto("BMW",1961));

    fp.Aufnehmen(new Auto("Mercedes",1951));
        fp.Aufnehmen(new Auto("Audi",1991));
            fp.Aufnehmen(new Auto("Ford",1981));
                fp.Aufnehmen(new Auto("Peugeot",1971));
                fp.getfuhrpark().Remove(2);

                fp.Inventur();

              Console.WriteLine(fp.BerechneFlottenalter());
           
    }
}
