using System;
using System.Net;
using System.Windows.Forms;

namespace ChromaCheatsEmulator
{
    public partial class frmSettings : Form
    {
        private WebClient wc;


        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.key = txtKey.Text;
            Properties.Settings.Default.iv = txtIv.Text;
            Properties.Settings.Default.url = txtUrl.Text;

            Properties.Settings.Default.url_key = txtKeyUrl.Text;
            Properties.Settings.Default.url_iv = txtIvUrl.Text;
            Properties.Settings.Default.url_url = txtUrlUrl.Text;
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            this.wc = new WebClient()
            {
                Proxy = null
            };

            if (Properties.Settings.Default.key != null)
                txtKey.Text = Properties.Settings.Default.key;

            if (Properties.Settings.Default.iv != null)
                txtIv.Text = Properties.Settings.Default.iv;

            if (Properties.Settings.Default.url != null)
                txtUrl.Text = Properties.Settings.Default.url;


            if (Properties.Settings.Default.url_key != null)
                txtKeyUrl.Text = Properties.Settings.Default.url_key;

            if (Properties.Settings.Default.url_iv != null)
                txtIvUrl.Text = Properties.Settings.Default.url_iv;

            if (Properties.Settings.Default.url_url != null)
                txtUrlUrl.Text = Properties.Settings.Default.url_url;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtKey.Text = wc.DownloadString("http://api.cc.aqbt.pw/aes/key").Trim();
            txtIv.Text = wc.DownloadString("http://api.cc.aqbt.pw/aes/iv").Trim();
            txtUrl.Text = wc.DownloadString("http://api.cc.aqbt.pw/api/url").Trim();
        }
    }
}
