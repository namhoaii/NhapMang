namespace TestArray
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
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnTim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.flpInput = new System.Windows.Forms.FlowLayoutPanel();
            this.flpOutput = new System.Windows.Forms.FlowLayoutPanel();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grbInput.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.btnXoa);
            this.grbInput.Controls.Add(this.btnXem);
            this.grbInput.Controls.Add(this.flpInput);
            this.grbInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbInput.Location = new System.Drawing.Point(0, 101);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(415, 366);
            this.grbInput.TabIndex = 4;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Nhập dãy số";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 101);
            this.panel1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(334, 40);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(123, 24);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(485, 31);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(97, 33);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "OK";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập số lượng";
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.flpOutput);
            this.grbOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbOutput.Location = new System.Drawing.Point(421, 101);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Size = new System.Drawing.Size(405, 366);
            this.grbOutput.TabIndex = 6;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Các số nguyên tố có trong mảng";
            // 
            // flpInput
            // 
            this.flpInput.AutoScroll = true;
            this.flpInput.AutoScrollMinSize = new System.Drawing.Size(0, 280);
            this.flpInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpInput.Location = new System.Drawing.Point(3, 20);
            this.flpInput.Name = "flpInput";
            this.flpInput.Size = new System.Drawing.Size(409, 286);
            this.flpInput.TabIndex = 0;
            // 
            // flpOutput
            // 
            this.flpOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOutput.Location = new System.Drawing.Point(3, 20);
            this.flpOutput.Name = "flpOutput";
            this.flpOutput.Size = new System.Drawing.Size(399, 343);
            this.flpOutput.TabIndex = 0;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(94, 321);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(97, 33);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(217, 321);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 33);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 467);
            this.Controls.Add(this.grbOutput);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbInput.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grbOutput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.FlowLayoutPanel flpInput;
        private System.Windows.Forms.FlowLayoutPanel flpOutput;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
    }
}

