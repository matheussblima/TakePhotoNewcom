using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using TakePhotoNewcom.Classes;
using System.Data;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Timers;

namespace TakePhotoNewcom
{
    public partial class FormPrincipal : Form
    {

        static string keyLocalFoto = "LocalFoto";
        static string keyServidor = "Servidor";
        static string keyAutenticacao = "Autenticacao";
        static string keyUsuario = "Usuario";
        static string keyPass = "Pass";
        static string keyBancoDados = "BancoDados";

        static string padraoLocalFoto = "\\192.168.10.131\\AcessoNet\\Fotos";
        static string padraoServidor = "192.168.10.131";
        static string padraoAutenticacao = "Windows";
        static string padraoUsuario = "_SA";
        static string padraoPass = "42690";
        static string padraoBancoDados = "SecullumAcessoNet";


        bool pageStart = false;
        User user;

        ModifyRegistry modifyRegistry = new ModifyRegistry();

        string localFoto = null;
        string autenticacao = null;
        string usuario = null;
        string pass = null;
        string bancoDados = null;
        string servidor = null;

        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // CONFIGURANDO DIALOG
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            circularProgressBar.Value = 0;
            circularProgressBar.Minimum = 0;
            circularProgressBar.Maximum = 100;

            // CARREGANDO CONFIGURACOES DO REGISTRO
            localFoto = modifyRegistry.Read(keyLocalFoto);
            autenticacao = modifyRegistry.Read(keyAutenticacao);
            usuario = modifyRegistry.Read(keyUsuario);
            pass = modifyRegistry.Read(keyPass);
            bancoDados = modifyRegistry.Read(keyBancoDados);
            servidor = modifyRegistry.Read(keyServidor);

            if (localFoto == null)
            {
                localFoto = padraoLocalFoto;
                modifyRegistry.Write(keyLocalFoto, padraoLocalFoto);
            }
            if (autenticacao == null)
            {
                autenticacao = padraoAutenticacao;
                modifyRegistry.Write(keyAutenticacao, padraoAutenticacao);
            }
            if (usuario == null)
            {
                usuario = padraoUsuario;
                modifyRegistry.Write(keyUsuario, padraoUsuario);
            }
            if (pass == null)
            {
                pass = padraoPass;
                modifyRegistry.Write(keyPass, padraoPass);
            }
            if (bancoDados == null)
            {
                bancoDados = padraoBancoDados;
                modifyRegistry.Write(keyBancoDados, padraoBancoDados);
            }
            if (servidor == null)
            {
                servidor = padraoServidor;
                modifyRegistry.Write(keyServidor, padraoServidor);
            }

            // CLASSE PARA ACESSO AO SERVIDOR
            user = new User(servidor, bancoDados);


            tCarregaPessoas();
            System.Timers.Timer _timer; // From System.Timers
            _timer = new System.Timers.Timer(3000); // Set up the timer for 3 seconds
                                      //
                                      // Type "_timer.Elapsed += " and press tab twice.
                                      //
            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            _timer.Enabled = true; // Enable it

            // INICIALIZA THREAD PARA CARREGAR PESSOAS DO BD NA JANELA
//            Thread threadCarregaPessoas = new Thread(tCarregaPessoas);
            //threadCarregaPessoas.Start();

            Thread threadProgressBar = new Thread(tProgressBar);
            threadProgressBar.Start();
        }

        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            int sel = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["id"].Value.ToString());

            tCarregaPessoas();
            dataGridView.Rows[sel-1].Selected = true;
        }

        private void tProgressBar()
        {
            int t = 0;

            while (t <= 100)
            {
                //circularProgressBar.Value = t;

                Thread.Sleep(1000);
                t += 10;
            }
        }

        private void tCarregaPessoas()
        {
            //while (true)
            //{
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
                        MessageBox.Show("Não foi possível conectar ao servidor. Por favor, contate o suporte da Newcom.");
                    }
                }

              //  Thread.Sleep(5000);
            //}
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0 && pageStart)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["id"].Value.ToString());

                FormPhoto formPhoto = new FormPhoto(id);
                formPhoto.Show();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0 && pageStart)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["id"].Value.ToString());

                string fullName = localFoto + id.ToString() + "-1.jpg";

                if (File.Exists(fullName)) pictureBoxFoto.Image = Image.FromFile(fullName);
                else pictureBoxFoto.Image = Image.FromFile("c:\\erro.jpg");
            }
        }

        private void configuraçãoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormConfig formConfig = new FormConfig();
            formConfig.Show();
        }

        // NECESSARIO PARA FECHAR TODOS OS THREADS QUANDO O FORM FOR FECHADO.
        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}