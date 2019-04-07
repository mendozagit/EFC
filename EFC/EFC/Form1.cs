using EFC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarS();
        }

        private void CargarS()
        {
            using (var c = new Contexto())
            {
                

                GridS.DataSource = c.Students.ToList();
            }
        }

        private void GridA_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            //datagridview.CurrentCell.RowIndex
            using (var c = new Contexto())
            {
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var c = new Contexto())
            {
                var student = c.Students.FirstOrDefault();
                var cursos = student.Courses;
            }

            

        }
    }
}
