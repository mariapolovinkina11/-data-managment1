using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Ab
{
    public partial class Form_c : Form
    {
        public Form_c()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        public Dictionary<int, string> ProviderData
        {
            set
            {
              comboBox_prov.DataSource = value.ToArray();
              comboBox_prov.DisplayMember = "value";
            }
        }

        public List<string> TypeData
        {
            set
            {
                comboBox_type.DataSource = value.ToArray();
                comboBox_type.DisplayMember = "value";
            }
        }



        public int ProviderId
        {
            get
            {
                return ((KeyValuePair<int, string>)comboBox_prov.SelectedItem).Key;
            }
            set 
         {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in comboBox_prov.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
                comboBox_prov.SelectedIndex = idx;
            }
        }

        public int TypeId
        {
            get
            {
                return ((KeyValuePair<int, string>)comboBox_prov.SelectedItem).Key;
            }
            set 
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in comboBox_prov.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
              comboBox_prov.SelectedIndex = idx;
            }
        }
    }
}
