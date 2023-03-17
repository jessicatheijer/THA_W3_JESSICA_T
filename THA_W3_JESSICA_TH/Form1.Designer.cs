namespace THA_W3_JESSICA_TH
{
    partial class MainForm
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
            this.Btn_NextForm = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label_FavArtist = new System.Windows.Forms.Label();
            this.TB_FavArtist = new System.Windows.Forms.TextBox();
            this.CB_True1 = new System.Windows.Forms.CheckBox();
            this.Btn_Submit1 = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.SuspendLayout();
            // 
            // Btn_NextForm
            // 
            this.Btn_NextForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Btn_NextForm.Location = new System.Drawing.Point(52, 250);
            this.Btn_NextForm.Name = "Btn_NextForm";
            this.Btn_NextForm.Size = new System.Drawing.Size(206, 51);
            this.Btn_NextForm.TabIndex = 0;
            this.Btn_NextForm.Text = "Open Next Form";
            this.Btn_NextForm.UseVisualStyleBackColor = true;
            this.Btn_NextForm.Click += new System.EventHandler(this.Btn_NextForm_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label_Name.Location = new System.Drawing.Point(48, 91);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(51, 20);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name";
            // 
            // TB_Name
            // 
            this.TB_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.TB_Name.Location = new System.Drawing.Point(270, 82);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(206, 26);
            this.TB_Name.TabIndex = 2;
            // 
            // label_FavArtist
            // 
            this.label_FavArtist.AutoSize = true;
            this.label_FavArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label_FavArtist.Location = new System.Drawing.Point(48, 146);
            this.label_FavArtist.Name = "label_FavArtist";
            this.label_FavArtist.Size = new System.Drawing.Size(131, 20);
            this.label_FavArtist.TabIndex = 3;
            this.label_FavArtist.Text = "My Favorite Artist";
            // 
            // TB_FavArtist
            // 
            this.TB_FavArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.TB_FavArtist.Location = new System.Drawing.Point(270, 139);
            this.TB_FavArtist.Name = "TB_FavArtist";
            this.TB_FavArtist.Size = new System.Drawing.Size(206, 26);
            this.TB_FavArtist.TabIndex = 4;
            this.TB_FavArtist.TextChanged += new System.EventHandler(this.TB_FavArtist_TextChanged);
            // 
            // CB_True1
            // 
            this.CB_True1.AutoSize = true;
            this.CB_True1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.CB_True1.Location = new System.Drawing.Point(52, 201);
            this.CB_True1.Name = "CB_True1";
            this.CB_True1.Size = new System.Drawing.Size(289, 24);
            this.CB_True1.TabIndex = 5;
            this.CB_True1.Text = "All of the content I put above is true!";
            this.CB_True1.UseVisualStyleBackColor = true;
            this.CB_True1.CheckedChanged += new System.EventHandler(this.CB_True1_CheckedChanged);
            // 
            // Btn_Submit1
            // 
            this.Btn_Submit1.Enabled = false;
            this.Btn_Submit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Btn_Submit1.Location = new System.Drawing.Point(349, 250);
            this.Btn_Submit1.Name = "Btn_Submit1";
            this.Btn_Submit1.Size = new System.Drawing.Size(127, 51);
            this.Btn_Submit1.TabIndex = 6;
            this.Btn_Submit1.Text = "Submit";
            this.Btn_Submit1.UseVisualStyleBackColor = true;
            this.Btn_Submit1.Click += new System.EventHandler(this.Btn_Submit1_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Submit1);
            this.Controls.Add(this.CB_True1);
            this.Controls.Add(this.TB_FavArtist);
            this.Controls.Add(this.label_FavArtist);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.Btn_NextForm);
            this.Name = "MainForm";
            this.Text = "Main Window Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_NextForm;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label_FavArtist;
        private System.Windows.Forms.TextBox TB_FavArtist;
        private System.Windows.Forms.CheckBox CB_True1;
        private System.Windows.Forms.Button Btn_Submit1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}

