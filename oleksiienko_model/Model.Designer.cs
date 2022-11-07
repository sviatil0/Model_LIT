
namespace oleksiienko_model
{
    partial class Model
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Model));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_downY = new System.Windows.Forms.TextBox();
            this.textBox_upY = new System.Windows.Forms.TextBox();
            this.textBox_rightX = new System.Windows.Forms.TextBox();
            this.textBox_leftX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.zoomPlus = new System.Windows.Forms.Button();
            this.zoomMinus = new System.Windows.Forms.Button();
            this.pushLeft = new System.Windows.Forms.Button();
            this.pushRight = new System.Windows.Forms.Button();
            this.pushUp = new System.Windows.Forms.Button();
            this.pushDown = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(454, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "down y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "up y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "right x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "left x";
            // 
            // textBox_downY
            // 
            this.textBox_downY.Location = new System.Drawing.Point(148, 119);
            this.textBox_downY.Name = "textBox_downY";
            this.textBox_downY.Size = new System.Drawing.Size(100, 34);
            this.textBox_downY.TabIndex = 14;
            this.textBox_downY.Text = "-10";
            this.textBox_downY.TextChanged += new System.EventHandler(this.textBox_downY_TextChanged);
            // 
            // textBox_upY
            // 
            this.textBox_upY.Location = new System.Drawing.Point(148, 84);
            this.textBox_upY.Name = "textBox_upY";
            this.textBox_upY.Size = new System.Drawing.Size(100, 34);
            this.textBox_upY.TabIndex = 13;
            this.textBox_upY.Text = "10";
            this.textBox_upY.TextChanged += new System.EventHandler(this.textBox_upY_TextChanged);
            // 
            // textBox_rightX
            // 
            this.textBox_rightX.Location = new System.Drawing.Point(148, 49);
            this.textBox_rightX.Name = "textBox_rightX";
            this.textBox_rightX.Size = new System.Drawing.Size(100, 34);
            this.textBox_rightX.TabIndex = 12;
            this.textBox_rightX.Text = "10";
            this.textBox_rightX.TextChanged += new System.EventHandler(this.textBox_rightX_TextChanged);
            // 
            // textBox_leftX
            // 
            this.textBox_leftX.Location = new System.Drawing.Point(148, 14);
            this.textBox_leftX.Name = "textBox_leftX";
            this.textBox_leftX.Size = new System.Drawing.Size(100, 34);
            this.textBox_leftX.TabIndex = 11;
            this.textBox_leftX.Text = "-10";
            this.textBox_leftX.TextChanged += new System.EventHandler(this.textBox_leftX_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 75);
            this.button1.TabIndex = 10;
            this.button1.Text = "Нарисовать систему координат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // zoomPlus
            // 
            this.zoomPlus.Location = new System.Drawing.Point(378, 27);
            this.zoomPlus.Margin = new System.Windows.Forms.Padding(6);
            this.zoomPlus.Name = "zoomPlus";
            this.zoomPlus.Size = new System.Drawing.Size(53, 40);
            this.zoomPlus.TabIndex = 19;
            this.zoomPlus.Text = "+";
            this.zoomPlus.UseVisualStyleBackColor = true;
            this.zoomPlus.Click += new System.EventHandler(this.zoomPlus_Click);
            this.zoomPlus.MouseHover += new System.EventHandler(this.zoomPlus_MouseHover);
            // 
            // zoomMinus
            // 
            this.zoomMinus.Location = new System.Drawing.Point(313, 27);
            this.zoomMinus.Margin = new System.Windows.Forms.Padding(6);
            this.zoomMinus.Name = "zoomMinus";
            this.zoomMinus.Size = new System.Drawing.Size(53, 40);
            this.zoomMinus.TabIndex = 20;
            this.zoomMinus.Text = "-";
            this.zoomMinus.UseVisualStyleBackColor = true;
            this.zoomMinus.Click += new System.EventHandler(this.zoomMinus_Click);
            this.zoomMinus.MouseHover += new System.EventHandler(this.zoomMinus_MouseHover);
            // 
            // pushLeft
            // 
            this.pushLeft.Location = new System.Drawing.Point(313, 145);
            this.pushLeft.Margin = new System.Windows.Forms.Padding(6);
            this.pushLeft.Name = "pushLeft";
            this.pushLeft.Size = new System.Drawing.Size(53, 40);
            this.pushLeft.TabIndex = 21;
            this.pushLeft.Text = "🢀";
            this.pushLeft.UseVisualStyleBackColor = true;
            this.pushLeft.Click += new System.EventHandler(this.pushLeft_Click);
            this.pushLeft.MouseHover += new System.EventHandler(this.pushLeft_MouseHover);
            // 
            // pushRight
            // 
            this.pushRight.Location = new System.Drawing.Point(378, 145);
            this.pushRight.Margin = new System.Windows.Forms.Padding(6);
            this.pushRight.Name = "pushRight";
            this.pushRight.Size = new System.Drawing.Size(53, 40);
            this.pushRight.TabIndex = 22;
            this.pushRight.Text = "🢂";
            this.pushRight.UseVisualStyleBackColor = true;
            this.pushRight.Click += new System.EventHandler(this.pushRight_Click);
            this.pushRight.MouseHover += new System.EventHandler(this.pushRight_MouseHover);
            // 
            // pushUp
            // 
            this.pushUp.Location = new System.Drawing.Point(347, 93);
            this.pushUp.Margin = new System.Windows.Forms.Padding(6);
            this.pushUp.Name = "pushUp";
            this.pushUp.Size = new System.Drawing.Size(53, 40);
            this.pushUp.TabIndex = 23;
            this.pushUp.Text = "🢁";
            this.pushUp.UseVisualStyleBackColor = true;
            this.pushUp.Click += new System.EventHandler(this.pushUp_Click);
            this.pushUp.MouseHover += new System.EventHandler(this.pushUp_MouseHover);
            // 
            // pushDown
            // 
            this.pushDown.Location = new System.Drawing.Point(347, 197);
            this.pushDown.Margin = new System.Windows.Forms.Padding(6);
            this.pushDown.Name = "pushDown";
            this.pushDown.Size = new System.Drawing.Size(53, 40);
            this.pushDown.TabIndex = 24;
            this.pushDown.Text = "🢃";
            this.pushDown.UseVisualStyleBackColor = true;
            this.pushDown.Click += new System.EventHandler(this.pushDown_Click);
            this.pushDown.MouseHover += new System.EventHandler(this.pushDown_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 40.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(36, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 74);
            this.label5.TabIndex = 25;
            this.label5.Text = "↺";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseHover += new System.EventHandler(this.label5_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 30.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 55);
            this.label6.TabIndex = 26;
            this.label6.Text = "↶";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.MouseHover += new System.EventHandler(this.label6_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 40.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(237, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 74);
            this.label7.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::oleksiienko_model.Properties.Resources.image;
            this.pictureBox2.Location = new System.Drawing.Point(250, 477);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 298);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(421, 158);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 604);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1069, 42);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(274, 37);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 646);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pushDown);
            this.Controls.Add(this.pushUp);
            this.Controls.Add(this.pushRight);
            this.Controls.Add(this.pushLeft);
            this.Controls.Add(this.zoomMinus);
            this.Controls.Add(this.zoomPlus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_downY);
            this.Controls.Add(this.textBox_upY);
            this.Controls.Add(this.textBox_rightX);
            this.Controls.Add(this.textBox_leftX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 14.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Model";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Model_FormClosed);
            this.Load += new System.EventHandler(this.Model_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Model_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_downY;
        private System.Windows.Forms.TextBox textBox_upY;
        private System.Windows.Forms.TextBox textBox_rightX;
        private System.Windows.Forms.TextBox textBox_leftX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button zoomPlus;
        private System.Windows.Forms.Button zoomMinus;
        private System.Windows.Forms.Button pushLeft;
        private System.Windows.Forms.Button pushRight;
        private System.Windows.Forms.Button pushUp;
        private System.Windows.Forms.Button pushDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}