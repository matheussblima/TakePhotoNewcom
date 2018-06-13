namespace TakePhotoNewcom
{
    partial class FormPhoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhoto));
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.button_TirarFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(12, 12);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(452, 318);
            this.axVLCPlugin21.TabIndex = 0;
            // 
            // button_TirarFoto
            // 
            this.button_TirarFoto.Image = global::TakePhotoNewcom.Properties.Resources.photo_camera;
            this.button_TirarFoto.Location = new System.Drawing.Point(208, 336);
            this.button_TirarFoto.Name = "button_TirarFoto";
            this.button_TirarFoto.Size = new System.Drawing.Size(59, 44);
            this.button_TirarFoto.TabIndex = 1;
            this.button_TirarFoto.UseVisualStyleBackColor = true;
            this.button_TirarFoto.Click += new System.EventHandler(this.button_TirarFoto_Click);
            // 
            // FormPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(477, 387);
            this.Controls.Add(this.button_TirarFoto);
            this.Controls.Add(this.axVLCPlugin21);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPhoto";
            this.ShowInTaskbar = false;
            this.Text = "TakePhotoNewcom - Foto";
            this.Load += new System.EventHandler(this.FormPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.Button button_TirarFoto;
    }
}