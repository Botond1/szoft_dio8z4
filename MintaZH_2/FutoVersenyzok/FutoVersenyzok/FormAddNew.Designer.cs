namespace FutoVersenyzok
{
    partial class FormAddNew
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(267, 454);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "&OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(186, 454);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "&Mégse";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "VersenyzoID", true));
            textBox1.Location = new Point(36, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 23);
            textBox1.TabIndex = 2;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Versenyző);
            // 
            // textBox4
            // 
            textBox4.Location = new Point(36, 55);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            textBox4.Text = "Ver";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(36, 130);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 7;
            textBox5.Text = "Ver";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "Nev", true));
            textBox6.Location = new Point(36, 159);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(240, 23);
            textBox6.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(36, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            textBox2.Text = "Ver";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "Nemzetiseg", true));
            textBox3.Location = new Point(36, 239);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(240, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(36, 285);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 11;
            textBox7.Text = "Ver";
            // 
            // textBox8
            // 
            textBox8.DataBindings.Add(new Binding("Text", bindingSource1, "EredmenyPerc", true));
            textBox8.Location = new Point(36, 314);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(240, 23);
            textBox8.TabIndex = 10;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(36, 363);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 13;
            textBox9.Text = "Ver";
            // 
            // textBox10
            // 
            textBox10.DataBindings.Add(new Binding("Text", bindingSource1, "Kategoria", true));
            textBox10.Location = new Point(36, 392);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(240, 23);
            textBox10.TabIndex = 12;
            // 
            // FormAddNew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 489);
            Controls.Add(textBox9);
            Controls.Add(textBox10);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormAddNew";
            Text = "FormAddNew";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private BindingSource bindingSource1;
    }
}