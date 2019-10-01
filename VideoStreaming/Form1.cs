using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Stream.Api.Authentication;
using Stream.Api.Authentication.Impl.Youtube;
using Stream.Api.Models;

namespace VideoStreaming
{
    public partial class Form1 : Form
    {

        private RecordStreamModel _recordStreamModel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //IStreamingServiceAuthentication authen = new YoutubeServiceAuthentication();
            //if (authen.Authenticate("client_id.json"))
            //{
            //    MessageBox.Show("OK");
            //} else
            //{
            //    MessageBox.Show("Failed");
            //}

            _recordStreamModel = new RecordStreamModel();
            _recordStreamModel.StartRecording();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _recordStreamModel.PauseRecording();
        }
    }
}
