using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownManager.Messages
{
    public partial class MessagesForm : Form
    {
        public MessagesForm()
        {
            InitializeComponent();
            Show();
        }

        public void SetMessageText(string text) {

            ErrorMessageLabel.Text = text;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MessagesForm_Load_1(object sender, EventArgs e)
        {
            
            ErrorMessageLabel.BorderStyle = BorderStyle.FixedSingle;
            ErrorMessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            
        }
    }
}
