using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxAXVLC;
using System.Net;
using System.IO;
using System.Drawing.Imaging;

namespace TakePhotoNewcom
{
    public partial class FormPhoto : Form
    {
        static string keyLocalFoto = "LocalFoto";
        static string keyParamFoto = "ParamFoto";
        static string keyRstp = "Rstp";
        static string keyUserCamera = "UserCamera";
        static string keyPassCamera = "PassCamera";
        string localFoto, paramFoto, rtsp, userCamera, passCamera;
        int idUser;

        ModifyRegistry modifyRegistry = new ModifyRegistry();

        public FormPhoto(int idUser)
        {
            InitializeComponent();

            this.idUser = idUser;

            localFoto = modifyRegistry.Read(keyLocalFoto);
            paramFoto = modifyRegistry.Read(keyParamFoto);
            rtsp = modifyRegistry.Read(keyRstp);
            userCamera = modifyRegistry.Read(keyUserCamera);
            passCamera = modifyRegistry.Read(keyPassCamera);

            if (localFoto == null || paramFoto == null || rtsp == null)
            {
                MessageBox.Show("Você precisa configurar os paramentros da foto");
                this.Close();
            }
        }

        private void FormPhoto_Load(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add(rtsp,null);
            axVLCPlugin21.playlist.play();
        }

        private void button_TirarFoto_Click(object sender, EventArgs e)
        {
            requestFrame();

        }

        private void requestFrame()
        {
            try
            {
                string cameraUrl = paramFoto;
                var request = System.Net.HttpWebRequest.Create(cameraUrl);
                request.Credentials = new NetworkCredential(userCamera, passCamera);
                request.Proxy = null;
                request.BeginGetResponse(new AsyncCallback(finishRequestFrame), request);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar acessar a câmera");
            }
        }

        private Bitmap loadedBitmap;

        void finishRequestFrame(IAsyncResult result)
        {
            try
            {
                HttpWebResponse response = (result.AsyncState as HttpWebRequest).EndGetResponse(result) as HttpWebResponse;
                Stream responseStream = response.GetResponseStream();

                using (Bitmap frame = new Bitmap(responseStream))
                {
                    if (frame != null)
                    {
                        loadedBitmap = (Bitmap)frame.Clone();
                        loadedBitmap.Save(string.Format("{0}\\{1}-1.jpg", localFoto, idUser.ToString()));
                    }
                }

                MessageBox.Show("Foto Capturada");
                this.Invoke((MethodInvoker)delegate () {
                    this.Close();
                });
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
