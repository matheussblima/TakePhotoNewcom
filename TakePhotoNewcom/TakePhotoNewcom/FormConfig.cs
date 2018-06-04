﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using Microsoft.SqlServer.Management.Smo;
using TakePhotoNewcom;

namespace TakePhotoNewcom
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        static string keyLocalFoto = "LocalFoto";
        static string keyServidor = "Servidor";
        static string keyAutenticacao = "Autenticacao";
        static string keyUsuario = "Usuario";
        static string keyPass = "Pass";
        static string keyBancoDados = "BancoDados";

        static string autenticacaoWindows = "Modo Windows";
        static string autenticacaoSQL = "Modo SQL Server";

        ModifyRegistry modifyRegistry = new ModifyRegistry();

        private void FormConfig_Load(object sender, EventArgs e)
        {
            Thread threadStartPage = new Thread(startPage);
            threadStartPage.Start();

            circularProgressBarServidor.Value = 0;
            circularProgressBarServidor.Minimum = 0;
            circularProgressBarServidor.Maximum = 100;

            string localFoto = modifyRegistry.Read(keyLocalFoto);
            string autenticacao = modifyRegistry.Read(keyAutenticacao);
            string usuario = modifyRegistry.Read(keyUsuario);
            string pass = modifyRegistry.Read(keyPass);
            string bancoDados = modifyRegistry.Read(keyBancoDados);

            comboBoxAutenticacao.Items.Add(autenticacaoWindows);
            comboBoxAutenticacao.Items.Add(autenticacaoSQL);

            textBoxLocalFoto.Text = localFoto;


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
            circularProgressBarServidor.Invoke((MethodInvoker)delegate() {
                circularProgressBarServidor.Value = 0;
                circularProgressBarServidor.Update();
            });
        }


        private string[] ListLocalSqlInstances()
        {
            DataTable table = SmoApplication.EnumAvailableSqlServers();

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
            circularProgressBarServidor.Increment(1);
            circularProgressBarServidor.Update();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxLocalFoto.Text == null && textBoxBDName.Text == null && comboBoxAutenticacao.SelectedItem.ToString() == "Modo SQL Server")
            {
                modifyRegistry.Write(keyLocalFoto, textBoxLocalFoto.Text);
                modifyRegistry.Write(keyServidor, comboBoxInstancia.SelectedItem);
                modifyRegistry.Write(keyAutenticacao, comboBoxAutenticacao.SelectedItem);
                modifyRegistry.Write(keyUsuario, textBoxUsuario.Text);
                modifyRegistry.Write(keyUsuario, textBoxUsuario.Text);
                modifyRegistry.Write(keyPass, textBoxSenha.Text);
                modifyRegistry.Write(keyBancoDados, textBoxBDName.Text);

                this.Close();
            }
            else
            {
                MessageBox.Show("Campos em Branco");
            }


        }

    }
}