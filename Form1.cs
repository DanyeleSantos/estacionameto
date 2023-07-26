namespace Aula09Estacionamento
{
    public partial class Form1 : Form
    {
       List<string> estacionamento = new List<string>();
          
        public Form1()
        {
            InitializeComponent();
        }
       







       
       
        void limpaCampos()
        {
          
            






        }
        private void txtplaca_TextChanged(object sender, EventArgs e) 
        {
             
        }

        

        

        private void btnretirar_Click(object sender, EventArgs e)
        {
            
            
            MessageBox.Show("Placa removida");
        }

        private void btnestacionar_Click(object sender, EventArgs e)
        {
            if (estacionamento.Count >= 5)
            {
                MessageBox.Show("Esta lotado!");
                return;
                    

            }
            if (txtplaca.Text == "")
            {
                MessageBox.Show("Preencha o campo para continuar");

            }
            string placa = txtplaca.Text;
            estacionamento.Add(placa);

            estacionamento.Remove(placa);

           lblcontador.Text = estacionamento.Count.ToString();

            lsttotal.Items.Clear();

            for (int i = 0; i < estacionamento.Count; i++)
            {
                lsttotal.Items.Add($"[VAGA - {i}]  {estacionamento[i]}");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lsttotal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}