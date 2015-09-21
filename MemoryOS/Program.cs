using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Hole {
        private int size;
        private int startingAddr;
        private int id;
        private int ActualSize;
        public LinkedList<Process> proceesfits = new LinkedList<Process>();
        public Hole(int id , int size, int starting , int ActualSize) {
            this.id = id;
            this.size = size;
            this.startingAddr = starting;
            this.ActualSize = ActualSize;
        }
        public int getID() {
            return id;
        }
        public int getActSize()
        {
            return ActualSize;
        }
        public int getSize() {
            return size;
        }
        public int getStartingAddr() {
            return startingAddr;
        }
        public void setSize(int size){
            this.size = size;
        }
        public void setStartingAddr(int starting) {
            this.startingAddr = starting;
        }
    }
    public class Process { 
        private int size;
        private string id;
        private int Addr;
        public Process(string id,int size) {
            this.size = size;
            this.id = id;
          
        }
        public int getSize() {
            return size;
        }
        public int getAddr()
        {
            return Addr;
        }
        public string getID() {
            return id;
        }
        public void setSize(int size){
            this.size = size;
        }
        public void setAddr(int addr)
        {
            this.Addr = addr;
        }
        public void setId(string starting) {
            this.id = starting;
        }
    }
        

}
