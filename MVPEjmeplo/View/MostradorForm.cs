using MVPEjmeplo.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPEjmeplo
{
    public partial class MostradorForm : Form, IVista
    {
        public event EventHandler ButtonClick;
        public MostradorForm()
        {
            InitializeComponent();
            btnSaludo.Click += (Sender, e) => ButtonClick?.Invoke(Sender, e);
       }

        public void SetMessage(string message)
        {
            lblSaludo.Text = message;
        }
    }
}
