using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace BJ_Students
{
    public partial class Details : Form
    {
        public Details(Student selected)
        {
            InitializeComponent();
            UpdateUI(selected);
        }

        private void Details_Load(object sender, EventArgs e)
        {

        }

        private void UpdateUI(Student selected)
        {
            try
            {
                string lvl = GetLevelString(selected.EnLvl);
                firstLbl.Text = selected.FirstName;
                lastLbl.Text = selected.LastName;
                lvlLbl.Text = lvl;
                mainLbl.Text = selected.MainClass;
                idLbl.Text = selected.ID.ToString();                
                speakLbl.Text = selected.Speak.ToString();
                readLbl.Text = selected.Read.ToString();
                writeLbl.Text = selected.Write.ToString();
                listenLbl.Text = selected.Listen.ToString();
                notesBox.Text = selected.Note;

                if (0 < selected.Makeup.Count)
                    mu1Lbl.Text = selected.Makeup[0];
                else mu1Lbl.Text = "None";

                if (1 < selected.Makeup.Count)
                    mu2Lbl.Text = selected.Makeup[1];
                else mu2Lbl.Text = "None";

                if (2 < selected.Makeup.Count)
                    mu3Lbl.Text = selected.Makeup[2];
                else mu3Lbl.Text = "None";

                if (3 < selected.Makeup.Count)
                    mu4Lbl.Text = selected.Makeup[3];
                else mu4Lbl.Text = "None";
            }

            catch (Exception excp)
            {
                MessageBox.Show("Invalid Selection");
                MessageBox.Show("Please report this error to the developer: " + excp.ToString());
                this.Close();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //moves from integer to string to get the level
        private string GetLevelString(int lvl)
        {
            if (lvl == 0)
            {
                return "B0";
            }

            if (lvl == 1)
            {
                return "B1";
            }

            if (lvl == 2)
            {
                return "B2";
            }

            if (lvl == 3)
            {
                return "IM1";
            }

            if (lvl == 4)
            {
                return "IM2";
            }

            if (lvl == 5)
            {
                return "AD1";
            }

            if (lvl == 6)
            {
                return "AD2";
            }

            return "null";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
