using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJ_Students
{
    public partial class Summary : Form
    {
        private Font printFont;

        public Summary()
        {
            InitializeComponent();
        }

        public Summary(List<LessonInstance> instances)
        {
            InitializeComponent();
            var Oinstances = instances.OrderBy(x => x.LessonTime);
            foreach (LessonInstance l in Oinstances)
            {
                if (l.Absent.Count > 0 || l.Makeup.Count > 0 || l.Trial.Count > 0)
                {
                    summaryBox.AppendText(l.Title.ToUpper() + " " + l.Teacher + "\r\n");

                    if (l.Absent.Count > 0)
                    {
                        summaryBox.AppendText("\r\n");
                        summaryBox.AppendText("---Absent---" + "\r\n");
                        foreach (Student s in l.Absent)
                        {
                            summaryBox.AppendText(s.FullName + "\r\n");
                        }
                    }

                    if (l.Makeup.Count > 0)
                    {
                        summaryBox.AppendText("\r\n");
                        summaryBox.AppendText("---Make-Up---" + "\r\n");
                        foreach (Student s in l.Makeup)
                        {
                            summaryBox.AppendText(s.FullName + "\r\n");
                        }
                    }

                    if (l.Trial.Count > 0)
                    {
                        summaryBox.AppendText("\r\n");
                        summaryBox.AppendText("---Trial---" + "\r\n");
                        foreach (Student s in l.Trial)
                        {
                            summaryBox.AppendText(s.FullName + "\r\n");
                        }
                    }
                    summaryBox.AppendText("\r\n");
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void summaryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Print()
        {
            string printString = summaryBox.Text;
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            string s = summaryBox.Text;

            PrintDocument p = new PrintDocument();
            p.OriginAtMargins = true;
            Margins margins = new Margins(50, 50, 50, 50);
            p.DefaultPageSettings.Margins = margins;
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(s, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

            };
            try
            {
                p.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
        }
    }
}
