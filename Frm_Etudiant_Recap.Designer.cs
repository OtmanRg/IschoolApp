namespace prj_iSchool
{
    partial class Frm_Etudiant_Recap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vw_recaps_etudiantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dst_recapabsenceEtudiant = new prj_iSchool.dst_recapabsenceEtudiant();
            this.Vw_MoyenneModuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSchool_dbDataSet1 = new prj_iSchool.iSchool_dbDataSet1();
            this.lbl_nomprenom = new System.Windows.Forms.Label();
            this.lbl_annee = new System.Windows.Forms.Label();
            this.vw_recaps_etudiantsTableAdapter = new prj_iSchool.dst_recapabsenceEtudiantTableAdapters.vw_recaps_etudiantsTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Vw_MoyenneModuleTableAdapter = new prj_iSchool.iSchool_dbDataSet1TableAdapters.Vw_MoyenneModuleTableAdapter();
            this.iSchool_dbDataSet5 = new prj_iSchool.iSchool_dbDataSet5();
            this.vw_recapPaiementParEtudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_recapPaiementParEtudiantTableAdapter = new prj_iSchool.iSchool_dbDataSet5TableAdapters.vw_recapPaiementParEtudiantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vw_recaps_etudiantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dst_recapabsenceEtudiant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_MoyenneModuleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSchool_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSchool_dbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_recapPaiementParEtudiantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vw_recaps_etudiantsBindingSource
            // 
            this.vw_recaps_etudiantsBindingSource.DataMember = "vw_recaps_etudiants";
            this.vw_recaps_etudiantsBindingSource.DataSource = this.dst_recapabsenceEtudiant;
            // 
            // dst_recapabsenceEtudiant
            // 
            this.dst_recapabsenceEtudiant.DataSetName = "dst_recapabsenceEtudiant";
            this.dst_recapabsenceEtudiant.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Vw_MoyenneModuleBindingSource
            // 
            this.Vw_MoyenneModuleBindingSource.DataMember = "Vw_MoyenneModule";
            this.Vw_MoyenneModuleBindingSource.DataSource = this.iSchool_dbDataSet1;
            // 
            // iSchool_dbDataSet1
            // 
            this.iSchool_dbDataSet1.DataSetName = "iSchool_dbDataSet1";
            this.iSchool_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_nomprenom
            // 
            this.lbl_nomprenom.AutoSize = true;
            this.lbl_nomprenom.Location = new System.Drawing.Point(206, 9);
            this.lbl_nomprenom.Name = "lbl_nomprenom";
            this.lbl_nomprenom.Size = new System.Drawing.Size(33, 13);
            this.lbl_nomprenom.TabIndex = 3;
            this.lbl_nomprenom.Text = "nomp";
            // 
            // lbl_annee
            // 
            this.lbl_annee.AutoSize = true;
            this.lbl_annee.Location = new System.Drawing.Point(245, 9);
            this.lbl_annee.Name = "lbl_annee";
            this.lbl_annee.Size = new System.Drawing.Size(35, 13);
            this.lbl_annee.TabIndex = 4;
            this.lbl_annee.Text = "label3";
            // 
            // vw_recaps_etudiantsTableAdapter
            // 
            this.vw_recaps_etudiantsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dstrecapabsenceetudiant";
            reportDataSource1.Value = this.vw_recaps_etudiantsBindingSource;
            reportDataSource2.Name = "dstrecapMoyennes";
            reportDataSource2.Value = this.Vw_MoyenneModuleBindingSource;
            reportDataSource3.Name = "dst_paiements";
            reportDataSource3.Value = this.vw_recapPaiementParEtudiantBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "prj_iSchool.Rapports.rpt_CourbeAbsences.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(953, 592);
            this.reportViewer1.TabIndex = 5;
            // 
            // Vw_MoyenneModuleTableAdapter
            // 
            this.Vw_MoyenneModuleTableAdapter.ClearBeforeFill = true;
            // 
            // iSchool_dbDataSet5
            // 
            this.iSchool_dbDataSet5.DataSetName = "iSchool_dbDataSet5";
            this.iSchool_dbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_recapPaiementParEtudiantBindingSource
            // 
            this.vw_recapPaiementParEtudiantBindingSource.DataMember = "vw_recapPaiementParEtudiant";
            this.vw_recapPaiementParEtudiantBindingSource.DataSource = this.iSchool_dbDataSet5;
            // 
            // vw_recapPaiementParEtudiantTableAdapter
            // 
            this.vw_recapPaiementParEtudiantTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Etudiant_Recap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 592);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lbl_annee);
            this.Controls.Add(this.lbl_nomprenom);
            this.Name = "Frm_Etudiant_Recap";
            this.Text = "Frm_Etudiant_Recap";
            this.Load += new System.EventHandler(this.Frm_Etudiant_Recap_Load);
            this.Controls.SetChildIndex(this.lbl_nomprenom, 0);
            this.Controls.SetChildIndex(this.lbl_annee, 0);
            this.Controls.SetChildIndex(this.reportViewer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.vw_recaps_etudiantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dst_recapabsenceEtudiant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_MoyenneModuleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSchool_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSchool_dbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_recapPaiementParEtudiantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nomprenom;
        private System.Windows.Forms.Label lbl_annee;
        private System.Windows.Forms.BindingSource vw_recaps_etudiantsBindingSource;
        private dst_recapabsenceEtudiant dst_recapabsenceEtudiant;
        private dst_recapabsenceEtudiantTableAdapters.vw_recaps_etudiantsTableAdapter vw_recaps_etudiantsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Vw_MoyenneModuleBindingSource;
        private iSchool_dbDataSet1 iSchool_dbDataSet1;
        private iSchool_dbDataSet1TableAdapters.Vw_MoyenneModuleTableAdapter Vw_MoyenneModuleTableAdapter;
        private System.Windows.Forms.BindingSource vw_recapPaiementParEtudiantBindingSource;
        private iSchool_dbDataSet5 iSchool_dbDataSet5;
        private iSchool_dbDataSet5TableAdapters.vw_recapPaiementParEtudiantTableAdapter vw_recapPaiementParEtudiantTableAdapter;
    }
}