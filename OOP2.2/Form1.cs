using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        Heroj heroj;
        Mob mob = new Mob("Pillager", 50,5);
        Mob mob1 = new Mob("Footman",100,10);
        Armor noarmor = new Armor(0, "No armor");
        Armor lightArmor = new Armor(3,"Light armor");
        Armor heavyArmor = new Armor(5,"Heavy armor");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupSelectClass.Visible = false;
            LabelClass.Text = buttonWarrior.Text;
            groupStats.Visible = true;
            heroj = new Heroj(LabelPlayer.Text, PHealth.Value, PMana.Value, 10,LabelClass.Text,lightArmor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupSelectClass.Visible = false;
            LabelClass.Text = buttonMage.Text;
            groupStats.Visible = true;
            heroj = new Heroj(LabelPlayer.Text,PHealth.Value, PMana.Value, 10, LabelClass.Text,lightArmor);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupSelectClass.Visible = false;
            LabelClass.Text = buttonPaladin.Text;
            groupStats.Visible = true;
            heroj = new Heroj(LabelPlayer.Text,PHealth.Value, PMana.Value, 10, LabelClass.Text,lightArmor);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LabelPlayer_Click(object sender, EventArgs e)
        {

        }

        private void BSubmit_Click(object sender, EventArgs e)
        {
            LabelPlayer.Text = InputPlayerName.Text;
            groupName.Visible = false;
            groupSelectClass.Visible = true;

            
        }
        

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            if (PMob.Value!= 0)
            {
                heroj.attack(heroj.getsetDmg, PMob,noarmor);
            }
            else if (PMob.Value == 0)
            {
                groupMobStats.Visible = false;
                groupLootWin.Visible = true;
                groupHeroUI.Visible = false;
            }
            mob.attack(mob.getsetDmg, PHealth,heroj.getsetHerojArmor);

            
        }

        private void EnterWorld_Click(object sender, EventArgs e)
        {
            buttonEnterWorld.Visible = false;
            groupMobStats.Visible = true;
            PMob.Value = mob.getsetHp;
            LabelMobDmgVal.Text = mob.getsetDmg.ToString();
            buttonAttack.Visible = true;
            groupHeroUI.Visible = true;
            if (LabelClass.Text == "Warrior")
            {
                buttonHeroAbility.Text = "Herioc Strike";
            }
            else if (LabelClass.Text == "Mage")
            {
                buttonHeroAbility.Text = "Conjure Potion";
            }
            else if(LabelClass.Text == "Paladin")
            {
                buttonHeroAbility.Text = "Holy light";
            }
            buttonHeroAbility.Visible = true;
        }

        private void groupStats_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonLoot_Click(object sender, EventArgs e)
        {
            groupLootWin.Visible = false;
            heroj.getsetHerojArmor = heavyArmor;
            LabelArmorVal.Text = heroj.getsetHerojArmor.getResistance.ToString();
            if (PMob.Value < 100)
            {  
               mob.getsetHp = mob.getsetHp + 10;
            }
            else
            {
                mob.getsetHp = 100;
            }
            groupMobStats.Visible = true;
            PMob.Value = mob1.getsetHp;
            LabelMobDmgVal.Text = mob1.getsetDmg.ToString();
            groupHeroUI.Visible = true;
            buttonHeroAbility.Visible = true;
        }

        private void buttonRetreat_Click(object sender, EventArgs e)
        {
            groupHeroUI.Visible = false;
            buttonHeroAbility.Visible = false;
            groupMobStats.Visible = false;
            buttonAttack.Visible = false;
            if (PHealth.Value<80) 
            {
                PHealth.Value += 20;
            }
            else if (PHealth.Value>=80) 
            {
                PHealth.Value = 100;
            }
            if (PMana.Value < 80) 
            {
                PMana.Value += 20;
            }
            else if (PMana.Value >= 80)
            {
                PMana.Value = 100;
            }
            buttonEnterWorld.Visible = true;
            buttonPotion.Visible = true;
            groupQuit.Visible = true;
        }

        private void buttonHeroAbility_Click(object sender, EventArgs e)
        {
            buttonHeroAbility.Visible=false;
            if(LabelClass.Text=="Warrior")
            {
                heroj.attack(heroj.getsetDmg, PMob,noarmor);
                PMana.Value -= 20;

            }
            else if (LabelClass.Text == "Mage")
            {
                buttonPotion.Visible = true;
                PMana.Value -= 25;
            }
            else
            {
                PHealth.Value = 100;
                PMana.Value -= 50;

            }
        }

        private void buttonPotion_Click(object sender, EventArgs e)
        {
            buttonPotion.Visible = false;
            if(PHealth.Value >= 80)
            {
                PHealth.Value = 100;
            }
            else
            {
                PHealth.Value += 20;
            }
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            groupQuit.Visible = false;
        }
    }
}
