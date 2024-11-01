namespace ScoreCalculation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            LblScore = new Label();
            groupBox1 = new GroupBox();
            LblDate = new Label();
            LblHour = new Label();
            groupBoxInformations = new GroupBox();
            TxtFName = new TextBox();
            TxtLName = new TextBox();
            LblFName = new Label();
            LblLName = new Label();
            LblTel = new Label();
            TxtTel = new TextBox();
            TxtNIC = new TextBox();
            LblCIN = new Label();
            groupBoxMarks = new GroupBox();
            TxtTech = new TextBox();
            TxtLang = new TextBox();
            LblTech = new Label();
            LblLang = new Label();
            groupBoxGender = new GroupBox();
            RdFem = new RadioButton();
            RdMas = new RadioButton();
            groupBoxBonus = new GroupBox();
            ChkDip = new CheckBox();
            ChkMotiv = new CheckBox();
            ChkExper = new CheckBox();
            LblAge = new Label();
            CmbAge = new ComboBox();
            LblCh = new Label();
            TxtChance = new TextBox();
            BtnCh = new Button();
            BtnIni = new Button();
            groupBoxButtons = new GroupBox();
            BtnEx = new Button();
            BtnAdd = new Button();
            BtnCalc = new Button();
            LblSc = new Label();
            TxtScore = new TextBox();
            groupBoxList = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Lst4 = new ListBox();
            Lst3 = new ListBox();
            Lst2 = new ListBox();
            Lst1 = new ListBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBoxInformations.SuspendLayout();
            groupBoxMarks.SuspendLayout();
            groupBoxGender.SuspendLayout();
            groupBoxBonus.SuspendLayout();
            groupBoxButtons.SuspendLayout();
            groupBoxList.SuspendLayout();
            SuspendLayout();
            // 
            // LblScore
            // 
            LblScore.AutoSize = true;
            LblScore.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblScore.Location = new Point(22, 30);
            LblScore.Name = "LblScore";
            LblScore.Size = new Size(183, 30);
            LblScore.TabIndex = 0;
            LblScore.Text = "Score Calculation";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblDate);
            groupBox1.Controls.Add(LblHour);
            groupBox1.Location = new Point(491, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(466, 44);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // LblDate
            // 
            LblDate.AutoSize = true;
            LblDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDate.Location = new Point(199, 19);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(38, 17);
            LblDate.TabIndex = 1;
            LblDate.Text = "Date:";
            // 
            // LblHour
            // 
            LblHour.AutoSize = true;
            LblHour.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblHour.Location = new Point(33, 19);
            LblHour.Name = "LblHour";
            LblHour.Size = new Size(40, 17);
            LblHour.TabIndex = 0;
            LblHour.Text = "Hour:";
            // 
            // groupBoxInformations
            // 
            groupBoxInformations.Controls.Add(TxtFName);
            groupBoxInformations.Controls.Add(TxtLName);
            groupBoxInformations.Controls.Add(LblFName);
            groupBoxInformations.Controls.Add(LblLName);
            groupBoxInformations.Controls.Add(LblTel);
            groupBoxInformations.Controls.Add(TxtTel);
            groupBoxInformations.Controls.Add(TxtNIC);
            groupBoxInformations.Controls.Add(LblCIN);
            groupBoxInformations.Location = new Point(22, 94);
            groupBoxInformations.Name = "groupBoxInformations";
            groupBoxInformations.Size = new Size(935, 95);
            groupBoxInformations.TabIndex = 2;
            groupBoxInformations.TabStop = false;
            groupBoxInformations.Text = "Informations";
            // 
            // TxtFName
            // 
            TxtFName.Location = new Point(657, 54);
            TxtFName.Name = "TxtFName";
            TxtFName.Size = new Size(236, 23);
            TxtFName.TabIndex = 7;
            // 
            // TxtLName
            // 
            TxtLName.Location = new Point(657, 25);
            TxtLName.Name = "TxtLName";
            TxtLName.Size = new Size(236, 23);
            TxtLName.TabIndex = 6;
            // 
            // LblFName
            // 
            LblFName.AutoSize = true;
            LblFName.Location = new Point(556, 60);
            LblFName.Name = "LblFName";
            LblFName.Size = new Size(67, 15);
            LblFName.TabIndex = 5;
            LblFName.Text = "First Name:";
            // 
            // LblLName
            // 
            LblLName.AutoSize = true;
            LblLName.Location = new Point(556, 25);
            LblLName.Name = "LblLName";
            LblLName.Size = new Size(66, 15);
            LblLName.TabIndex = 4;
            LblLName.Text = "Last Name:";
            // 
            // LblTel
            // 
            LblTel.AutoSize = true;
            LblTel.Location = new Point(36, 60);
            LblTel.Name = "LblTel";
            LblTel.Size = new Size(24, 15);
            LblTel.TabIndex = 3;
            LblTel.Text = "Tel:";
            // 
            // TxtTel
            // 
            TxtTel.Location = new Point(66, 57);
            TxtTel.Name = "TxtTel";
            TxtTel.Size = new Size(236, 23);
            TxtTel.TabIndex = 2;
            // 
            // TxtNIC
            // 
            TxtNIC.Location = new Point(66, 22);
            TxtNIC.MaxLength = 8;
            TxtNIC.Name = "TxtNIC";
            TxtNIC.Size = new Size(236, 23);
            TxtNIC.TabIndex = 1;
            // 
            // LblCIN
            // 
            LblCIN.AutoSize = true;
            LblCIN.Location = new Point(30, 25);
            LblCIN.Name = "LblCIN";
            LblCIN.Size = new Size(30, 15);
            LblCIN.TabIndex = 0;
            LblCIN.Text = "NIC:";
            // 
            // groupBoxMarks
            // 
            groupBoxMarks.Controls.Add(TxtTech);
            groupBoxMarks.Controls.Add(TxtLang);
            groupBoxMarks.Controls.Add(LblTech);
            groupBoxMarks.Controls.Add(LblLang);
            groupBoxMarks.Location = new Point(22, 209);
            groupBoxMarks.Name = "groupBoxMarks";
            groupBoxMarks.Size = new Size(322, 91);
            groupBoxMarks.TabIndex = 3;
            groupBoxMarks.TabStop = false;
            groupBoxMarks.Text = "Marks";
            // 
            // TxtTech
            // 
            TxtTech.Location = new Point(171, 55);
            TxtTech.Name = "TxtTech";
            TxtTech.Size = new Size(100, 23);
            TxtTech.TabIndex = 3;
            TxtTech.Text = "0";
            // 
            // TxtLang
            // 
            TxtLang.Location = new Point(171, 26);
            TxtLang.Name = "TxtLang";
            TxtLang.Size = new Size(100, 23);
            TxtLang.TabIndex = 2;
            TxtLang.Text = "0";
            // 
            // LblTech
            // 
            LblTech.AutoSize = true;
            LblTech.Location = new Point(18, 60);
            LblTech.Name = "LblTech";
            LblTech.Size = new Size(61, 15);
            LblTech.TabIndex = 1;
            LblTech.Text = "Technique";
            // 
            // LblLang
            // 
            LblLang.AutoSize = true;
            LblLang.Location = new Point(18, 34);
            LblLang.Name = "LblLang";
            LblLang.Size = new Size(59, 15);
            LblLang.TabIndex = 0;
            LblLang.Text = "Language";
            // 
            // groupBoxGender
            // 
            groupBoxGender.Controls.Add(RdFem);
            groupBoxGender.Controls.Add(RdMas);
            groupBoxGender.Location = new Point(654, 209);
            groupBoxGender.Name = "groupBoxGender";
            groupBoxGender.Size = new Size(303, 91);
            groupBoxGender.TabIndex = 4;
            groupBoxGender.TabStop = false;
            groupBoxGender.Text = "Gender";
            // 
            // RdFem
            // 
            RdFem.AutoSize = true;
            RdFem.Location = new Point(57, 59);
            RdFem.Name = "RdFem";
            RdFem.Size = new Size(74, 19);
            RdFem.TabIndex = 1;
            RdFem.TabStop = true;
            RdFem.Text = "Feminine";
            RdFem.UseVisualStyleBackColor = true;
            // 
            // RdMas
            // 
            RdMas.AutoSize = true;
            RdMas.Location = new Point(57, 36);
            RdMas.Name = "RdMas";
            RdMas.Size = new Size(73, 19);
            RdMas.TabIndex = 0;
            RdMas.TabStop = true;
            RdMas.Text = "Masculin";
            RdMas.UseVisualStyleBackColor = true;
            // 
            // groupBoxBonus
            // 
            groupBoxBonus.Controls.Add(ChkDip);
            groupBoxBonus.Controls.Add(ChkMotiv);
            groupBoxBonus.Controls.Add(ChkExper);
            groupBoxBonus.Location = new Point(22, 331);
            groupBoxBonus.Name = "groupBoxBonus";
            groupBoxBonus.Size = new Size(935, 48);
            groupBoxBonus.TabIndex = 5;
            groupBoxBonus.TabStop = false;
            groupBoxBonus.Text = "Bonus";
            // 
            // ChkDip
            // 
            ChkDip.AutoSize = true;
            ChkDip.Location = new Point(793, 23);
            ChkDip.Name = "ChkDip";
            ChkDip.Size = new Size(76, 19);
            ChkDip.TabIndex = 2;
            ChkDip.Text = "Diplomas";
            ChkDip.UseVisualStyleBackColor = true;
            // 
            // ChkMotiv
            // 
            ChkMotiv.AutoSize = true;
            ChkMotiv.Location = new Point(469, 23);
            ChkMotiv.Name = "ChkMotiv";
            ChkMotiv.Size = new Size(84, 19);
            ChkMotiv.TabIndex = 1;
            ChkMotiv.Text = "Motivation";
            ChkMotiv.UseVisualStyleBackColor = true;
            // 
            // ChkExper
            // 
            ChkExper.AutoSize = true;
            ChkExper.Location = new Point(49, 22);
            ChkExper.Name = "ChkExper";
            ChkExper.Size = new Size(150, 19);
            ChkExper.TabIndex = 0;
            ChkExper.Text = "Professional experience";
            ChkExper.UseVisualStyleBackColor = true;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(22, 409);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(28, 15);
            LblAge.TabIndex = 6;
            LblAge.Text = "Age";
            // 
            // CmbAge
            // 
            CmbAge.FormattingEnabled = true;
            CmbAge.Items.AddRange(new object[] { "20-30 ", "30-40", "40 and more " });
            CmbAge.Location = new Point(84, 406);
            CmbAge.Name = "CmbAge";
            CmbAge.Size = new Size(121, 23);
            CmbAge.TabIndex = 7;
            // 
            // LblCh
            // 
            LblCh.AutoSize = true;
            LblCh.Location = new Point(555, 414);
            LblCh.Name = "LblCh";
            LblCh.Size = new Size(78, 15);
            LblCh.TabIndex = 8;
            LblCh.Text = "Chance value";
            // 
            // TxtChance
            // 
            TxtChance.Location = new Point(663, 410);
            TxtChance.Name = "TxtChance";
            TxtChance.ReadOnly = true;
            TxtChance.Size = new Size(131, 23);
            TxtChance.TabIndex = 9;
            TxtChance.Text = "0";
            // 
            // BtnCh
            // 
            BtnCh.Location = new Point(840, 410);
            BtnCh.Name = "BtnCh";
            BtnCh.Size = new Size(75, 23);
            BtnCh.TabIndex = 10;
            BtnCh.Text = "Genrate";
            BtnCh.UseVisualStyleBackColor = true;
            BtnCh.Click += BtnCh_Click;
            // 
            // BtnIni
            // 
            BtnIni.Location = new Point(66, 22);
            BtnIni.Name = "BtnIni";
            BtnIni.Size = new Size(98, 23);
            BtnIni.TabIndex = 11;
            BtnIni.Text = "Initialize";
            BtnIni.UseVisualStyleBackColor = true;
            BtnIni.Click += BtnIni_Click;
            // 
            // groupBoxButtons
            // 
            groupBoxButtons.Controls.Add(BtnEx);
            groupBoxButtons.Controls.Add(BtnAdd);
            groupBoxButtons.Controls.Add(BtnCalc);
            groupBoxButtons.Controls.Add(BtnIni);
            groupBoxButtons.Location = new Point(22, 457);
            groupBoxButtons.Name = "groupBoxButtons";
            groupBoxButtons.Size = new Size(935, 57);
            groupBoxButtons.TabIndex = 12;
            groupBoxButtons.TabStop = false;
            // 
            // BtnEx
            // 
            BtnEx.Location = new Point(771, 22);
            BtnEx.Name = "BtnEx";
            BtnEx.Size = new Size(98, 23);
            BtnEx.TabIndex = 14;
            BtnEx.Text = "Exit";
            BtnEx.UseVisualStyleBackColor = true;
            BtnEx.Click += BtnEx_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Enabled = false;
            BtnAdd.Location = new Point(565, 22);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(98, 23);
            BtnAdd.TabIndex = 13;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnCalc
            // 
            BtnCalc.Location = new Point(323, 22);
            BtnCalc.Name = "BtnCalc";
            BtnCalc.Size = new Size(98, 23);
            BtnCalc.TabIndex = 12;
            BtnCalc.Text = "Calculate";
            BtnCalc.UseVisualStyleBackColor = true;
            BtnCalc.Click += BtnCalc_Click;
            // 
            // LblSc
            // 
            LblSc.AutoSize = true;
            LblSc.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSc.Location = new Point(86, 538);
            LblSc.Name = "LblSc";
            LblSc.Size = new Size(67, 30);
            LblSc.TabIndex = 13;
            LblSc.Text = "Score";
            // 
            // TxtScore
            // 
            TxtScore.Location = new Point(87, 583);
            TxtScore.Name = "TxtScore";
            TxtScore.ReadOnly = true;
            TxtScore.Size = new Size(100, 23);
            TxtScore.TabIndex = 14;
            TxtScore.Text = "0";
            // 
            // groupBoxList
            // 
            groupBoxList.Controls.Add(label4);
            groupBoxList.Controls.Add(label3);
            groupBoxList.Controls.Add(label2);
            groupBoxList.Controls.Add(Lst4);
            groupBoxList.Controls.Add(Lst3);
            groupBoxList.Controls.Add(Lst2);
            groupBoxList.Controls.Add(Lst1);
            groupBoxList.Controls.Add(label1);
            groupBoxList.Location = new Point(325, 538);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Size = new Size(632, 176);
            groupBoxList.TabIndex = 15;
            groupBoxList.TabStop = false;
            groupBoxList.Text = "List of people";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 27);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Score";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 27);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 6;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 27);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Last Name";
            // 
            // Lst4
            // 
            Lst4.FormattingEnabled = true;
            Lst4.ItemHeight = 15;
            Lst4.Location = new Point(491, 52);
            Lst4.Name = "Lst4";
            Lst4.Size = new Size(120, 94);
            Lst4.TabIndex = 4;
            // 
            // Lst3
            // 
            Lst3.FormattingEnabled = true;
            Lst3.ItemHeight = 15;
            Lst3.Location = new Point(349, 52);
            Lst3.Name = "Lst3";
            Lst3.Size = new Size(120, 94);
            Lst3.TabIndex = 3;
            // 
            // Lst2
            // 
            Lst2.FormattingEnabled = true;
            Lst2.ItemHeight = 15;
            Lst2.Location = new Point(188, 52);
            Lst2.Name = "Lst2";
            Lst2.Size = new Size(120, 94);
            Lst2.TabIndex = 2;
            // 
            // Lst1
            // 
            Lst1.FormattingEnabled = true;
            Lst1.ItemHeight = 15;
            Lst1.Location = new Point(29, 52);
            Lst1.Name = "Lst1";
            Lst1.Size = new Size(120, 94);
            Lst1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 27);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "NIC";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 749);
            Controls.Add(groupBoxList);
            Controls.Add(TxtScore);
            Controls.Add(LblSc);
            Controls.Add(BtnCh);
            Controls.Add(TxtChance);
            Controls.Add(LblCh);
            Controls.Add(CmbAge);
            Controls.Add(LblAge);
            Controls.Add(groupBoxBonus);
            Controls.Add(groupBoxGender);
            Controls.Add(groupBoxMarks);
            Controls.Add(groupBoxInformations);
            Controls.Add(groupBox1);
            Controls.Add(LblScore);
            Controls.Add(groupBoxButtons);
            Name = "Form1";
            Text = "Score Calculation";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxInformations.ResumeLayout(false);
            groupBoxInformations.PerformLayout();
            groupBoxMarks.ResumeLayout(false);
            groupBoxMarks.PerformLayout();
            groupBoxGender.ResumeLayout(false);
            groupBoxGender.PerformLayout();
            groupBoxBonus.ResumeLayout(false);
            groupBoxBonus.PerformLayout();
            groupBoxButtons.ResumeLayout(false);
            groupBoxList.ResumeLayout(false);
            groupBoxList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblScore;
        private GroupBox groupBox1;
        private Label LblDate;
        private Label LblHour;
        private GroupBox groupBoxInformations;
        private TextBox TxtNIC;
        private Label LblCIN;
        private Label LblTel;
        private TextBox TxtTel;
        private TextBox TxtLName;
        private Label LblFName;
        private Label LblLName;
        private TextBox TxtFName;
        private GroupBox groupBoxMarks;
        private TextBox TxtTech;
        private TextBox TxtLang;
        private Label LblTech;
        private Label LblLang;
        private GroupBox groupBoxGender;
        private RadioButton RdFem;
        private RadioButton RdMas;
        private GroupBox groupBoxBonus;
        private CheckBox ChkDip;
        private CheckBox ChkMotiv;
        private CheckBox ChkExper;
        private Label LblAge;
        private ComboBox CmbAge;
        private Label LblCh;
        private TextBox TxtChance;
        private Button BtnCh;
        private Button BtnIni;
        private GroupBox groupBoxButtons;
        private Button BtnEx;
        private Button BtnAdd;
        private Button BtnCalc;
        private Label LblSc;
        private TextBox TxtScore;
        private GroupBox groupBoxList;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox Lst4;
        private ListBox Lst3;
        private ListBox Lst2;
        private ListBox Lst1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
