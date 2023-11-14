
namespace praktikum11 ;

class GarageTor
{
    CdStopp am=new CdStopp(new CdPlayer("stopp")) ;
    CdStart ac=new CdStart(new CdPlayer("start"));
    

    public void hoch()
    {

        ac.execute();
        Console.WriteLine("garage hoch");
    }



    public void runter()
    {
        am.execute();
       Console.WriteLine("garage runter ");
    }

}