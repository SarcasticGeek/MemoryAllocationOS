namespace MemoryOS
{
    partial class Form3
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
            this.dataall = new System.Windows.Forms.DataGridView();
            this.Hole_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Next = new System.Windows.Forms.Button();
            this.Process_Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataall)).BeginInit();
            this.SuspendLayout();
            // 
            // dataall
            // 
            this.dataall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hole_ID,
            this.Process_ID,
            this.Process_Size,
            this.Process_Addr});
            this.dataall.Location = new System.Drawing.Point(12, 12);
            this.dataall.Name = "dataall";
            this.dataall.ReadOnly = true;
            this.dataall.Size = new System.Drawing.Size(452, 308);
            this.dataall.TabIndex = 2;
            // 
            // Hole_ID
            // 
            this.Hole_ID.HeaderText = "Hole ID";
            this.Hole_ID.Name = "Hole_ID";
            // 
            // Process_ID
            // 
            this.Process_ID.HeaderText = "Process ID";
            this.Process_ID.Name = "Process_ID";
            // 
            // Process_Size
            // 
            this.Process_Size.HeaderText = "Process Size";
            this.Process_Size.Name = "Process_Size";
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(470, 169);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(141, 23);
            this.Next.TabIndex = 3;
            this.Next.Text = "Next Added Process";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Process_Addr
            // 
            this.Process_Addr.HeaderText = "Process Address";
            this.Process_Addr.Name = "Process_Addr";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 554);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.dataall);
            this.Name = "Form3";
            this.Text = "Showing Adding Processes in Holes";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataall;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hole_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process_Size;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process_Addr;
    }
}