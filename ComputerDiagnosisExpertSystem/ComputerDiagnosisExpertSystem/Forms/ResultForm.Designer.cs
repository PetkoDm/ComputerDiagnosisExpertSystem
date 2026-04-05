namespace ComputerDiagnosisExpertSystem.Forms
{
    partial class ResultForm
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDamage = new System.Windows.Forms.TextBox();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblResDam = new System.Windows.Forms.Label();
            this.lblResSol = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(188, 104);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(44, 16);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(623, 392);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label2";
            // 
            // txtDamage
            // 
            this.txtDamage.Location = new System.Drawing.Point(191, 187);
            this.txtDamage.Name = "txtDamage";
            this.txtDamage.Size = new System.Drawing.Size(342, 22);
            this.txtDamage.TabIndex = 2;
            // 
            // txtSolution
            // 
            this.txtSolution.Location = new System.Drawing.Point(191, 265);
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.Size = new System.Drawing.Size(342, 22);
            this.txtSolution.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 384);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 33);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Затвори";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(45, 384);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(157, 33);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Нова диагностика";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Location = new System.Drawing.Point(42, 104);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(90, 16);
            this.lblUserInfo.TabIndex = 6;
            this.lblUserInfo.Text = "Потребител:";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(504, 392);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(79, 16);
            this.lblDateTime.TabIndex = 7;
            this.lblDateTime.Text = "Дата и час:";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(300, 33);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(143, 29);
            this.lblResults.TabIndex = 8;
            this.lblResults.Text = "Резултати";
            // 
            // lblResDam
            // 
            this.lblResDam.AutoSize = true;
            this.lblResDam.Location = new System.Drawing.Point(42, 187);
            this.lblResDam.Name = "lblResDam";
            this.lblResDam.Size = new System.Drawing.Size(94, 16);
            this.lblResDam.TabIndex = 9;
            this.lblResDam.Text = "Вид повреда:";
            // 
            // lblResSol
            // 
            this.lblResSol.AutoSize = true;
            this.lblResSol.Location = new System.Drawing.Point(42, 265);
            this.lblResSol.Name = "lblResSol";
            this.lblResSol.Size = new System.Drawing.Size(51, 16);
            this.lblResSol.TabIndex = 10;
            this.lblResSol.Text = "Съвет:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(45, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 29);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Запази резултат";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblResSol);
            this.Controls.Add(this.lblResDam);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSolution);
            this.Controls.Add(this.txtDamage);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUser);
            this.Name = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDamage;
        private System.Windows.Forms.TextBox txtSolution;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblResDam;
        private System.Windows.Forms.Label lblResSol;
        private System.Windows.Forms.Button btnSave;
    }
}