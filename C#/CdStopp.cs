using System;


     class CdStopp : praktikum11.Command
{
    praktikum11.CdPlayer player;
        //public CdPlayer Player { get; set; }

        public CdStopp(praktikum11.CdPlayer player)
        {
            this.player = player;
        }

        public  void execute()
        {
            player.Stopp();
        }
    }

