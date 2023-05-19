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
    }
}