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
            this.circularProgressBarServidor = new CircularProgressBar.CircularProgressBar();
            this.timerProgresseBarServidor = new System.Windows.Forms.Timer(this.components);
            this.comboBoxAutenticacao = new System.Windows.Forms.ComboBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
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
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Servidor/Instância: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Autenticação: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Usuário: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Senha: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 304);
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
            this.textBoxUsuario.Location = new System.Drawing.Point(214, 225);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(201, 20);
            this.textBoxUsuario.TabIndex = 12;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(214, 266);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(201, 20);
            this.textBoxSenha.TabIndex = 13;
            // 
            // textBoxBDName
            // 
            this.textBoxBDName.Location = new System.Drawing.Point(214, 304);
            this.textBoxBDName.Name = "textBoxBDName";
            this.textBoxBDName.Size = new System.Drawing.Size(201, 20);
            this.textBoxBDName.TabIndex = 14;
            // 
            // comboBoxInstancia
            // 
            this.comboBoxInstancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstancia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxInstancia.Location = new System.Drawing.Point(214, 138);
            this.comboBoxInstancia.Name = "comboBoxInstancia";
            this.comboBoxInstancia.Size = new System.Drawing.Size(201, 21);
            this.comboBoxInstancia.TabIndex = 15;
            // 
            // circularProgressBarServidor
            // 
            this.circularProgressBarServidor.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarServidor.AnimationSpeed = 500;
            this.circularProgressBarServidor.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarServidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarServidor.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarServidor.InnerMargin = 2;
            this.circularProgressBarServidor.InnerWidth = -1;
            this.circularProgressBarServidor.Location = new System.Drawing.Point(525, 12);
            this.circularProgressBarServidor.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarServidor.Name = "circularProgressBarServidor";
            this.circularProgressBarServidor.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarServidor.OuterMargin = -25;
            this.circularProgressBarServidor.OuterWidth = 26;
            this.circularProgressBarServidor.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarServidor.ProgressWidth = 5;
            this.circularProgressBarServidor.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarServidor.Size = new System.Drawing.Size(40, 40);
            this.circularProgressBarServidor.StartAngle = 270;
            this.circularProgressBarServidor.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBarServidor.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarServidor.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarServidor.SubscriptText = ".23";
            this.circularProgressBarServidor.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarServidor.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarServidor.SuperscriptText = "°C";
            this.circularProgressBarServidor.TabIndex = 16;
            this.circularProgressBarServidor.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarServidor.Value = 68;
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
            this.comboBoxAutenticacao.Location = new System.Drawing.Point(214, 183);
            this.comboBoxAutenticacao.Name = "comboBoxAutenticacao";
            this.comboBoxAutenticacao.Size = new System.Drawing.Size(201, 21);
            this.comboBoxAutenticacao.TabIndex = 17;
            this.comboBoxAutenticacao.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutenticacao_SelectedIndexChanged);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(258, 380);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(106, 33);
            this.buttonSalvar.TabIndex = 18;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 425);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.comboBoxAutenticacao);
            this.Controls.Add(this.circularProgressBarServidor);
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
            this.Name = "FormConfig";
            this.Text = "FormConfig";
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
        private CircularProgressBar.CircularProgressBar circularProgressBarServidor;
        private System.Windows.Forms.Timer timerProgresseBarServidor;
        private System.Windows.Forms.ComboBox comboBoxAutenticacao;
        private System.Windows.Forms.Button buttonSalvar;
    }
}