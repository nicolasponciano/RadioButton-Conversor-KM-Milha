namespace RadioButton_tp_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            Converte converte = new Converte();
            converte.Valor = txtValor.Text;

            if (rbKmMilha.Checked)
            {
                converte.converteKm();
                txtConvertido.Text = converte.converteKm();
            }
            if (rbMilhaKm.Checked)
            {
                converte.converteMilha();
                txtConvertido.Text = converte.converteMilha();
            }
        }
    }
}