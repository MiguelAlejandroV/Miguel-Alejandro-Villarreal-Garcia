namespace Unidad_3_Practica_1._problema_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox1.Text);
            int B = int.Parse(textBox2.Text);
            int C = int.Parse(textBox3.Text);
if (A>B)
            if (B>C)
                      if(B>C)
                                 {textBox4.Text = A.ToString();
                        textBox5.Text = B.ToString();
                        textBox6.Text = C.ToString();}
                      else
                        {textBox4.Text = A.ToString();
                        textBox5.Text = C.ToString();
                        textBox6.Text = B.ToString();}
            else
               {textBox4.Text = C.ToString();
               textBox5.Text = A.ToString();
               textBox6.Text = B.ToString();}

else 
           if (B>C)
                      if (A>C)
                                {textBox4.Text = A.ToString();
                       textBox5.Text = B.ToString();
                       textBox6.Text = C.ToString();}
                else
                 {textBox4.Text = A.ToString();
                 textBox5.Text = C.ToString();
                 textBox6.Text = B.ToString();}
            else
             {textBox4.Text = C.ToString();
             textBox5.Text = A.ToString();
             textBox6.Text = B.ToString();}








        }
    }
}
