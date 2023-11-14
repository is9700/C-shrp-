namespace Praktikum12;
using System;

public class Auto 
{

private string Hersteller{ get ; set ;}
private int  Baujahr { get ; set ;}

    public Auto( string Hersteller,int Baujahr)
    {
        this.Baujahr=Baujahr;
        this.Hersteller=Hersteller;
    }

  public int Alter()
    {
        return 2022 - Baujahr;
    }


public void DruckeDaten()
{
    Console.WriteLine(" Hersteller {0},Baujahr {1}  ",Hersteller,Baujahr);
}








}