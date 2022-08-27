using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_iSchool
{
    public partial class Frm_Etudiant_Recap : Form1
    {
        public Frm_Etudiant_Recap()
        {
            InitializeComponent();
        }

        private void Frm_Etudiant_Recap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSchool_dbDataSet3.vw_recaps_etudiants' table. You can move, or remove it, as needed.
            try
            {
                lbl_annee.Text = Properties.Settings.Default.AnneeSc.ToString();
                //lbl_nomprenom.Text = frm_etudiants.nomprenom;
                /// this.vw_recaps_etudiantsTableAdapter.Fill(this.iSchool_dbDataSet3.vw_recaps_etudiants);
                this.vw_recaps_etudiantsTableAdapter.Fill(this.dst_recapabsenceEtudiant.vw_recaps_etudiants, lbl_nomprenom.Text);
                this.Vw_MoyenneModuleTableAdapter.Fill(this.iSchool_dbDataSet1.Vw_MoyenneModule, lbl_nomprenom.Text);
                this.vw_recapPaiementParEtudiantTableAdapter.Fill(this.iSchool_dbDataSet5.vw_recapPaiementParEtudiant, lbl_nomprenom.Text);
                /// this.reportViewer1.RefreshReport();
                // ReportParameterCollection reportParametre = new ReportParameterCollection();
                // reportParametre.Add(new ReportParameter("Nomprenom",  frm_etudiants.nomprenom));
                // reportParametre.Add(new ReportParameter("annee", Properties.Settings.Default.AnneeSc.ToString() ));
                //reportParametre.Add(new ReportParameter("DateFin", dtp_dateF.Text));
                // this.reportViewer1.LocalReport.SetParameters(reportParametre);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Courbe d'absence: " + ex.Message);
                //throw;
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
