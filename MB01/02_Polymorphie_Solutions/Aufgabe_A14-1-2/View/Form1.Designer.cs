namespace Analyseaufgabe_A14_1_4
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
            this.TxtMediaList = new System.Windows.Forms.TextBox();
            this.CmdShowMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtMediaList
            // 
            this.TxtMediaList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMediaList.Location = new System.Drawing.Point(141, 24);
            this.TxtMediaList.Multiline = true;
            this.TxtMediaList.Name = "TxtMediaList";
            this.TxtMediaList.Size = new System.Drawing.Size(459, 414);
            this.TxtMediaList.TabIndex = 0;
            // 
            // CmdShowMedia
            // 
            this.CmdShowMedia.Location = new System.Drawing.Point(40, 22);
            this.CmdShowMedia.Name = "CmdShowMedia";
            this.CmdShowMedia.Size = new System.Drawing.Size(95, 23);
            this.CmdShowMedia.TabIndex = 2;
            this.CmdShowMedia.Text = "Zeige Medien";
            this.CmdShowMedia.UseVisualStyleBackColor = true;
            this.CmdShowMedia.Click += new System.EventHandler(this.CmdShowMedia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.CmdShowMedia);
            this.Controls.Add(this.TxtMediaList);
            this.Name = "Form1";
            this.Text = "Aufgabe_A14-1-2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMediaList;
        private System.Windows.Forms.Button CmdShowMedia;
    }
}

