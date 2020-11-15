namespace GitClient
{
    sealed partial class MainWindow
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Push = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиТемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeRepositoryButton = new System.Windows.Forms.Button();
            this.ChangePathButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 56);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(633, 183);
            this.treeView1.TabIndex = 3;
            // 
            // Push
            // 
            this.Push.Location = new System.Drawing.Point(289, 245);
            this.Push.Name = "Push";
            this.Push.Size = new System.Drawing.Size(75, 23);
            this.Push.TabIndex = 5;
            this.Push.Text = "Отправить";
            this.Push.UseVisualStyleBackColor = true;
            this.Push.Click += new System.EventHandler(this.PushButtonClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.параметрыToolStripMenuItem, this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.настройкиТемыToolStripMenuItem});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // настройкиТемыToolStripMenuItem
            // 
            this.настройкиТемыToolStripMenuItem.Name = "настройкиТемыToolStripMenuItem";
            this.настройкиТемыToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.настройкиТемыToolStripMenuItem.Text = "Настройки темы";
            this.настройкиТемыToolStripMenuItem.Click += new System.EventHandler(this.настройкиТемыToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // ChangeRepositoryButton
            // 
            this.ChangeRepositoryButton.Location = new System.Drawing.Point(12, 27);
            this.ChangeRepositoryButton.Name = "ChangeRepositoryButton";
            this.ChangeRepositoryButton.Size = new System.Drawing.Size(144, 23);
            this.ChangeRepositoryButton.TabIndex = 7;
            this.ChangeRepositoryButton.Text = "Изменить репозиторий";
            this.ChangeRepositoryButton.UseVisualStyleBackColor = true;
            this.ChangeRepositoryButton.Click += new System.EventHandler(this.ChangeRepositoryButton_Click);
            // 
            // ChangePathButton
            // 
            this.ChangePathButton.Location = new System.Drawing.Point(162, 27);
            this.ChangePathButton.Name = "ChangePathButton";
            this.ChangePathButton.Size = new System.Drawing.Size(121, 23);
            this.ChangePathButton.TabIndex = 8;
            this.ChangePathButton.Text = "Изменить путь";
            this.ChangePathButton.UseVisualStyleBackColor = true;
            this.ChangePathButton.Click += new System.EventHandler(this.ChangePathButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 280);
            this.Controls.Add(this.ChangePathButton);
            this.Controls.Add(this.ChangeRepositoryButton);
            this.Controls.Add(this.Push);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "GitClient";
            this.Load += new System.EventHandler(this.MainWindowLoadAsync);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button ChangePathButton;
        private System.Windows.Forms.Button ChangeRepositoryButton;

        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиТемыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;

        private System.Windows.Forms.Button Push;

        private System.Windows.Forms.TreeView treeView1;

        #endregion
    }
}

