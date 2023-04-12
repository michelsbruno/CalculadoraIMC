namespace CalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_form_Click(object sender, EventArgs e)
        {
            CalcIMC tela = new CalcIMC();
            tela.Show();
        }
    }
}