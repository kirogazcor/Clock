namespace Clock
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.типЧасовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналоговыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цифровыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стрелкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.секундыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.циферблатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.арабскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеЦифрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.римскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеЦифрыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iIIVIIXXIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безЦифрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типЧасовToolStripMenuItem,
            this.изображениеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // типЧасовToolStripMenuItem
            // 
            this.типЧасовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аналоговыеToolStripMenuItem,
            this.цифровыеToolStripMenuItem});
            this.типЧасовToolStripMenuItem.Name = "типЧасовToolStripMenuItem";
            this.типЧасовToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.типЧасовToolStripMenuItem.Text = "Тип часов";
            // 
            // аналоговыеToolStripMenuItem
            // 
            this.аналоговыеToolStripMenuItem.Checked = true;
            this.аналоговыеToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.аналоговыеToolStripMenuItem.Name = "аналоговыеToolStripMenuItem";
            this.аналоговыеToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.аналоговыеToolStripMenuItem.Text = "Аналоговые";
            this.аналоговыеToolStripMenuItem.Click += new System.EventHandler(this.аналоговыеToolStripMenuItem_Click);
            // 
            // цифровыеToolStripMenuItem
            // 
            this.цифровыеToolStripMenuItem.Name = "цифровыеToolStripMenuItem";
            this.цифровыеToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.цифровыеToolStripMenuItem.Text = "Цифровые";
            this.цифровыеToolStripMenuItem.Click += new System.EventHandler(this.цифровыеToolStripMenuItem_Click);
            // 
            // изображениеToolStripMenuItem
            // 
            this.изображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стрелкиToolStripMenuItem,
            this.циферблатToolStripMenuItem,
            this.цветФонаToolStripMenuItem,
            this.toolStripMenuItem1,
            this.шрифтToolStripMenuItem,
            this.датаToolStripMenuItem});
            this.изображениеToolStripMenuItem.Name = "изображениеToolStripMenuItem";
            this.изображениеToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.изображениеToolStripMenuItem.Text = "Изображение";
            // 
            // стрелкиToolStripMenuItem
            // 
            this.стрелкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.секундыToolStripMenuItem,
            this.цветToolStripMenuItem});
            this.стрелкиToolStripMenuItem.Name = "стрелкиToolStripMenuItem";
            this.стрелкиToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.стрелкиToolStripMenuItem.Text = "Стрелки";
            // 
            // секундыToolStripMenuItem
            // 
            this.секундыToolStripMenuItem.Checked = true;
            this.секундыToolStripMenuItem.CheckOnClick = true;
            this.секундыToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.секундыToolStripMenuItem.Name = "секундыToolStripMenuItem";
            this.секундыToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.секундыToolStripMenuItem.Text = "Секунды";
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.цветToolStripMenuItem.Text = "Цвет";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.цветToolStripMenuItem_Click);
            // 
            // циферблатToolStripMenuItem
            // 
            this.циферблатToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.арабскийToolStripMenuItem,
            this.римскийToolStripMenuItem,
            this.безЦифрToolStripMenuItem});
            this.циферблатToolStripMenuItem.Name = "циферблатToolStripMenuItem";
            this.циферблатToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.циферблатToolStripMenuItem.Text = "Циферблат";
            // 
            // арабскийToolStripMenuItem
            // 
            this.арабскийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеЦифрыToolStripMenuItem,
            this.toolStripMenuItem3});
            this.арабскийToolStripMenuItem.Name = "арабскийToolStripMenuItem";
            this.арабскийToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.арабскийToolStripMenuItem.Text = "Арабский";
            // 
            // всеЦифрыToolStripMenuItem
            // 
            this.всеЦифрыToolStripMenuItem.Checked = true;
            this.всеЦифрыToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.всеЦифрыToolStripMenuItem.Name = "всеЦифрыToolStripMenuItem";
            this.всеЦифрыToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.всеЦифрыToolStripMenuItem.Text = "Все цифры";
            this.всеЦифрыToolStripMenuItem.Click += new System.EventHandler(this.всеЦифрыToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItem3.Text = "3, 6, 9, 12";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // римскийToolStripMenuItem
            // 
            this.римскийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеЦифрыToolStripMenuItem1,
            this.iIIVIIXXIIToolStripMenuItem});
            this.римскийToolStripMenuItem.Name = "римскийToolStripMenuItem";
            this.римскийToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.римскийToolStripMenuItem.Text = "Римский";
            // 
            // всеЦифрыToolStripMenuItem1
            // 
            this.всеЦифрыToolStripMenuItem1.Name = "всеЦифрыToolStripMenuItem1";
            this.всеЦифрыToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.всеЦифрыToolStripMenuItem1.Text = "Все цифры";
            this.всеЦифрыToolStripMenuItem1.Click += new System.EventHandler(this.всеЦифрыToolStripMenuItem1_Click);
            // 
            // iIIVIIXXIIToolStripMenuItem
            // 
            this.iIIVIIXXIIToolStripMenuItem.Name = "iIIVIIXXIIToolStripMenuItem";
            this.iIIVIIXXIIToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.iIIVIIXXIIToolStripMenuItem.Text = "III, VI, IX, XII";
            this.iIIVIIXXIIToolStripMenuItem.Click += new System.EventHandler(this.iIIVIIXXIIToolStripMenuItem_Click);
            // 
            // безЦифрToolStripMenuItem
            // 
            this.безЦифрToolStripMenuItem.Name = "безЦифрToolStripMenuItem";
            this.безЦифрToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.безЦифрToolStripMenuItem.Text = "Без цифр";
            this.безЦифрToolStripMenuItem.Click += new System.EventHandler(this.безЦифрToolStripMenuItem_Click);
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.цветФонаToolStripMenuItem.Text = "Цвет фона";
            this.цветФонаToolStripMenuItem.Click += new System.EventHandler(this.цветФонаToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItem1.Text = "Цвет цифр";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Enabled = false;
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // датаToolStripMenuItem
            // 
            this.датаToolStripMenuItem.CheckOnClick = true;
            this.датаToolStripMenuItem.Enabled = false;
            this.датаToolStripMenuItem.Name = "датаToolStripMenuItem";
            this.датаToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.датаToolStripMenuItem.Text = "Дата";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 235);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clock.Properties.Resources.clock_A1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Часы";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem типЧасовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аналоговыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цифровыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стрелкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem секундыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem циферблатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem арабскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem римскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem безЦифрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem всеЦифрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem всеЦифрыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iIIVIIXXIIToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

