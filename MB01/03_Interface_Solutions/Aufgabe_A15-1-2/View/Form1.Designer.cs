namespace Aufgabe_A15_1_2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtNames = new System.Windows.Forms.TextBox();
            this.CmdSortNames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNames
            // 
            this.TxtNames.Location = new System.Drawing.Point(12, 12);
            this.TxtNames.Multiline = true;
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.Size = new System.Drawing.Size(253, 228);
            this.TxtNames.TabIndex = 0;
            // 
            // CmdSortNames
            // 
            this.CmdSortNames.Location = new System.Drawing.Point(12, 247);
            this.CmdSortNames.Name = "CmdSortNames";
            this.CmdSortNames.Size = new System.Drawing.Size(253, 23);
            this.CmdSortNames.TabIndex = 2;
            this.CmdSortNames.Text = "Sortiere Namen";
            this.CmdSortNames.UseVisualStyleBackColor = true;
            this.CmdSortNames.Click += new System.EventHandler(this.CmdSortNames_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 281);
            this.Controls.Add(this.CmdSortNames);
            this.Controls.Add(this.TxtNames);
            this.Name = "Form1";
            this.Text = "Aufgabe_A15-1-2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNames;
        private System.Windows.Forms.Button CmdSortNames;
    }
}

