using GrapeCity.Core;
using GrapeCity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrapeCity
{
    public partial class Form1 : Form
    {
        private readonly ICityData _dataSource;

        public IEnumerable<City> Cities { get; set; }
        public string SearchTerm { get; set; }

        public Form1(ICityData dataSource)
        {
            InitializeComponent();

            _dataSource = dataSource; 
            LoadCityData();
            BindCityGrid();
        }

        private void LoadCityData()
        {
            Cities = _dataSource.GetCityByName(SearchTerm);
        }

        private void BindCityGrid()
        {
            var tbl = Cities.CreateTable();            
            dgFlexGrid.DataSource = tbl;
        }
    }
}
