namespace Lesson_One_Hello_World_
{
    partial class helloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helloWorld));
            outputText = new Label();
            blueButton = new Button();
            label1 = new Label();
            greenButton = new Button();
            redButton = new Button();
            outputLabel = new Label();
            SuspendLayout();
            // 
            // outputText
            // 
            outputText.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputText.ForeColor = Color.White;
            outputText.Location = new Point(335, 189);
            outputText.Name = "outputText";
            outputText.Size = new Size(356, 124);
            outputText.TabIndex = 0;
            outputText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // blueButton
            // 
            blueButton.BackColor = Color.FromArgb(0, 0, 192);
            blueButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            blueButton.ForeColor = Color.White;
            blueButton.Location = new Point(103, 428);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(259, 144);
            blueButton.TabIndex = 1;
            blueButton.Text = "BLUE";
            blueButton.UseVisualStyleBackColor = false;
            blueButton.Click += activateButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(287, 222);
            label1.Name = "label1";
            label1.Size = new Size(517, 124);
            label1.TabIndex = 2;
            label1.Text = "Choose a colour";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // greenButton
            // 
            greenButton.BackColor = Color.Lime;
            greenButton.FlatStyle = FlatStyle.Flat;
            greenButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greenButton.ForeColor = Color.White;
            greenButton.Location = new Point(401, 425);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(259, 144);
            greenButton.TabIndex = 3;
            greenButton.Text = "GREEN";
            greenButton.UseVisualStyleBackColor = false;
            greenButton.Click += button1_Click;
            // 
            // redButton
            // 
            redButton.BackColor = Color.Red;
            redButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            redButton.ForeColor = Color.White;
            redButton.Location = new Point(707, 365);
            redButton.Name = "redButton";
            redButton.Size = new Size(259, 144);
            redButton.TabIndex = 4;
            redButton.Text = "RED";
            redButton.UseVisualStyleBackColor = false;
            redButton.Click += button2_Click;
            // 
            // outputLabel
            // 
            outputLabel.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputLabel.Location = new Point(103, 672);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(845, 299);
            outputLabel.TabIndex = 5;
            outputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // helloWorld
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1061, 995);
            Controls.Add(outputLabel);
            Controls.Add(redButton);
            Controls.Add(greenButton);
            Controls.Add(label1);
            Controls.Add(blueButton);
            Controls.Add(outputText);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "helloWorld";
            Text = "Colour Choice";
            ResumeLayout(false);
        }

        #endregion

        private Label outputText;
        private Button blueButton;
        private Label label1;
        private Button greenButton;
        private Button redButton;
        private Label outputLabel;
    }
}
