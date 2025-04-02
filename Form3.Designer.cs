namespace TravelGuide
{
    partial class FormEdit
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
            this.LabelEditName = new System.Windows.Forms.Label();
            this.LabelEditDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonEditAccept = new System.Windows.Forms.Button();
            this.TextBoxEditName = new System.Windows.Forms.TextBox();
            this.TextBoxEditDescription = new System.Windows.Forms.TextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ButtonEditPicture1 = new System.Windows.Forms.Button();
            this.ButtonEditPicture2 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonEditPictureDelete1 = new System.Windows.Forms.Button();
            this.ButtonEditPictureDelete2 = new System.Windows.Forms.Button();
            this.LabelEdit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelEditName
            // 
            this.LabelEditName.AutoSize = true;
            this.LabelEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEditName.Location = new System.Drawing.Point(12, 153);
            this.LabelEditName.Name = "LabelEditName";
            this.LabelEditName.Size = new System.Drawing.Size(105, 25);
            this.LabelEditName.TabIndex = 0;
            this.LabelEditName.Text = "Название:";
            // 
            // LabelEditDescription
            // 
            this.LabelEditDescription.AutoSize = true;
            this.LabelEditDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEditDescription.Location = new System.Drawing.Point(12, 206);
            this.LabelEditDescription.Name = "LabelEditDescription";
            this.LabelEditDescription.Size = new System.Drawing.Size(108, 25);
            this.LabelEditDescription.TabIndex = 1;
            this.LabelEditDescription.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(392, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фото №1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(392, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фото №2:";
            // 
            // ButtonEditAccept
            // 
            this.ButtonEditAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEditAccept.Location = new System.Drawing.Point(307, 388);
            this.ButtonEditAccept.Name = "ButtonEditAccept";
            this.ButtonEditAccept.Size = new System.Drawing.Size(157, 77);
            this.ButtonEditAccept.TabIndex = 4;
            this.ButtonEditAccept.Text = "Изм/Доб";
            this.ButtonEditAccept.UseVisualStyleBackColor = true;
            this.ButtonEditAccept.Click += new System.EventHandler(this.ButtonEditAccept_Click);
            // 
            // TextBoxEditName
            // 
            this.TextBoxEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxEditName.Location = new System.Drawing.Point(123, 152);
            this.TextBoxEditName.MaxLength = 25;
            this.TextBoxEditName.Name = "TextBoxEditName";
            this.TextBoxEditName.Size = new System.Drawing.Size(243, 26);
            this.TextBoxEditName.TabIndex = 5;
            // 
            // TextBoxEditDescription
            // 
            this.TextBoxEditDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxEditDescription.Location = new System.Drawing.Point(123, 207);
            this.TextBoxEditDescription.Multiline = true;
            this.TextBoxEditDescription.Name = "TextBoxEditDescription";
            this.TextBoxEditDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxEditDescription.Size = new System.Drawing.Size(243, 158);
            this.TextBoxEditDescription.TabIndex = 6;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "Изображения (*.png)|*.png|Изображения (*.jpg)|*.jpg";
            this.OpenFileDialog.Title = "Выберите изображение...";
            // 
            // ButtonEditPicture1
            // 
            this.ButtonEditPicture1.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditPicture1.Location = new System.Drawing.Point(692, 156);
            this.ButtonEditPicture1.Name = "ButtonEditPicture1";
            this.ButtonEditPicture1.Size = new System.Drawing.Size(38, 25);
            this.ButtonEditPicture1.TabIndex = 9;
            this.ButtonEditPicture1.Text = "...";
            this.ButtonEditPicture1.UseVisualStyleBackColor = true;
            this.ButtonEditPicture1.Click += new System.EventHandler(this.ButtonEditPicture1_Click);
            // 
            // ButtonEditPicture2
            // 
            this.ButtonEditPicture2.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditPicture2.Location = new System.Drawing.Point(692, 269);
            this.ButtonEditPicture2.Name = "ButtonEditPicture2";
            this.ButtonEditPicture2.Size = new System.Drawing.Size(38, 25);
            this.ButtonEditPicture2.TabIndex = 10;
            this.ButtonEditPicture2.Text = "...";
            this.ButtonEditPicture2.UseVisualStyleBackColor = true;
            this.ButtonEditPicture2.Click += new System.EventHandler(this.ButtonEditPicture2_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.PictureBox1.Location = new System.Drawing.Point(504, 153);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(182, 105);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 11;
            this.PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.PictureBox2.Location = new System.Drawing.Point(504, 267);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(182, 105);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 12;
            this.PictureBox2.TabStop = false;
            // 
            // ButtonEditPictureDelete1
            // 
            this.ButtonEditPictureDelete1.Enabled = false;
            this.ButtonEditPictureDelete1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEditPictureDelete1.ForeColor = System.Drawing.Color.Red;
            this.ButtonEditPictureDelete1.Location = new System.Drawing.Point(693, 187);
            this.ButtonEditPictureDelete1.Name = "ButtonEditPictureDelete1";
            this.ButtonEditPictureDelete1.Size = new System.Drawing.Size(37, 23);
            this.ButtonEditPictureDelete1.TabIndex = 13;
            this.ButtonEditPictureDelete1.Text = "X";
            this.ButtonEditPictureDelete1.UseVisualStyleBackColor = true;
            this.ButtonEditPictureDelete1.Click += new System.EventHandler(this.ButtonEditPictureDelete1_Click);
            // 
            // ButtonEditPictureDelete2
            // 
            this.ButtonEditPictureDelete2.Enabled = false;
            this.ButtonEditPictureDelete2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEditPictureDelete2.ForeColor = System.Drawing.Color.Red;
            this.ButtonEditPictureDelete2.Location = new System.Drawing.Point(692, 300);
            this.ButtonEditPictureDelete2.Name = "ButtonEditPictureDelete2";
            this.ButtonEditPictureDelete2.Size = new System.Drawing.Size(37, 23);
            this.ButtonEditPictureDelete2.TabIndex = 14;
            this.ButtonEditPictureDelete2.Text = "X";
            this.ButtonEditPictureDelete2.UseVisualStyleBackColor = true;
            this.ButtonEditPictureDelete2.Click += new System.EventHandler(this.ButtonEditPictureDelete2_Click);
            // 
            // LabelEdit
            // 
            this.LabelEdit.AutoSize = true;
            this.LabelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEdit.Location = new System.Drawing.Point(12, 9);
            this.LabelEdit.Name = "LabelEdit";
            this.LabelEdit.Size = new System.Drawing.Size(684, 100);
            this.LabelEdit.TabIndex = 15;
            this.LabelEdit.Text = "Помощь:\r\n1) поля \"Название\" и \"Описание\" должны быть обязательно заполнены;\r\n2) н" +
    "азвание города не должно повторяться;\r\n3) чтобы отменить редактирование, закройт" +
    "е данное окно.";
            this.LabelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 477);
            this.Controls.Add(this.LabelEdit);
            this.Controls.Add(this.ButtonEditPictureDelete2);
            this.Controls.Add(this.ButtonEditPictureDelete1);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.ButtonEditPicture2);
            this.Controls.Add(this.ButtonEditPicture1);
            this.Controls.Add(this.TextBoxEditDescription);
            this.Controls.Add(this.TextBoxEditName);
            this.Controls.Add(this.ButtonEditAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelEditDescription);
            this.Controls.Add(this.LabelEditName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор таблицы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEdit_FormClosing);
            this.Load += new System.EventHandler(this.FormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelEditName;
        private System.Windows.Forms.Label LabelEditDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonEditAccept;
        private System.Windows.Forms.TextBox TextBoxEditName;
        private System.Windows.Forms.TextBox TextBoxEditDescription;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button ButtonEditPicture1;
        private System.Windows.Forms.Button ButtonEditPicture2;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.Button ButtonEditPictureDelete1;
        private System.Windows.Forms.Button ButtonEditPictureDelete2;
        private System.Windows.Forms.Label LabelEdit;
    }
}