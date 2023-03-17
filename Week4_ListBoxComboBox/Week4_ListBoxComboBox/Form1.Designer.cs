namespace Week4_ListBoxComboBox
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
            this.listCountry = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtboxCountry = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.cmbGames1 = new System.Windows.Forms.ComboBox();
            this.lblGame = new System.Windows.Forms.Label();
            this.cmbHP = new System.Windows.Forms.ComboBox();
            this.lblHP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listCountry
            // 
            this.listCountry.FormattingEnabled = true;
            this.listCountry.ItemHeight = 16;
            this.listCountry.Items.AddRange(new object[] {
            "Amerika",
            "United Kingdom",
            "Indonesia",
            "Singapore",
            "Brazil"});
            this.listCountry.Location = new System.Drawing.Point(541, 12);
            this.listCountry.Name = "listCountry";
            this.listCountry.Size = new System.Drawing.Size(195, 244);
            this.listCountry.TabIndex = 0;
            this.listCountry.SelectedIndexChanged += new System.EventHandler(this.listCountry_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(427, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(62, 42);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(55, 16);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Country:";
            // 
            // txtboxCountry
            // 
            this.txtboxCountry.Location = new System.Drawing.Point(123, 42);
            this.txtboxCountry.Name = "txtboxCountry";
            this.txtboxCountry.Size = new System.Drawing.Size(266, 22);
            this.txtboxCountry.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(427, 71);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(427, 100);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 5;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(427, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(538, 275);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(67, 16);
            this.lblChoose.TabIndex = 7;
            this.lblChoose.Text = "Selected: ";
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(602, 275);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(14, 16);
            this.lblSelection.TabIndex = 8;
            this.lblSelection.Text = "?";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(767, 34);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(767, 71);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 10;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // cmbGames1
            // 
            this.cmbGames1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGames1.FormattingEnabled = true;
            this.cmbGames1.Items.AddRange(new object[] {
            "Valorant",
            "Dota",
            "Genshin Impact",
            "Ragnarok Online",
            "Rising Force Online"});
            this.cmbGames1.Location = new System.Drawing.Point(65, 232);
            this.cmbGames1.Name = "cmbGames1";
            this.cmbGames1.Size = new System.Drawing.Size(176, 24);
            this.cmbGames1.TabIndex = 11;
            this.cmbGames1.SelectedIndexChanged += new System.EventHandler(this.cmbGames1_SelectedIndexChanged);
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(248, 232);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(51, 16);
            this.lblGame.TabIndex = 12;
            this.lblGame.Text = "Games";
            // 
            // cmbHP
            // 
            this.cmbHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHP.FormattingEnabled = true;
            this.cmbHP.Items.AddRange(new object[] {
            "Nokia",
            "Apple",
            "Samsung",
            "Xiaomi",
            "Motorola"});
            this.cmbHP.Location = new System.Drawing.Point(65, 320);
            this.cmbHP.Name = "cmbHP";
            this.cmbHP.Size = new System.Drawing.Size(176, 24);
            this.cmbHP.TabIndex = 13;
            this.cmbHP.SelectionChangeCommitted += new System.EventHandler(this.cmbHP_SelectionChangeCommitted);
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(248, 323);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(26, 16);
            this.lblHP.TabIndex = 14;
            this.lblHP.Text = "HP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.cmbHP);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.cmbGames1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtboxCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCountry;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtboxCountry;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.ComboBox cmbGames1;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.ComboBox cmbHP;
        private System.Windows.Forms.Label lblHP;
    }
}

