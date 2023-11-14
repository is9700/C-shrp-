namespace praktikum11 ;

class CdStart:Command
{

CdPlayer player ;
//public CdPlayer Player { get; set; } //automatic properties


  public  CdStart(CdPlayer player)
    {
        this.player = player;   
    }


 public   void  execute()
{
    player.Start();

}
}