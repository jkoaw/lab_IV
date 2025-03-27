namespace lab_IV
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
            pictureBox = new PictureBox();
            button_load = new Button();
            checkBox_90 = new CheckBox();
            checkBox_180 = new CheckBox();
            checkBox_270 = new CheckBox();
            button_rotate = new Button();
            button_invert = new Button();
            button_upside = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(449, 70);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(226, 166);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // button_load
            // 
            button_load.Location = new Point(41, 361);
            button_load.Name = "button_load";
            button_load.Size = new Size(75, 23);
            button_load.TabIndex = 1;
            button_load.Text = "wczytaj";
            button_load.UseVisualStyleBackColor = true;
            button_load.Click += button_load_Click;
            // 
            // checkBox_90
            // 
            checkBox_90.AutoSize = true;
            checkBox_90.Location = new Point(50, 47);
            checkBox_90.Name = "checkBox_90";
            checkBox_90.Size = new Size(45, 19);
            checkBox_90.TabIndex = 2;
            checkBox_90.Text = "90o";
            checkBox_90.UseVisualStyleBackColor = true;
            checkBox_90.CheckedChanged += checkBox_90_CheckedChanged;
            // 
            // checkBox_180
            // 
            checkBox_180.AutoSize = true;
            checkBox_180.Location = new Point(50, 72);
            checkBox_180.Name = "checkBox_180";
            checkBox_180.Size = new Size(51, 19);
            checkBox_180.TabIndex = 3;
            checkBox_180.Text = "180o";
            checkBox_180.UseVisualStyleBackColor = true;
            checkBox_180.CheckedChanged += checkBox_180_CheckedChanged;
            // 
            // checkBox_270
            // 
            checkBox_270.AutoSize = true;
            checkBox_270.Location = new Point(50, 97);
            checkBox_270.Name = "checkBox_270";
            checkBox_270.Size = new Size(51, 19);
            checkBox_270.TabIndex = 4;
            checkBox_270.Text = "270o";
            checkBox_270.UseVisualStyleBackColor = true;
            checkBox_270.CheckedChanged += checkBox_270_CheckedChanged;
            // 
            // button_rotate
            // 
            button_rotate.Location = new Point(41, 319);
            button_rotate.Name = "button_rotate";
            button_rotate.Size = new Size(75, 23);
            button_rotate.TabIndex = 5;
            button_rotate.Text = "Rotate";
            button_rotate.UseVisualStyleBackColor = true;
            button_rotate.Click += button_rotate_Click;
            // 
            // button_invert
            // 
            button_invert.Location = new Point(41, 290);
            button_invert.Name = "button_invert";
            button_invert.Size = new Size(75, 23);
            button_invert.TabIndex = 6;
            button_invert.Text = "invert";
            button_invert.UseVisualStyleBackColor = true;
            button_invert.Click += button_invert_Click;
            // 
            // button_upside
            // 
            button_upside.Location = new Point(41, 261);
            button_upside.Name = "button_upside";
            button_upside.Size = new Size(75, 23);
            button_upside.TabIndex = 7;
            button_upside.Text = "upside down";
            button_upside.UseVisualStyleBackColor = true;
            button_upside.Click += button_upside_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_upside);
            Controls.Add(button_invert);
            Controls.Add(button_rotate);
            Controls.Add(checkBox_270);
            Controls.Add(checkBox_180);
            Controls.Add(checkBox_90);
            Controls.Add(button_load);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Button button_load;
        private CheckBox checkBox_90;
        private CheckBox checkBox_180;
        private CheckBox checkBox_270;
        private Button button_rotate;
        private Button button_invert;
        private Button button_upside;
    }
}
