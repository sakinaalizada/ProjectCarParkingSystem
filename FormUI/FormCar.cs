using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
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
    public partial class FormCar : Form
    {
        private ICarService _carService;
        private IParkingSpaceService _parkingSpaceService;
        public FormCar()
        {
            InitializeComponent();
            _carService = new CarManager(new EFCarDal());
            _parkingSpaceService = new ParkingSpaceManager(new EFParkingSpaceDal());
        }

        private void btnCarAdd_Click(object sender, EventArgs e)
        {
            _carService.Add(new Car
            {
                CarPlate = tbxCarPlateAdd.Text,
                ArrivalTime = dtpArrivalTimeAdd.Value,
                Status = "Active",
                ParkingSpaceId = Convert.ToInt32(tbxParkingSpaceIdAdd.Text)

            });
            LoadData();
        }

        private void FormCar_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgwCarAdd.DataSource = _carService.GetAll(m => m.Status == "Active");
        }
        private void LoadDataPassive()
        {
            dgwCarAdd.DataSource = _carService.GetAll((m => m.Status == "Passive"));
        }

        private void tbxCarPlateSearch_TextChanged(object sender, EventArgs e)
        {
            string text = tbxCarPlateSearch.Text.ToLower();


            if (!String.IsNullOrEmpty(text))
            {
                dgwCarAdd.DataSource = _carService.SearchByCarPlate(text);
            }
            else
            {
                LoadData();
            }

        }

        private void dgwCarAdd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxCarPlateCalculate.Text = dgwCarAdd.CurrentRow.Cells[1].Value.ToString();
            dtpDepartureTimeCalculate.Value = DateTime.Now;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal time = Math.Round((dtpDepartureTimeCalculate.Value.Hour * 60 + dtpDepartureTimeCalculate.Value.Minute -
               (Convert.ToDateTime(dgwCarAdd.CurrentRow.Cells[2].Value.ToString()).Hour * 60 +
               Convert.ToDateTime(dgwCarAdd.CurrentRow.Cells[2].Value.ToString()).Minute)) / 60m, 2);
            decimal totalCharge = time * _parkingSpaceService.GetChargeForHourById(Convert.ToInt32(dgwCarAdd.CurrentRow.Cells[7].Value));
            tbxTotalChargeCalculate.Text = (totalCharge).ToString();

            _carService.Update(new Car
            {
                CarId = (int)dgwCarAdd.CurrentRow.Cells[0].Value,
                CarPlate = dgwCarAdd.CurrentRow.Cells[1].Value.ToString(),
                ArrivalTime = Convert.ToDateTime(dgwCarAdd.CurrentRow.Cells[2].Value.ToString()),
                DepartureTime = DateTime.Now,
                TotalTime = time,
                TotalCharge = totalCharge,
                Status = "Passive",
                ParkingSpaceId = (int)dgwCarAdd.CurrentRow.Cells[7].Value

            });
            LoadData();
        }

        private void btnPassiveCars_Click(object sender, EventArgs e)
        {
            LoadDataPassive();
        }

        private void btnActiveCars_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
