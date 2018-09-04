using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial10_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getHoursBtn_Click(object sender, EventArgs e)
        {
            string name, id, track;

            name = nameTB.Text;
            id = idTB.Text;
            
            if (infoSystemsRB.Checked)
            {
                track = "Information Systems";
            }
            else
            {
                track = "Software Engineering";
            }

            CompSciStudent csStudent =
                new CompSciStudent(name, id, track);

            requiredHoursLbl.Text =
                csStudent.RequiredHours.ToString("n1");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
        
}
