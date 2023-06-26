using System.Media;

namespace Lost_Ark_Fish_Oreha_Fusion_Material_Calculator
{
    public partial class Form1 : Form
    {
        decimal input1, input2, input3, input4;
        string fishes;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxInput1.Text == "" || textBoxInput1.Text.Any(char.IsLetter) || textBoxInput1.Text.Any(char.IsSymbol) || textBoxInput1.Text.Any(char.IsPunctuation))
            {
                SystemSounds.Beep.Play();
                return;
            }
            if (textBoxInput2.Text == "")
            {
                SystemSounds.Beep.Play();
                return;
            }
            if (textBoxInput3.Text == "")
            {
                SystemSounds.Beep.Play();
                return;
            }
            if (textBoxInput4.Text == "")
            {
                SystemSounds.Beep.Play();
                return;
            }

            input1 = Convert.ToDecimal(textBoxInput1.Text);
            input2 = Convert.ToDecimal(textBoxInput2.Text);
            input3 = Convert.ToDecimal(textBoxInput3.Text);
            input4 = Convert.ToDecimal(textBoxInput4.Text);


            fishes = Convert.ToString((Decimal.Multiply(input1, (decimal)0.8) + (Decimal.Multiply(input2, 4)) + input3 + input4));
            decimal fishesdec = Convert.ToDecimal(fishes);
            labelCalculate.Text = Convert.ToString(Decimal.Divide(fishesdec, 30) + 1);
        }
    }
}