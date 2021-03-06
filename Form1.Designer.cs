
namespace ReadFromFile
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
            this.inputOwnerName = new System.Windows.Forms.TextBox();
            this.inputEmploee = new System.Windows.Forms.TextBox();
            this.inputNameOfBussiness = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnNameOf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddEmploee = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.deleteText = new System.Windows.Forms.TextBox();
            this.updateText = new System.Windows.Forms.TextBox();
            this.updateTo = new System.Windows.Forms.TextBox();
            this.lblEror = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteALL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputOwnerName
            // 
            this.inputOwnerName.Location = new System.Drawing.Point(180, 42);
            this.inputOwnerName.Name = "inputOwnerName";
            this.inputOwnerName.Size = new System.Drawing.Size(100, 22);
            this.inputOwnerName.TabIndex = 0;
            this.inputOwnerName.TextChanged += new System.EventHandler(this.inputManagerName_TextChanged);
            // 
            // inputEmploee
            // 
            this.inputEmploee.Location = new System.Drawing.Point(180, 187);
            this.inputEmploee.Name = "inputEmploee";
            this.inputEmploee.Size = new System.Drawing.Size(100, 22);
            this.inputEmploee.TabIndex = 1;
            // 
            // inputNameOfBussiness
            // 
            this.inputNameOfBussiness.Location = new System.Drawing.Point(180, 109);
            this.inputNameOfBussiness.Name = "inputNameOfBussiness";
            this.inputNameOfBussiness.Size = new System.Drawing.Size(100, 22);
            this.inputNameOfBussiness.TabIndex = 2;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(194, 232);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(164, 294);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(205, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(460, 130);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(136, 23);
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.Text = "Read Text File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnNameOf
            // 
            this.btnNameOf.AutoSize = true;
            this.btnNameOf.Location = new System.Drawing.Point(68, 42);
            this.btnNameOf.Name = "btnNameOf";
            this.btnNameOf.Size = new System.Drawing.Size(90, 17);
            this.btnNameOf.TabIndex = 7;
            this.btnNameOf.Text = "Owner Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name Of Bussiness";
            // 
            // AddEmploee
            // 
            this.AddEmploee.AutoSize = true;
            this.AddEmploee.Location = new System.Drawing.Point(69, 192);
            this.AddEmploee.Name = "AddEmploee";
            this.AddEmploee.Size = new System.Drawing.Size(102, 17);
            this.AddEmploee.TabIndex = 9;
            this.AddEmploee.Text = "New Emploee?";
            this.AddEmploee.Click += new System.EventHandler(this.label3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(361, 168);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 225);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // deleteText
            // 
            this.deleteText.Location = new System.Drawing.Point(47, 371);
            this.deleteText.Name = "deleteText";
            this.deleteText.Size = new System.Drawing.Size(136, 22);
            this.deleteText.TabIndex = 11;
            this.deleteText.Text = "What To Delete?";
            this.deleteText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // updateText
            // 
            this.updateText.Location = new System.Drawing.Point(34, 267);
            this.updateText.Name = "updateText";
            this.updateText.Size = new System.Drawing.Size(124, 22);
            this.updateText.TabIndex = 12;
            this.updateText.Text = "What To Update?";
            // 
            // updateTo
            // 
            this.updateTo.Location = new System.Drawing.Point(47, 295);
            this.updateTo.Name = "updateTo";
            this.updateTo.Size = new System.Drawing.Size(100, 22);
            this.updateTo.TabIndex = 13;
            this.updateTo.Text = "updated Text ";
            // 
            // lblEror
            // 
            this.lblEror.AutoSize = true;
            this.lblEror.Location = new System.Drawing.Point(19, 323);
            this.lblEror.Name = "lblEror";
            this.lblEror.Size = new System.Drawing.Size(0, 17);
            this.lblEror.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "עבודה עם קבצים";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDeleteALL
            // 
            this.btnDeleteALL.Location = new System.Drawing.Point(482, 399);
            this.btnDeleteALL.Name = "btnDeleteALL";
            this.btnDeleteALL.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteALL.TabIndex = 16;
            this.btnDeleteALL.Text = "Delete ALL";
            this.btnDeleteALL.UseVisualStyleBackColor = true;
            this.btnDeleteALL.UseWaitCursor = true;
            this.btnDeleteALL.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteALL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEror);
            this.Controls.Add(this.updateTo);
            this.Controls.Add(this.updateText);
            this.Controls.Add(this.deleteText);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.AddEmploee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNameOf);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.inputNameOfBussiness);
            this.Controls.Add(this.inputEmploee);
            this.Controls.Add(this.inputOwnerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputOwnerName;
        private System.Windows.Forms.TextBox inputEmploee;
        private System.Windows.Forms.TextBox inputNameOfBussiness;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label btnNameOf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AddEmploee;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox deleteText;
        private System.Windows.Forms.TextBox updateText;
        private System.Windows.Forms.TextBox updateTo;
        private System.Windows.Forms.Label lblEror;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteALL;
    }
}

