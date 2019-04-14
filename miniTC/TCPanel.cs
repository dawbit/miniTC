using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace miniTC
{
    public partial class TCPanel : UserControl, IPanel
    {
        public TCPanel()
        {
            InitializeComponent();
            listView_Items.View = View.Details;
            listView_Items.HeaderStyle = ColumnHeaderStyle.None;
        }

        #region IPanel
        public string[] Drives
        {
            set
            {
                comboBoxDrives.Items.Clear();
                comboBoxDrives.Items.AddRange(value);
            }
        }

        public string CurrentPath
        {
            get
            {
                return label_Path.Text;
            }
            set
            {
                label_Path.Text = value;
            }
        }


        public string SelectedDirectory
        {
            get
            {
                return listView_Items.SelectedItems[0].Text;
            }
        }

        public string[] Items
        {
            get
            {
                return listView_Items.Items.Cast<string>().ToArray();
            }
            set
            {
                listView_Items.Items.Clear();
                foreach (var item in value)
                    listView_Items.Items.Add(item);
            }
        }

        #endregion

        public event Func<string[]> GetDrives;
        private void comboBoxDrives_Click(object sender, EventArgs e)
        {
            Drives = GetDrives();
        }

        public event EventHandler ChangeSelectedDrive;
        private void ComboBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentPath = comboBoxDrives.SelectedItem.ToString();

            this.ChangeSelectedDrive?.Invoke(this, e);

            listView_Items.Focus();
        }

        public event Func<string[]> GetItems;

        private void label_Path_TextChanged(object sender, EventArgs e)
        {
            if (GetItems != null)
            {
                Items = GetItems();
            }
        }

        public event Action SelectedDirectoryChange;

        private void listView_Items_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (SelectedDirectoryChange != null)
                SelectedDirectoryChange();
        }

        public event Func<string> Backwards;

        private void button_Backwards_Click(object sender, EventArgs e)
        {
            if (Backwards!=null)
                CurrentPath = Backwards();
        }
    }
}
