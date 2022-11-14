using SaleManagement.repo.Repository;
using SaleManagement.repo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.winform
{
    public partial class frmMembers : Form
    {
        IMemberRepository _memberRepository;
        BindingSource _bindingSource;
        Member _member;
        public frmMembers()
        {
            InitializeComponent();
            _memberRepository = new MemberRepository();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadDataToDgv();
        }
        private void LoadDataToDgv() {
            dvgMembers.DataSource = null;
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _memberRepository.GetAllMember();
            dvgMembers.DataSource = _bindingSource;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                InsertOrUpdate = false,
                memberRepository = _memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK) {
                LoadDataToDgv();
                _bindingSource.Position = _bindingSource.Count - 1;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete this record ?", "Delete Operator", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_member != null)
                {
                    bool check = _memberRepository.Delete(_member.MemberId);
                    if (check)
                    {
                        LoadDataToDgv();
                        MessageBox.Show("Delete successfully");
                    }
                }
                else
                {
                    MessageBox.Show("You need to click on record you wanto delete");
                }
            }
        }

        private void dvgMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowData = dvgMembers.Rows[e.RowIndex];
            Member member = GetMember(e.RowIndex);
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                InsertOrUpdate = true,
                member = member,
                memberRepository = _memberRepository

            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadDataToDgv();
                _bindingSource.Position = _bindingSource.Count - 1;
            }
        }
        private Member GetMember(int rowIndex) {
            return new Member
            {
                MemberId = int.Parse(dvgMembers.Rows[rowIndex].Cells[0].Value.ToString()),
                Email = dvgMembers.Rows[rowIndex].Cells[1].Value.ToString(),
                Password = dvgMembers.Rows[rowIndex].Cells[2].Value.ToString(),
                CompanyName = dvgMembers.Rows[rowIndex].Cells[3].Value.ToString(),
                City = dvgMembers.Rows[rowIndex].Cells[4].Value.ToString(),
                Country = dvgMembers.Rows[rowIndex].Cells[5].Value.ToString(),
            };
        }

        private void dvgMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { 
                _member = GetMember(e.RowIndex);
            }
        }
    }
}
