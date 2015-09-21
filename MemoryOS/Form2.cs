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
    public partial class Form2 : Form
    {
        public int numOfProcesses;
        LinkedList<Process> processinprog = new LinkedList<Process>();
        LinkedList<Hole> dataOfHoless = new LinkedList<Hole>();
        LinkedList<Hole> Sortedholes = new LinkedList<Hole>();
        public Form2(int numOfProcs, LinkedList<Hole> dataOfHoles)
        {
            InitializeComponent();
            dataOfHoless = dataOfHoles;
            numOfProcesses = numOfProcs;
            for (int i = 0; i < numOfProcs ; i++) {
                DataGridViewRow row = (DataGridViewRow)holesin2.Rows[i].Clone();
                row.Cells[0].Value = "P" + i;
                row.Cells[1].Value = 0;
                row.Cells[0].ReadOnly = true;
                row.Cells[1].ReadOnly = false;
                holesin2.Rows.Add(row);
            }
            holesin2.AllowUserToAddRows = false;
      
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
     
        private void run_Click(object sender, EventArgs e)
        {
            
                if (radioButton1.Checked) {
                    run.Enabled = false;
                    holesin2.Enabled = false;

                    string idofPr_row; int sizeOfPro_row;
                    for (int i = 0; i < numOfProcesses; i++)
                    {
                        idofPr_row = holesin2.Rows[i].Cells[0].Value.ToString();
                        sizeOfPro_row = int.Parse(holesin2.Rows[i].Cells[1].Value.ToString());
                        processinprog.AddLast(new Process(idofPr_row, sizeOfPro_row));
                    }
                //First Fit
                    Sortedholes = dataOfHoless;
                    foreach (Process process in processinprog) {
                        foreach (Hole hole in dataOfHoless) {
                            if (hole.getSize() >= process.getSize()) {
                                process.setAddr(hole.getStartingAddr() + hole.getActSize() - hole.getSize());
                                hole.proceesfits.AddLast(process);
                                hole.setSize(hole.getSize() - process.getSize());
                                break;
                            }
                        }
                    }
                    Form3 drwform = new Form3(processinprog, dataOfHoless, Sortedholes);
                    drwform.Show();
                    this.Hide();
                }
                else if (radioButton2.Checked) {
                    run.Enabled = false;
                    holesin2.Enabled = false;

                    string idofPr_row; int sizeOfPro_row;
                    for (int i = 0; i < numOfProcesses; i++)
                    {
                        idofPr_row = holesin2.Rows[i].Cells[0].Value.ToString();
                        sizeOfPro_row = int.Parse(holesin2.Rows[i].Cells[1].Value.ToString());
                        processinprog.AddLast(new Process(idofPr_row, sizeOfPro_row));
                    }
                //Best Fit
                    foreach (Process process in processinprog)
                    {
                        Sortedholes = new LinkedList<Hole>(dataOfHoless.OrderBy(o => o.getSize()).ToList());
                        foreach (Hole hole in Sortedholes)
                        {
                            if (hole.getSize() >= process.getSize())
                            {
                                process.setAddr(hole.getStartingAddr() + hole.getActSize() - hole.getSize());
                                hole.proceesfits.AddLast(process);
                                hole.setSize(hole.getSize() - process.getSize());
                               
                                break;
                            }
                        }
                    }
                    Form3 drwform = new Form3(processinprog, dataOfHoless, Sortedholes);
                    drwform.Show();
                    this.Hide();
                }
                else if (radioButton3.Checked)
                {
                    run.Enabled = false;
                    holesin2.Enabled = false;

                    string idofPr_row; int sizeOfPro_row;
                    for (int i = 0; i < numOfProcesses; i++)
                    {
                        idofPr_row = holesin2.Rows[i].Cells[0].Value.ToString();
                        sizeOfPro_row = int.Parse(holesin2.Rows[i].Cells[1].Value.ToString());
                        processinprog.AddLast(new Process(idofPr_row, sizeOfPro_row));
                    }
                    //Worst fit
                    foreach (Process process in processinprog)
                    {
                        Sortedholes = new LinkedList<Hole>(dataOfHoless.OrderByDescending(o => o.getSize()).ToList());
                        //       Sortedholes.Reverse();
                        foreach (Hole hole in Sortedholes)
                        {
                            if (hole.getSize() >= process.getSize())
                            {
                                process.setAddr(hole.getStartingAddr() + hole.getActSize() - hole.getSize());
                                hole.proceesfits.AddLast(process);
                                hole.setSize(hole.getSize() - process.getSize());
                                break;
                            }
                        }
                    }
                    Form3 drwform = new Form3(processinprog, dataOfHoless, Sortedholes);
                    drwform.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Please check any fit allocation!");
                }
                
        }
    }
}
