using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_LTHSK
{
    public partial class QLKH : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        string connectionString = ConfigurationManager.ConnectionStrings["QuanLyCuaHangTienLoi_connectionString"].ConnectionString;
        private DataView dvKhachHang = new DataView();
        public QLKH()
        {
            InitializeComponent();
        }
        private void LoadQLKH(object sender, EventArgs e)
        {
            LoaddlKH();
            loaddsKH();
        }
        private void LoaddlKH(string filter= "")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "Select MaDT from tblDoiTuong where MaDT like '%KH%'";
                using (SqlCommand command = new SqlCommand(query1,connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        cmbMa.Items.Clear();
                        while(reader.Read())
                        {
                            cmbMa.Items.Add(reader["MaDT"].ToString());
                        }
                    }
                }
            }
        }
        private void loaddsKH(string filter = " ")
        {
            string query = "select_DSKH";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        using (DataTable dataTable = new DataTable())
                        {
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0)
                            {
                                dvKhachHang = dataTable.DefaultView;
                                dgvKH.AutoGenerateColumns = true;
                                if (!string.IsNullOrEmpty(filter))
                               {
                                    dvKhachHang.RowFilter = filter;
                               }
                                dgvKH.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("Không có bản ghi nào");
                            }
                        }
                    }
                }
            }
        }

        private void TB_makhachhang_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_makhachhang.Text))
            {
                errorProvider.SetError(TB_makhachhang, "Mã khách hàng không được để trống");
            }
            else
            {
                errorProvider.SetError(TB_makhachhang, null);
            }
        }

        private void TB_diachi_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_makhachhang.Text))
            {
                errorProvider.SetError(TB_makhachhang, "Địa chỉ không được để trống");
            }
            else
            {
                errorProvider.SetError(TB_makhachhang, null);
            }
        }

        private void cmbMa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaDT = cmbMa.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MaDT FROM tblDoiTuong WHERE MaDT = @MaDT";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaDT", selectedMaDT);

                   
                    string tenDT = (string)command.ExecuteScalar();

                    
                    TB_makhachhang.Text = tenDT;
                }
            }
        }

        private void TB_ten_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_makhachhang.Text))
            {
                errorProvider.SetError(TB_makhachhang, "Số điện thoại không được để trống");
            }
            else
            {
                errorProvider.SetError(TB_makhachhang, null);
            }
        }

        private void TB_sdtKH_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_makhachhang.Text))
            {
                errorProvider.SetError(TB_makhachhang, "Tên khách hàng không được để trống");
            }
            else
            {
                errorProvider.SetError(TB_makhachhang, null);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ResetData()
        {
            TB_makhachhang.Text =
            TB_ten.Text =
            TB_sdtKH.Text =
            TB_diachi.Text =
            cmbMa.Text = string.Empty;
            TB_makhachhang.Focus();
        }
        private void btn_themKH_Click(object sender, EventArgs e)
        {
            string maKH = TB_makhachhang.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if(ValidateChildren(ValidationConstraints.Enabled))
                {
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "select_KH";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@maKH", maKH);
                        connection.Open();
                        var maKH_SQL = cmd.ExecuteScalar();
                        connection.Close();
                        if(maKH_SQL == null)
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter())
                            {
                                adapter.SelectCommand = new SqlCommand("SELECT * FROM tblDoiTuong", connection);
                                DataTable dtKhachHang = new DataTable("tblDoiTuong");
                                adapter.Fill(dtKhachHang);

                                DataSet ds = new DataSet();
                                ds.Tables.Add(dtKhachHang);
                                DataRow newRow = dtKhachHang.NewRow();
                                newRow["MaDT"] = this.TB_makhachhang.Text;
                                newRow["TenDT"] = this.TB_ten.Text;
                                newRow["DiaChi"] = this.TB_diachi.Text;
                                newRow["SDT"] = this.TB_sdtKH.Text;
                                dtKhachHang.Rows.Add(newRow);

                                cmd.CommandText = "insert_KH";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@maKH", this.TB_makhachhang.Text);
                                cmd.Parameters.AddWithValue("@tenKH", this.TB_ten.Text);
                                cmd.Parameters.AddWithValue("@DiaChi", this.TB_diachi.Text);
                                cmd.Parameters.AddWithValue("@SDT", this.TB_sdtKH.Text);

                                adapter.InsertCommand = cmd;
                                adapter.Update(ds,"tblDoiTuong");
                                MessageBox.Show("Thêm mới thành công");

                                loaddsKH();
                            }
                        }    
                    }
                }
            }
        }
        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKH.Rows.Count)
            {
                int index = e.RowIndex;
                TB_makhachhang.Text = dgvKH.Rows[index].Cells["MaKH"].Value.ToString();
                TB_ten.Text = dgvKH.Rows[index].Cells["TenKH"].Value.ToString();
                TB_diachi.Text = dgvKH.Rows[index].Cells["Diachi"].Value.ToString();
                TB_sdtKH.Text = dgvKH.Rows[index].Cells["sdt"].Value.ToString();
            }
        }

        private void btn_suaKH_Click(object sender, EventArgs e)
        {
            string queryUpdate = "update_KH";
            try
            {
                using (SqlConnection sqlConnetion = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        //Lấy danh sách sinh viên vào dataTable
                        adapter.SelectCommand = new SqlCommand("SELECT * FROM tblDoiTuong", sqlConnetion);
                        DataTable dtKH = new DataTable("tblDoiTuong");
                        adapter.Fill(dtKH);

                        //add từng dataTable và dataSet
                        DataSet ds = new DataSet();
                        ds.Tables.Add(dtKH);

                        //chỉnh sửa dữ liệu trong datatable của dataset
                        dtKH.PrimaryKey = new DataColumn[] { dtKH.Columns["MaDT"] };
                        DataRow dataRow = dtKH.Rows.Find(TB_makhachhang.Text);
                        dataRow["MaDT"] = this.TB_makhachhang.Text;
                        dataRow["TenDT"] = this.TB_ten.Text;
                        dataRow["DiaChi"] = this.TB_diachi.Text;
                        dataRow["SDT"] = this.TB_sdtKH.Text;

                        //thực hiện UpdateCommand
                        using (SqlCommand sqlCommand = sqlConnetion.CreateCommand())
                        {
                            sqlCommand.CommandText = queryUpdate;
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.Parameters.AddWithValue("@maKH", this.TB_makhachhang.Text);
                            sqlCommand.Parameters.AddWithValue("@tenKH", this.TB_ten.Text);
                            sqlCommand.Parameters.AddWithValue("@DiaChi", this.TB_diachi.Text);
                            sqlCommand.Parameters.AddWithValue("@SDT", this.TB_sdtKH.Text);
                            adapter.UpdateCommand = sqlCommand;
                            adapter.Update(ds,"tblDoiTuong");
                            MessageBox.Show("Chỉnh sửa thành công");

                            loaddsKH();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra" + ex);
            }
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            int index = dgvKH.CurrentRow.Index;
            string maKH = dvKhachHang[index]["MaDT"].ToString();
            try
            {
                //Xóa
                DialogResult h = MessageBox.Show("Có muốn xóa mã khách hàng " + maKH + " thật không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (h == DialogResult.Yes)
                {
                    string queryDelete = "delete_KH";
                    using (SqlConnection sqlConnetion = new SqlConnection(connectionString))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Lấy danh sách sinh viên vào dataTable
                            adapter.SelectCommand = new SqlCommand("SELECT * FROM tblDoiTuong", sqlConnetion);
                            DataTable dtKH = new DataTable("tblDoiTuong");
                            adapter.Fill(dtKH);

                            //add từng dataTable và dataSet
                            DataSet ds = new DataSet();
                            ds.Tables.Add(dtKH);

                            //tìm ma sv cần xóa
                            dtKH.PrimaryKey = new DataColumn[] { dtKH.Columns["MaDT"] };
                            DataRow dataRow = dtKH.Rows.Find(maKH);
                            dataRow.Delete();

                            //xóa mã đã chọn trong CSDL thực hiện DeleteCommand
                            using (SqlCommand sqlCommand = sqlConnetion.CreateCommand())
                            {
                                sqlCommand.CommandText = queryDelete;
                                sqlCommand.CommandType = CommandType.StoredProcedure;
                                sqlCommand.Parameters.AddWithValue("@maKH", maKH);

                                adapter.DeleteCommand = sqlCommand;
                                int i = adapter.Update(ds, "tblDoiTuong");

                            }
                        }
                    }
                    ResetData();
                    loaddsKH();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string filter = "MaDT IS NOT NULL";
            if (!string.IsNullOrEmpty(TB_makhachhang.Text.Trim()))
            {
                filter += string.Format(" AND MaDT LIKE '%KH%'", TB_makhachhang.Text);
            }
            loaddsKH(filter);
        }
    }
}
