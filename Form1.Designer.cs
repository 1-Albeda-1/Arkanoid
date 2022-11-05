namespace Arkanoid
{
    partial class Арканоид
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Арканоид));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.PictureBox();
            this.platform = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ball);
            this.panel1.Controls.Add(this.platform);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ball
            // 
            this.ball.Image = global::Arkanoid.Properties.Resources.шар;
            this.ball.Location = new System.Drawing.Point(423, 273);
            this.ball.Margin = new System.Windows.Forms.Padding(4);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(24, 22);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // platform
            // 
            this.platform.Image = ((System.Drawing.Image)(resources.GetObject("platform.Image")));
            this.platform.ImageLocation = "";
            this.platform.Location = new System.Drawing.Point(405, 404);
            this.platform.Margin = new System.Windows.Forms.Padding(4);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(130, 17);
            this.platform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform.TabIndex = 0;
            this.platform.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Арканоид
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Арканоид";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Арканоид_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ball;
    }
}

