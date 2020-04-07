namespace chm6
{
    partial class MainForm
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
            this.x0Lable = new System.Windows.Forms.Label();
            this.x0TextBox = new System.Windows.Forms.TextBox();
            this.y0TextBox = new System.Windows.Forms.TextBox();
            this.y0Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hLabel = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.nLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_yi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // x0Lable
            // 
            this.x0Lable.AutoSize = true;
            this.x0Lable.Location = new System.Drawing.Point(24, 43);
            this.x0Lable.Name = "x0Lable";
            this.x0Lable.Size = new System.Drawing.Size(18, 13);
            this.x0Lable.TabIndex = 0;
            this.x0Lable.Text = "x0";
            // 
            // x0TextBox
            // 
            this.x0TextBox.Location = new System.Drawing.Point(57, 40);
            this.x0TextBox.Name = "x0TextBox";
            this.x0TextBox.Size = new System.Drawing.Size(100, 20);
            this.x0TextBox.TabIndex = 1;
            // 
            // y0TextBox
            // 
            this.y0TextBox.Location = new System.Drawing.Point(57, 66);
            this.y0TextBox.Name = "y0TextBox";
            this.y0TextBox.Size = new System.Drawing.Size(100, 20);
            this.y0TextBox.TabIndex = 3;
            // 
            // y0Label
            // 
            this.y0Label.AutoSize = true;
            this.y0Label.Location = new System.Drawing.Point(24, 69);
            this.y0Label.Name = "y0Label";
            this.y0Label.Size = new System.Drawing.Size(18, 13);
            this.y0Label.TabIndex = 2;
            this.y0Label.Text = "y0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(24, 95);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(13, 13);
            this.hLabel.TabIndex = 4;
            this.hLabel.Text = "h";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(57, 118);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(100, 20);
            this.nTextBox.TabIndex = 7;
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(24, 121);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(13, 13);
            this.nLabel.TabIndex = 6;
            this.nLabel.Text = "n";
            // 
            // CalculateButton
            // 
            this.CalculateButton.ForeColor = System.Drawing.Color.Green;
            this.CalculateButton.Location = new System.Drawing.Point(210, 85);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate!";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_i,
            this.Column_xi,
            this.Column_yi});
            this.dataGridView1.Location = new System.Drawing.Point(378, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 381);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column_i
            // 
            this.Column_i.Frozen = true;
            this.Column_i.HeaderText = "i";
            this.Column_i.Name = "Column_i";
            this.Column_i.ReadOnly = true;
            // 
            // Column_xi
            // 
            this.Column_xi.Frozen = true;
            this.Column_xi.HeaderText = "xi";
            this.Column_xi.Name = "Column_xi";
            this.Column_xi.ReadOnly = true;
            // 
            // Column_yi
            // 
            this.Column_yi.Frozen = true;
            this.Column_yi.HeaderText = "yi";
            this.Column_yi.Name = "Column_yi";
            this.Column_yi.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.y0TextBox);
            this.Controls.Add(this.y0Label);
            this.Controls.Add(this.x0TextBox);
            this.Controls.Add(this.x0Lable);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x0Lable;
        private System.Windows.Forms.TextBox x0TextBox;
        private System.Windows.Forms.Label y0Label;
        private System.Windows.Forms.TextBox y0TextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_yi;
    }
}

