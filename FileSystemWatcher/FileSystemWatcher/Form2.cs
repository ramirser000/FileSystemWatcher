using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFileSystemWatcher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string ext = textBox1.Text;


            DataManager.UpdateGrid(dataGridResults, ext);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure? All data will be deleted.", "Clear Database", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                DataManager.clear();
                DataManager.UpdateGrid(dataGridResults, null);

            }
        }
    }
}
