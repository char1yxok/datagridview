using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            valueDataset.valueDataTable.AddvalueDataTableRow("Root", "CEO", "CEO", "5000", "USD");
            //valueDataset.valueDataTable.AddvalueDataTableRow("Root", "a", "a", "5000", "USD");
            //valueDataset.valueDataTable.AddvalueDataTableRow("a","b", "b", "5000", "USD");
            //valueDataset.valueDataTable.AddvalueDataTableRow("a", "C", "c", "5000", "USD");

            //DatasetのRoot
            /*var RootDataset = new valueDataset();

            var Root = RootDataset.valueDataTable.NewRow();

            Root[0] = "Root";
            Root[1] = "CEO";
            Root[2] = "CEO";
            Root[3] = "5000";
            Root[4] = "USD";

            RootDataset.valueDataTable.Rows.Add(Root);

            RootDataset.valueDataTable.AddvalueDataTableRow(Root);
            var NodeColumnName = RootDataset.valueDataTable.nodeColumn.ColumnName;
            var TypeColumnName = RootDataset.valueDataTable.typeColumn.ColumnName;
            var NameColumnName = RootDataset.valueDataTable.nameColumn.ColumnName;
            var ValueColumnName = RootDataset.valueDataTable.valueColumn.ColumnName;
            var UnitColumnName = RootDataset.valueDataTable.unitColumn.ColumnName;

            var Rootrow = RootDataset.valueDataTable.Rows(0);*/

            

        }




        

        private void button1_Click(object sender, EventArgs e)
        {

            //string json = JsonConvert.SerializeObject(valueDataset);
            //Console.WriteLine(json);

            var nodeb = textBox1.Text;
            var typeb = textBox2.Text;
            var nameb = textBox3.Text;
            var valueb = textBox4.Text;
            var unitb = textBox5.Text;

            DataRow dr = valueDataset.valueDataTable.NewRow();
            dr[0] = nodeb;
            dr[1] = typeb;
            dr[2] = nameb;
            dr[3] = valueb;
            dr[4] = unitb;

            valueDataset.valueDataTable.Rows.Add(dr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow removerow = dataGridView1.CurrentRow;
            dataGridView1.Rows.Remove(removerow);
        }
    }
}
