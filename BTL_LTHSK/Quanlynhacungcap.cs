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
using System.Web;
using System.Windows.Forms;

namespace BTL_LTHSK
{
    public partial class Quanlynhacungcap : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        string connectionString = ConfigurationManager.ConnectionStrings["QuanLyCuaHangTienLoi_connectionString"].ConnectionString;
        private DataView dvNCC = new DataView();
        public Quanlynhacungcap()
        {
            InitializeComponent();
        }
        private void Quanlynhacungcap_Load(object sender, EventArgs e)
        {
            loadMancc();
            loaddsNCC();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadMancc(string filter=" ")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "Select MaDT from tblDoiTuong where MaDT like '%NCC%'";
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        cmbMancc.Items.Clear();
                        while (reader.Read())
                        {
                            cmbMancc.Items.Add(reader["MaDT"].ToString());
                        }
                    }
                }
            }
        }
        private void loaddsNCC(string filter = " ")
        {
            string query = "select_DSNCC";
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
                                dvNCC = dataTable.DefaultView;
                                dgvNCC.AutoGenerateColumns = true;
                                if (!string.IsNullOrEmpty(filter))
                                {
                                    dvNCC.RowFilter = filter;
                                }
                                dgvNCC.DataSource = dataTable;
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
        private void ResetData()
        {
            TB_MaNCC.Text =
            TB_TenNCC.Text =
            TB_DCNCC.Text =
            TB_SDTNCC.Text =
            cmbMancc.Text = string.Empty;
            TB_MaNCC.Focus();
        }
        private void cmbMancc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maNCC = TB_MaNCC.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "select_NCC";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@maNCC", maNCC);
                        connection.Open();
                        var maNCC_SQL = cmd.ExecuteScalar();
                        connection.Close();
                        if (maNCC_SQL == null)
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter())
                            {
                                adapter.SelectCommand = new SqlCommand("SELECT * FROM tblDoiTuong", connection);
                                DataTable dtKhachHang = new DataTable("tblDoiTuong");
                                adapter.Fill(dtKhachHang);

                                DataSet ds = new DataSet();
                                ds.Tables.Add(dtKhachHang);
                                DataRow newRow = dtKhachHang.NewRow();
                                newRow["MaDT"] = this.TB_MaNCC.Text;
                                newRow["TenDT"] = this.TB_TenNCC.Text;
                                newRow["DiaChi"] = this.TB_DCNCC.Text;
                                newRow["SDT"] = this.TB_SDTNCC.Text;
                                dtKhachHang.Rows.Add(newRow);

                                cmd.CommandText = "insert_NCC";
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@maNCC", this.TB_MaNCC.Text);
                                cmd.Parameters.AddWithValue("@tenNCC", this.TB_TenNCC.Text);
                                cmd.Parameters.AddWithValue("@dcNCC", this.TB_DCNCC.Text);
                                cmd.Parameters.AddWithValue("@sdtNCC", this.TB_SDTNCC.Text);

                                adapter.InsertCommand = cmd;
                                adapter.Update(ds, "tblDoiTuong");
                                MessageBox.Show("Thêm mới thành công");

                                loaddsNCC();
                            }
                        }
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string queryUpdate = "update_NCC";
            try
            {
                using (SqlConnection sqlConnetion = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        //Lấy danh sách sinh viên vào dataTable
                        adapter.SelectCommand = new SqlCommand("SELECT * FROM tblDoiTuong", sqlConnetion);
                        DataTable dtNCC = new DataTable("tblDoiTuong");
                        adapter.Fill(dtNCC);

                        //add từng dataTable và dataSet
                        DataSet ds = new DataSet();
                        ds.Tables.Add(dtNCC);

                        //chỉnh sửa dữ liệu trong datatable của dataset
                        dtNCC.PrimaryKey = new DataColumn[] { dtNCC.Columns["MaDT"] };
                        DataRow dataRow = dtNCC.Rows.Find(TB_MaNCC.Text);
                        dataRow["MaDT"] = this.TB_MaNCC.Text;
                        dataRow["TenDT"] = this.TB_TenNCC.Text;
                        dataRow["DiaChi"] = this.TB_DCNCC.Text;
                        dataRow["SDT"] = this.TB_SDTNCC.Text;

                        //thực hiện UpdateCommand
                        using (SqlCommand sqlCommand = sqlConnetion.CreateCommand())
                        {
                            sqlCommand.CommandText = queryUpdate;
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.Parameters.AddWithValue("@maNCC", this.TB_MaNCC.Text);
                            sqlCommand.Parameters.AddWithValue("@tenNCC", this.TB_TenNCC.Text);
                            sqlCommand.Parameters.AddWithValue("@dcNCC", this.TB_DCNCC.Text);
                            sqlCommand.Parameters.AddWithValue("@sdtNCC ", this.TB_SDTNCC.Text);
                            adapter.UpdateCommand = sqlCommand;
                            adapter.Update(ds, "tblDoiTuong");
                            MessageBox.Show("Chỉnh sửa thành công");

                            loaddsNCC();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra" + ex);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int index = dgvNCC.CurrentRow.Index;
            string maNCC = dvNCC[index]["MaDT"].ToString();
            try
            {
                //Xóa
                DialogResult h = MessageBox.Show("Có muốn xóa mã nhà cung cấp " + maNCC + " thật không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (h == DialogResult.Yes)
                {
                    string queryDelete = "delete_NCC";
                    using (SqlConnection sqlConnetion = new SqlConnection(connectionString))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Lấy danh sách sinh viên vào dataTable
                            adapter.SelectCommand = new SqlCommand("SELECT * FROM tblDoiTuong", sqlConnetion);
                            DataTable dtNCC = new DataTable("tblDoiTuong");
                            adapter.Fill(dtNCC);

                            //add từng dataTable và dataSet
                            DataSet ds = new DataSet();
                            ds.Tables.Add(dtNCC);

                            //tìm ma sv cần xóa
                            dtNCC.PrimaryKey = new DataColumn[] { dtNCC.Columns["MaDT"] };
                            DataRow dataRow = dtNCC.Rows.Find(maNCC);
                            dataRow.Delete();

                            //xóa mã đã chọn trong CSDL thực hiện DeleteCommand
                            using (SqlCommand sqlCommand = sqlConnetion.CreateCommand())
                            {
                                sqlCommand.CommandText = queryDelete;
                                sqlCommand.CommandType = CommandType.StoredProcedure;
                                sqlCommand.Parameters.AddWithValue("@maNCC", maNCC);

                                adapter.DeleteCommand = sqlCommand;
                                int i = adapter.Update(ds, "tblDoiTuong");

                            }
                        }
                    }
                    ResetData();
                    loaddsNCC();
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

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNCC.Rows.Count)
            {
                int index = e.RowIndex;
                TB_MaNCC.Text = dgvNCC.Rows[index].Cells["MaNCC"].Value.ToString();
                TB_TenNCC.Text = dgvNCC.Rows[index].Cells["tenncc"].Value.ToString();
                TB_DCNCC.Text = dgvNCC.Rows[index].Cells["diachi"].Value.ToString();
                TB_SDTNCC.Text = dgvNCC.Rows[index].Cells["sdtncc"].Value.ToString();
            }
        }

        private void TB_MaNCC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_MaNCC.Text))
            {
                errorProvider.SetError(TB_MaNCC, "Mã nhà cung cấp không được để trống");
            }
            else
            {
                errorProvider.SetError(TB_MaNCC, null);
            }
        }

        private void TB_TenNCC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_TenNCC.Text))
            {
                errorProvider.SetError(TB_TenNCC, "Tên nhà cung cấp không được để trống");
            }
            else
            {
                errorProvider.SetError(TB_TenNCC, null);
            }
        }

        private void TB_DCNCC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_DCNCC.Text))
            {
                errorProvider.SetError(TB_DCNCC, "Địa chỉ nhà cung cấp không được để trống");
            }
            else
            {
                errorProvider.SetError(TB_DCNCC, null);
            }
        }

        private void TB_SDTNCC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_SDTNCC.Text))
            {
                errorProvider.SetError(TB_SDTNCC, "Số điện thoại nhà cung cấp không được để trống");
            }
            else
            {
                errorProvider.SetError(TB_SDTNCC, null);
            }
        }
    }
}
