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
            button_green = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(449, 70);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(226, 166);
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
            // button_green
            // 
            button_green.Location = new Point(41, 213);
            button_green.Name = "button_green";
            button_green.Size = new Size(75, 23);
            button_green.TabIndex = 2;
            button_green.Text = "only green";
            button_green.UseVisualStyleBackColor = true;
            button_green.Click += button_green_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_green);
            Controls.Add(button_load);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button button_load;
        private Button button_green;
    }
}
