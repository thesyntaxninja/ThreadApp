namespace ThreadApp1
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
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addShapeButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.shapeComboBox = new System.Windows.Forms.ComboBox();
            this.speedUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.threadCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(13, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(168, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 42);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addShapeButton
            // 
            this.addShapeButton.Location = new System.Drawing.Point(406, 42);
            this.addShapeButton.Name = "addShapeButton";
            this.addShapeButton.Size = new System.Drawing.Size(75, 23);
            this.addShapeButton.TabIndex = 2;
            this.addShapeButton.Text = "Add Shape";
            this.addShapeButton.UseVisualStyleBackColor = true;
            this.addShapeButton.Click += new System.EventHandler(this.addShapeButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(406, 13);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 3;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // shapeComboBox
            // 
            this.shapeComboBox.FormattingEnabled = true;
            this.shapeComboBox.Items.AddRange(new object[] {
            "Square",
            "Circle"});
            this.shapeComboBox.Location = new System.Drawing.Point(264, 15);
            this.shapeComboBox.Name = "shapeComboBox";
            this.shapeComboBox.Size = new System.Drawing.Size(121, 21);
            this.shapeComboBox.TabIndex = 4;
            this.shapeComboBox.Text = "Square";
            // 
            // speedUpDown
            // 
            this.speedUpDown.Location = new System.Drawing.Point(264, 44);
            this.speedUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.speedUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedUpDown.Name = "speedUpDown";
            this.speedUpDown.Size = new System.Drawing.Size(120, 20);
            this.speedUpDown.TabIndex = 5;
            this.speedUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Shape:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Speed:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(13, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 381);
            this.panel1.TabIndex = 8;
            // 
            // threadCountLabel
            // 
            this.threadCountLabel.AutoSize = true;
            this.threadCountLabel.Location = new System.Drawing.Point(9, 462);
            this.threadCountLabel.Name = "threadCountLabel";
            this.threadCountLabel.Size = new System.Drawing.Size(90, 13);
            this.threadCountLabel.TabIndex = 9;
            this.threadCountLabel.Text = "Thread Count = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 484);
            this.Controls.Add(this.threadCountLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedUpDown);
            this.Controls.Add(this.shapeComboBox);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.addShapeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "HW3 Parker Esmay";
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addShapeButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.ComboBox shapeComboBox;
        private System.Windows.Forms.NumericUpDown speedUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label threadCountLabel;

    }
}

