namespace WinFormsShotgunGame.Classes
{
    public class Bot:GamePlayers
    {
        //Använder mig av Random classen för att randomisera datorns val
        //Lägger även till lite logik i valen som boten väljer utifrån uppgiften
        private Random random = new Random();

        public PlayerAction BotChosenAction(Player player)
        {

            if (Bullets >= 3)
            {
                return Shotgun();
            }
            if (player.Bullets == 0 && Bullets > 0)
            {
                return Shoot();
            }
            if (player.Bullets == 0 && Bullets == 0)
            {
                return Reload();
            }
            int randomNumber = random.Next(1, 3);
            if (Bullets == 0)
            {
                switch (randomNumber)
                { 
                    case 1:
                        return Reload();
                    case 2:
                        return Block();
                    default:
                        return Block();
                }
            }
            else {
                randomNumber = random.Next(1, 4);
                switch (randomNumber) 
                {
                case 1:
                    return Shoot();
                case 2:
                    return Reload();
                case 3:
                    return Block();
                default:
                    return Block();
                }
            }
        }
    }
}
