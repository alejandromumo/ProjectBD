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
            this.NameText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Lista_Jogadores_Encontrados = new System.Windows.Forms.ListBox();
            this.getReportsButton = new System.Windows.Forms.Button();
            this.InsertIntoDBButton = new System.Windows.Forms.Button();
            this.insertionTypeCheck = new System.Windows.Forms.CheckedListBox();
            this.InsertFromTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lista_Observações
            // 
            this.Lista_Observações.FormattingEnabled = true;
            this.Lista_Observações.Location = new System.Drawing.Point(12, 337);
            this.Lista_Observações.Name = "Lista_Observações";
            this.Lista_Observações.Size = new System.Drawing.Size(607, 147);
            this.Lista_Observações.TabIndex = 0;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(86, 50);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 53);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(81, 87);
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
            this.Lista_Jogadores_Encontrados.Location = new System.Drawing.Point(12, 131);
            this.Lista_Jogadores_Encontrados.Name = "Lista_Jogadores_Encontrados";
            this.Lista_Jogadores_Encontrados.Size = new System.Drawing.Size(189, 186);
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
            this.InsertIntoDBButton.Location = new System.Drawing.Point(382, 201);
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
            this.insertionTypeCheck.Location = new System.Drawing.Point(382, 71);
            this.insertionTypeCheck.Name = "insertionTypeCheck";
            this.insertionTypeCheck.Size = new System.Drawing.Size(120, 124);
            this.insertionTypeCheck.TabIndex = 7;
            // 
            // InsertFromTextBox
            // 
            this.InsertFromTextBox.Location = new System.Drawing.Point(382, 45);
            this.InsertFromTextBox.Name = "InsertFromTextBox";
            this.InsertFromTextBox.Size = new System.Drawing.Size(100, 20);
            this.InsertFromTextBox.TabIndex = 8;
            this.InsertFromTextBox.Text = "C: \\Users\\mumox\\Desktop\\clubs_final.csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 564);
            this.Controls.Add(this.InsertFromTextBox);
            this.Controls.Add(this.insertionTypeCheck);
            this.Controls.Add(this.InsertIntoDBButton);
            this.Controls.Add(this.getReportsButton);
            this.Controls.Add(this.Lista_Jogadores_Encontrados);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.Lista_Observações);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lista_Observações;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox Lista_Jogadores_Encontrados;
        private System.Windows.Forms.Button getReportsButton;
        private System.Windows.Forms.CheckedListBox insertionTypeCheck;
        private System.Windows.Forms.TextBox InsertFromTextBox;
        public System.Windows.Forms.Button InsertIntoDBButton;
    }
}

