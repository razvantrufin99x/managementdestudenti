using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managementdestudenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public proiectStudenti.diagrama.listadestudenti olistacustudenti = new proiectStudenti.diagrama.listadestudenti();

        private void Form1_Load(object sender, EventArgs e)
        {
            olistacustudenti.listastudentilor.Add(new proiectStudenti.diagrama.student());
            olistacustudenti.listastudentilor[0].prenume = "alex";
            olistacustudenti.listastudentilor[0].nume = "nustiu";
            olistacustudenti.listastudentilor[0].varsta = 44.0f;

            string t = olistacustudenti.listastudentilor[0].nume + ",  " + olistacustudenti.listastudentilor[0].prenume + " , " + olistacustudenti.listastudentilor[0].varsta.ToString();
            Text = t;

        }
    }
}
