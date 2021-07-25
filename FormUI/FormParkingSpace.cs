using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFrameWork.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormParkingSpace : Form
    {
        private IParkingSpaceService _parkingSpaceService;
        public FormParkingSpace()
        {
            InitializeComponent();
            _parkingSpaceService = new ParkingSpaceManager(new EFParkingSpaceDal());

        }
        private void LoadData()
        {
            dgwParkingSpace.DataSource = _parkingSpaceService.GetAll();
        }

        private void btnParkingSpaceAdd_Click(object sender, EventArgs e)
        {
            _parkingSpaceService.Add(new ParkingSpace
            {
                ParkingSpaceAdress = tbxParkingSpaceAdressAdd.Text,
                TotalNumberParkingSpots = Convert.ToInt32(tbxTotalNumberParkingSpotsAdd.Text),
                ChargeForHour = Convert.ToDecimal(tbxChargeForHourAdd.Text)

            });
            LoadData();
        }

        private void FormParkingSpace_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgwParkingSpace_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxChargeForHourUpdate.Text = dgwParkingSpace.CurrentRow.Cells[3].Value.ToString();
            tbxParkingSpaceAdressUpdate.Text = dgwParkingSpace.CurrentRow.Cells[1].Value.ToString();
            tbxTotalNumberParkingSpotsUpdate.Text = dgwParkingSpace.CurrentRow.Cells[2].Value.ToString();
            tbxParkingSpaceIdDelete.Text = dgwParkingSpace.CurrentRow.Cells[0].Value.ToString();
        }

        private void tbxParkingSpaceIdSearch_TextChanged(object sender, EventArgs e)
        {
            string text = tbxParkingSpaceIdSearch.Text;
            if (!String.IsNullOrEmpty(text))
            {
                dgwParkingSpace.DataSource = _parkingSpaceService.GetAll(m => m.ParkingSpaceId.ToString().Contains(text));
            }
            else
            {
                LoadData();
            }
        }

        private void btnParkingSpaceUpdate_Click(object sender, EventArgs e)
        {
            _parkingSpaceService.Update(new ParkingSpace
            {
                ParkingSpaceId =Convert.ToInt32(dgwParkingSpace.CurrentRow.Cells[3].Value),
                ParkingSpaceAdress = tbxParkingSpaceAdressUpdate.Text,
                TotalNumberParkingSpots = Convert.ToInt32(tbxTotalNumberParkingSpotsUpdate.Text),
                ChargeForHour = Convert.ToDecimal(tbxChargeForHourUpdate.Text)
            });
            LoadData();
        }

        private void btnParkingSpaceDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxParkingSpaceIdDelete.Text))
            {

                _parkingSpaceService.Delete(_parkingSpaceService.GetById(Convert.ToInt32(tbxParkingSpaceIdDelete.Text)));

            }
            LoadData();

        }
    }
}
