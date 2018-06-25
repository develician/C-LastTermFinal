using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class ReturnedHistoryForm : Form
    {
        public ReturnedHistoryForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();


            dataGridView1.DataSource = DataManager.returnedHistories;
            dataGridView1.ReadOnly = true;


            dataGridView1.Columns[0].HeaderText = "반납자 번호";
            dataGridView1.Columns[1].HeaderText = "반납자";
            dataGridView1.Columns[2].HeaderText = "반납일시";
            dataGridView1.Columns[3].HeaderText = "책이름";
            dataGridView1.Columns[4].HeaderText = "책 Isbn";
        }
    }
}
