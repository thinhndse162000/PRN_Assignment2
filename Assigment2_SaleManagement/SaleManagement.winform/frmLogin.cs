using SaleManagement.repo.Models;
using SaleManagement.repo.Repository;

namespace SaleManagement.winform
{
    public partial class frmLogin : Form
    {
        private IMemberRepository _memberRepository;
        public frmLogin()
        {
            InitializeComponent();
            _memberRepository = new MemberRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //1 validate null
            if (txtEmail.Text == String.Empty || txtEmail.Text == "")
            {
                MessageBox.Show("Please input Email!");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please input password");
            }
            else {
                var email = _memberRepository.GetAdminEmail();
                var pass = _memberRepository.GetAdminPassword();
                if (txtEmail.Text != email)
                {
                    MessageBox.Show("Email Incorrect!");
                }
                else if (txtPassword.Text != pass)
                {

                    MessageBox.Show("Incorrect Password");
                }
                else {
                    frmMain frmMain = new ();
                    this.Hide();
                    frmMain.Show();

                }
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}