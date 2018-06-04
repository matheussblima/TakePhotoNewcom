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

namespace TakePhotoNewcom
{
    public partial class FormPhoto : Form
    {
        public FormPhoto()
        {
            InitializeComponent();
        }

        private void FormPhoto_Load(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.add("rtsp://admin:Newcomlab2015@192.168.1.64:554/",null);
            axVLCPlugin21.playlist.play();
        }
    }
}
