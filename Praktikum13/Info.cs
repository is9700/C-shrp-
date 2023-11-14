namespace Praktikum13;

using System;



public class Info
{ 

    Fuhrpark fs;

    public Info(Fuhrpark fs)
    {
        this.fs=fs;
        fs.AutoEvent+=this.printinfo;
    }

    public void printinfo(object sender, AutoEventArgs a)
    {
        Console.WriteLine("neue auto :");

        a.Au.DruckeDaten();

    }


}





















/*
public class Info
{
    public Info(Fuhrpark fuhrpark)
    {   
    //
    fuhrpark.NewCarEvent+=this.printNewCarInfo;
    }

    public void printNewCarInfo(object sender, AutoEventArgs a)
    {
        System.Console.Write("Neues Auto: ");

        a.Auto.DruckeDaten();
   
}
}








/*
 public string printNewCarInfo(object sender, AutoEventArgs args)
    {
        System.Console.Write("Neues Auto: ");
    //       args.Auto.DruckeDaten();
    args.auto.DruckeDaten();
    return "d";
    }*/
