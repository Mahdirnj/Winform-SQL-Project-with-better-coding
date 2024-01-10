
namespace Winform_SQL_Project
{
    partial class frmEdit
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmitEdit = new System.Windows.Forms.Button();
            this.txtEditLast = new System.Windows.Forms.TextBox();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(487, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 27);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmitEdit
            // 
            this.btnSubmitEdit.BackColor = System.Drawing.Color.DarkRed;
            this.btnSubmitEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSubmitEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitEdit.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEdit.Location = new System.Drawing.Point(101, 235);
            this.btnSubmitEdit.Name = "btnSubmitEdit";
            this.btnSubmitEdit.Size = new System.Drawing.Size(89, 27);
            this.btnSubmitEdit.TabIndex = 12;
            this.btnSubmitEdit.Text = "Edit";
            this.btnSubmitEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSubmitEdit.UseVisualStyleBackColor = false;
            this.btnSubmitEdit.Click += new System.EventHandler(this.btnSubmitEdit_Click);
            // 
            // txtEditLast
            // 
            this.txtEditLast.BackColor = System.Drawing.Color.Black;
            this.txtEditLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditLast.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEditLast.Location = new System.Drawing.Point(463, 15);
            this.txtEditLast.Name = "txtEditLast";
            this.txtEditLast.Size = new System.Drawing.Size(204, 34);
            this.txtEditLast.TabIndex = 9;
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.BackColor = System.Drawing.Color.Black;
            this.txtEditEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditEmail.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEditEmail.Location = new System.Drawing.Point(101, 141);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(475, 34);
            this.txtEditEmail.TabIndex = 11;
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.BackColor = System.Drawing.Color.Black;
            this.txtEditPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditPhone.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEditPhone.Location = new System.Drawing.Point(101, 74);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(204, 34);
            this.txtEditPhone.TabIndex = 10;
            // 
            // txtEditName
            // 
            this.txtEditName.BackColor = System.Drawing.Color.Black;
            this.txtEditName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEditName.Location = new System.Drawing.Point(101, 12);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(204, 34);
            this.txtEditName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(326, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "*Last Name  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "*Phone :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "*Name :";
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(692, 279);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmitEdit);
            this.Controls.Add(this.txtEditLast);
            this.Controls.Add(this.txtEditEmail);
            this.Controls.Add(this.txtEditPhone);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Contact";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmitEdit;
        private System.Windows.Forms.TextBox txtEditLast;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.TextBox txtEditPhone;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}