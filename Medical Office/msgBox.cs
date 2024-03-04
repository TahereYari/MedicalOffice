using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Office
{
    class msgBox
    {
        public DialogResult myshowdialog(string title, string fainfo, string enginfo, bool buttons, bool type)
        {
            MessageForm m = new MessageForm();
            
            m.label3.Text = title;
            m.label1.Text = fainfo;
            m.label2.Text = enginfo;
            if (buttons)
            {
                m.buttonX2.Text = "خیر";
            }
            else
            {
                m.buttonX1.Visible = false;
            }

            if (type)
            {
                m.BackColor = Color.FromArgb(242, 69, 29);
                m.label4.BackColor= Color.FromArgb(242, 69, 29);
                m.label5.BackColor = Color.FromArgb(242, 69, 29);
                m.pictureBox1.Image = Properties.Resources.danger2;
                m.pictureBox1.BackColor= Color.FromArgb(242, 69, 29);
                m.label3.BackColor= Color.FromArgb(242, 69, 29);
            }
            m.ShowDialog();
            return m.DialogResult;


        }
    }
    }
