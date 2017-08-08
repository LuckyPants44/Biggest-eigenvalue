using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greater_eigenvalue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double[,] m = { { 2, 4,0 }, { -2,1, 3 }, {-1,0,1 } };
            double[] v = { 1, 2, -1 };
            QuadMatrix A = new QuadMatrix(m);
            Vector V = new Vector(v);
        }

    }
}
