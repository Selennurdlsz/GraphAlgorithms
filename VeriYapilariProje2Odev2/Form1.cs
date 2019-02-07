using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilariProje2Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GraphOlustur()
        {
            Dijkstra g = new Dijkstra();
            g.add_vertex("A", new Dictionary<string, int>() { { "B", 7 }, { "C", 8 } });
            g.add_vertex("B", new Dictionary<string, int>() { { "A", 7 }, { "F", 2 } });
            g.add_vertex("C", new Dictionary<string, int>() { { "A", 8 }, { "F", 6 }, { "G", 4 } });
            g.add_vertex("D", new Dictionary<string, int>() { { "F", 8 } });
            g.add_vertex("E", new Dictionary<string, int>() { { "H", 1 } });
            g.add_vertex("F", new Dictionary<string, int>() { { "B", 2 }, { "C", 6 }, { "D", 8 }, { "G", 9 }, { "H", 3 } });
            g.add_vertex("G", new Dictionary<string, int>() { { "C", 4 }, { "F", 9 } });
            g.add_vertex("H", new Dictionary<string, int>() { { "E", 1 }, { "F", 3 } });
            g.shortest_path("A", "H").ForEach(x => Console.WriteLine(x));
            string temp = "";
            return temp;
        }
    }
}
