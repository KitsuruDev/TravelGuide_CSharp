namespace TravelGuide
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemCities = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCitiesConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditModify = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProgramAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.LabelMain = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelMainWelcome = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCities,
            this.MenuItemEdit,
            this.MenuItemProgram});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1087, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "Подменю";
            // 
            // MenuItemCities
            // 
            this.MenuItemCities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCitiesConnect});
            this.MenuItemCities.Name = "MenuItemCities";
            this.MenuItemCities.Size = new System.Drawing.Size(135, 24);
            this.MenuItemCities.Text = "Список городов";
            // 
            // MenuItemCitiesConnect
            // 
            this.MenuItemCitiesConnect.Name = "MenuItemCitiesConnect";
            this.MenuItemCitiesConnect.Size = new System.Drawing.Size(224, 26);
            this.MenuItemCitiesConnect.Text = "Вывести на экран...";
            this.MenuItemCitiesConnect.Click += new System.EventHandler(this.MenuItemCitiesConnect_Click);
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEditModify,
            this.MenuItemEditDelete,
            this.MenuItemEditAdd});
            this.MenuItemEdit.Enabled = false;
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.Size = new System.Drawing.Size(137, 24);
            this.MenuItemEdit.Text = "Редактирование";
            // 
            // MenuItemEditModify
            // 
            this.MenuItemEditModify.Enabled = false;
            this.MenuItemEditModify.Name = "MenuItemEditModify";
            this.MenuItemEditModify.Size = new System.Drawing.Size(308, 26);
            this.MenuItemEditModify.Text = "Изменить выделенный город...";
            this.MenuItemEditModify.Click += new System.EventHandler(this.MenuItemEditModify_Click);
            // 
            // MenuItemEditDelete
            // 
            this.MenuItemEditDelete.Enabled = false;
            this.MenuItemEditDelete.Name = "MenuItemEditDelete";
            this.MenuItemEditDelete.Size = new System.Drawing.Size(308, 26);
            this.MenuItemEditDelete.Text = "Удалить выделенный город...";
            this.MenuItemEditDelete.Click += new System.EventHandler(this.MenuItemEditDelete_Click);
            // 
            // MenuItemEditAdd
            // 
            this.MenuItemEditAdd.Name = "MenuItemEditAdd";
            this.MenuItemEditAdd.Size = new System.Drawing.Size(308, 26);
            this.MenuItemEditAdd.Text = "Добавить новый город...";
            this.MenuItemEditAdd.Click += new System.EventHandler(this.MenuItemEditAdd_Click);
            // 
            // MenuItemProgram
            // 
            this.MenuItemProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemProgramAbout});
            this.MenuItemProgram.Name = "MenuItemProgram";
            this.MenuItemProgram.Size = new System.Drawing.Size(81, 24);
            this.MenuItemProgram.Text = "Справка";
            // 
            // MenuItemProgramAbout
            // 
            this.MenuItemProgramAbout.Name = "MenuItemProgramAbout";
            this.MenuItemProgramAbout.Size = new System.Drawing.Size(196, 26);
            this.MenuItemProgramAbout.Text = "О программе...";
            this.MenuItemProgramAbout.Click += new System.EventHandler(this.MenuItemProgramAbout_Click);
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.SystemColors.Window;
            this.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ListBox.ItemHeight = 22;
            this.ListBox.Location = new System.Drawing.Point(12, 51);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(254, 486);
            this.ListBox.Sorted = true;
            this.ListBox.TabIndex = 1;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // LabelMain
            // 
            this.LabelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMain.Location = new System.Drawing.Point(749, 111);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(326, 32);
            this.LabelMain.TabIndex = 2;
            this.LabelMain.Text = "Выберите город";
            this.LabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelMain.Visible = false;
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(736, 164);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(339, 373);
            this.TextBox.TabIndex = 3;
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox.Visible = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Location = new System.Drawing.Point(291, 309);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(428, 211);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 4;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Visible = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(291, 69);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(428, 211);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Visible = false;
            // 
            // LabelMainWelcome
            // 
            this.LabelMainWelcome.AutoSize = true;
            this.LabelMainWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMainWelcome.Location = new System.Drawing.Point(279, 164);
            this.LabelMainWelcome.Name = "LabelMainWelcome";
            this.LabelMainWelcome.Size = new System.Drawing.Size(796, 203);
            this.LabelMainWelcome.TabIndex = 6;
            this.LabelMainWelcome.Text = resources.GetString("LabelMainWelcome.Text");
            this.LabelMainWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 549);
            this.Controls.Add(this.LabelMainWelcome);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.LabelMain);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.MenuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Путеводитель по городам России";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCities;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCitiesConnect;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Label LabelMain;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditModify;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditDelete;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProgram;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProgramAbout;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label LabelMainWelcome;
    }
}

