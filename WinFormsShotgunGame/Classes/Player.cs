namespace WinFormsShotgunGame.Classes
{
    public class Player : GamePlayers
    {
        //Lägger till prop PlayerAction och en metod för att kunna retunera knappvalen senare,
        //ingen constructor behövs då parentclassen har en
        public PlayerAction PlayerAction { get; set; }


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
