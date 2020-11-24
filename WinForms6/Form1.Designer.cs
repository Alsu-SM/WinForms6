namespace WinForms6
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСГрафомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чтениеИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранениеВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСГрафомToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВершинуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРеброToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВершинуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьРеброToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(257, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 294);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСГрафомToolStripMenuItem,
            this.работаСГрафомToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСГрафомToolStripMenuItem
            // 
            this.работаСГрафомToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чтениеИзФайлаToolStripMenuItem,
            this.сохранениеВФайлToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.работаСГрафомToolStripMenuItem.Name = "работаСГрафомToolStripMenuItem";
            this.работаСГрафомToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.работаСГрафомToolStripMenuItem.Text = "Файл";
            // 
            // чтениеИзФайлаToolStripMenuItem
            // 
            this.чтениеИзФайлаToolStripMenuItem.Name = "чтениеИзФайлаToolStripMenuItem";
            this.чтениеИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.чтениеИзФайлаToolStripMenuItem.Text = "Чтение из файла";
            this.чтениеИзФайлаToolStripMenuItem.Click += new System.EventHandler(this.чтениеИзФайлаToolStripMenuItem_Click);
            // 
            // сохранениеВФайлToolStripMenuItem
            // 
            this.сохранениеВФайлToolStripMenuItem.Name = "сохранениеВФайлToolStripMenuItem";
            this.сохранениеВФайлToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.сохранениеВФайлToolStripMenuItem.Text = "Сохранение в файл";
            this.сохранениеВФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранениеВФайлToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // работаСГрафомToolStripMenuItem1
            // 
            this.работаСГрафомToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВершинуToolStripMenuItem,
            this.добавитьРеброToolStripMenuItem,
            this.удалитьВершинуToolStripMenuItem,
            this.удалитьРеброToolStripMenuItem});
            this.работаСГрафомToolStripMenuItem1.Name = "работаСГрафомToolStripMenuItem1";
            this.работаСГрафомToolStripMenuItem1.Size = new System.Drawing.Size(112, 20);
            this.работаСГрафомToolStripMenuItem1.Text = "Работа с графом";
            // 
            // добавитьВершинуToolStripMenuItem
            // 
            this.добавитьВершинуToolStripMenuItem.Name = "добавитьВершинуToolStripMenuItem";
            this.добавитьВершинуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьВершинуToolStripMenuItem.Text = "Добавить вершину";
            this.добавитьВершинуToolStripMenuItem.Click += new System.EventHandler(this.добавитьВершинуToolStripMenuItem_Click);
            // 
            // добавитьРеброToolStripMenuItem
            // 
            this.добавитьРеброToolStripMenuItem.Name = "добавитьРеброToolStripMenuItem";
            this.добавитьРеброToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьРеброToolStripMenuItem.Text = "Добавить ребро";
            this.добавитьРеброToolStripMenuItem.Click += new System.EventHandler(this.добавитьРеброToolStripMenuItem_Click);
            // 
            // удалитьВершинуToolStripMenuItem
            // 
            this.удалитьВершинуToolStripMenuItem.Name = "удалитьВершинуToolStripMenuItem";
            this.удалитьВершинуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьВершинуToolStripMenuItem.Text = "Удалить вершину";
            this.удалитьВершинуToolStripMenuItem.Click += new System.EventHandler(this.удалитьВершинуToolStripMenuItem_Click);
            // 
            // удалитьРеброToolStripMenuItem
            // 
            this.удалитьРеброToolStripMenuItem.Name = "удалитьРеброToolStripMenuItem";
            this.удалитьРеброToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьРеброToolStripMenuItem.Text = "Удалить ребро";
            this.удалитьРеброToolStripMenuItem.Click += new System.EventHandler(this.удалитьРеброToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Свойства графа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Двудольность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Граф Эйлеров:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(229, 199);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Операции с ребрами:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Вершина 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Вершина 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 327);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(34, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Операция с вершинами:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Номер вершины";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 401);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(34, 20);
            this.textBox3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 470);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Работа с графом";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСГрафомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чтениеИзФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранениеВФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСГрафомToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьВершинуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРеброToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВершинуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьРеброToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
    }
}

