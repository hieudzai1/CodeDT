using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTHSK
{
    public partial class FormBCdon : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QuanLyCuaHangTienLoi_connectionString"].ConnectionString;
        public FormBCdon()
        {
            InitializeComponent();
        }

        private void FormBCdon_Load(object sender, EventArgs e)
        {
            Showreport("Baocaodon", "select_DT");
        }
        private void Showreport(string tenBaoCao, string tenProc)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = tenProc;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                adapter.Fill(dt);

                                //Load du lieu len bao cao
                                ReportDocument report = new ReportDocument();
                                string path = string.Format("C\\Users\\hv824\\source\\repos\\BTL_LTHSK\\BTL_LTHSK\\Baocaodon.rpt", Application.StartupPath, tenBaoCao);
                                report.Load(path);

                                report.Database.Tables[tenProc].SetDataSource(dt);
                                report.SetParameterValue("@Nguoilapbieu", "vuminhhieu");
                                crystalReportViewer1.ReportSource = report;
                                crystalReportViewer1.Refresh();
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }
    }
}
