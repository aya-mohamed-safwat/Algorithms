using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Algorithms
{
    public partial class Form1 : Form
    {
        ArrayList array = new ArrayList();
        int check;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fcfsbtn_Click(object sender, EventArgs e)
        {
            check = 1;

            array.Add(Convert.ToInt32(p1txt.Text));
            array.Add(Convert.ToInt32(p2txt.Text));
            array.Add(Convert.ToInt32(p3txt.Text));
            array.Add(Convert.ToInt32(p4txt.Text));

            foreach (var item in array)
            {
                checkedListBox1.Items.Add(item);
            }
            timer1.Start();
        }
        private void RRbtn_Click(object sender, EventArgs e)
        {

            label1.Text = p1txt.Text;
            label2.Text = p2txt.Text;
            label3.Text = p3txt.Text;
            label4.Text = p4txt.Text;

            timer3.Start();
        }

        private void priortybtn_Click(object sender, EventArgs e)
        {
            check = 3;

            array.Add(Convert.ToInt32(textBox1.Text));
            array.Add(Convert.ToInt32(textBox2.Text));
            array.Add(Convert.ToInt32(textBox3.Text));
            array.Add(Convert.ToInt32(textBox4.Text));
            array.Sort();
            foreach (var item in array)
            {
                checkedListBox1.Items.Add(item);
            }
            timer1.Start();
        }

        private void sjf2btn_Click(object sender, EventArgs e)
        {
            check = 4;

            array.Add(Convert.ToInt32(p1txt.Text));
            array.Add(Convert.ToInt32(p2txt.Text));
            array.Add(Convert.ToInt32(p3txt.Text));
            array.Add(Convert.ToInt32(p4txt.Text));
            array.Sort();
            foreach (var item in array)
            {
                checkedListBox1.Items.Add(item);
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check == 1)
            {

                timer1.Interval = Convert.ToInt32(checkedListBox1.Items[0] + "000");
                if (checkedListBox1.Items[0].ToString() == p1txt.Text)
                {
                    cputxt.Text = p1.Text;
                }
                else if (checkedListBox1.Items[0].ToString() == p2txt.Text)
                {
                    cputxt.Text = p2.Text;
                }
                else if (checkedListBox1.Items[0].ToString() == p3txt.Text)
                {
                    cputxt.Text = p3.Text;
                }
                else if (checkedListBox1.Items[0].ToString() == p4txt.Text)
                {
                    cputxt.Text = p4.Text;
                }
                checkedListBox1.Items.RemoveAt(0);

                if (checkedListBox1.Items.Count <= 0)
                {
                    timer1.Stop();
                }

            }
               
            else if (check == 3)
            {

                timer1.Interval = Convert.ToInt32(checkedListBox1.Items[0] + "000");
                if (checkedListBox1.Items[0].ToString() == textBox1.Text)
                {
                    cputxt.Text = p1.Text;
                }
                else if (checkedListBox1.Items[0].ToString() == textBox2.Text)
                {
                    cputxt.Text = p2.Text;
                }
                else if (checkedListBox1.Items[0].ToString() == textBox3.Text)
                {
                    cputxt.Text = p3.Text;
                }
                else if (checkedListBox1.Items[0].ToString() == textBox4.Text)
                {
                    cputxt.Text = p4.Text;
                }
                checkedListBox1.Items.RemoveAt(0);

                if (checkedListBox1.Items.Count <= 0)
                {
                    timer1.Stop();
                }

            }
            else if (check == 4)
            {

                timer1.Interval = Convert.ToInt32(checkedListBox1.Items[0] + "000");
                if (checkedListBox1.Items[0].ToString() == p1txt.Text)
                {
                    cputxt.Text = p1.Text;
                }
                else if (checkedListBox1.Items[0].ToString() == p2txt.Text)
                {
                    cputxt.Text = p2.Text;
                }
                else if (checkedListBox1.Items[0].ToString() == p3txt.Text)
                {
                    cputxt.Text = p3.Text;
                }
                else if (checkedListBox1.Items[0].ToString() == p4txt.Text)
                {
                    cputxt.Text = p4.Text;
                }
                checkedListBox1.Items.RemoveAt(0);

                if (checkedListBox1.Items.Count <= 0)
                {
                    timer1.Stop();
                }

            }

        }

       

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (p1txt.Text != "" && p2txt.Text != "" && p3txt.Text != "" && p4txt.Text != "" && txtq.Text != "")
            {
                //p1
                if (Convert.ToInt16(p1txt.Text) > 0)
                {
                    if (Convert.ToInt16(p1txt.Text) >= Convert.ToInt16(txtq.Text))
                    {
                        p1txt.Text = (Convert.ToInt16(p1txt.Text) - Convert.ToInt16(txtq.Text)).ToString();
                        checkedListBox1.Items.Add(p1.Text);
                    }
                    else if (Convert.ToInt16(p1txt.Text) < Convert.ToInt16(txtq.Text))
                    {
                        p1txt.Text = "0";
                        checkedListBox1.Items.Add(p1.Text);
                    }
                }
                //p2
                if (Convert.ToInt16(p2txt.Text) > 0)
                {
                    if (Convert.ToInt16(p2txt.Text) >= Convert.ToInt16(txtq.Text))
                    {
                        p2txt.Text = (Convert.ToInt16(p2txt.Text) - Convert.ToInt16(txtq.Text)).ToString();
                        checkedListBox1.Items.Add(p2.Text);
                    }
                    else if (Convert.ToInt16(p2txt.Text) < Convert.ToInt16(txtq.Text))
                    {
                        p2txt.Text = "0";
                        checkedListBox1.Items.Add(p2.Text);
                    }
                }

                //p3
                if (Convert.ToInt16(p3txt.Text) > 0)
                {
                    if (Convert.ToInt16(p3txt.Text) >= Convert.ToInt16(txtq.Text))
                    {
                        p3txt.Text = (Convert.ToInt16(p3txt.Text) - Convert.ToInt16(txtq.Text)).ToString();
                        checkedListBox1.Items.Add(p3.Text);
                    }
                    else if (Convert.ToInt16(p3txt.Text) < Convert.ToInt16(txtq.Text))
                    {
                        p3txt.Text = "0";
                        checkedListBox1.Items.Add(p3.Text);
                    }
                }

                //p4
                if (Convert.ToInt16(p4txt.Text) > 0)
                {
                    if (Convert.ToInt16(p4txt.Text) >= Convert.ToInt16(txtq.Text))
                    {
                        p4txt.Text = (Convert.ToInt16(p4txt.Text) - Convert.ToInt16(txtq.Text)).ToString();
                        checkedListBox1.Items.Add(p4.Text);
                    }
                    else if (Convert.ToInt16(p4txt.Text) < Convert.ToInt16(txtq.Text))
                    {
                        p4txt.Text = "0";
                        checkedListBox1.Items.Add(p4.Text);
                    }
                }
                timer3.Stop();
                cputxt.Text = "";
                timer2.Start();
            }
            else
            {
                timer3.Stop();
                MessageBox.Show("You should Inter Values First");
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count > 0)
            {
                cputxt.Text = checkedListBox1.Items[0].ToString();
                checkedListBox1.Items.RemoveAt(0);
                timer2.Stop();
                timer3.Start();
            }
            else if (checkedListBox1.Items.Count <= 0)
            {
                timer2.Stop();

            }
        }
    }
    
}

        

       
    
    
