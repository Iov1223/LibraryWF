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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPlaceNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxBooks
            // 
            this.comboBoxBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxBooks.FormattingEnabled = true;
            this.comboBoxBooks.Location = new System.Drawing.Point(10, 11);
            this.comboBoxBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxBooks.Name = "comboBoxBooks";
            this.comboBoxBooks.Size = new System.Drawing.Size(582, 25);
            this.comboBoxBooks.TabIndex = 0;
            this.comboBoxBooks.Text = "Выбрать произведение, которое нужно удалить";
            this.comboBoxBooks.SelectedIndexChanged += new System.EventHandler(this.comboBoxBooks_SelectedIndexChanged);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(10, 55);
            this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(436, 20);
            this.textBoxAuthor.TabIndex = 1;
            this.textBoxAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAuthor_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(10, 143);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 3;
            // 
            // textBoxPlaceNumber
            // 
            this.textBoxPlaceNumber.Location = new System.Drawing.Point(10, 222);
            this.textBoxPlaceNumber.Name = "textBoxPlaceNumber";
            this.textBoxPlaceNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlaceNumber.TabIndex = 4;
            this.textBoxPlaceNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPlaceNumber_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBoxPlaceNumber);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.comboBoxBooks);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBooks;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPlaceNumber;
    }
}

