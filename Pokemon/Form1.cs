using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void attackMenu_Click(object sender, EventArgs e)
        {
            fightPanel.Visible = !fightPanel.Visible;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void update(Pokemon friendly, Pokemon enemy)
        {
            try
            {
                friendlyName.Text = friendly.name;
                enemyName.Text = enemy.name;

                friendlyHp.Maximum = friendly.hp;
                friendlyHp.Value = friendly.hp;
                friendlyHpLabel.Text = friendly.hp.ToString() + " / " + friendlyHp.Maximum.ToString();
                friendlyPicture.Image = Image.FromFile("../../Sprites/" + friendly.name + "Back.png");


                enemyHp.Maximum = enemy.hp;
                enemyHp.Value = enemy.hp;
                enemyHpLabel.Text = enemy.hp.ToString() + " / " + enemyHp.Maximum.ToString();
                enemyPicture.Image = Image.FromFile("../../Sprites/" + enemy.name + ".png");

                for (int i = 0; i < friendly.Attacks.Length; i++)
                {
                    Button btn = this.Controls.Find("attack" + (i + 1), true).FirstOrDefault() as Button;
                    if (btn != null)
                    {
                        btn.Text = friendly.Attacks[i].name;
                    }
                }
            } catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                startButton.Visible = false;
                Attacks[] GreninjaMoves = new Attacks[] {
                    new Attacks("Dark Pulse", "Dark", true, 80, 1, "none", 0),
                    new Attacks("Hypnosis", "Psychic", true, 80, 1, "none", 0),
                    new Attacks("Nasty Plot", "Dark", true, 80, 1, "none", 0),
                    new Attacks("Sludge Bomb", "Poison", true, 80, 1, "none", 0),
                };

                Attacks[] BreloomMoves = new Attacks[] {
                    new Attacks("Substitute", "Normal", false, 0, 1, "none", 0),
                    new Attacks("Spore", "Grass", true, 0, 1, "none", 0),
                    new Attacks("Leech Seed", "Dark", true, 80, 1, "none", 0),
                    new Attacks("Focus Punch", "Fighting", true, 80, 1, "none", 0),
                };

                Pokemon friendly = new Pokemon(70, "Greninja", new string[] { "Dark" }, 84, new int[] { 4, }, GreninjaMoves, 90, 90, 135, 90, 125, 0);
                Pokemon enemy = new Pokemon(60, "Breloom", new string[] { "Grass", "Fighting" }, 84, new int[] { 4, }, BreloomMoves, 130, 80, 60, 60, 70, 0);
                update(friendly, enemy);
            } catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void attack1_Click(object sender, EventArgs e)
        {

        }
    }
}
