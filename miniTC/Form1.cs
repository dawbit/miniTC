using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniTC
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public IPanel LeftPanel
        {
            get
            {
                return tcPanelLeft;
            }
        }

        public IPanel RightPanel
        {
            get
            {
                return tcPanelRight;
            }
        }

        public event Action Copy;

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (Copy != null)
            {
                Copy();
            }
        }
    }
}
