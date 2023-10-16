namespace треугольник313Ладвинский
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
            this.Check = new System.Windows.Forms.Button();
            this.side1 = new System.Windows.Forms.TextBox();
            this.side2 = new System.Windows.Forms.TextBox();
            this.side3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.Indigo;
            this.Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Check.Location = new System.Drawing.Point(193, 203);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(106, 50);
            this.Check.TabIndex = 0;
            this.Check.Text = "Проверить";
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // side1
            // 
            this.side1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.side1.Location = new System.Drawing.Point(52, 88);
            this.side1.Multiline = true;
            this.side1.Name = "side1";
            this.side1.Size = new System.Drawing.Size(106, 33);
            this.side1.TabIndex = 1;
            // 
            // side2
            // 
            this.side2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.side2.Location = new System.Drawing.Point(193, 88);
            this.side2.Multiline = true;
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(106, 33);
            this.side2.TabIndex = 2;
            // 
            // side3
            // 
            this.side3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.side3.Location = new System.Drawing.Point(333, 88);
            this.side3.Multiline = true;
            this.side3.Name = "side3";
            this.side3.Size = new System.Drawing.Size(106, 33);
            this.side3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(109, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Indigo;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Location = new System.Drawing.Point(193, 203);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(106, 50);
            this.back.TabIndex = 5;
            this.back.Text = "Еще раз";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(503, 365);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.side3);
            this.Controls.Add(this.side2);
            this.Controls.Add(this.side1);
            this.Controls.Add(this.Check);
            this.Name = "Form1";
            this.Text = "Треугольник";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.TextBox side1;
        private System.Windows.Forms.TextBox side2;
        private System.Windows.Forms.TextBox side3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
    }
}

