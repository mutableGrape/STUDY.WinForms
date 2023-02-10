namespace WinForm2
{
    partial class AreaCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.rectRadio = new System.Windows.Forms.RadioButton();
            this.rectPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.circPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.triPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.selectShapePanel = new System.Windows.Forms.Panel();
            this.triRadio = new System.Windows.Forms.RadioButton();
            this.circRadio = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputTxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rectPanel.SuspendLayout();
            this.circPanel.SuspendLayout();
            this.triPanel.SuspendLayout();
            this.selectShapePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area Calculator";
            // 
            // rectRadio
            // 
            this.rectRadio.AutoSize = true;
            this.rectRadio.Checked = true;
            this.rectRadio.Location = new System.Drawing.Point(13, 27);
            this.rectRadio.Name = "rectRadio";
            this.rectRadio.Size = new System.Drawing.Size(74, 17);
            this.rectRadio.TabIndex = 1;
            this.rectRadio.TabStop = true;
            this.rectRadio.Text = "Rectangle";
            this.rectRadio.UseVisualStyleBackColor = true;
            this.rectRadio.CheckedChanged += new System.EventHandler(this.rectRadio_CheckedChanged);
            // 
            // rectPanel
            // 
            this.rectPanel.Controls.Add(this.label4);
            this.rectPanel.Controls.Add(this.label5);
            this.rectPanel.Controls.Add(this.textBox3);
            this.rectPanel.Controls.Add(this.textBox4);
            this.rectPanel.Location = new System.Drawing.Point(116, 120);
            this.rectPanel.Name = "rectPanel";
            this.rectPanel.Size = new System.Drawing.Size(215, 140);
            this.rectPanel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Width";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(69, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 0;
            // 
            // circPanel
            // 
            this.circPanel.Controls.Add(this.label7);
            this.circPanel.Controls.Add(this.textBox6);
            this.circPanel.Location = new System.Drawing.Point(112, 123);
            this.circPanel.Name = "circPanel";
            this.circPanel.Size = new System.Drawing.Size(215, 140);
            this.circPanel.TabIndex = 3;
            this.circPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Radius";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(69, 23);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 0;
            // 
            // triPanel
            // 
            this.triPanel.Controls.Add(this.label6);
            this.triPanel.Controls.Add(this.textBox5);
            this.triPanel.Controls.Add(this.label8);
            this.triPanel.Controls.Add(this.label9);
            this.triPanel.Controls.Add(this.textBox7);
            this.triPanel.Controls.Add(this.textBox8);
            this.triPanel.Location = new System.Drawing.Point(109, 126);
            this.triPanel.Name = "triPanel";
            this.triPanel.Size = new System.Drawing.Size(215, 140);
            this.triPanel.TabIndex = 4;
            this.triPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Side C";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(69, 98);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Side B";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Sida A";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(69, 62);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(69, 23);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 0;
            // 
            // selectShapePanel
            // 
            this.selectShapePanel.Controls.Add(this.triRadio);
            this.selectShapePanel.Controls.Add(this.circRadio);
            this.selectShapePanel.Controls.Add(this.label10);
            this.selectShapePanel.Controls.Add(this.rectRadio);
            this.selectShapePanel.Location = new System.Drawing.Point(43, 42);
            this.selectShapePanel.Name = "selectShapePanel";
            this.selectShapePanel.Size = new System.Drawing.Size(369, 59);
            this.selectShapePanel.TabIndex = 5;
            // 
            // triRadio
            // 
            this.triRadio.AutoSize = true;
            this.triRadio.Location = new System.Drawing.Point(221, 27);
            this.triRadio.Name = "triRadio";
            this.triRadio.Size = new System.Drawing.Size(63, 17);
            this.triRadio.TabIndex = 4;
            this.triRadio.Text = "Triangle";
            this.triRadio.UseVisualStyleBackColor = true;
            this.triRadio.CheckedChanged += new System.EventHandler(this.triRadio_CheckedChanged);
            // 
            // circRadio
            // 
            this.circRadio.AutoSize = true;
            this.circRadio.Location = new System.Drawing.Point(127, 27);
            this.circRadio.Name = "circRadio";
            this.circRadio.Size = new System.Drawing.Size(51, 17);
            this.circRadio.TabIndex = 3;
            this.circRadio.Text = "Circle";
            this.circRadio.UseVisualStyleBackColor = true;
            this.circRadio.CheckedChanged += new System.EventHandler(this.circRadio_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Select Shape";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output: ";
            // 
            // outputTxt
            // 
            this.outputTxt.AutoSize = true;
            this.outputTxt.Location = new System.Drawing.Point(265, 296);
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.Size = new System.Drawing.Size(29, 13);
            this.outputTxt.TabIndex = 7;
            this.outputTxt.Text = "NaN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AreaCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectShapePanel);
            this.Controls.Add(this.triPanel);
            this.Controls.Add(this.circPanel);
            this.Controls.Add(this.rectPanel);
            this.Controls.Add(this.label1);
            this.Name = "AreaCalculator";
            this.Text = "Form1";
            this.rectPanel.ResumeLayout(false);
            this.rectPanel.PerformLayout();
            this.circPanel.ResumeLayout(false);
            this.circPanel.PerformLayout();
            this.triPanel.ResumeLayout(false);
            this.triPanel.PerformLayout();
            this.selectShapePanel.ResumeLayout(false);
            this.selectShapePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rectRadio;
        private System.Windows.Forms.Panel rectPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel circPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel triPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel selectShapePanel;
        private System.Windows.Forms.RadioButton triRadio;
        private System.Windows.Forms.RadioButton circRadio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outputTxt;
        private System.Windows.Forms.Button button1;
    }
}