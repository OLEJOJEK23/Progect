namespace шарики
{
    partial class Шарики
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Шарики));
            this.Ball_1 = new System.Windows.Forms.PictureBox();
            this.Dvijenie_X1 = new System.Windows.Forms.Timer(this.components);
            this.Traectory = new System.Windows.Forms.Timer(this.components);
            this.Dvijenie_X2 = new System.Windows.Forms.Timer(this.components);
            this.Dvijenie_Y1 = new System.Windows.Forms.Timer(this.components);
            this.Dvijenie_Y2 = new System.Windows.Forms.Timer(this.components);
            this.Ball_2 = new System.Windows.Forms.PictureBox();
            this.Dvijenie2_X1 = new System.Windows.Forms.Timer(this.components);
            this.Dvijenie2_X2 = new System.Windows.Forms.Timer(this.components);
            this.Dvijenie2_Y1 = new System.Windows.Forms.Timer(this.components);
            this.Dvijenie2_Y2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ball_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball_2)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball_1
            // 
            this.Ball_1.BackColor = System.Drawing.Color.Transparent;
            this.Ball_1.Image = ((System.Drawing.Image)(resources.GetObject("Ball_1.Image")));
            this.Ball_1.Location = new System.Drawing.Point(226, 79);
            this.Ball_1.Name = "Ball_1";
            this.Ball_1.Size = new System.Drawing.Size(100, 100);
            this.Ball_1.TabIndex = 0;
            this.Ball_1.TabStop = false;
            // 
            // Dvijenie_X1
            // 
            this.Dvijenie_X1.Enabled = true;
            this.Dvijenie_X1.Interval = 1;
            this.Dvijenie_X1.Tick += new System.EventHandler(this.Dvijenie_X1_Tick);
            // 
            // Traectory
            // 
            this.Traectory.Enabled = true;
            this.Traectory.Interval = 1;
            this.Traectory.Tick += new System.EventHandler(this.Traectory_Tick);
            // 
            // Dvijenie_X2
            // 
            this.Dvijenie_X2.Interval = 1;
            this.Dvijenie_X2.Tick += new System.EventHandler(this.Dvijenie_X2_Tick);
            // 
            // Dvijenie_Y1
            // 
            this.Dvijenie_Y1.Enabled = true;
            this.Dvijenie_Y1.Interval = 1;
            this.Dvijenie_Y1.Tick += new System.EventHandler(this.Dvijenie_Y1_Tick);
            // 
            // Dvijenie_Y2
            // 
            this.Dvijenie_Y2.Interval = 1;
            this.Dvijenie_Y2.Tick += new System.EventHandler(this.Dvijenie_Y2_Tick);
            // 
            // Ball_2
            // 
            this.Ball_2.BackColor = System.Drawing.Color.Transparent;
            this.Ball_2.Image = ((System.Drawing.Image)(resources.GetObject("Ball_2.Image")));
            this.Ball_2.Location = new System.Drawing.Point(457, 206);
            this.Ball_2.Name = "Ball_2";
            this.Ball_2.Size = new System.Drawing.Size(100, 100);
            this.Ball_2.TabIndex = 1;
            this.Ball_2.TabStop = false;
            // 
            // Dvijenie2_X1
            // 
            this.Dvijenie2_X1.Enabled = true;
            this.Dvijenie2_X1.Interval = 1;
            this.Dvijenie2_X1.Tick += new System.EventHandler(this.Dvijenie2_X1_Tick);
            // 
            // Dvijenie2_X2
            // 
            this.Dvijenie2_X2.Interval = 1;
            this.Dvijenie2_X2.Tick += new System.EventHandler(this.Dvijenie2_X2_Tick);
            // 
            // Dvijenie2_Y1
            // 
            this.Dvijenie2_Y1.Enabled = true;
            this.Dvijenie2_Y1.Interval = 1;
            this.Dvijenie2_Y1.Tick += new System.EventHandler(this.Dvijenie2_Y1_Tick);
            // 
            // Dvijenie2_Y2
            // 
            this.Dvijenie2_Y2.Interval = 1;
            this.Dvijenie2_Y2.Tick += new System.EventHandler(this.Dvijenie2_Y2_Tick);
            // 
            // Шарики
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ball_2);
            this.Controls.Add(this.Ball_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Шарики";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шарики";
            this.Load += new System.EventHandler(this.Шарики_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Шарики_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Ball_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Ball_1;
        private System.Windows.Forms.Timer Dvijenie_X1;
        private System.Windows.Forms.Timer Traectory;
        private System.Windows.Forms.Timer Dvijenie_X2;
        private System.Windows.Forms.Timer Dvijenie_Y1;
        private System.Windows.Forms.Timer Dvijenie_Y2;
        private System.Windows.Forms.PictureBox Ball_2;
        private System.Windows.Forms.Timer Dvijenie2_X1;
        private System.Windows.Forms.Timer Dvijenie2_X2;
        private System.Windows.Forms.Timer Dvijenie2_Y1;
        private System.Windows.Forms.Timer Dvijenie2_Y2;
    }
}

