namespace Aufgabe_A15_1_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmdCreate = new System.Windows.Forms.Button();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtFirstname = new System.Windows.Forms.TextBox();
            this.DtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblOldestPerson = new System.Windows.Forms.Label();
            this.CmdOldestPerson = new System.Windows.Forms.Button();
            this.TxtList = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmdCreate);
            this.groupBox1.Controls.Add(this.TxtLastName);
            this.groupBox1.Controls.Add(this.TxtFirstname);
            this.groupBox1.Controls.Add(this.DtpBirthday);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // CmdCreate
            // 
            this.CmdCreate.Location = new System.Drawing.Point(200, 173);
            this.CmdCreate.Name = "CmdCreate";
            this.CmdCreate.Size = new System.Drawing.Size(75, 23);
            this.CmdCreate.TabIndex = 6;
            this.CmdCreate.Text = "Erstellen";
            this.CmdCreate.UseVisualStyleBackColor = true;
            this.CmdCreate.Click += new System.EventHandler(this.CmdCreate_Click);
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(75, 49);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(200, 20);
            this.TxtLastName.TabIndex = 5;
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.Location = new System.Drawing.Point(75, 17);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(200, 20);
            this.TxtFirstname.TabIndex = 4;
            // 
            // DtpBirthday
            // 
            this.DtpBirthday.Location = new System.Drawing.Point(75, 87);
            this.DtpBirthday.Name = "DtpBirthday";
            this.DtpBirthday.Size = new System.Drawing.Size(200, 20);
            this.DtpBirthday.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geburtstag:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblOldestPerson);
            this.groupBox2.Controls.Add(this.CmdOldestPerson);
            this.groupBox2.Controls.Add(this.TxtList);
            this.groupBox2.Location = new System.Drawing.Point(344, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // LblOldestPerson
            // 
            this.LblOldestPerson.AutoSize = true;
            this.LblOldestPerson.Location = new System.Drawing.Point(111, 178);
            this.LblOldestPerson.Name = "LblOldestPerson";
            this.LblOldestPerson.Size = new System.Drawing.Size(16, 13);
            this.LblOldestPerson.TabIndex = 2;
            this.LblOldestPerson.Text = "...";
            // 
            // CmdOldestPerson
            // 
            this.CmdOldestPerson.Location = new System.Drawing.Point(10, 173);
            this.CmdOldestPerson.Name = "CmdOldestPerson";
            this.CmdOldestPerson.Size = new System.Drawing.Size(95, 23);
            this.CmdOldestPerson.TabIndex = 1;
            this.CmdOldestPerson.Text = "Älteste Person";
            this.CmdOldestPerson.UseVisualStyleBackColor = true;
            this.CmdOldestPerson.Click += new System.EventHandler(this.CmdOldestPerson_Click);
            // 
            // TxtList
            // 
            this.TxtList.Location = new System.Drawing.Point(10, 17);
            this.TxtList.Multiline = true;
            this.TxtList.Name = "TxtList";
            this.TxtList.Size = new System.Drawing.Size(307, 149);
            this.TxtList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 317);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aufgabe_A15-1-3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CmdCreate;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtFirstname;
        private System.Windows.Forms.DateTimePicker DtpBirthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtList;
        private System.Windows.Forms.Label LblOldestPerson;
        private System.Windows.Forms.Button CmdOldestPerson;
    }
}

