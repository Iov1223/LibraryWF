namespace LibraryWF
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
            this.comboBoxBooks = new System.Windows.Forms.ComboBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.buttonAddToLibrary = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPlaceNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxBooks
            // 
            this.comboBoxBooks.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxBooks.FormattingEnabled = true;
            this.comboBoxBooks.Location = new System.Drawing.Point(7, 269);
            this.comboBoxBooks.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBooks.Name = "comboBoxBooks";
            this.comboBoxBooks.Size = new System.Drawing.Size(582, 27);
            this.comboBoxBooks.TabIndex = 0;
            this.comboBoxBooks.Text = "Выбор произведения";
            this.comboBoxBooks.SelectedIndexChanged += new System.EventHandler(this.comboBoxBooks_SelectedIndexChanged);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAuthor.Location = new System.Drawing.Point(7, 69);
            this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(409, 24);
            this.textBoxAuthor.TabIndex = 1;
            this.textBoxAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAuthor_KeyPress);
            // 
            // buttonAddToLibrary
            // 
            this.buttonAddToLibrary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddToLibrary.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToLibrary.ForeColor = System.Drawing.Color.Black;
            this.buttonAddToLibrary.Location = new System.Drawing.Point(236, 176);
            this.buttonAddToLibrary.Name = "buttonAddToLibrary";
            this.buttonAddToLibrary.Size = new System.Drawing.Size(180, 24);
            this.buttonAddToLibrary.TabIndex = 2;
            this.buttonAddToLibrary.Text = "Добавить в библиотеку";
            this.buttonAddToLibrary.UseVisualStyleBackColor = false;
            this.buttonAddToLibrary.Click += new System.EventHandler(this.buttonAddToLibrary_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle.Location = new System.Drawing.Point(7, 121);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(409, 24);
            this.textBoxTitle.TabIndex = 3;
            // 
            // textBoxPlaceNumber
            // 
            this.textBoxPlaceNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPlaceNumber.Location = new System.Drawing.Point(7, 176);
            this.textBoxPlaceNumber.Name = "textBoxPlaceNumber";
            this.textBoxPlaceNumber.Size = new System.Drawing.Size(195, 24);
            this.textBoxPlaceNumber.TabIndex = 4;
            this.textBoxPlaceNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPlaceNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Удаление произведения из библиотеки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Добавить произведение в библиотеку:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Автор:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Название:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Номер места расположения:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LibraryWF.Properties.Resources.Library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 307);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPlaceNumber);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonAddToLibrary);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.comboBoxBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(616, 346);
            this.MinimumSize = new System.Drawing.Size(616, 346);
            this.Name = "Form1";
            this.Text = "Форма добавления и удвления книг";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBooks;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Button buttonAddToLibrary;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPlaceNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

