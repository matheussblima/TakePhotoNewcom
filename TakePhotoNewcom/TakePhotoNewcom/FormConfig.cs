using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using Microsoft.SqlServer.Management.Smo;
using TakePhotoNewcom;

namespace TakePhotoNewcom
{
    public partial class FormConfig : Form
    {
        static string keyLocalFoto = "LocalFoto";
        static string keyServidor = "Servidor";
        static string keyAutenticacao = "Autenticacao";
        static string keyUsuario = "Usuario";
        static string keyPass = "Pass";
        static string keyBancoDados = "BancoDados";
        static string keyRstp = "Rstp";
        static string keyParamFoto = "ParamFoto";
        static string keyUserCamera = "UserCamera";
        static string keyPassCamera = "PassCamera";

        static string autenticacaoWindows = "Modo Windows";
        static string autenticacaoSQL = "Modo SQL Server";

        ModifyRegistry modifyRegistry = new ModifyRegistry();

        public FormConfig()
        {
            InitializeComponent();
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            Thread threadStartPage = new Thread(startPage);
            threadStartPage.Start();

            circularProgressBarConfig.Value = 0;
            circularProgressBarConfig.Minimum = 0;
            circularProgressBarConfig.Maximum = 100;

            string localFoto = modifyRegistry.Read(keyLocalFoto);
            string autenticacao = modifyRegistry.Read(keyAutenticacao);
            string usuario = modifyRegistry.Read(keyUsuario);
            string pass = modifyRegistry.Read(keyPass);
            string bancoDados = modifyRegistry.Read(keyBancoDados);
            string rtsp = modifyRegistry.Read(keyRstp);
            string paramFoto = modifyRegistry.Read(keyParamFoto);
            string userCamera = modifyRegistry.Read(keyUserCamera);
            string passCamera = modifyRegistry.Read(keyPassCamera);

            comboBoxAutenticacao.Items.Add(autenticacaoWindows);
            comboBoxAutenticacao.Items.Add(autenticacaoSQL);

            textBoxLocalFoto.Text = localFoto;

            if (userCamera != null)
            {
                textBoxUserCamera.Text = userCamera;
            }
            else
            {
                textBoxUserCamera.Text = "Admin";
            }

            if (passCamera != null)
            {
                textBoxPasswordCamera.Text = passCamera;
            }
            else
            {
                textBoxPasswordCamera.Text = "Newcomlab2015";
            }

            if (paramFoto != null)
            {
                textBoxParamFoto.Text = paramFoto;
            }
            else
            {
                textBoxParamFoto.Text = "http://admin:Newcomlab@192.168.1.64/ISAPI/Streaming/channels/101/picture";
            }

            if (rtsp != null)
            {
                textBoxRtsp.Text = rtsp;
            }
            else
            {
                textBoxRtsp.Text = "rtsp://admin:Newcomlab2015@192.168.1.64:554/";
            }


            if (autenticacao != null)
            {
                comboBoxAutenticacao.SelectedItem = autenticacao;

                if (comboBoxAutenticacao.SelectedItem.ToString() == autenticacaoWindows)
                {
                    textBoxSenha.Enabled = false;
                    textBoxUsuario.Enabled = false;
                }
            }
            else
            {
                comboBoxAutenticacao.SelectedIndex = 0;
            }

            if (bancoDados != null)
            {
                textBoxBDName.Text = bancoDados;
            }
            else
            {
                textBoxBDName.Text = "SecullumAcessoNet";
            }

            buttonSalvar.Enabled = false;
            comboBoxInstancia.Enabled = false;
        }

        private void startPage()
        {
            timerProgresseBarServidor.Start();

            string[] instances = ListLocalSqlInstances();

            if (instances.Length > 0)
            {
                foreach (string instancia in instances)
                {
                    comboBoxInstancia.Invoke((MethodInvoker)delegate () {
                        comboBoxInstancia.Items.Add(instancia);
                        comboBoxInstancia.Update();
                    });
                }

                comboBoxInstancia.Invoke((MethodInvoker)delegate () {
                    string servidor = modifyRegistry.Read(keyServidor);

                    if (servidor != null)
                    {
                        comboBoxInstancia.SelectedItem = servidor;
                    }
                    else
                    {
                        comboBoxInstancia.SelectedIndex = 0;
                    }

                    buttonSalvar.Enabled = true;
                    comboBoxInstancia.Enabled = true;
                });

            }

            timerProgresseBarServidor.Stop();
            circularProgressBarConfig.Invoke((MethodInvoker)delegate() {
                circularProgressBarConfig.Value = 0;
                circularProgressBarConfig.Update();
            });
        }


        private string[] ListLocalSqlInstances()
        {
            DataTable table = null;

            table = SmoApplication.EnumAvailableSqlServers();

            try
            {
                table = SmoApplication.EnumAvailableSqlServers();
            }
            catch (Exception e)
            {
                MessageBox.Show("ListLocalSqlInstances: " + e.Message);
                return null;
            }

            string [] instances = new string[table.Rows.Count];
            int cont = 0;

            foreach (DataRow row in table.Rows)
            {
                instances[cont] = row["Name"].ToString();
                cont++;
            }

            return instances;

        }

        private void comboBoxAutenticacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAutenticacao.SelectedItem.ToString() == autenticacaoWindows)
            {
                textBoxSenha.Enabled = false;
                textBoxUsuario.Enabled = false;
            }
            else
            {
                textBoxSenha.Enabled = true;
                textBoxUsuario.Enabled = true;
            }
        }

        private void timerProgresseBarServidor_Tick(object sender, EventArgs e)
        {
            circularProgressBarConfig.Increment(1);
            circularProgressBarConfig.Update();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxLocalFoto.Text != null && textBoxBDName.Text != null)
            {
                modifyRegistry.Write(keyLocalFoto, textBoxLocalFoto.Text);
                modifyRegistry.Write(keyServidor, comboBoxInstancia.SelectedItem);
                modifyRegistry.Write(keyAutenticacao, comboBoxAutenticacao.SelectedItem);
                modifyRegistry.Write(keyUsuario, textBoxUsuario.Text);
                modifyRegistry.Write(keyPass, textBoxSenha.Text);
                modifyRegistry.Write(keyBancoDados, textBoxBDName.Text);
                modifyRegistry.Write(keyRstp, textBoxRtsp.Text);
                modifyRegistry.Write(keyParamFoto, textBoxParamFoto.Text);
                modifyRegistry.Write(keyPassCamera, textBoxPasswordCamera.Text);
                modifyRegistry.Write(keyUserCamera, textBoxUserCamera.Text);

                this.Close();
            }
            else
            {
                MessageBox.Show("Campos em Branco");
            }
        }
    }
}
