namespace Lost_Ark_Fish_Oreha_Fusion_Material_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxInput1 = new TextBox();
            textBoxInput2 = new TextBox();
            textBoxInput3 = new TextBox();
            textBoxInput4 = new TextBox();
            buttonCalculate = new Button();
            labelCalculate = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // textBoxInput1
            // 
            textBoxInput1.Location = new Point(278, 30);
            textBoxInput1.Name = "textBoxInput1";
            textBoxInput1.Size = new Size(100, 23);
            textBoxInput1.TabIndex = 0;
            // 
            // textBoxInput2
            // 
            textBoxInput2.Location = new Point(278, 96);
            textBoxInput2.Name = "textBoxInput2";
            textBoxInput2.Size = new Size(100, 23);
            textBoxInput2.TabIndex = 1;
            // 
            // textBoxInput3
            // 
            textBoxInput3.Location = new Point(278, 162);
            textBoxInput3.Name = "textBoxInput3";
            textBoxInput3.Size = new Size(100, 23);
            textBoxInput3.TabIndex = 2;
            // 
            // textBoxInput4
            // 
            textBoxInput4.Location = new Point(278, 228);
            textBoxInput4.Name = "textBoxInput4";
            textBoxInput4.Size = new Size(100, 23);
            textBoxInput4.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalculate.Location = new Point(257, 345);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(141, 45);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += button1_Click;
            // 
            // labelCalculate
            // 
            labelCalculate.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            labelCalculate.Location = new Point(278, 278);
            labelCalculate.Name = "labelCalculate";
            labelCalculate.Size = new Size(100, 50);
            labelCalculate.TabIndex = 5;
            labelCalculate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_3;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 60);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_4;
            pictureBox2.Location = new Point(12, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(260, 60);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Screenshot_5;
            pictureBox3.Location = new Point(12, 144);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(260, 60);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 225);
            label1.Name = "label1";
            label1.Size = new Size(144, 30);
            label1.TabIndex = 9;
            label1.Text = "Crafting Cost:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(524, 421);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelCalculate);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxInput4);
            Controls.Add(textBoxInput3);
            Controls.Add(textBoxInput2);
            Controls.Add(textBoxInput1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(540, 460);
            MinimumSize = new Size(540, 460);
            Name = "Form1";
            Text = "Lost Ark Fish Oreha Fusion Material Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput1;
        private TextBox textBoxInput2;
        private TextBox textBoxInput3;
        private TextBox textBoxInput4;
        private Button buttonCalculate;
        private Label labelCalculate;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
    }
}