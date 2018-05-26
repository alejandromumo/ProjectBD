namespace ProjetoBD
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
            this.Lista_Observações = new System.Windows.Forms.ListBox();
            this.PlayerNameTB = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Lista_Jogadores_Encontrados = new System.Windows.Forms.ListBox();
            this.getReportsButton = new System.Windows.Forms.Button();
            this.InsertIntoDBButton = new System.Windows.Forms.Button();
            this.insertionTypeCheck = new System.Windows.Forms.CheckedListBox();
            this.InsertFromTextBox = new System.Windows.Forms.TextBox();
            this.sportURLTB = new System.Windows.Forms.TextBox();
            this.sportNameTB = new System.Windows.Forms.TextBox();
            this.addSportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lista_Clubes_Encontrados = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clubNameTB = new System.Windows.Forms.TextBox();
            this.clubSearchButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.addPositionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addPositionTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lista_Observações
            // 
            this.Lista_Observações.FormattingEnabled = true;
            this.Lista_Observações.Location = new System.Drawing.Point(12, 428);
            this.Lista_Observações.Name = "Lista_Observações";
            this.Lista_Observações.Size = new System.Drawing.Size(607, 56);
            this.Lista_Observações.TabIndex = 0;
            // 
            // PlayerNameTB
            // 
            this.PlayerNameTB.Location = new System.Drawing.Point(85, 177);
            this.PlayerNameTB.Name = "PlayerNameTB";
            this.PlayerNameTB.Size = new System.Drawing.Size(105, 20);
            this.PlayerNameTB.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 180);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(67, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Player Name";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(85, 201);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(105, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Lista_Jogadores_Encontrados
            // 
            this.Lista_Jogadores_Encontrados.FormattingEnabled = true;
            this.Lista_Jogadores_Encontrados.Location = new System.Drawing.Point(15, 236);
            this.Lista_Jogadores_Encontrados.Name = "Lista_Jogadores_Encontrados";
            this.Lista_Jogadores_Encontrados.Size = new System.Drawing.Size(604, 186);
            this.Lista_Jogadores_Encontrados.TabIndex = 4;
            // 
            // getReportsButton
            // 
            this.getReportsButton.Location = new System.Drawing.Point(15, 500);
            this.getReportsButton.Name = "getReportsButton";
            this.getReportsButton.Size = new System.Drawing.Size(75, 23);
            this.getReportsButton.TabIndex = 5;
            this.getReportsButton.Text = "Get Reports";
            this.getReportsButton.UseVisualStyleBackColor = true;
            this.getReportsButton.Click += new System.EventHandler(this.getReportsButton_Click);
            // 
            // InsertIntoDBButton
            // 
            this.InsertIntoDBButton.Location = new System.Drawing.Point(499, 201);
            this.InsertIntoDBButton.Name = "InsertIntoDBButton";
            this.InsertIntoDBButton.Size = new System.Drawing.Size(75, 23);
            this.InsertIntoDBButton.TabIndex = 6;
            this.InsertIntoDBButton.Text = "Insert";
            this.InsertIntoDBButton.UseVisualStyleBackColor = true;
            this.InsertIntoDBButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // insertionTypeCheck
            // 
            this.insertionTypeCheck.FormattingEnabled = true;
            this.insertionTypeCheck.Items.AddRange(new object[] {
            "Sport",
            "League",
            "Club",
            "URL",
            "Person",
            "Player",
            "Scout",
            "Report"});
            this.insertionTypeCheck.Location = new System.Drawing.Point(499, 71);
            this.insertionTypeCheck.Name = "insertionTypeCheck";
            this.insertionTypeCheck.Size = new System.Drawing.Size(120, 124);
            this.insertionTypeCheck.TabIndex = 7;
            // 
            // InsertFromTextBox
            // 
            this.InsertFromTextBox.Location = new System.Drawing.Point(499, 45);
            this.InsertFromTextBox.Name = "InsertFromTextBox";
            this.InsertFromTextBox.Size = new System.Drawing.Size(100, 20);
            this.InsertFromTextBox.TabIndex = 8;
            this.InsertFromTextBox.Text = "C: \\Users\\mumox\\Desktop\\players_final.csv";
            // 
            // sportURLTB
            // 
            this.sportURLTB.Location = new System.Drawing.Point(356, 75);
            this.sportURLTB.Name = "sportURLTB";
            this.sportURLTB.Size = new System.Drawing.Size(100, 20);
            this.sportURLTB.TabIndex = 9;
            // 
            // sportNameTB
            // 
            this.sportNameTB.Location = new System.Drawing.Point(356, 49);
            this.sportNameTB.Name = "sportNameTB";
            this.sportNameTB.Size = new System.Drawing.Size(100, 20);
            this.sportNameTB.TabIndex = 10;
            // 
            // addSportButton
            // 
            this.addSportButton.Location = new System.Drawing.Point(381, 101);
            this.addSportButton.Name = "addSportButton";
            this.addSportButton.Size = new System.Drawing.Size(75, 46);
            this.addSportButton.TabIndex = 11;
            this.addSportButton.Text = "Add Sport";
            this.addSportButton.UseVisualStyleBackColor = true;
            this.addSportButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sport Name : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sport URL : ";
            // 
            // Lista_Clubes_Encontrados
            // 
            this.Lista_Clubes_Encontrados.FormattingEnabled = true;
            this.Lista_Clubes_Encontrados.Location = new System.Drawing.Point(15, 56);
            this.Lista_Clubes_Encontrados.Name = "Lista_Clubes_Encontrados";
            this.Lista_Clubes_Encontrados.Size = new System.Drawing.Size(239, 95);
            this.Lista_Clubes_Encontrados.TabIndex = 14;
            this.Lista_Clubes_Encontrados.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Club Name";
            // 
            // clubNameTB
            // 
            this.clubNameTB.Location = new System.Drawing.Point(78, 27);
            this.clubNameTB.Name = "clubNameTB";
            this.clubNameTB.Size = new System.Drawing.Size(100, 20);
            this.clubNameTB.TabIndex = 16;
            // 
            // clubSearchButton
            // 
            this.clubSearchButton.Location = new System.Drawing.Point(184, 27);
            this.clubSearchButton.Name = "clubSearchButton";
            this.clubSearchButton.Size = new System.Drawing.Size(53, 23);
            this.clubSearchButton.TabIndex = 17;
            this.clubSearchButton.Text = "Search";
            this.clubSearchButton.UseVisualStyleBackColor = true;
            this.clubSearchButton.Click += new System.EventHandler(this.clubSearchButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(544, 529);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 18;
            this.nextButton.Text = "Next Page";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // addPositionButton
            // 
            this.addPositionButton.Location = new System.Drawing.Point(240, 523);
            this.addPositionButton.Name = "addPositionButton";
            this.addPositionButton.Size = new System.Drawing.Size(75, 23);
            this.addPositionButton.TabIndex = 19;
            this.addPositionButton.Text = "addPosition";
            this.addPositionButton.UseVisualStyleBackColor = true;
            this.addPositionButton.Click += new System.EventHandler(this.addPositionButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Position:";
            // 
            // addPositionTB
            // 
            this.addPositionTB.Location = new System.Drawing.Point(215, 497);
            this.addPositionTB.Name = "addPositionTB";
            this.addPositionTB.Size = new System.Drawing.Size(100, 20);
            this.addPositionTB.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 564);
            this.Controls.Add(this.addPositionTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addPositionButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.clubSearchButton);
            this.Controls.Add(this.clubNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lista_Clubes_Encontrados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSportButton);
            this.Controls.Add(this.sportNameTB);
            this.Controls.Add(this.sportURLTB);
            this.Controls.Add(this.InsertFromTextBox);
            this.Controls.Add(this.insertionTypeCheck);
            this.Controls.Add(this.InsertIntoDBButton);
            this.Controls.Add(this.getReportsButton);
            this.Controls.Add(this.Lista_Jogadores_Encontrados);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PlayerNameTB);
            this.Controls.Add(this.Lista_Observações);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lista_Observações;
        private System.Windows.Forms.TextBox PlayerNameTB;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox Lista_Jogadores_Encontrados;
        private System.Windows.Forms.Button getReportsButton;
        private System.Windows.Forms.CheckedListBox insertionTypeCheck;
        private System.Windows.Forms.TextBox InsertFromTextBox;
        public System.Windows.Forms.Button InsertIntoDBButton;
        private System.Windows.Forms.TextBox sportURLTB;
        private System.Windows.Forms.TextBox sportNameTB;
        private System.Windows.Forms.Button addSportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Lista_Clubes_Encontrados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clubNameTB;
        private System.Windows.Forms.Button clubSearchButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button addPositionButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addPositionTB;
    }
}

