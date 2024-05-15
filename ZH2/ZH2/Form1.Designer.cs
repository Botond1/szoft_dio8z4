namespace ZH2
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            filmIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kiadasiEvDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bevetelekMillioUSDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sikeresDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            filmBindingSource1 = new BindingSource(components);
            filmBindingSource = new BindingSource(components);
            newrecordBtn = new Button();
            deleteBtn = new Button();
            openBtn = new Button();
            saveBtn = new Button();
            erdekessegBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { filmIDDataGridViewTextBoxColumn, cimDataGridViewTextBoxColumn, kiadasiEvDataGridViewTextBoxColumn, bevetelekMillioUSDDataGridViewTextBoxColumn, sikeresDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = filmBindingSource1;
            dataGridView1.Location = new Point(12, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 227);
            dataGridView1.TabIndex = 0;
            // 
            // filmIDDataGridViewTextBoxColumn
            // 
            filmIDDataGridViewTextBoxColumn.DataPropertyName = "FilmID";
            filmIDDataGridViewTextBoxColumn.HeaderText = "FilmID";
            filmIDDataGridViewTextBoxColumn.Name = "filmIDDataGridViewTextBoxColumn";
            // 
            // cimDataGridViewTextBoxColumn
            // 
            cimDataGridViewTextBoxColumn.DataPropertyName = "Cim";
            cimDataGridViewTextBoxColumn.HeaderText = "Cim";
            cimDataGridViewTextBoxColumn.Name = "cimDataGridViewTextBoxColumn";
            // 
            // kiadasiEvDataGridViewTextBoxColumn
            // 
            kiadasiEvDataGridViewTextBoxColumn.DataPropertyName = "KiadasiEv";
            kiadasiEvDataGridViewTextBoxColumn.HeaderText = "KiadasiEv";
            kiadasiEvDataGridViewTextBoxColumn.Name = "kiadasiEvDataGridViewTextBoxColumn";
            // 
            // bevetelekMillioUSDDataGridViewTextBoxColumn
            // 
            bevetelekMillioUSDDataGridViewTextBoxColumn.DataPropertyName = "BevetelekMillioUSD";
            bevetelekMillioUSDDataGridViewTextBoxColumn.HeaderText = "BevetelekMillioUSD";
            bevetelekMillioUSDDataGridViewTextBoxColumn.Name = "bevetelekMillioUSDDataGridViewTextBoxColumn";
            // 
            // sikeresDataGridViewCheckBoxColumn
            // 
            sikeresDataGridViewCheckBoxColumn.DataPropertyName = "Sikeres";
            sikeresDataGridViewCheckBoxColumn.HeaderText = "Sikeres";
            sikeresDataGridViewCheckBoxColumn.Name = "sikeresDataGridViewCheckBoxColumn";
            // 
            // filmBindingSource1
            // 
            filmBindingSource1.DataSource = typeof(film);
            // 
            // filmBindingSource
            // 
            filmBindingSource.DataSource = typeof(film);
            // 
            // newrecordBtn
            // 
            newrecordBtn.Location = new Point(713, 396);
            newrecordBtn.Name = "newrecordBtn";
            newrecordBtn.Size = new Size(75, 23);
            newrecordBtn.TabIndex = 1;
            newrecordBtn.Text = "Új sor";
            newrecordBtn.UseVisualStyleBackColor = true;
            newrecordBtn.Click += newrecordBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(608, 396);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Törlés";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // openBtn
            // 
            openBtn.Location = new Point(713, 65);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(75, 23);
            openBtn.TabIndex = 3;
            openBtn.Text = "Betöltés";
            openBtn.UseVisualStyleBackColor = true;
            openBtn.Click += openBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(608, 65);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Mentés";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // erdekessegBtn
            // 
            erdekessegBtn.Location = new Point(12, 65);
            erdekessegBtn.Name = "erdekessegBtn";
            erdekessegBtn.Size = new Size(75, 23);
            erdekessegBtn.TabIndex = 5;
            erdekessegBtn.Text = "Érdekességek";
            erdekessegBtn.UseVisualStyleBackColor = true;
            erdekessegBtn.Click += erdekessegBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(erdekessegBtn);
            Controls.Add(saveBtn);
            Controls.Add(openBtn);
            Controls.Add(deleteBtn);
            Controls.Add(newrecordBtn);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button newrecordBtn;
        private Button deleteBtn;
        private Button openBtn;
        private Button saveBtn;
        private Button erdekessegBtn;
        private BindingSource filmBindingSource;
        private DataGridViewTextBoxColumn filmIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kiadasiEvDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bevetelekMillioUSDDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn sikeresDataGridViewCheckBoxColumn;
        private BindingSource filmBindingSource1;
    }
}