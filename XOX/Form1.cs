using System.Drawing.Text;

namespace XOX
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turnCount = 0;
        private Panel[,] panels;
        string plus = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\image\plus.png";
        string circle = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\image\circler.png";


        public Form1()
        {
            InitializeComponent();
            panels = new Panel[,] { { panel1, panel2, panel3 }, { panel4, panel5, panel6 }, { panel7, panel8, panel9 } };
        }

        private void panel_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            turn = !turn;
            if (turn)
            {
                panel.BackgroundImage = Image.FromFile(plus);
                panel.Tag = "X";
            }
            else
            {
                panel.BackgroundImage= Image.FromFile(circle);
                panel.Tag = "O";
            }
            panel.Enabled = false;
            turnCount++;
            if (panel.Enabled == false)
            {
                panel.BackColor = Color.White;
            }


            if (CheckForWinner())
            {
                string winner = turn ? "X" : "O";
                MessageBox.Show("Игрок за " + winner + " побеждает!", "Поздравляю!");

            }
            else
            {
                if (turnCount == 9)
                {
                    MessageBox.Show("Это ничья!", "Игра окончена");
                }
            }
        }

        private bool CheckForWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (panels[i, 0].Tag == panels[i, 1].Tag && panels[i, 1].Tag == panels[i, 2].Tag && panels[i, 0].Tag != null)
                {
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (panels[0, i].Tag == panels[1, i].Tag && panels[1, i].Tag == panels[2, i].Tag && panels[0, i].Tag != null)
                {
                    return true;
                }
            }
            if (panels[0, 0].Tag == panels[1, 1].Tag && panels[1, 1].Tag == panels[2, 2].Tag && panels[0, 0].Tag != null)
            {
                return true;
            }

            if (panels[2, 0].Tag == panels[1, 1].Tag && panels[1, 1].Tag == panels[0, 2].Tag && panels[2, 0].Tag != null)
            {
                return true;
            }
            return false;

            
        }

        private void DisablePanels()
        {
            foreach (Control control in Controls)
            {
                if (control is Panel)
                {
                    control.Enabled = false;
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;
            foreach (Control control in Controls)
            {
                if (control is Panel)
                {
                    control.Enabled = true;
                    control.Text = "";
                }
            }
        }

        private void Restart(object sender, EventArgs e)
        {
            foreach (Panel panel in panels)
            {
                panel.BackgroundImage = null;
                panel.Tag = null;
                panel.BackColor = SystemColors.ButtonShadow;
                panel.Enabled = true;
            }

            turn = true;
            turnCount = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
            foreach (Panel panel in panels)
            {
                panel.BackgroundImage = null;
                panel.BackColor = SystemColors.ButtonShadow;
                panel.Enabled = true;
                panel.Tag = null;
            }

            turn = true;
            turnCount = 0;
        }
    }
}
