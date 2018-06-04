using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using TakePhotoNewcom.Classes;
using System.Data;
using System.Threading;

namespace TakePhotoNewcom
{
    public partial class FormMain : Form
    {

        static string keyLocalFoto = "LocalFoto";
        static string keyServidor = "Servidor";
        static string keyAutenticacao = "Autenticacao";
        static string keyUsuario = "Usuario";
        static string keyPass = "Pass";
        static string keyBancoDados = "BancoDados";
        bool pageStart = false;
        User user;

        ModifyRegistry modifyRegistry = new ModifyRegistry();

        public FormMain()
        {
            InitializeComponent();
        }

        string localFoto = null;
        string autenticacao = null;
        string usuario = null;
        string pass = null;
        string bancoDados = null;
        string servidor = null;


        private void Form1_Load(object sender, EventArgs e)
        {
          
            localFoto = modifyRegistry.Read(keyLocalFoto);
            autenticacao = modifyRegistry.Read(keyAutenticacao);
            usuario = modifyRegistry.Read(keyUsuario);
            pass = modifyRegistry.Read(keyPass);
            bancoDados = modifyRegistry.Read(keyBancoDados);
            servidor = modifyRegistry.Read(keyServidor);

            user = new User(servidor, bancoDados);

            Thread threadStartPage = new Thread(startPage);
            threadStartPage.Start();

        }

        private void startPage()
        {
            if (servidor != null && bancoDados != null)
            {
                SqlDataAdapter sqlDataAdapter = user.getAllUsersSqlDataAdapter();

                if (sqlDataAdapter != null)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGridView.Invoke((MethodInvoker)delegate ()
                    {
                        dataGridView.DataSource = dataTable;
                    });

                    //Tira a seleção do gridView
                    dataGridView.Invoke((MethodInvoker)delegate ()
                    {
                        dataGridView.Rows[0].Selected = false;
                    });

                    pageStart = true;
                }
                else
                {
                    MessageBox.Show("Não foi possível conectar ao servidor");
                }
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0 && pageStart)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["n_identificador"].Value.ToString());
                string name = dataGridView.SelectedRows[0].Cells["nome"].Value.ToString();

                FormPhoto formPhoto = new FormPhoto();
                formPhoto.Show();
            }
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfig formConfig = new FormConfig();
            formConfig.Show();
        }
    }
}
