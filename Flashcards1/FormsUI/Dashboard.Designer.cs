namespace FormsUI
{
    partial class Dashboard
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
            this.flashcardsListbox = new System.Windows.Forms.ListBox();
            this.bandNameTextbox = new System.Windows.Forms.TextBox();
            this.bandNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.bandNameInputTextbox = new System.Windows.Forms.TextBox();
            this.bandNameInputLabel = new System.Windows.Forms.Label();
            this.songNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseStatusListBox = new System.Windows.Forms.ListBox();
            this.addToDatabaseButton = new System.Windows.Forms.Button();
            this.addFlashcardToList = new System.Windows.Forms.Label();
            this.deleteFlashcardFromListLabel = new System.Windows.Forms.Label();
            this.iDNumberLabel = new System.Windows.Forms.Label();
            this.idToDeleteTextbox = new System.Windows.Forms.TextBox();
            this.idDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flashcardsListbox
            // 
            this.flashcardsListbox.FormattingEnabled = true;
            this.flashcardsListbox.Location = new System.Drawing.Point(12, 73);
            this.flashcardsListbox.Name = "flashcardsListbox";
            this.flashcardsListbox.Size = new System.Drawing.Size(374, 82);
            this.flashcardsListbox.TabIndex = 0;
            this.flashcardsListbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bandNameTextbox
            // 
            this.bandNameTextbox.Location = new System.Drawing.Point(146, 33);
            this.bandNameTextbox.Name = "bandNameTextbox";
            this.bandNameTextbox.Size = new System.Drawing.Size(147, 20);
            this.bandNameTextbox.TabIndex = 1;
            // 
            // bandNameLabel
            // 
            this.bandNameLabel.AutoSize = true;
            this.bandNameLabel.Location = new System.Drawing.Point(9, 35);
            this.bandNameLabel.Name = "bandNameLabel";
            this.bandNameLabel.Size = new System.Drawing.Size(100, 13);
            this.bandNameLabel.TabIndex = 2;
            this.bandNameLabel.Text = "Band Name Search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(311, 30);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // bandNameInputTextbox
            // 
            this.bandNameInputTextbox.Location = new System.Drawing.Point(117, 222);
            this.bandNameInputTextbox.Name = "bandNameInputTextbox";
            this.bandNameInputTextbox.Size = new System.Drawing.Size(173, 20);
            this.bandNameInputTextbox.TabIndex = 4;
            this.bandNameInputTextbox.Text = "Band Name Input";
            this.bandNameInputTextbox.TextChanged += new System.EventHandler(this.bandNameInputTextbox_TextChanged);
            // 
            // bandNameInputLabel
            // 
            this.bandNameInputLabel.AutoSize = true;
            this.bandNameInputLabel.Location = new System.Drawing.Point(9, 222);
            this.bandNameInputLabel.Name = "bandNameInputLabel";
            this.bandNameInputLabel.Size = new System.Drawing.Size(90, 13);
            this.bandNameInputLabel.TabIndex = 5;
            this.bandNameInputLabel.Text = "Band Name Input";
            // 
            // songNameTextbox
            // 
            this.songNameTextbox.Location = new System.Drawing.Point(120, 267);
            this.songNameTextbox.Name = "songNameTextbox";
            this.songNameTextbox.Size = new System.Drawing.Size(170, 20);
            this.songNameTextbox.TabIndex = 6;
            this.songNameTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Song Name";
            // 
            // databaseStatusListBox
            // 
            this.databaseStatusListBox.FormattingEnabled = true;
            this.databaseStatusListBox.Location = new System.Drawing.Point(12, 293);
            this.databaseStatusListBox.Name = "databaseStatusListBox";
            this.databaseStatusListBox.Size = new System.Drawing.Size(374, 43);
            this.databaseStatusListBox.TabIndex = 8;
            this.databaseStatusListBox.SelectedIndexChanged += new System.EventHandler(this.databaseStatusListBox_SelectedIndexChanged);
            // 
            // addToDatabaseButton
            // 
            this.addToDatabaseButton.Location = new System.Drawing.Point(297, 233);
            this.addToDatabaseButton.Name = "addToDatabaseButton";
            this.addToDatabaseButton.Size = new System.Drawing.Size(100, 24);
            this.addToDatabaseButton.TabIndex = 9;
            this.addToDatabaseButton.Text = "Add to Database";
            this.addToDatabaseButton.UseVisualStyleBackColor = true;
            this.addToDatabaseButton.Click += new System.EventHandler(this.addToDatabaseButton_Click);
            // 
            // addFlashcardToList
            // 
            this.addFlashcardToList.AutoSize = true;
            this.addFlashcardToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFlashcardToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.addFlashcardToList.Location = new System.Drawing.Point(12, 185);
            this.addFlashcardToList.Name = "addFlashcardToList";
            this.addFlashcardToList.Size = new System.Drawing.Size(141, 17);
            this.addFlashcardToList.TabIndex = 10;
            this.addFlashcardToList.Text = "Add Flashcard to List";
            // 
            // deleteFlashcardFromListLabel
            // 
            this.deleteFlashcardFromListLabel.AutoSize = true;
            this.deleteFlashcardFromListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.deleteFlashcardFromListLabel.Location = new System.Drawing.Point(467, 0);
            this.deleteFlashcardFromListLabel.Name = "deleteFlashcardFromListLabel";
            this.deleteFlashcardFromListLabel.Size = new System.Drawing.Size(177, 17);
            this.deleteFlashcardFromListLabel.TabIndex = 11;
            this.deleteFlashcardFromListLabel.Text = "Delete Flashcard From List";
            // 
            // iDNumberLabel
            // 
            this.iDNumberLabel.AutoSize = true;
            this.iDNumberLabel.Location = new System.Drawing.Point(482, 27);
            this.iDNumberLabel.Name = "iDNumberLabel";
            this.iDNumberLabel.Size = new System.Drawing.Size(58, 13);
            this.iDNumberLabel.TabIndex = 12;
            this.iDNumberLabel.Text = "ID Number";
            // 
            // idToDeleteTextbox
            // 
            this.idToDeleteTextbox.Location = new System.Drawing.Point(574, 24);
            this.idToDeleteTextbox.Name = "idToDeleteTextbox";
            this.idToDeleteTextbox.Size = new System.Drawing.Size(58, 20);
            this.idToDeleteTextbox.TabIndex = 13;
            // 
            // idDeleteButton
            // 
            this.idDeleteButton.Location = new System.Drawing.Point(656, 21);
            this.idDeleteButton.Name = "idDeleteButton";
            this.idDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.idDeleteButton.TabIndex = 14;
            this.idDeleteButton.Text = "Delete";
            this.idDeleteButton.UseVisualStyleBackColor = true;
            this.idDeleteButton.Click += new System.EventHandler(this.idDeleteButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.idDeleteButton);
            this.Controls.Add(this.idToDeleteTextbox);
            this.Controls.Add(this.iDNumberLabel);
            this.Controls.Add(this.deleteFlashcardFromListLabel);
            this.Controls.Add(this.addFlashcardToList);
            this.Controls.Add(this.addToDatabaseButton);
            this.Controls.Add(this.databaseStatusListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.songNameTextbox);
            this.Controls.Add(this.bandNameInputLabel);
            this.Controls.Add(this.bandNameInputTextbox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.bandNameLabel);
            this.Controls.Add(this.bandNameTextbox);
            this.Controls.Add(this.flashcardsListbox);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox flashcardsListbox;
        private System.Windows.Forms.TextBox bandNameTextbox;
        private System.Windows.Forms.Label bandNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox bandNameInputTextbox;
        private System.Windows.Forms.Label bandNameInputLabel;
        private System.Windows.Forms.TextBox songNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox databaseStatusListBox;
        private System.Windows.Forms.Button addToDatabaseButton;
        private System.Windows.Forms.Label addFlashcardToList;
        private System.Windows.Forms.Label deleteFlashcardFromListLabel;
        private System.Windows.Forms.Label iDNumberLabel;
        private System.Windows.Forms.TextBox idToDeleteTextbox;
        private System.Windows.Forms.Button idDeleteButton;
    }
}

