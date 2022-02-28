namespace Cats_and_Dogs
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
            this.listpets = new System.Windows.Forms.ListBox();
            this.Pets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listpets
            // 
            this.listpets.FormattingEnabled = true;
            this.listpets.Location = new System.Drawing.Point(66, 178);
            this.listpets.Name = "listpets";
            this.listpets.Size = new System.Drawing.Size(120, 95);
            this.listpets.TabIndex = 0;
            this.listpets.SelectedIndexChanged += new System.EventHandler(this.listpets_SelectedIndexChanged);
            // 
            // Pets
            // 
            this.Pets.AutoSize = true;
            this.Pets.Location = new System.Drawing.Point(66, 60);
            this.Pets.Name = "Pets";
            this.Pets.Size = new System.Drawing.Size(28, 13);
            this.Pets.TabIndex = 1;
            this.Pets.Text = "Pets";
            this.Pets.Click += new System.EventHandler(this.Pets_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pets);
            this.Controls.Add(this.listpets);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listpets;
        private System.Windows.Forms.Label Pets;
    }
}

