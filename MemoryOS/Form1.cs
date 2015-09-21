using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0 && holes.RowCount > 1)
            {
                LinkedList<Hole> holesData = new LinkedList<Hole>();
                int rownums = holes.RowCount , errors = 0;
                int numOfProcess = int.Parse(numericUpDown1.Value.ToString());
                for (int i = 0; i < rownums - 1; i++)
                {
                    if (holes.Rows[i].Cells[1].Value == null || holes.Rows[i].Cells[0].Value == null)
                    {
                        MessageBox.Show("Error on enterng data");
                        errors += 1;
                    }
                    else
                    {

                        holesData.AddLast(new Hole(i, int.Parse(holes.Rows[i].Cells[0].Value.ToString()), int.Parse(holes.Rows[i].Cells[1].Value.ToString()), int.Parse(holes.Rows[i].Cells[0].Value.ToString())));
                    }
                }
                if (errors == 0)
                {
                    Form2 nextForm = new Form2(numOfProcess, holesData);
                    nextForm.Show();
                    this.Hide();
                }
            }
            else {
                MessageBox.Show("Please Add number of Processes above zero Or Add Holes");
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
