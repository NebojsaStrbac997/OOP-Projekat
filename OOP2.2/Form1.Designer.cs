namespace OOP2._2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputPlayerName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonWarrior = new System.Windows.Forms.Button();
            this.buttonMage = new System.Windows.Forms.Button();
            this.buttonPaladin = new System.Windows.Forms.Button();
            this.LabelPlayer = new System.Windows.Forms.Label();
            this.PHealth = new System.Windows.Forms.ProgressBar();
            this.PMana = new System.Windows.Forms.ProgressBar();
            this.groupStats = new System.Windows.Forms.GroupBox();
            this.LabelXp = new System.Windows.Forms.Label();
            this.LabelHP = new System.Windows.Forms.Label();
            this.LabelArmorVal = new System.Windows.Forms.Label();
            this.LabelDmgVal = new System.Windows.Forms.Label();
            this.LabelArmorValue = new System.Windows.Forms.Label();
            this.LabelDMGValue = new System.Windows.Forms.Label();
            this.LabelArmor = new System.Windows.Forms.Label();
            this.LabelDmg = new System.Windows.Forms.Label();
            this.LabelClass = new System.Windows.Forms.Label();
            this.BSubmit = new System.Windows.Forms.Button();
            this.groupName = new System.Windows.Forms.GroupBox();
            this.groupSelectClass = new System.Windows.Forms.GroupBox();
            this.PMob = new System.Windows.Forms.ProgressBar();
            this.groupHeroUI = new System.Windows.Forms.GroupBox();
            this.buttonHeroAbility = new System.Windows.Forms.Button();
            this.buttonPotion = new System.Windows.Forms.Button();
            this.buttonRetreat = new System.Windows.Forms.Button();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.buttonEnterWorld = new System.Windows.Forms.Button();
            this.groupMobStats = new System.Windows.Forms.GroupBox();
            this.LabelMobDmgVal = new System.Windows.Forms.Label();
            this.LabelMobDmg = new System.Windows.Forms.Label();
            this.LabelMobRace = new System.Windows.Forms.Label();
            this.LabelMobName = new System.Windows.Forms.Label();
            this.buttonLoot = new System.Windows.Forms.Button();
            this.groupLootWin = new System.Windows.Forms.GroupBox();
            this.LabelArmL = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.labelQuit = new System.Windows.Forms.Label();
            this.groupQuit = new System.Windows.Forms.GroupBox();
            this.groupStats.SuspendLayout();
            this.groupName.SuspendLayout();
            this.groupSelectClass.SuspendLayout();
            this.groupHeroUI.SuspendLayout();
            this.groupMobStats.SuspendLayout();
            this.groupLootWin.SuspendLayout();
            this.groupQuit.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputPlayerName
            // 
            this.InputPlayerName.Location = new System.Drawing.Point(6, 30);
            this.InputPlayerName.Name = "InputPlayerName";
            this.InputPlayerName.Size = new System.Drawing.Size(100, 20);
            this.InputPlayerName.TabIndex = 0;
            this.InputPlayerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(12, 14);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(87, 13);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Enter your name:";
            this.LabelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose your class:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonWarrior
            // 
            this.buttonWarrior.Location = new System.Drawing.Point(15, 44);
            this.buttonWarrior.Name = "buttonWarrior";
            this.buttonWarrior.Size = new System.Drawing.Size(75, 23);
            this.buttonWarrior.TabIndex = 3;
            this.buttonWarrior.Text = "Warrior";
            this.buttonWarrior.UseVisualStyleBackColor = true;
            this.buttonWarrior.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMage
            // 
            this.buttonMage.Location = new System.Drawing.Point(15, 73);
            this.buttonMage.Name = "buttonMage";
            this.buttonMage.Size = new System.Drawing.Size(75, 23);
            this.buttonMage.TabIndex = 4;
            this.buttonMage.Text = "Mage";
            this.buttonMage.UseVisualStyleBackColor = true;
            this.buttonMage.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPaladin
            // 
            this.buttonPaladin.Location = new System.Drawing.Point(15, 102);
            this.buttonPaladin.Name = "buttonPaladin";
            this.buttonPaladin.Size = new System.Drawing.Size(75, 23);
            this.buttonPaladin.TabIndex = 5;
            this.buttonPaladin.Text = "Paladin";
            this.buttonPaladin.UseVisualStyleBackColor = true;
            this.buttonPaladin.Click += new System.EventHandler(this.button3_Click);
            // 
            // LabelPlayer
            // 
            this.LabelPlayer.AutoSize = true;
            this.LabelPlayer.Location = new System.Drawing.Point(0, 16);
            this.LabelPlayer.Name = "LabelPlayer";
            this.LabelPlayer.Size = new System.Drawing.Size(64, 13);
            this.LabelPlayer.TabIndex = 6;
            this.LabelPlayer.Text = "PlayerName";
            this.LabelPlayer.Click += new System.EventHandler(this.LabelPlayer_Click);
            // 
            // PHealth
            // 
            this.PHealth.Location = new System.Drawing.Point(0, 77);
            this.PHealth.Name = "PHealth";
            this.PHealth.Size = new System.Drawing.Size(127, 23);
            this.PHealth.TabIndex = 7;
            this.PHealth.Value = 100;
            // 
            // PMana
            // 
            this.PMana.BackColor = System.Drawing.SystemColors.Control;
            this.PMana.Location = new System.Drawing.Point(0, 123);
            this.PMana.Name = "PMana";
            this.PMana.Size = new System.Drawing.Size(127, 23);
            this.PMana.TabIndex = 8;
            this.PMana.Value = 100;
            // 
            // groupStats
            // 
            this.groupStats.Controls.Add(this.LabelXp);
            this.groupStats.Controls.Add(this.LabelHP);
            this.groupStats.Controls.Add(this.LabelArmorVal);
            this.groupStats.Controls.Add(this.LabelDmgVal);
            this.groupStats.Controls.Add(this.LabelArmorValue);
            this.groupStats.Controls.Add(this.LabelDMGValue);
            this.groupStats.Controls.Add(this.LabelArmor);
            this.groupStats.Controls.Add(this.LabelDmg);
            this.groupStats.Controls.Add(this.LabelClass);
            this.groupStats.Controls.Add(this.PHealth);
            this.groupStats.Controls.Add(this.LabelPlayer);
            this.groupStats.Controls.Add(this.PMana);
            this.groupStats.Location = new System.Drawing.Point(12, 12);
            this.groupStats.Name = "groupStats";
            this.groupStats.Size = new System.Drawing.Size(155, 220);
            this.groupStats.TabIndex = 9;
            this.groupStats.TabStop = false;
            this.groupStats.Visible = false;
            this.groupStats.Enter += new System.EventHandler(this.groupStats_Enter);
            // 
            // LabelXp
            // 
            this.LabelXp.AutoSize = true;
            this.LabelXp.Location = new System.Drawing.Point(1, 107);
            this.LabelXp.Name = "LabelXp";
            this.LabelXp.Size = new System.Drawing.Size(37, 13);
            this.LabelXp.TabIndex = 17;
            this.LabelXp.Text = "Mana:";
            // 
            // LabelHP
            // 
            this.LabelHP.AutoSize = true;
            this.LabelHP.Location = new System.Drawing.Point(1, 61);
            this.LabelHP.Name = "LabelHP";
            this.LabelHP.Size = new System.Drawing.Size(41, 13);
            this.LabelHP.TabIndex = 16;
            this.LabelHP.Text = "Health:";
            // 
            // LabelArmorVal
            // 
            this.LabelArmorVal.AutoSize = true;
            this.LabelArmorVal.Location = new System.Drawing.Point(45, 171);
            this.LabelArmorVal.Name = "LabelArmorVal";
            this.LabelArmorVal.Size = new System.Drawing.Size(13, 13);
            this.LabelArmorVal.TabIndex = 15;
            this.LabelArmorVal.Text = "3";
            // 
            // LabelDmgVal
            // 
            this.LabelDmgVal.AutoSize = true;
            this.LabelDmgVal.Location = new System.Drawing.Point(45, 155);
            this.LabelDmgVal.Name = "LabelDmgVal";
            this.LabelDmgVal.Size = new System.Drawing.Size(19, 13);
            this.LabelDmgVal.TabIndex = 14;
            this.LabelDmgVal.Text = "10";
            // 
            // LabelArmorValue
            // 
            this.LabelArmorValue.AutoSize = true;
            this.LabelArmorValue.Location = new System.Drawing.Point(148, 41);
            this.LabelArmorValue.Name = "LabelArmorValue";
            this.LabelArmorValue.Size = new System.Drawing.Size(0, 13);
            this.LabelArmorValue.TabIndex = 13;
            // 
            // LabelDMGValue
            // 
            this.LabelDMGValue.AutoSize = true;
            this.LabelDMGValue.Location = new System.Drawing.Point(145, 16);
            this.LabelDMGValue.Name = "LabelDMGValue";
            this.LabelDMGValue.Size = new System.Drawing.Size(0, 13);
            this.LabelDMGValue.TabIndex = 12;
            // 
            // LabelArmor
            // 
            this.LabelArmor.AutoSize = true;
            this.LabelArmor.Location = new System.Drawing.Point(7, 171);
            this.LabelArmor.Name = "LabelArmor";
            this.LabelArmor.Size = new System.Drawing.Size(37, 13);
            this.LabelArmor.TabIndex = 11;
            this.LabelArmor.Text = "Armor:";
            // 
            // LabelDmg
            // 
            this.LabelDmg.AutoSize = true;
            this.LabelDmg.Location = new System.Drawing.Point(7, 155);
            this.LabelDmg.Name = "LabelDmg";
            this.LabelDmg.Size = new System.Drawing.Size(35, 13);
            this.LabelDmg.TabIndex = 10;
            this.LabelDmg.Text = "DMG:";
            // 
            // LabelClass
            // 
            this.LabelClass.AutoSize = true;
            this.LabelClass.Location = new System.Drawing.Point(65, 16);
            this.LabelClass.Name = "LabelClass";
            this.LabelClass.Size = new System.Drawing.Size(32, 13);
            this.LabelClass.TabIndex = 9;
            this.LabelClass.Text = "Class";
            // 
            // BSubmit
            // 
            this.BSubmit.Location = new System.Drawing.Point(15, 56);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(75, 23);
            this.BSubmit.TabIndex = 10;
            this.BSubmit.Text = "Submit";
            this.BSubmit.UseVisualStyleBackColor = true;
            this.BSubmit.Click += new System.EventHandler(this.BSubmit_Click);
            // 
            // groupName
            // 
            this.groupName.Controls.Add(this.InputPlayerName);
            this.groupName.Controls.Add(this.BSubmit);
            this.groupName.Controls.Add(this.LabelName);
            this.groupName.Location = new System.Drawing.Point(345, 153);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(113, 100);
            this.groupName.TabIndex = 11;
            this.groupName.TabStop = false;
            // 
            // groupSelectClass
            // 
            this.groupSelectClass.Controls.Add(this.label2);
            this.groupSelectClass.Controls.Add(this.buttonWarrior);
            this.groupSelectClass.Controls.Add(this.buttonMage);
            this.groupSelectClass.Controls.Add(this.buttonPaladin);
            this.groupSelectClass.Location = new System.Drawing.Point(345, 259);
            this.groupSelectClass.Name = "groupSelectClass";
            this.groupSelectClass.Size = new System.Drawing.Size(113, 148);
            this.groupSelectClass.TabIndex = 12;
            this.groupSelectClass.TabStop = false;
            this.groupSelectClass.Visible = false;
            // 
            // PMob
            // 
            this.PMob.Location = new System.Drawing.Point(6, 41);
            this.PMob.Name = "PMob";
            this.PMob.Size = new System.Drawing.Size(100, 23);
            this.PMob.TabIndex = 13;
            this.PMob.Value = 100;
            // 
            // groupHeroUI
            // 
            this.groupHeroUI.Controls.Add(this.buttonHeroAbility);
            this.groupHeroUI.Controls.Add(this.buttonPotion);
            this.groupHeroUI.Controls.Add(this.buttonRetreat);
            this.groupHeroUI.Controls.Add(this.buttonAttack);
            this.groupHeroUI.Location = new System.Drawing.Point(12, 243);
            this.groupHeroUI.Name = "groupHeroUI";
            this.groupHeroUI.Size = new System.Drawing.Size(207, 141);
            this.groupHeroUI.TabIndex = 14;
            this.groupHeroUI.TabStop = false;
            this.groupHeroUI.Visible = false;
            // 
            // buttonHeroAbility
            // 
            this.buttonHeroAbility.Location = new System.Drawing.Point(104, 11);
            this.buttonHeroAbility.Name = "buttonHeroAbility";
            this.buttonHeroAbility.Size = new System.Drawing.Size(97, 49);
            this.buttonHeroAbility.TabIndex = 3;
            this.buttonHeroAbility.Text = "Hero Ability";
            this.buttonHeroAbility.UseVisualStyleBackColor = true;
            this.buttonHeroAbility.Click += new System.EventHandler(this.buttonHeroAbility_Click);
            // 
            // buttonPotion
            // 
            this.buttonPotion.Location = new System.Drawing.Point(6, 66);
            this.buttonPotion.Name = "buttonPotion";
            this.buttonPotion.Size = new System.Drawing.Size(91, 46);
            this.buttonPotion.TabIndex = 2;
            this.buttonPotion.Text = "Drink potion";
            this.buttonPotion.UseVisualStyleBackColor = true;
            this.buttonPotion.Click += new System.EventHandler(this.buttonPotion_Click);
            // 
            // buttonRetreat
            // 
            this.buttonRetreat.Location = new System.Drawing.Point(104, 66);
            this.buttonRetreat.Name = "buttonRetreat";
            this.buttonRetreat.Size = new System.Drawing.Size(97, 46);
            this.buttonRetreat.TabIndex = 1;
            this.buttonRetreat.Text = "Retreat";
            this.buttonRetreat.UseVisualStyleBackColor = true;
            this.buttonRetreat.Click += new System.EventHandler(this.buttonRetreat_Click);
            // 
            // buttonAttack
            // 
            this.buttonAttack.Location = new System.Drawing.Point(6, 11);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(91, 49);
            this.buttonAttack.TabIndex = 0;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Visible = false;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // buttonEnterWorld
            // 
            this.buttonEnterWorld.Location = new System.Drawing.Point(360, 413);
            this.buttonEnterWorld.Name = "buttonEnterWorld";
            this.buttonEnterWorld.Size = new System.Drawing.Size(75, 23);
            this.buttonEnterWorld.TabIndex = 15;
            this.buttonEnterWorld.Text = "Enter world";
            this.buttonEnterWorld.UseVisualStyleBackColor = true;
            this.buttonEnterWorld.Click += new System.EventHandler(this.EnterWorld_Click);
            // 
            // groupMobStats
            // 
            this.groupMobStats.Controls.Add(this.LabelMobDmgVal);
            this.groupMobStats.Controls.Add(this.LabelMobDmg);
            this.groupMobStats.Controls.Add(this.LabelMobRace);
            this.groupMobStats.Controls.Add(this.LabelMobName);
            this.groupMobStats.Controls.Add(this.PMob);
            this.groupMobStats.Location = new System.Drawing.Point(588, 12);
            this.groupMobStats.Name = "groupMobStats";
            this.groupMobStats.Size = new System.Drawing.Size(200, 100);
            this.groupMobStats.TabIndex = 16;
            this.groupMobStats.TabStop = false;
            this.groupMobStats.Visible = false;
            // 
            // LabelMobDmgVal
            // 
            this.LabelMobDmgVal.AutoSize = true;
            this.LabelMobDmgVal.Location = new System.Drawing.Point(172, 41);
            this.LabelMobDmgVal.Name = "LabelMobDmgVal";
            this.LabelMobDmgVal.Size = new System.Drawing.Size(13, 13);
            this.LabelMobDmgVal.TabIndex = 17;
            this.LabelMobDmgVal.Text = "0";
            // 
            // LabelMobDmg
            // 
            this.LabelMobDmg.AutoSize = true;
            this.LabelMobDmg.Location = new System.Drawing.Point(112, 41);
            this.LabelMobDmg.Name = "LabelMobDmg";
            this.LabelMobDmg.Size = new System.Drawing.Size(35, 13);
            this.LabelMobDmg.TabIndex = 16;
            this.LabelMobDmg.Text = "DMG:";
            // 
            // LabelMobRace
            // 
            this.LabelMobRace.AutoSize = true;
            this.LabelMobRace.Location = new System.Drawing.Point(70, 16);
            this.LabelMobRace.Name = "LabelMobRace";
            this.LabelMobRace.Size = new System.Drawing.Size(54, 13);
            this.LabelMobRace.TabIndex = 15;
            this.LabelMobRace.Text = "MobRace";
            // 
            // LabelMobName
            // 
            this.LabelMobName.AutoSize = true;
            this.LabelMobName.Location = new System.Drawing.Point(7, 16);
            this.LabelMobName.Name = "LabelMobName";
            this.LabelMobName.Size = new System.Drawing.Size(56, 13);
            this.LabelMobName.TabIndex = 14;
            this.LabelMobName.Text = "MobName";
            // 
            // buttonLoot
            // 
            this.buttonLoot.Location = new System.Drawing.Point(6, 62);
            this.buttonLoot.Name = "buttonLoot";
            this.buttonLoot.Size = new System.Drawing.Size(75, 23);
            this.buttonLoot.TabIndex = 17;
            this.buttonLoot.Text = "Loot";
            this.buttonLoot.UseVisualStyleBackColor = true;
            this.buttonLoot.Click += new System.EventHandler(this.ButtonLoot_Click);
            // 
            // groupLootWin
            // 
            this.groupLootWin.Controls.Add(this.LabelArmL);
            this.groupLootWin.Controls.Add(this.buttonLoot);
            this.groupLootWin.Location = new System.Drawing.Point(710, 259);
            this.groupLootWin.Name = "groupLootWin";
            this.groupLootWin.Size = new System.Drawing.Size(78, 100);
            this.groupLootWin.TabIndex = 18;
            this.groupLootWin.TabStop = false;
            this.groupLootWin.Visible = false;
            // 
            // LabelArmL
            // 
            this.LabelArmL.AutoSize = true;
            this.LabelArmL.Location = new System.Drawing.Point(6, 16);
            this.LabelArmL.Name = "LabelArmL";
            this.LabelArmL.Size = new System.Drawing.Size(67, 13);
            this.LabelArmL.TabIndex = 18;
            this.LabelArmL.Text = "Heavy armor";
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(12, 54);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(75, 23);
            this.buttonYes.TabIndex = 19;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(110, 54);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 20;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // labelQuit
            // 
            this.labelQuit.AutoSize = true;
            this.labelQuit.Location = new System.Drawing.Point(42, 26);
            this.labelQuit.Name = "labelQuit";
            this.labelQuit.Size = new System.Drawing.Size(105, 13);
            this.labelQuit.TabIndex = 21;
            this.labelQuit.Text = "Do you want to quit?";
            // 
            // groupQuit
            // 
            this.groupQuit.Controls.Add(this.buttonYes);
            this.groupQuit.Controls.Add(this.labelQuit);
            this.groupQuit.Controls.Add(this.buttonNo);
            this.groupQuit.Location = new System.Drawing.Point(303, 47);
            this.groupQuit.Name = "groupQuit";
            this.groupQuit.Size = new System.Drawing.Size(200, 100);
            this.groupQuit.TabIndex = 22;
            this.groupQuit.TabStop = false;
            this.groupQuit.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupQuit);
            this.Controls.Add(this.groupLootWin);
            this.Controls.Add(this.groupMobStats);
            this.Controls.Add(this.buttonEnterWorld);
            this.Controls.Add(this.groupHeroUI);
            this.Controls.Add(this.groupSelectClass);
            this.Controls.Add(this.groupName);
            this.Controls.Add(this.groupStats);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupStats.ResumeLayout(false);
            this.groupStats.PerformLayout();
            this.groupName.ResumeLayout(false);
            this.groupName.PerformLayout();
            this.groupSelectClass.ResumeLayout(false);
            this.groupSelectClass.PerformLayout();
            this.groupHeroUI.ResumeLayout(false);
            this.groupMobStats.ResumeLayout(false);
            this.groupMobStats.PerformLayout();
            this.groupLootWin.ResumeLayout(false);
            this.groupLootWin.PerformLayout();
            this.groupQuit.ResumeLayout(false);
            this.groupQuit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox InputPlayerName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonWarrior;
        private System.Windows.Forms.Button buttonMage;
        private System.Windows.Forms.Button buttonPaladin;
        private System.Windows.Forms.Label LabelPlayer;
        private System.Windows.Forms.ProgressBar PHealth;
        private System.Windows.Forms.ProgressBar PMana;
        private System.Windows.Forms.GroupBox groupStats;
        private System.Windows.Forms.Label LabelClass;
        private System.Windows.Forms.Button BSubmit;
        private System.Windows.Forms.GroupBox groupName;
        private System.Windows.Forms.GroupBox groupSelectClass;
        private System.Windows.Forms.Label LabelDmg;
        private System.Windows.Forms.ProgressBar PMob;
        private System.Windows.Forms.GroupBox groupHeroUI;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button buttonEnterWorld;
        private System.Windows.Forms.GroupBox groupMobStats;
        private System.Windows.Forms.Label LabelMobDmg;
        private System.Windows.Forms.Label LabelMobRace;
        private System.Windows.Forms.Label LabelMobName;
        private System.Windows.Forms.Label LabelArmor;
        private System.Windows.Forms.Button buttonLoot;
        private System.Windows.Forms.Label LabelArmorValue;
        private System.Windows.Forms.Label LabelDMGValue;
        private System.Windows.Forms.Label LabelArmorVal;
        private System.Windows.Forms.Label LabelDmgVal;
        private System.Windows.Forms.GroupBox groupLootWin;
        private System.Windows.Forms.Label LabelArmL;
        private System.Windows.Forms.Label LabelMobDmgVal;
        private System.Windows.Forms.Label LabelXp;
        private System.Windows.Forms.Label LabelHP;
        private System.Windows.Forms.Button buttonHeroAbility;
        private System.Windows.Forms.Button buttonPotion;
        private System.Windows.Forms.Button buttonRetreat;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Label labelQuit;
        private System.Windows.Forms.GroupBox groupQuit;
    }
}

