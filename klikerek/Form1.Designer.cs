namespace klikerek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bnt1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bnt2 = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bnt1
            // 
            this.bnt1.Enabled = false;
            this.bnt1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnt1.Location = new System.Drawing.Point(226, 191);
            this.bnt1.Name = "bnt1";
            this.bnt1.Size = new System.Drawing.Size(112, 88);
            this.bnt1.TabIndex = 0;
            this.bnt1.Text = "clik";
            this.bnt1.UseVisualStyleBackColor = true;
            this.bnt1.Click += new System.EventHandler(this.bnt1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(83, 191);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(106, 33);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "kliker";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            // 
            // bnt2
            // 
            this.bnt2.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnt2.Location = new System.Drawing.Point(363, 201);
            this.bnt2.Name = "bnt2";
            this.bnt2.Size = new System.Drawing.Size(129, 78);
            this.bnt2.TabIndex = 2;
            this.bnt2.Text = "start";
            this.bnt2.UseVisualStyleBackColor = true;
            this.bnt2.Click += new System.EventHandler(this.bnt2_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(103, 263);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(74, 31);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "???";
            // 
            // timer3
            // 
            this.timer3.Interval = 5000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.bnt2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.bnt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bnt1;
        private Label lbl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button bnt2;
        private Label lbl2;
        private System.Windows.Forms.Timer timer3;
    }
}