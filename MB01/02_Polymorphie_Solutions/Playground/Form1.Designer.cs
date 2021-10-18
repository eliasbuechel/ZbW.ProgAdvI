namespace Playground
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
            this.CmdButton = new System.Windows.Forms.Button();
            this.TxtLogger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdButton
            // 
            this.CmdButton.Location = new System.Drawing.Point(64, 61);
            this.CmdButton.Name = "CmdButton";
            this.CmdButton.Size = new System.Drawing.Size(75, 23);
            this.CmdButton.TabIndex = 0;
            this.CmdButton.Text = "button1";
            this.CmdButton.UseVisualStyleBackColor = true;
            this.CmdButton.Click += new System.EventHandler(this.CmdButton_Click);
            // 
            // TxtLogger
            // 
            this.TxtLogger.Location = new System.Drawing.Point(64, 163);
            this.TxtLogger.Multiline = true;
            this.TxtLogger.Name = "TxtLogger";
            this.TxtLogger.Size = new System.Drawing.Size(526, 244);
            this.TxtLogger.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtLogger);
            this.Controls.Add(this.CmdButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdButton;
        private System.Windows.Forms.TextBox TxtLogger;
    }
}

