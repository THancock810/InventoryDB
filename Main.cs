using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using InventoryDB.dbClasses;

namespace InventoryDB
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DataTable inventory = new DataTable();
            inventory = inventoryClass.Select();
            DGV.DataSource = inventory;
            DGV.Columns["ID"].Visible = false;
            DGV.Columns["Image"].Visible = true;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Image";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DGV.Columns.Add(imgCol);

            int index = 0;
            foreach (DataRow row in inventory.Rows)
            {
                if (row[4] != DBNull.Value)
                {
                    Image img = Image.FromFile(row[4].ToString());
                    Image thumbnail = img.GetThumbnailImage(75, 75, null, IntPtr.Zero);
                    DGV.Rows[index].Cells[5].Value = thumbnail;
                    DGV.Rows[index].Cells[4].Value = row[4].ToString();
                }
                index += 1;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGV.DataSource = inventoryClass.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            inventoryClass.Insert(new inventoryClass("DS", "X352DF5G", "My DS", @"DBImages\CeceModIcon.png"));


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (splitContainer.SplitterDistance != 75)
            {
                splitContainer.SplitterDistance = 75;

            }
            else
            {
                splitContainer.SplitterDistance = 550;
            }

        }

        private void splitContainer_SizeChanged(object sender, EventArgs e)
        {
            if (splitContainer.SplitterDistance <= 200)
            {
                splitContainer.SplitterDistance = 75;

            }
            else
            {
                splitContainer.SplitterDistance = 550;
            }

        }
    
    }
}
