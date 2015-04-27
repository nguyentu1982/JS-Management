using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class ActiveDateForm : Form
    {        
        public ActiveDateForm()
        {
            InitializeComponent();
            activeDateTableAdapter.Connection = CommonHelper.GetSQLConnection();
        }

        private void ActiveDateForm_Load(object sender, EventArgs e)
        {
            if (!LoginInfor.IsAdmin)
            {
                this.Close();
            }
            cboxMonth.Text = System.DateTime.Now.Month.ToString();
            cboxYear.Text = System.DateTime.Now.Year.ToString();
        }
        
        public static List<DateTime> GetDates(int year, int month)
        {
            var dates = new List<DateTime>();

            // Loop from the first day of the month until we hit the next month, moving forward a day at a time
            for (var date = new DateTime(year, month, 1); date.Month == month; date = date.AddDays(1))
            {
                dates.Add(date);
            }

            return dates;
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            int month;
            if(!int.TryParse(cboxMonth.Text, out month))
            {
                MessageBox.Show("Tháng không hợp lệ!");
                return;
            }
            int year;
            if (!int.TryParse(cboxYear.Text, out year))
            {
                MessageBox.Show("Năm không hợp lệ!");
                return;
            }
            grvActiveDate.DataSource = activeDateTableAdapter.GetDateByMonthAndYear(month, year);
        }

        private void grvActiveDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grvActiveDate.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void grvActiveDate_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1| e.RowIndex >= grvActiveDate.Rows.Count - 1)
                return;
            DataGridViewRow row = grvActiveDate.Rows[e.RowIndex];

            if (row.IsNewRow) return;

            Point cur = new Point(e.ColumnIndex, e.RowIndex);
            DataGridViewCheckBoxCell curCell = (DataGridViewCheckBoxCell)grvActiveDate[cur.X, cur.Y];
            
            int activeDateId = int.Parse(row.Cells[0].Value.ToString());
            DateTime activeDate = DateTime.Parse(row.Cells[1].Value.ToString());
            bool isActive = bool.Parse(row.Cells[2].Value.ToString());
            if (activeDateId == 0)
            {
                //Insert
                activeDateTableAdapter.Insert(activeDate, isActive);
            }
            else
            { 
                //Update
                activeDateTableAdapter.UpdateActiveDateById(isActive, activeDateId);
            }
        }

        private void grvActiveDate_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }            

        private void ActiveDateForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
