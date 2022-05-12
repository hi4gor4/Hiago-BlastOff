using SorteiaFuncionario.Planilha;
using SorteiaFuncionario.Model;

namespace SorteioToodoo
{
    public partial class Form1 : Form
    {
        public static string SORTEADOS = "sorteados.xlsx";
        public static string PARTICIPANTES = "Lista_de_funcionarios.xlsx";
        private Sorteio Sorteio { get; set; }
        public Form1()
        {
            InitializeComponent();
            
            Sorteio = new Sorteio("Toodoo");

            VisivelLista();

            if (ExcelManager.VerifyTable(Path.GetFullPath(SORTEADOS)))
                Sorteio.Sorteados = ExcelManager.GetLinhas(1, Path.GetFullPath(SORTEADOS));
            if (ExcelManager.VerifyTable(Path.GetFullPath(PARTICIPANTES)))
                AddFuncs();   
            }
        private  void AddFuncs()
        {
            string path = Path.GetFullPath("Lista_de_funcionarios.xlsx");
            List<string> funcionarios = ExcelManager.GetLinhas(1, path);
            if (funcionarios.Count() == 0)
            {
                throw new Exception("Impossivel adicionar participantes");
            }
            foreach (string nome in funcionarios)
            {
                Sorteio.AddFuncionario(nome);
            }
        }

        private void AddSorteados()
        {
            string path = Path.GetFullPath(SORTEADOS);
            List<string> funcionarios = ExcelManager.GetLinhas(1, path);
            foreach (string nome in funcionarios)
            {
                Sorteio.AddSorteado(nome);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                string sorteado = Sorteio.Sortear();
                VisivelSorteado();
                string path = Path.GetFullPath(SORTEADOS);
                ExcelManager.AddLinha(1, path, sorteado);
                sorteadoBox.Text = sorteado;

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        private  void VisivelSorteado()
        {
            painelFogosdireito.Visible = true;
            painelFogosEsquerdo.Visible = true;
            listSorteio.Visible=false;
            sorteadoBox.Visible = true;
        }
        private void VisivelLista()
        {
            painelFogosdireito.Visible = false;
            painelFogosEsquerdo.Visible = false;
            listSorteio.Visible = true;
            sorteadoBox.Visible = false;
            listSorteio.Items.Clear();

        }
        private void btnSorteados_Click(object sender, EventArgs e)
        {
            VisivelLista();
            listSorteio.Items.Add("Sorteados:");
            foreach(string sorteado in Sorteio.Sorteados)
            {
                listSorteio.Items.Add(sorteado);
            }
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            VisivelLista();
            listSorteio.Items.Add("Participantes:");
            foreach (string participante in Sorteio.Participantes)
            {
                listSorteio.Items.Add(participante);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}