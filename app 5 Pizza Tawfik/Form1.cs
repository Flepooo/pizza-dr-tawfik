using System;
using System.Windows.Forms;

namespace app_5_Pizza_Tawfik
{
    public partial class Form1 : Form
    {

        int total = 0 ;
        int listNum = 0;
       
        public Form1()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = 0;
       /*     int small = 30;
            int medium = 40;
            int large = 50;    */
            int amount = 1;

            //     amount = Convert.ToInt32(textBox1.Text);
            bool amountBool = Int32.TryParse(textBox1.Text , out amount);

            if(amountBool == false)
            {
                MessageBox.Show("Plz enter a valid number", "error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }

            int toto = 0;

            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("Plz select size", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String x = listBox1.SelectedItem.ToString() ;
            listBox4.Items.Add((++listNum)+"-"+x);
            listBox6.Items.Add(amount);

            if (radioButton1.Checked == true)
            {
                price = 30;
                toto += amount * price;
                listBox5.Items.Add(price);
                listBox7.Items.Add(toto);
            }

            if (radioButton2.Checked == true)
            {
                price = 40;
                toto += amount * price;
                listBox5.Items.Add(price);
                listBox7.Items.Add(amount * price);
            }

            if (radioButton3.Checked == true)
            {
                price = 50;
                toto += amount * price;
                listBox5.Items.Add(price);
                listBox7.Items.Add(amount * price);
            }


            toto += amount * price;
            total += toto;
            label6.Text = total.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int priceAll = 15;
            int amountS = 1;

            //    amountS = Convert.ToInt32(textBox2.Text);

            bool amountBool = Int32.TryParse(textBox2.Text, out amountS);

            if (amountBool == false)
            {
                MessageBox.Show("Plz enter a valid number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int toto = priceAll * amountS;


            String x = listBox2.SelectedItem.ToString();

            listBox4.Items.Add((++listNum) + "-" + x);
            listBox5.Items.Add(priceAll);
            listBox6.Items.Add(amountS);
            listBox7.Items.Add(toto);

            total += toto;
            label6.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cola = 6;
            int amountD = 1;

            //   amountD = Convert.ToInt32(textBox3.Text);

            bool amountBool = Int32.TryParse(textBox3.Text, out amountD);

            if (amountBool == false)
            {
                MessageBox.Show("Plz enter a valid number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int toto = cola * amountD;


            String x = listBox3.SelectedItem.ToString();

            listBox4.Items.Add((++listNum) + "-" + x);
            listBox5.Items.Add(cola);
            listBox6.Items.Add(amountD);
            listBox7.Items.Add(toto);

            total += toto;
            label6.Text = total.ToString();
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox4.Items.Remove(listBox4.SelectedItem);


            
        }
    }
}
