using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuVien.DTO;
using QLThuVien.BUS;

namespace QLThuVien.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool CheckPassword(string passwd)
        {

            if (passwd.Length < 6)
            {
                lbMsg.Text = "Mật khẩu tối thiếu là 6 kí tự. ";
                return false;
            }
            if (passwd.Contains(" "))
            {
                lbMsg.Text = "Mật khẩu không chứa khoảng trắng.";
                return false;
            }

            return true;
        }

        public static string userstr;
        TaiKhoan_BUS tkBus = new TaiKhoan_BUS();

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangKy newdangky = new FrmDangKy();
            newdangky.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            bool check1, check2, check3;
            check1 = check2 = check3 = true;
            if (user.Trim() == string.Empty)
            {

                errorProvider1.SetError(lbMsg, "Không được để trống!!");
                lbMsg.Text = "Bạn phải nhập Tên đăng nhập!!";
                check1 = false;
            }
            else
            {
                lbMsg.Text = "";
                check1 = true;
            }

            if (pass.Trim() == string.Empty)
            {
                errorProvider1.SetError(lbMsg, "Không được để trống!!");
                lbMsg.Text = "Bạn phải nhập mật khẩu!!";
                check2 = false;
            }
            else if (!CheckPassword(pass))
            {
                errorProvider1.SetError(lbMsg, "Không được để trống!!");
                check2 = false;
            }
            else
            {
                lbMsg.Text = "";
                check2 = true;
            }

            if (btnToggle.Checked)
            {
                check3 = true;
            }

            if (check1 && check2 && check3)
            {
                if (tkBus.DangNhap(user, pass))
                {
                    GUI_Khach.Form1.isLogin = true;

                    string loaitk = tkBus.LoadLoaiTK(user);


                    switch (loaitk)
                    {
                        case "docgia":
                            {
                                MessageBox.Show("Đăng nhập thành công !!");
                                this.Hide();
                                userstr = user;
                                if (GUI_Khach.TimKiem4Hello.DaTim)
                                {
                                    GUI_Khach.TimKiem4Hello.openAfterLog();
                                }
                                else
                                {
                                    GUI_DocGia.frmDocGia newdg = new GUI_DocGia.frmDocGia(user);
                                    newdg.LogOut += F_LogOut;
                                    newdg.ShowDialog();
                                }

                                break;
                            }
                        case "nhanvien":
                            {
                                MessageBox.Show("Đăng nhập thành công !!");
                                this.Hide();
                                GUI_NhanVien.FrmNhanVien newnv = new GUI_NhanVien.FrmNhanVien(user);
                                newnv.LogOut += F_LogOut;
                                newnv.ShowDialog();
                                break;
                            }
                        case "quanly":
                            {
                                MessageBox.Show("Đăng nhập thành công !!");
                                this.Hide();
                                GUI_Admin.FormAdmin newadmin = new GUI_Admin.FormAdmin();
                                newadmin.LogOut += F_LogOut;
                                newadmin.ShowDialog();
                                break;
                            }
                        case "vohieuhoa":
                            {
                                MessageBox.Show("Tài khoản của bạn đã bị vô hiệu hóa");
                                break;
                            }
                    }

                }
                else
                {
                    MessageBox.Show("Không tồn tại độc giả nào có mã " + user, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void F_LogOut(object sender, EventArgs e)
        {
            this.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            GUI_Khach.Form1 newform = new GUI_Khach.Form1();
            this.Hide();
            newform.Show();
        }
    }
}
