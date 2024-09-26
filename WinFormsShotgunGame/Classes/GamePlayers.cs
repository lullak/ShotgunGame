namespace WinFormsShotgunGame.Classes
{
    public class GamePlayers
    {
        //Skapa en Parent class med members som går att använda för både spelare och datorn
        public int Bullets { get; set; }


        public GamePlayers()
        {
            Bullets = 0;
        }

        public PlayerAction Shoot() 
        {
            Bullets--;
            return PlayerAction.Shoot;
        }
        public PlayerAction Block() 
        {
            return PlayerAction.Block;
        }
        public PlayerAction Reload() 
        {
            Bullets++;
            return PlayerAction.Reload; 
        }
        public PlayerAction Shotgun() 
        {
            Bullets -= 3; 
            return PlayerAction.Shotgun; 
        }
    }
}
