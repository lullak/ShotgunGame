namespace WinFormsShotgunGame.Classes
{
    public class ShotgunGameLogic
    {
        public Player Player { get; set; }
        public Bot Bot { get; set; }
       
        public ShotgunGameLogic()
        {
            Player = new Player();
            Bot = new Bot();
            
        }

        //Check för att kolla om skjut knappen ska enablas
        public bool PlayerCheckBullets ()
        {
            if(Player.Bullets > 0)
            {
                return true;
            }
            return false;
        }

        //Check för att kolla om Shorgun knappen ska enablas
        public bool CanShotgun()
        {
            if (Player.Bullets >= 3)
            {
                return true;
            }
            return false;
        }

        //Tar emot spelarens och botens drag och ger tillbaka outcomen callar även outcome metoden
        public string Turn(PlayerAction playerAction)
        {
            PlayerAction botAction = Bot.BotChosenAction(Player);
            PlayerAction playerActionResult = Player.PlayerChosenAction(playerAction);

            return Outcome(playerActionResult, botAction);
        }

        //Kollar på olika scenarion enligt uppgiften och returna en string med det scenariot
        private string Outcome(PlayerAction playerAction, PlayerAction botAction)
        {
            //switch expression för att får enumsen att skriva ut de texterna jag vill
            string swedishPlayerAction = playerAction switch
            {
                PlayerAction.Reload => "Ladda",
                PlayerAction.Shoot => "Skjuta",
                PlayerAction.Block => "Blockera",
                PlayerAction.Shotgun => "Shotgun"

            };

            string swedishBotAction = playerAction switch
            {
                PlayerAction.Reload => "Ladda",
                PlayerAction.Shoot => "Skjuta",
                PlayerAction.Block => "Blockera",
                PlayerAction.Shotgun => "Shotgun"

            };

            string result = $"Spelare: {swedishPlayerAction}, Bot: {swedishBotAction}\n\n";

            //Lite fler texter för flesta scenarionen samt att kunna avgöra när spelet är över
            if (playerAction == PlayerAction.Shoot && botAction == PlayerAction.Shoot)
            {
                result += "Båda skjuter!\nBåda förlorar ett skott.";
            }
            else if (playerAction == PlayerAction.Shoot && botAction == PlayerAction.Block)
            {
                result += "Bot blockerar skottet!\nSpelare förlorar ett skott";
            }
            else if (playerAction == PlayerAction.Shoot && botAction == PlayerAction.Reload)
            {
                result += "Spelare skjuter Bot!\nSpelare vinner!";
            }
            else if (playerAction == PlayerAction.Reload && botAction == PlayerAction.Shoot)
            {
                result += "Bot skjuter spelare!\nBot vinner!";
            }
            else if (playerAction == PlayerAction.Reload && botAction == PlayerAction.Reload)
            {
                result += "Båda väljer att ladda.";
            }
            else if (playerAction == PlayerAction.Block && botAction == PlayerAction.Block)
            {
                result += "Båda blockerar.";
            }
            else if (playerAction == PlayerAction.Shotgun && botAction == PlayerAction.Shotgun)
            {
                result += "Båda väljer shotgun!\nVi har ingen vinnare!";
            }
            else if (playerAction == PlayerAction.Shotgun)
            {
                result += "Spelare använder shotgun!\nSpelare vinner!";
            }
            else if (botAction == PlayerAction.Shotgun)
            {
                result += "Bot använder shotgun!\nBot vinner!";
            }

            return result;
        }

        //metod bool som kollar om texten innehåller vinner eller vinnare
        public bool IsGameOver(string result)
        {
            if (result.Contains("vinner") || result.Contains("vinnare"))
            {
                return true;
            }
            return false;
        }


    }
}
