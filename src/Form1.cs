namespace Sorteador
{
    public partial class Sorteador : Form
    {
        List<string> listaString = new List<string>();


        private static Random rand = new Random();
        public Sorteador()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            listaString.Add(txtItems.Text);
            txtItems.Text = "";
            txtItems.Focus();

            Listar();
        }

        private void Listar()
        {
            Lista.Items.Clear();
            foreach (string item in listaString)
            {

                Lista.Items.Add(item);
            }
        }

        private void btnLimpar_MouseClick(object sender, MouseEventArgs e)
        {
            txtItems.Text = "";
            Lista.Items.Clear();
            listaString.Clear();
            resultList.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtItems.PlaceholderText = "Entrada de nome ou número";
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            resultList.Items.Clear();
            int valorSorteio = rand.Next(listaString.Count);
            resultList.Items.Add(listaString[valorSorteio]);

        }

        
    }
}
