using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SaleManagement.repo.Models;
using SaleManagement.repo.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.winform
{
    public partial class frmProfile : Form
    {
        private int id;
        IMemberRepository _memberRepository;
        public frmProfile()
        {
            InitializeComponent();
        }

        public frmProfile(int id)
        {
            InitializeComponent();
            this.id = id;
            _memberRepository = new MemberRepository();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            Member member = _memberRepository.GetMemberById(id);
            txtMemberId.Enabled = false;
            txtPassword.Enabled = false;
            txtCity.Enabled = false;
            txtCompany.Enabled = false;
            txtEmail.Enabled = false;
            txtCountry.Enabled = false;

            txtEmail.Text = member.Email;
            txtPassword.Text = member.Password;
            txtMemberId.Text = member.MemberId.ToString();
            txtCompany.Text = member.CompanyName;
            txtCountry.Text = member.Country;
            txtCity.Text = member.City;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Member member = _memberRepository.GetMemberById(id);
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {

                InsertOrUpdate = true,
                member = member,
                memberRepository = _memberRepository

            };
            this.Hide();
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                load();
                this.Show();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmOrdersObjectMember frm = new frmOrdersObjectMember
            {
                memberId = id,
            };
            frm.Show();
        }
    }
}
