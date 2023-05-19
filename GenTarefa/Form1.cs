namespace GenTarefa
{
    public partial class AreaInicial : Form
    {
        public AreaInicial()
        {
            InitializeComponent();
        }

        private void AreaInicial_Load(object sender, EventArgs e)
        {

        }

        private void novaListaButton_Click(object sender, EventArgs e)
        {
            NovaLista novaLista = new NovaLista();
            novaLista.Show();
        }

        private void listasButton_Click(object sender, EventArgs e)
        {
            ListasSalvas listasSalvas = new ListasSalvas();
            listasSalvas.Show();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            const string message = "Tem certeza que deseja sair?";
            var result = MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                this.Close();
                
            }
        }
    }
}