using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayManual
{
    public partial class Form1 : Form
    {
        #region Cara 1
        //private String[] nama = new String[] { "Marhen", "Tono", "Andi", "Riko", "Juni" };
        #endregion

        #region Cara 2
        string[] nama = { "Marhen", "Tono", "Andi", "Riko", "Juli", "Dedy", "Vincen" };
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Cara Memanggil Data Array Ke Dalam ListBox            
            for (int i = 0; i < nama.Length; i++)
            {
                lBNama.Items.Add(nama[i]);
            }
            #endregion
        }
    }
}
