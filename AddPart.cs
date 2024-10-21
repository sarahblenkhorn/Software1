using Software1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Software1
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Part newPart;

                if (radioInHouse.Checked)
                {
                    newPart = new Inhouse()
                    {
                        PartID = int.Parse(textBox1.Text),
                        Name = textBox5.Text,
                        Price = decimal.Parse(textBox3.Text),
                        InStock = int.Parse(textBox4.Text),
                        Min = int.Parse(textBox6.Text),
                        Max = int.Parse(textBox7.Text),
                        MachineID = int.Parse(textBox2.Text)
                    };
                }
                else if (radioOutsourced.Checked) 
                {
                    newPart = new Outsourced()
                    {
                        PartID = int.Parse(textBox1.Text),
                        Name = textBox5.Text,
                        Price = decimal.Parse(textBox3.Text),
                        InStock = int.Parse(textBox4.Text),
                        Min = int.Parse(textBox6.Text),
                        Max = int.Parse(textBox7.Text),
                        CompanyName = textBox2.Text
                    };
                }
                else
                {
                    MessageBox.Show("Please select a part type.");
                    return;
                }

                Inventory.addPart(newPart);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void radioInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInHouse.Checked)
            {
                labelCompanyOrMachineID.Text = "Machine ID";
            }
        }

        private void radioOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOutsourced.Checked)
            {
                labelCompanyOrMachineID.Text = "Company Name";
            }
        }

    }
}
