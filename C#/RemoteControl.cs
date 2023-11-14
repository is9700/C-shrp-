namespace praktikum11 ;




class RemoteControl
{


Command[,] a=new Command[4,2];//4 F KOL WAHDA FAMA ZOUZ 
int i ;

public void setCommand(int i, Command on, Command off)
{ 
    a[i,0]=on;
    a[i, 1] =off;    
}

public void PressOn(int i)
 {


       a[i,0].execute();

 }

public void PressOff(int i)
{
   
        a[i, 1].execute();
}


}