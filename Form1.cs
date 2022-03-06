namespace Semana7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexión con = new Conexión();
        private void button1_Click(object sender, EventArgs e)
        {
            Musica mus = new Musica();

            mus.id= int.Parse(txtID.Text);
            mus.nombre = txtNombre.Text;
            mus.albúm = txtAlbum.Text;  
            mus.artista = txtArtista.Text;    \

            con.inupmusic(mus);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void actualizar()
        {
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = con.mostrar("Select ID_CAN AS [INDICE], NOM_CAN AS [NOMBRE], ALB_CAN AS [ALBUM], ART_CAN AS [ARTISTA] from Musica");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text= dataGridView1.SelectedCells[0].Value.ToString();
            txtNombre.Text= dataGridView1.SelectedCells[1].Value.ToString();
            txtArtista.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtAlbum.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }
    }
}