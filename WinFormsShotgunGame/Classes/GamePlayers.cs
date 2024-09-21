namespace WinFormsShotgunGame.Classes
{
    public class GamePlayers
    {
        //Skapa en Parent class med members som går att använda för både spelare och datorn
        public int Bullets { get; set; }
        public bool IsBlocking { get; set; }

        public GamePlayers()
        {
            Bullets = 0;
            IsBlocking = false;
        }

        public PlayerAction Shoot() 
        {
            Bullets--;
            IsBlocking = false;
            return PlayerAction.Shoot;
        }
        public PlayerAction Block() 
        {
            IsBlocking = true;
            return PlayerAction.Block;
        }
        public PlayerAction Reload() 
        {
            Bullets++;
            IsBlocking = false;
            return PlayerAction.Reload; 
        }
        public PlayerAction Shotgun() 
        {
            Bullets -= 3; 
            IsBlocking = false;
            return PlayerAction.Shotgun; 
        }
    }
}
