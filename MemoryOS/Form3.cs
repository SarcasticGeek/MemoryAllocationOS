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
    public partial class Form3 : Form
    {
        LinkedList<Process> processinprogD = new LinkedList<Process>();
        LinkedList<Hole> dataOfHolessD = new LinkedList<Hole>();
        LinkedList<Hole> SortedholesD = new LinkedList<Hole>();
        Dictionary<Process, Hole> saveproces = new Dictionary<Process, Hole>();
        public LinkedListNode<Process> y;
        public int startingX = 10 , startingY = 350 ,HightAll = 70 , HolesSizeD = 600;

        public int getHolesSize() {
            int sizze = 0;
            if ( dataOfHolessD.Last!= null)
                sizze = dataOfHolessD.Last.Value.getStartingAddr() + dataOfHolessD.Last.Value.getActSize();
            
            return sizze;
        }
        public int getWidthAny(int any) {
            return ( (any * HolesSizeD) / getHolesSize());
            
        }
        public Form3(LinkedList<Process> processinprogg, LinkedList<Hole> dataOfHolesss, LinkedList<Hole> Sortedholess)
        {
            processinprogD = processinprogg;
            dataOfHolessD = dataOfHolesss;
            SortedholesD = Sortedholess;
            InitializeComponent();
            this.Paint += Form3_Paint;
            int i = 0;
            foreach(Hole hole in SortedholesD){
                
                    DataGridViewRow row = (DataGridViewRow)dataall.Rows[i].Clone();
                    row.Cells[0].Value = "hole" + i;//hole.getStartingAddr();
                    row.Cells[1].Value = 0;
                    row.Cells[2].Value = 0;
                    row.Cells[3].Value = 0;
                    row.ReadOnly = true;
                    dataall.Rows.Add(row);
                    i++;
                
               
            }
          //  dataall.AllowUserToAddRows = false;
            y = processinprogD.First ;

        }

       
        private void Form3_Paint(object sender, PaintEventArgs e)
        {
       
            drawARectt(startingX, startingY, HolesSizeD, e);
            foreach(Hole hole in dataOfHolessD){
                using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Pixel))
                {
                    PointF pointF1 = new PointF(getWidthAny(hole.getStartingAddr()) + 10, startingY - 25);
                    e.Graphics.DrawString("Addr: "+hole.getStartingAddr()+" ,Hole: " + hole.getID(), font1, Brushes.Blue, pointF1);
                }
                drawARectt(startingX + getWidthAny(hole.getStartingAddr()), startingY, getWidthAny(hole.getActSize()), e);
               
                }
        }

        private static Random r = new Random();
        private void drawARectt(int xx, int yy, int wid, PaintEventArgs e)
        {
            const int min = 0;
            const int max = 255;
            Color chosenColor = Color.FromArgb(r.Next(min, max), r.Next(min, max), r.Next(min, max));
            using (System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(chosenColor))
            {
                e.Graphics.FillRectangle(myBrush, new Rectangle(xx, yy, wid, HightAll));
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

       
        public int ii = 0,counter=1;

        private void Next_Click(object sender, EventArgs e)
        {
       
            foreach (Hole holeinsort in SortedholesD) {
                if ( holeinsort.proceesfits.Find(y.Value) != null) {
                    saveproces.Add(y.Value, holeinsort);
                    break;
                }
            }
            if (counter >= processinprogD.Count )
                Next.Enabled = false;
            else
            {
                y = y.Next;
                counter++;
            }

            dataall.Rows.Clear();
            ii = 0;
            foreach (Hole hole in dataOfHolessD)
            {
                if (saveproces.FirstOrDefault(o => o.Value == hole).Key == null) {
                    DataGridViewRow row = (DataGridViewRow)dataall.Rows[ii].Clone();
                    row.Cells[0].Value = "hole" + hole.getID();
                    row.Cells[1].Value = 0;
                    row.Cells[2].Value = 0;
                    row.Cells[3].Value = 0;
                    row.ReadOnly = true;
                    dataall.Rows.Add(row);
                    ii++;
                }
                foreach (Process procs in saveproces.Keys )
                {

                    if (saveproces[procs] == hole)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataall.Rows[ii].Clone();
                        row.Cells[0].Value = "hole"+ saveproces[procs].getID();
                        row.Cells[1].Value = procs.getID();
                        row.Cells[2].Value = procs.getSize();
                        row.Cells[3].Value = procs.getAddr();
                      
                        row.ReadOnly = true;
                        dataall.Rows.Add(row);
                        //Draw Rect of Process
                        Graphics formGraphics = this.CreateGraphics();
                        formGraphics.DrawRectangle(new Pen(Brushes.Black,2), new Rectangle(startingX+getWidthAny(procs.getAddr()),startingY,getWidthAny(procs.getSize()),HightAll));
                        formGraphics.DrawString( procs.getID(), new Font("Arial", 7, FontStyle.Italic), SystemBrushes.WindowText, new PointF(startingX + getWidthAny(procs.getAddr()), startingY + HightAll + 5));
                        formGraphics.DrawString("Addr" , new Font("Arial", 7, FontStyle.Italic), SystemBrushes.WindowText, new PointF(startingX + getWidthAny(procs.getAddr()), startingY + HightAll + 15));
                        formGraphics.DrawString(procs.getAddr().ToString() , new Font("Arial", 7, FontStyle.Italic), SystemBrushes.WindowText, new PointF(startingX + getWidthAny(procs.getAddr()), startingY + HightAll + 25));
                        formGraphics.Dispose();
                        
                        ii++;
                    }
                    else {
                        
                    }

                }
                
            }
           
         }
            
          
        
    }
}
