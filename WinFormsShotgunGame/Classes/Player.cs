namespace WinFormsShotgunGame.Classes
{
    public class Player : GamePlayers
    { 
        public PlayerAction PlayerChosenAction(PlayerAction playerAction)
        {
            switch (playerAction)
            {
                case PlayerAction.Shoot:
                    return Shoot();
                case PlayerAction.Reload:
                    return Reload();
                case PlayerAction.Block:
                    return Block();
                case PlayerAction.Shotgun:
                    return Shotgun();
                default:
                    return Block();
            }
        }
      
    }
}
