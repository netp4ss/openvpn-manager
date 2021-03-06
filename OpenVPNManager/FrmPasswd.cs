﻿using System.Windows.Forms;

namespace OpenVPNManager
{
    /// <summary>
    /// provides a formular which asks for a password
    /// </summary>
    public partial class FrmPasswd : Form
    {
        #region constructor
        /// <summary>
        /// generates the form
        /// </summary>
        public FrmPasswd()
        {
            InitializeComponent();
        }
        #endregion

        /// <summary>
        /// Asks for a password.
        /// </summary>
        /// <param name="pwTitle">name of the password, e.g. 'private key'</param>
        /// <param name="config">name of the config</param>
        /// <returns>the password or null if aborted</returns>
        public string AskPass(string pwTitle, string config)
        {
            // set labels
            lblAsk.Text = pwTitle;
            lblName.Text = config;

            // show form, return
            if (this.ShowDialog() != DialogResult.OK)
                return null;
            else
                return txtPasswd.Text;
        }
    }
}
