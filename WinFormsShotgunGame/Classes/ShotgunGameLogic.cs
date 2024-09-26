namespace WinFormsShotgunGame.Classes
{
    public class ShotgunGameLogic
    {
        public Player Player { get; private set; }
        public Bot Bot { get; private set; }
        public bool GameOver { get; private set; }
       
        public ShotgunGameLogic()
        {
            Player = new Player();
            Bot = new Bot();
            GameOver = false;
            
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

        //Check för att kolla om Shotgun knappen ska enablas
        public bool CanShotgun()
        {
            if (Player.Bullets >= 3)
            {
                return true;
            }
            return false;
        }

        public string Outcome(PlayerAction playerAction)
        {
            PlayerAction botAction = Bot.BotChosenAction(Player);//Viktigt att ha denna logik först så att spelarens antal skott räknas in korrekt
            Player.PlayerChosenAction(playerAction);

            string playerActionTranslate = Translate(playerAction);
            string botActionTranslate = Translate(botAction);
            string result = $"Spelare: {playerActionTranslate}, Bot: {botActionTranslate}\n\n";

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
                GameOver = true;
            }
            else if (playerAction == PlayerAction.Reload && botAction == PlayerAction.Shoot)
            {
                result += "Bot skjuter spelare!\nBot vinner!";
                GameOver = true;
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
                GameOver = true;
            }
            else if (playerAction == PlayerAction.Shotgun)
            {
                result += "Spelare använder shotgun!\nSpelare vinner!";
                GameOver = true;
            }
            else if (botAction == PlayerAction.Shotgun)
            {
                result += "Bot använder shotgun!\nBot vinner!";
                GameOver = true;
            }
            
            return result;
        }


        //method med switch expressions för att får enumsen att skriva ut de texterna jag vill
        private string Translate(PlayerAction action)
        {
            return action switch
            {
                PlayerAction.Reload => "Ladda",
                PlayerAction.Shoot => "Skjut",
                PlayerAction.Block => "Blocka",
                PlayerAction.Shotgun => "Shotgun"
            };
        }
    }
}
