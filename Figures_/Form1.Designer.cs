namespace Figures_
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
            this.Generate_btn = new System.Windows.Forms.Button();
            this.Discover_btn = new System.Windows.Forms.Button();
            this.Draw_btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Generate_btn
            // 
            this.Generate_btn.Location = new System.Drawing.Point(12, 28);
            this.Generate_btn.Name = "Generate_btn";
            this.Generate_btn.Size = new System.Drawing.Size(122, 37);
            this.Generate_btn.TabIndex = 0;
            this.Generate_btn.Text = "Сгенирировать";
            this.Generate_btn.UseVisualStyleBackColor = true;
            this.Generate_btn.Click += new System.EventHandler(this.Generate_btn_Click);
            // 
            // Discover_btn
            // 
            this.Discover_btn.Location = new System.Drawing.Point(157, 28);
            this.Discover_btn.Name = "Discover_btn";
            this.Discover_btn.Size = new System.Drawing.Size(122, 37);
            this.Discover_btn.TabIndex = 1;
            this.Discover_btn.Text = "Узнать";
            this.Discover_btn.UseVisualStyleBackColor = true;
            this.Discover_btn.Click += new System.EventHandler(this.Discover_btn_Click);
            // 
            // Draw_btn
            // 
            this.Draw_btn.Location = new System.Drawing.Point(326, 30);
            this.Draw_btn.Name = "Draw_btn";
            this.Draw_btn.Size = new System.Drawing.Size(118, 35);
            this.Draw_btn.TabIndex = 2;
            this.Draw_btn.Text = "Нарисовать";
            this.Draw_btn.UseVisualStyleBackColor = true;
            this.Draw_btn.Click += new System.EventHandler(this.Draw_btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(976, 404);
            this.listBox1.TabIndex = 3;
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(483, 30);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(115, 34);
            this.Clear_btn.TabIndex = 4;
            this.Clear_btn.Text = "Стереть";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 561);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Draw_btn);
            this.Controls.Add(this.Discover_btn);
            this.Controls.Add(this.Generate_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Generate_btn;
        private System.Windows.Forms.Button Discover_btn;
        private System.Windows.Forms.Button Draw_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Clear_btn;
    }
}

