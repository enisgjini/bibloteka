using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bibloteka
{
    public partial class Ballina : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Ballina()
        {
            InitializeComponent();
        }

        private void lexuesit_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Lexuesit.Instance))
            {
                panel1.Controls.Add(Lexuesit.Instance);
                Lexuesit.Instance.Dock = DockStyle.Fill;
                Lexuesit.Instance.BringToFront();
            }
            Lexuesit.Instance.BringToFront();
        }

        private void librat_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Librat.Instance))
            {
                panel1.Controls.Add(Librat.Instance);
                Librat.Instance.Dock = DockStyle.Fill;
                Librat.Instance.BringToFront();
            }
            Librat.Instance.BringToFront();
        }

        private void dheniaelibrit_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(DheniaELibrit.Instance))
            {
                panel1.Controls.Add(DheniaELibrit.Instance);
                DheniaELibrit.Instance.Dock = DockStyle.Fill;
                DheniaELibrit.Instance.BringToFront();
            }
            DheniaELibrit.Instance.BringToFront();
        }

       
    }
}
