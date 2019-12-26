namespace Library
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.задолженностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DebtsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BooksAdministrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersAdministrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DebtorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.YellowGreen;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задолженностиToolStripMenuItem,
            this.окноToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // задолженностиToolStripMenuItem
            // 
            this.задолженностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DebtsToolStripMenuItem1,
            this.DebtorsToolStripMenuItem});
            this.задолженностиToolStripMenuItem.Name = "задолженностиToolStripMenuItem";
            this.задолженностиToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.задолженностиToolStripMenuItem.Text = "Задолженности";
            // 
            // DebtsToolStripMenuItem1
            // 
            this.DebtsToolStripMenuItem1.Name = "DebtsToolStripMenuItem1";
            this.DebtsToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.DebtsToolStripMenuItem1.Text = "Показать задолженности";
            this.DebtsToolStripMenuItem1.Click += new System.EventHandler(this.DebtsToolStripMenuItem1_Click);
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BooksAdministrationToolStripMenuItem,
            this.UsersAdministrationToolStripMenuItem});
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.окноToolStripMenuItem.Text = "Окно";
            // 
            // BooksAdministrationToolStripMenuItem
            // 
            this.BooksAdministrationToolStripMenuItem.Name = "BooksAdministrationToolStripMenuItem";
            this.BooksAdministrationToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.BooksAdministrationToolStripMenuItem.Text = "Управление книгами";
            this.BooksAdministrationToolStripMenuItem.Click += new System.EventHandler(this.BooksAdministrationToolStripMenuItem_Click);
            // 
            // UsersAdministrationToolStripMenuItem
            // 
            this.UsersAdministrationToolStripMenuItem.Name = "UsersAdministrationToolStripMenuItem";
            this.UsersAdministrationToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.UsersAdministrationToolStripMenuItem.Text = "Управление пользователями";
            this.UsersAdministrationToolStripMenuItem.Click += new System.EventHandler(this.UsersAdministrationToolStripMenuItem_Click);
            // 
            // DebtorsToolStripMenuItem
            // 
            this.DebtorsToolStripMenuItem.Name = "DebtorsToolStripMenuItem";
            this.DebtorsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.DebtorsToolStripMenuItem.Text = "Показать должников";
            this.DebtorsToolStripMenuItem.Click += new System.EventHandler(this.DebtorsToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BooksAdministrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersAdministrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задолженностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DebtsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DebtorsToolStripMenuItem;
    }
}

