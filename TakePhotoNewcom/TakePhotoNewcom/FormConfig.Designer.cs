namespace TakePhotoNewcom
{
    partial class FormConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLocalFoto = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxBDName = new System.Windows.Forms.TextBox();
            this.comboBoxInstancia = new System.Windows.Forms.ComboBox();
            this.circularProgressBarConfig = new CircularProgressBar.CircularProgressBar();
            this.timerProgresseBarServidor = new System.Windows.Forms.Timer(this.components);
            this.comboBoxAutenticacao = new System.Windows.Forms.ComboBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxRtsp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxParamFoto = new System.Windows.Forms.TextBox();
            this.textBoxUserCamera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPasswordCamera = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuração do Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local Foto: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Servidor/Instância: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Autenticação: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Usuário: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Senha: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nome do Banco de Dados: ";
            // 
            // textBoxLocalFoto
            // 
            this.textBoxLocalFoto.Location = new System.Drawing.Point(214, 70);
            this.textBoxLocalFoto.Name = "textBoxLocalFoto";
            this.textBoxLocalFoto.Size = new System.Drawing.Size(201, 20);
            this.textBoxLocalFoto.TabIndex = 8;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(214, 344);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(201, 20);
            this.textBoxUsuario.TabIndex = 12;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(214, 385);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(201, 20);
            this.textBoxSenha.TabIndex = 13;
            // 
            // textBoxBDName
            // 
            this.textBoxBDName.Location = new System.Drawing.Point(214, 423);
            this.textBoxBDName.Name = "textBoxBDName";
            this.textBoxBDName.Size = new System.Drawing.Size(201, 20);
            this.textBoxBDName.TabIndex = 14;
            // 
            // comboBoxInstancia
            // 
            this.comboBoxInstancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstancia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxInstancia.Location = new System.Drawing.Point(214, 257);
            this.comboBoxInstancia.Name = "comboBoxInstancia";
            this.comboBoxInstancia.Size = new System.Drawing.Size(201, 21);
            this.comboBoxInstancia.TabIndex = 15;
            // 
            // circularProgressBarConfig
            // 
            this.circularProgressBarConfig.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarConfig.AnimationSpeed = 500;
            this.circularProgressBarConfig.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarConfig.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarConfig.InnerMargin = 2;
            this.circularProgressBarConfig.InnerWidth = -1;
            this.circularProgressBarConfig.Location = new System.Drawing.Point(375, 20);
            this.circularProgressBarConfig.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarConfig.Name = "circularProgressBarConfig";
            this.circularProgressBarConfig.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarConfig.OuterMargin = -25;
            this.circularProgressBarConfig.OuterWidth = 26;
            this.circularProgressBarConfig.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarConfig.ProgressWidth = 5;
            this.circularProgressBarConfig.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarConfig.Size = new System.Drawing.Size(40, 40);
            this.circularProgressBarConfig.StartAngle = 270;
            this.circularProgressBarConfig.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBarConfig.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarConfig.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarConfig.SubscriptText = ".23";
            this.circularProgressBarConfig.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarConfig.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarConfig.SuperscriptText = "°C";
            this.circularProgressBarConfig.TabIndex = 16;
            this.circularProgressBarConfig.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarConfig.Value = 68;
            // 
            // timerProgresseBarServidor
            // 
            this.timerProgresseBarServidor.Enabled = true;
            this.timerProgresseBarServidor.Interval = 30;
            this.timerProgresseBarServidor.Tick += new System.EventHandler(this.timerProgresseBarServidor_Tick);
            // 
            // comboBoxAutenticacao
            // 
            this.comboBoxAutenticacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAutenticacao.FormattingEnabled = true;
            this.comboBoxAutenticacao.Location = new System.Drawing.Point(214, 302);
            this.comboBoxAutenticacao.Name = "comboBoxAutenticacao";
            this.comboBoxAutenticacao.Size = new System.Drawing.Size(201, 21);
            this.comboBoxAutenticacao.TabIndex = 17;
            this.comboBoxAutenticacao.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutenticacao_SelectedIndexChanged);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(309, 471);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(106, 33);
            this.buttonSalvar.TabIndex = 18;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.label9.Location = new System.Drawing.Point(16, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "RTSP:";
            // 
            // textBoxRtsp
            // 
            this.textBoxRtsp.Location = new System.Drawing.Point(214, 109);
            this.textBoxRtsp.Name = "textBoxRtsp";
            this.textBoxRtsp.Size = new System.Drawing.Size(201, 20);
            this.textBoxRtsp.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.label10.Location = new System.Drawing.Point(16, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Parametro Foto:";
            // 
            // textBoxParamFoto
            // 
            this.textBoxParamFoto.Location = new System.Drawing.Point(214, 150);
            this.textBoxParamFoto.Name = "textBoxParamFoto";
            this.textBoxParamFoto.Size = new System.Drawing.Size(201, 20);
            this.textBoxParamFoto.TabIndex = 23;
            // 
            // textBoxUserCamera
            // 
            this.textBoxUserCamera.Location = new System.Drawing.Point(214, 186);
            this.textBoxUserCamera.Name = "textBoxUserCamera";
            this.textBoxUserCamera.Size = new System.Drawing.Size(201, 20);
            this.textBoxUserCamera.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.label3.Location = new System.Drawing.Point(16, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Usuário Camera:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.label11.Location = new System.Drawing.Point(16, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Password Camera:";
            // 
            // textBoxPasswordCamera
            // 
            this.textBoxPasswordCamera.Location = new System.Drawing.Point(214, 222);
            this.textBoxPasswordCamera.Name = "textBoxPasswordCamera";
            this.textBoxPasswordCamera.PasswordChar = '*';
            this.textBoxPasswordCamera.Size = new System.Drawing.Size(201, 20);
            this.textBoxPasswordCamera.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 28;
            this.button1.Text = "Padrão";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxPasswordCamera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUserCamera);
            this.Controls.Add(this.textBoxParamFoto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxRtsp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.comboBoxAutenticacao);
            this.Controls.Add(this.circularProgressBarConfig);
            this.Controls.Add(this.comboBoxInstancia);
            this.Controls.Add(this.textBoxBDName);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.textBoxLocalFoto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfig";
            this.ShowInTaskbar = false;
            this.Text = "TakePhotoNewcom - Configurações";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLocalFoto;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxBDName;
        private System.Windows.Forms.ComboBox comboBoxInstancia;
        private CircularProgressBar.CircularProgressBar circularProgressBarConfig;
        private System.Windows.Forms.Timer timerProgresseBarServidor;
        private System.Windows.Forms.ComboBox comboBoxAutenticacao;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxRtsp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxParamFoto;
        private System.Windows.Forms.TextBox textBoxUserCamera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPasswordCamera;
        private System.Windows.Forms.Button button1;
    }
}