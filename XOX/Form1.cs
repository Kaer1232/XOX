using System.Drawing.Text;

namespace XOX
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turnCount = 0;
        private Button[,] buttons;

        public Form1()
        {
            InitializeComponent();
            buttons = new Button[,] { { button1, button2, button3 }, { button4, button5, button6 }, { button7, button8, button9 } };
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
                button.Text = "X";
            else
                button.Text = "O";

            turn = !turn;
            button.Enabled = false;
            turnCount++;

            if (CheckForWinner())
            {
                string winner = turn ? "O" : "X";
                MessageBox.Show("Игрок за " + winner + " побеждает!", "Поздравляю!");
                DisableButtons();
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
                if (buttons[i, 0].Text == buttons[i, 1].Text && buttons[i, 1].Text == buttons[i, 2].Text && buttons[i, 0].Text != "")
                {
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (buttons[0, i].Text == buttons[1, i].Text && buttons[1, i].Text == buttons[2, i].Text && buttons[0, i].Text != "")
                {
                    return true;
                }
            }
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text && buttons[0, 0].Text != "")
            {
                return true;
            }

            if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[0, 2].Text && buttons[2, 0].Text != "")
            {
                return true;
            }

            return false;
        }

        private void DisableButtons()
        {
            foreach (Control control in Controls)
            {
                if (control is Button)
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
                if (control is Button)
                {
                    control.Enabled = true;
                    control.Text = "";
                }
            }
        }

        private void Restart(object sender, EventArgs e)
        {
            foreach (Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
            }

            turn = true;
            turnCount = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
