
namespace The_Aars
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.fajr = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dhohr = new System.Windows.Forms.Label();
            this.asr = new System.Windows.Forms.Label();
            this.maghreb = new System.Windows.Forms.Label();
            this.isha = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.show = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(307, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "صلاة الفجر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(302, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "صلاة الظهر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(294, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "صلاة العصر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(298, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "صلاة العشاء";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(285, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "صلاة المغرب";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Black;
            this.time.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.time.ForeColor = System.Drawing.Color.Red;
            this.time.Location = new System.Drawing.Point(122, 127);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(87, 38);
            this.time.TabIndex = 5;
            this.time.Text = "Time";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Black;
            this.date.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.date.ForeColor = System.Drawing.Color.Red;
            this.date.Location = new System.Drawing.Point(135, 40);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(69, 32);
            this.date.TabIndex = 6;
            this.date.Text = "Date";
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.BackColor = System.Drawing.Color.Black;
            this.month.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.month.ForeColor = System.Drawing.Color.Red;
            this.month.Location = new System.Drawing.Point(193, 84);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(88, 32);
            this.month.TabIndex = 7;
            this.month.Text = "month";
            // 
            // fajr
            // 
            this.fajr.AutoSize = true;
            this.fajr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.fajr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fajr.Location = new System.Drawing.Point(139, 224);
            this.fajr.Name = "fajr";
            this.fajr.Size = new System.Drawing.Size(42, 25);
            this.fajr.TabIndex = 8;
            this.fajr.Text = "fajr";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dhohr
            // 
            this.dhohr.AutoSize = true;
            this.dhohr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dhohr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dhohr.Location = new System.Drawing.Point(139, 283);
            this.dhohr.Name = "dhohr";
            this.dhohr.Size = new System.Drawing.Size(67, 25);
            this.dhohr.TabIndex = 9;
            this.dhohr.Text = "dhohr";
            // 
            // asr
            // 
            this.asr.AutoSize = true;
            this.asr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.asr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.asr.Location = new System.Drawing.Point(139, 346);
            this.asr.Name = "asr";
            this.asr.Size = new System.Drawing.Size(42, 25);
            this.asr.TabIndex = 10;
            this.asr.Text = "asr";
            // 
            // maghreb
            // 
            this.maghreb.AutoSize = true;
            this.maghreb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.maghreb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maghreb.Location = new System.Drawing.Point(139, 405);
            this.maghreb.Name = "maghreb";
            this.maghreb.Size = new System.Drawing.Size(96, 25);
            this.maghreb.TabIndex = 11;
            this.maghreb.Text = "maghreb";
            // 
            // isha
            // 
            this.isha.AutoSize = true;
            this.isha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.isha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.isha.Location = new System.Drawing.Point(139, 465);
            this.isha.Name = "isha";
            this.isha.Size = new System.Drawing.Size(52, 25);
            this.isha.TabIndex = 12;
            this.isha.Text = "isha";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "مواقيت الصلاة";
            this.notifyIcon1.BalloonTipTitle = "مواقيت الصلاة";
            this.notifyIcon1.ContextMenuStrip = this.cms;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Tag = "";
            this.notifyIcon1.Text = "مواقيت الصلاة";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show,
            this.exit});
            this.cms.Name = "contextMenuStrip1";
            this.cms.Size = new System.Drawing.Size(115, 52);
            // 
            // show
            // 
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(114, 24);
            this.show.Text = "Show";
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(114, 24);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(476, 533);
            this.Controls.Add(this.isha);
            this.Controls.Add(this.maghreb);
            this.Controls.Add(this.asr);
            this.Controls.Add(this.dhohr);
            this.Controls.Add(this.fajr);
            this.Controls.Add(this.month);
            this.Controls.Add(this.date);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "مواقيت الصلاة";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label fajr;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dhohr;
        private System.Windows.Forms.Label asr;
        private System.Windows.Forms.Label maghreb;
        private System.Windows.Forms.Label isha;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem show;
        private System.Windows.Forms.ToolStripMenuItem exit;
    }
}

