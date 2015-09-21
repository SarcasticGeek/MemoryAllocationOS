namespace MemoryOS
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
            this.holes = new System.Windows.Forms.DataGridView();
            this.hole_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starting_Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numofPr = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.holes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // holes
            // 
            this.holes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.holes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hole_size,
            this.starting_Addr});
            this.holes.Location = new System.Drawing.Point(12, 12);
            this.holes.Name = "holes";
            this.holes.Size = new System.Drawing.Size(245, 147);
            this.holes.TabIndex = 0;
            this.holes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hole_size
            // 
            this.hole_size.HeaderText = "Hole Size";
            this.hole_size.Name = "hole_size";
            // 
            // starting_Addr
            // 
            this.starting_Addr.HeaderText = "Starting Address";
            this.starting_Addr.Name = "starting_Addr";
            // 
            // numofPr
            // 
            this.numofPr.AutoSize = true;
            this.numofPr.Location = new System.Drawing.Point(13, 187);
            this.numofPr.Name = "numofPr";
            this.numofPr.Size = new System.Drawing.Size(108, 13);
            this.numofPr.TabIndex = 1;
            this.numofPr.Text = "Number of Processes";
            this.numofPr.Click += new System.EventHandler(this.label1_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(127, 226);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 3;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(127, 185);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 315);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.numofPr);
            this.Controls.Add(this.holes);
            this.Name = "Form1";
            this.Text = "Adding Holes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.holes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView holes;
        private System.Windows.Forms.Label numofPr;
        private System.Windows.Forms.DataGridViewTextBoxColumn hole_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn starting_Addr;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

