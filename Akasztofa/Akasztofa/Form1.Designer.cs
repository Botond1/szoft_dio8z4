namespace Akasztofa
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
            button1 = new Button();
            szoLabel = new Label();
            hibaszamLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(144, 39);
            button1.TabIndex = 0;
            button1.Text = "Fájl megnyitása";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // szoLabel
            // 
            szoLabel.AutoSize = true;
            szoLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            szoLabel.Location = new Point(307, 61);
            szoLabel.Name = "szoLabel";
            szoLabel.Size = new Size(155, 46);
            szoLabel.TabIndex = 1;
            szoLabel.Text = "*********";
            // 
            // hibaszamLabel
            // 
            hibaszamLabel.AutoSize = true;
            hibaszamLabel.Location = new Point(663, 31);
            hibaszamLabel.Name = "hibaszamLabel";
            hibaszamLabel.Size = new Size(115, 20);
            hibaszamLabel.TabIndex = 2;
            hibaszamLabel.Text = "Tölts be jatekot!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 489);
            Controls.Add(hibaszamLabel);
            Controls.Add(szoLabel);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label szoLabel;
        private Label hibaszamLabel;
    }
}