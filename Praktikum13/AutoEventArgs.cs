namespace Praktikum13;

using System;

public class AutoEventArgs:EventArgs
{
  public Auto Au{ get ; set; }

public AutoEventArgs(Auto a )
{
  Au=a;
}



}

















/*
public class AutoEventArgs : System.EventArgs
{
  public Auto Auto{
    private set;
    get;
  }
public AutoEventArgs(Auto auto)
{
    Auto=auto;
}

}*/
