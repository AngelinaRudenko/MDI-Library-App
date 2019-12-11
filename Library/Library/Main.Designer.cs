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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.импортэкспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BooksAdministrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersAdministrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.YellowGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортэкспортToolStripMenuItem,
            this.окноToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // импортэкспортToolStripMenuItem
            // 
            this.импортэкспортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportToolStripMenuItem,
            this.ExportToolStripMenuItem});
            this.импортэкспортToolStripMenuItem.Name = "импортэкспортToolStripMenuItem";
            this.импортэкспортToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.импортэкспортToolStripMenuItem.Text = "Импорт/экспорт";
            // 
            // ImportToolStripMenuItem
            // 
            this.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            this.ImportToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ImportToolStripMenuItem.Text = "Импорт";
            // 
            // ExportToolStripMenuItem
            // 
            this.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            this.ExportToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ExportToolStripMenuItem.Text = "Экспорт";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem импортэкспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BooksAdministrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersAdministrationToolStripMenuItem;
    }
}

