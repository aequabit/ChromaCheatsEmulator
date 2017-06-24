using System;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace ChromaCheatsEmulator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private int unix()
        {
            return (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            try
            {
                string response;

                /**
                 * Send the payload to the server.
                 */
                response = new ChromaFramework.Networking.HttpRequestHandler().Post(
                    Properties.Settings.Default.url,
                    txtPayload.Text
                );


                /**
                 * If the response can't be decrypted, it's probably a product.
                 */
                try
                {
                    ChromaFramework.Encryption.Rijndael.Decrypt(
                        response,
                        Properties.Settings.Default.key,
                        Properties.Settings.Default.iv
                    );
                }
                catch (Exception ex)
                {
                    /**
                     * Gét the binary.
                     */
                    byte[] file = new ChromaFramework.Networking.HttpRequestHandler().PostBytes(
                        Properties.Settings.Default.url,
                        txtPayload.Text
                    );

                    /**
                     * Open a File Dialog to specify the download location of the product.
                     */
                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Filter = "ChromaCheats Product|*.exe";
                    var result = dlg.ShowDialog();

                    /**
                     * If the Dialog finished successfully, save the product.
                     */
                    if (result == DialogResult.OK)
                    {
                        File.WriteAllBytes(dlg.FileName, file);
                        txtResponse.Text = "Request: Decryption failed. Handled response as download.";
                    }
                    else
                    {
                        txtResponse.Text = "Request: Aborted download.";
                    }

                    return;
                }

                /**
                 * Decrypt the response if needed.
                 */
                if (chkDecrypt.Checked)
                {
                    txtResponse.Text = ChromaFramework.Encryption.Rijndael.Decrypt(
                        response,
                        Properties.Settings.Default.key,
                        Properties.Settings.Default.iv
                    );
                }
                else
                    txtResponse.Text = response;
            }
            catch (Exception ex)
            {
                txtResponse.Text = ex.Message + Environment.NewLine + ex.StackTrace;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkAutosend.Checked)
                {
                    txtOut.Text = ChromaFramework.Encryption.Rijndael.Encrypt(
                        txtIn.Text.Replace("%TIME%", unix().ToString()),
                        Properties.Settings.Default.key,
                        Properties.Settings.Default.iv
                    );
                    txtPayload.Text = txtOut.Text;
                    btnRequest.PerformClick();
                }
                else
                {
                    txtOut.Text = ChromaFramework.Encryption.Rijndael.Encrypt(
                        txtIn.Text,
                        Properties.Settings.Default.key,
                        Properties.Settings.Default.iv
                    );
                }
            }
            catch (Exception ex)
            {
                txtOut.Text = ex.Message + Environment.NewLine + ex.StackTrace;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txtOut.Text = ChromaFramework.Encryption.Rijndael.Decrypt(
                    txtIn.Text,
                    Properties.Settings.Default.key,
                    Properties.Settings.Default.iv
                );
            }
            catch (Exception ex)
            {
                txtOut.Text = ex.Message + Environment.NewLine + ex.StackTrace;
            }
        }

        private void chkDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                /**
                 * 
                 */
                if (txtResponse.Text.IndexOf("Request:") == -1)
                {
                    /**
                     * En- or decrypt the response.
                     */
                    if (chkDecrypt.Checked)
                    {
                        txtResponse.Text = ChromaFramework.Encryption.Rijndael.Decrypt(
                            txtResponse.Text,
                            Properties.Settings.Default.key,
                            Properties.Settings.Default.iv
                        );
                    }
                    else
                    {
                        txtResponse.Text = ChromaFramework.Encryption.Rijndael.Encrypt(
                            txtResponse.Text,
                            Properties.Settings.Default.key,
                            Properties.Settings.Default.iv
                        );
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            /**
             * If the emulator was launched the first time.
             */
            if (Properties.Settings.Default.first)
            {
                MessageBox.Show("Since this is the first time you launch the emulator, you may want to update the keys and the URL." +
                    Environment.NewLine + "Go to File -> Settings -> Config and click the update button.", "Update config", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Properties.Settings.Default.first = false;
                Properties.Settings.Default.Save();
            }

            chkAutosend.Checked = Properties.Settings.Default.autosend;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSettings().ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void chkAutosend_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autosend = chkAutosend.Checked;
        }
    }
}
