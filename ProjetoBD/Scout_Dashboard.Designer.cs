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
            this.getReportsButton = new System.Windows.Forms.Button();
            this.InsertIntoDBButton = new System.Windows.Forms.Button();
            this.insertionTypeCheck = new System.Windows.Forms.CheckedListBox();
            this.InsertFromTextBox = new System.Windows.Forms.TextBox();
            this.sportURLTB = new System.Windows.Forms.TextBox();
            this.sportNameTB = new System.Windows.Forms.TextBox();
            this.addSportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clubNameTB = new System.Windows.Forms.TextBox();
            this.clubSearchButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.addPositionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addPositionTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.Lista_Jogadores_Encontrados = new System.Windows.Forms.DataGridView();
            this.listaClubesEncontrados = new System.Windows.Forms.DataGridView();
            this.listaCategorias = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.positionCategoriesTB = new System.Windows.Forms.TextBox();
            this.positionCategoriesButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.positionAttributesTB = new System.Windows.Forms.TextBox();
            this.listaAtributosEncontrados = new System.Windows.Forms.DataGridView();
            this.attributesButton = new System.Windows.Forms.Button();
            this.categoryAttributesTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Lista_Jogadores_Encontrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClubesEncontrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAtributosEncontrados)).BeginInit();
            this.SuspendLayout();
            // 
            // Lista_Observações
            // 
            this.Lista_Observações.FormattingEnabled = true;
            this.Lista_Observações.Location = new System.Drawing.Point(581, 291);
            this.Lista_Observações.Name = "Lista_Observações";
            this.Lista_Observações.Size = new System.Drawing.Size(97, 56);
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
            // getReportsButton
            // 
            this.getReportsButton.Location = new System.Drawing.Point(581, 353);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Club Name";
            this.label3.Visible = false;
            // 
            // clubNameTB
            // 
            this.clubNameTB.Location = new System.Drawing.Point(78, 27);
            this.clubNameTB.Name = "clubNameTB";
            this.clubNameTB.Size = new System.Drawing.Size(100, 20);
            this.clubNameTB.TabIndex = 16;
            this.clubNameTB.Visible = false;
            // 
            // clubSearchButton
            // 
            this.clubSearchButton.Location = new System.Drawing.Point(184, 27);
            this.clubSearchButton.Name = "clubSearchButton";
            this.clubSearchButton.Size = new System.Drawing.Size(53, 23);
            this.clubSearchButton.TabIndex = 17;
            this.clubSearchButton.Text = "Search";
            this.clubSearchButton.UseVisualStyleBackColor = true;
            this.clubSearchButton.Visible = false;
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
            this.addPositionButton.Location = new System.Drawing.Point(606, 408);
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
            this.label4.Location = new System.Drawing.Point(528, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Position:";
            // 
            // addPositionTB
            // 
            this.addPositionTB.Location = new System.Drawing.Point(581, 382);
            this.addPositionTB.Name = "addPositionTB";
            this.addPositionTB.Size = new System.Drawing.Size(100, 20);
            this.addPositionTB.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "username";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "password";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(296, 177);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(100, 20);
            this.usernameTB.TabIndex = 24;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(296, 201);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(100, 20);
            this.passwordTB.TabIndex = 25;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(402, 191);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 26;
            this.loginButton.Text = "login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Lista_Jogadores_Encontrados
            // 
            this.Lista_Jogadores_Encontrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lista_Jogadores_Encontrados.Location = new System.Drawing.Point(12, 230);
            this.Lista_Jogadores_Encontrados.Name = "Lista_Jogadores_Encontrados";
            this.Lista_Jogadores_Encontrados.Size = new System.Drawing.Size(533, 140);
            this.Lista_Jogadores_Encontrados.TabIndex = 27;
            // 
            // listaClubesEncontrados
            // 
            this.listaClubesEncontrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaClubesEncontrados.Location = new System.Drawing.Point(15, 56);
            this.listaClubesEncontrados.Name = "listaClubesEncontrados";
            this.listaClubesEncontrados.Size = new System.Drawing.Size(257, 115);
            this.listaClubesEncontrados.TabIndex = 28;
            // 
            // listaCategorias
            // 
            this.listaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCategorias.Location = new System.Drawing.Point(15, 402);
            this.listaCategorias.Name = "listaCategorias";
            this.listaCategorias.Size = new System.Drawing.Size(390, 150);
            this.listaCategorias.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "position:";
            // 
            // positionCategoriesTB
            // 
            this.positionCategoriesTB.Location = new System.Drawing.Point(65, 373);
            this.positionCategoriesTB.Name = "positionCategoriesTB";
            this.positionCategoriesTB.Size = new System.Drawing.Size(100, 20);
            this.positionCategoriesTB.TabIndex = 31;
            // 
            // positionCategoriesButton
            // 
            this.positionCategoriesButton.Location = new System.Drawing.Point(184, 373);
            this.positionCategoriesButton.Name = "positionCategoriesButton";
            this.positionCategoriesButton.Size = new System.Drawing.Size(75, 23);
            this.positionCategoriesButton.TabIndex = 32;
            this.positionCategoriesButton.Text = "search";
            this.positionCategoriesButton.UseVisualStyleBackColor = true;
            this.positionCategoriesButton.Click += new System.EventHandler(this.positionCategoriesButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(681, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "position";
            // 
            // positionAttributesTB
            // 
            this.positionAttributesTB.Location = new System.Drawing.Point(730, 13);
            this.positionAttributesTB.Name = "positionAttributesTB";
            this.positionAttributesTB.Size = new System.Drawing.Size(100, 20);
            this.positionAttributesTB.TabIndex = 34;
            // 
            // listaAtributosEncontrados
            // 
            this.listaAtributosEncontrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaAtributosEncontrados.Location = new System.Drawing.Point(684, 71);
            this.listaAtributosEncontrados.Name = "listaAtributosEncontrados";
            this.listaAtributosEncontrados.Size = new System.Drawing.Size(497, 122);
            this.listaAtributosEncontrados.TabIndex = 35;
            // 
            // attributesButton
            // 
            this.attributesButton.Location = new System.Drawing.Point(849, 40);
            this.attributesButton.Name = "attributesButton";
            this.attributesButton.Size = new System.Drawing.Size(75, 23);
            this.attributesButton.TabIndex = 36;
            this.attributesButton.Text = "search";
            this.attributesButton.UseVisualStyleBackColor = true;
            this.attributesButton.Click += new System.EventHandler(this.attributesButton_Click);
            // 
            // categoryAttributesTB
            // 
            this.categoryAttributesTB.Location = new System.Drawing.Point(730, 43);
            this.categoryAttributesTB.Name = "categoryAttributesTB";
            this.categoryAttributesTB.Size = new System.Drawing.Size(100, 20);
            this.categoryAttributesTB.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(681, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "category";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(849, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.categoryAttributesTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.attributesButton);
            this.Controls.Add(this.listaAtributosEncontrados);
            this.Controls.Add(this.positionAttributesTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.positionCategoriesButton);
            this.Controls.Add(this.positionCategoriesTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listaCategorias);
            this.Controls.Add(this.listaClubesEncontrados);
            this.Controls.Add(this.Lista_Jogadores_Encontrados);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addPositionTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addPositionButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.clubSearchButton);
            this.Controls.Add(this.clubNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSportButton);
            this.Controls.Add(this.sportNameTB);
            this.Controls.Add(this.sportURLTB);
            this.Controls.Add(this.InsertFromTextBox);
            this.Controls.Add(this.insertionTypeCheck);
            this.Controls.Add(this.InsertIntoDBButton);
            this.Controls.Add(this.getReportsButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PlayerNameTB);
            this.Controls.Add(this.Lista_Observações);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lista_Jogadores_Encontrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClubesEncontrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAtributosEncontrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lista_Observações;
        private System.Windows.Forms.TextBox PlayerNameTB;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button getReportsButton;
        private System.Windows.Forms.CheckedListBox insertionTypeCheck;
        private System.Windows.Forms.TextBox InsertFromTextBox;
        public System.Windows.Forms.Button InsertIntoDBButton;
        private System.Windows.Forms.TextBox sportURLTB;
        private System.Windows.Forms.TextBox sportNameTB;
        private System.Windows.Forms.Button addSportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clubNameTB;
        private System.Windows.Forms.Button clubSearchButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button addPositionButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addPositionTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.DataGridView Lista_Jogadores_Encontrados;
        private System.Windows.Forms.DataGridView listaClubesEncontrados;
        private System.Windows.Forms.DataGridView listaCategorias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox positionCategoriesTB;
        private System.Windows.Forms.Button positionCategoriesButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox positionAttributesTB;
        private System.Windows.Forms.DataGridView listaAtributosEncontrados;
        private System.Windows.Forms.Button attributesButton;
        private System.Windows.Forms.TextBox categoryAttributesTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}

