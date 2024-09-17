namespace Harry_Potter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnChapeu_Click(object sender, EventArgs e)
        {
            string studentName = txtNome.Text;
            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Por favor, insira o nome do aluno.");
                return;
            }

            string house = SortHouse();
            MessageBox.Show($"{studentName}, irá para a casa {house}!");

            switch (house)
            {
                case "Grifinória":
                    lstGryffindor.Items.Add(studentName);
                    break;
                case "Lufa-Lufa":
                    lstHufflepuff.Items.Add(studentName);
                    break;
                case "Corvinal":
                    lstRavenclaw.Items.Add(studentName);
                    break;
                case "Sonserina":
                    lstSlytherin.Items.Add(studentName);
                    break;
            }

            txtNome.Clear();
        }
        private string SortHouse()
        {
            string[] houses = { "Grifinória", "Lufa-Lufa", "Corvinal", "Sonserina" };
            Random rand = new Random();
            int index = rand.Next(houses.Length);
            return houses[index];
        }

        private void finalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

