using WinFormsShotgunGame.Classes;

namespace WinFormsShotgunGame
{
    public partial class FormShotgunGame : Form
    {
        //deklarer en ShotgunGameLogic class som �r i scope f�r eventens/metoderna
        public ShotgunGameLogic Logic;
        public string result;
        // I samband med att formen startar s� initeras objectet ShotgunGameLogic och ui:n uppdateras.
        public FormShotgunGame()
        {
            InitializeComponent();
            Logic = new ShotgunGameLogic();
            UpdateUI();
        }

        //Logiken f�r att uppdera ui �r att alltid visa senaste bullet count f�r spelare och dator
        // samt disable knapparna som skjuta och shotgun om man inte har tillr�cklig m�nga skott.
        public void UpdateUI()
        {
            labelPlayerBullets.Text = $"Spelare, Antal skott: {Logic.Player.Bullets}";
            labelBotBullets.Text = $"Bot, Antal skott: {Logic.Bot.Bullets}";
            buttonShotgun.Enabled = Logic.CanShotgun();
            buttonShoot.Enabled = Logic.PlayerCheckBullets();
        }

        //Logik f�r att visa information om rundan samt fr�ga om man vill spela igen.
        public void ShowResult(string result)
        {
            labelGameStatus.Text = result;
            UpdateUI();

            if (Logic.GameOver)
            {
                DialogResult dialogResult = MessageBox.Show("Spela igen?", "Rundan �r �ver", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Logic = new ShotgunGameLogic();
                    UpdateUI();
                    labelGameStatus.Text = "V�lj ditt drag.";
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
            MessageBox.Show("Varje spelare b�rjar utan skott, och f�r att f� fler skott m�ste du �Ladda�. " +
                "Varje g�ng du laddar f�r du ett nytt skott. Skjuta mot Skjuta resulterar i att b�da spelarna f�rlorar" +
                "ett skott, men ingen vinner. D� en spelare samlat p� sig tre skott kan denne anv�nda sig av" +
                "\"Shotgun\", vilket vinner �ven om motspelaren \"blockar\" eller \"skjuter\"." +
                "\n\nLadda mot ladda: B�da spelarna f�r ett skott.\n" +
                "Ladda mot blocka: Spelaren som laddar f�r ett skott.\n" +
                "Blocka mot blocka: Ingenting h�nder.\n" +
                "Skjuta mot blocka: Spelaren som skjuter f�rlorar ett skott.\n" +
                "Skjuta mot skjuta: B�da spelarna f�rlorar ett skott.\n" +
                "Skjuta mot ladda: Spelaren som skjuter vinner spelet.\n");

        }
    }
}
