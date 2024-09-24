using WinFormsShotgunGame.Classes;

namespace WinFormsShotgunGame
{
    public partial class FormShotgunGame : Form
    {
        //deklarer en ShotgunGameLogic class som är i scope för eventens/metoderna
        public ShotgunGameLogic Logic;
        public string result;
        // I samband med att formen startar så initeras objectet ShotgunGameLogic och ui:n uppdateras.
        public FormShotgunGame()
        {
            InitializeComponent();
            Logic = new ShotgunGameLogic();
            UpdateUI();
        }

        //Logiken för att uppdera ui är att alltid visa senaste bullet count för spelare och dator
        // samt disable knapparna som skjuta och shotgun om man inte har tillräcklig många skott.
        public void UpdateUI()
        {
            labelPlayerBullets.Text = $"Spelare, Antal skott: {Logic.Player.Bullets}";
            labelBotBullets.Text = $"Bot, Antal skott: {Logic.Bot.Bullets}";
            buttonShotgun.Enabled = Logic.CanShotgun();
            buttonShoot.Enabled = Logic.PlayerCheckBullets();
        }

        //Logik för att visa information om rundan samt fråga om man vill spela igen.
        public void ShowResult(string result)
        {
            labelGameStatus.Text = result;
            UpdateUI();

            if (Logic.GameOver)
            {
                DialogResult dialogResult = MessageBox.Show("Spela igen?", "Rundan är över", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Logic = new ShotgunGameLogic();
                    UpdateUI();
                    labelGameStatus.Text = "Välj ditt drag.";
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            result = Logic.Turn(PlayerAction.Shoot);
            ShowResult(result);
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            result = Logic.Turn(PlayerAction.Reload);
            ShowResult(result);
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            result = Logic.Turn(PlayerAction.Block);
            ShowResult(result);
        }

        private void buttonShotgun_Click(object sender, EventArgs e)
        {
            result = Logic.Turn(PlayerAction.Shotgun);
            ShowResult(result);
        }

        private void buttonGameRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Varje spelare börjar utan skott, och för att få fler skott måste du “Ladda”. " +
                "Varje gång du laddar får du ett nytt skott. Skjuta mot Skjuta resulterar i att båda spelarna förlorar" +
                "ett skott, men ingen vinner. Då en spelare samlat på sig tre skott kan denne använda sig av" +
                "\"Shotgun\", vilket vinner även om motspelaren \"blockar\" eller \"skjuter\"." +
                "\n\nLadda mot ladda: Båda spelarna får ett skott.\n" +
                "Ladda mot blocka: Spelaren som laddar får ett skott.\n" +
                "Blocka mot blocka: Ingenting händer.\n" +
                "Skjuta mot blocka: Spelaren som skjuter förlorar ett skott.\n" +
                "Skjuta mot skjuta: Båda spelarna förlorar ett skott.\n" +
                "Skjuta mot ladda: Spelaren som skjuter vinner spelet.\n");

        }
    }
}
