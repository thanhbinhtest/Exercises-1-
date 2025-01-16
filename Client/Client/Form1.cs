using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void getCountrybyCode_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ServiceReference1.WebService1SoapClient(ServiceReference1.WebService1SoapClient.EndpointConfiguration.WebService1Soap);

                string countryCode = txb_CountryCode.Text.Trim();

                if (string.IsNullOrEmpty(countryCode))
                {
                    MessageBox.Show("Please enter a valid country code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var response = await client.GetCountryByCodeAsync(countryCode);
                var country = response.Body.GetCountryByCodeResult;

                if (country != null)
                {
                    dgvResults.DataSource = null;
                    dgvResults.DataSource = ConvertToDataTable(new[] { country },
                        new[] { "Code", "Name", "Continent", "Region", "Population" },
                        c => new object[] { c.Code, c.Name, c.Continent, c.Region, c.Population });
                }
                else
                {
                    MessageBox.Show("Country not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getCityByName_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ServiceReference1.WebService1SoapClient(ServiceReference1.WebService1SoapClient.EndpointConfiguration.WebService1Soap);

                string cityName = txb_CityName.Text.Trim();

                if (string.IsNullOrEmpty(cityName))
                {
                    MessageBox.Show("Please enter a valid city name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var response = await client.GetCityByNameAsync(cityName);
                var city = response.Body.GetCityByNameResult;

                if (city != null)
                {
                    dgvResults.DataSource = null;
                    dgvResults.DataSource = ConvertToDataTable(new[] { city },
                        new[] { "ID", "Name", "CountryCode", "District", "Population" },
                        c => new object[] { c.ID, c.Name, c.CountryCode, c.District, c.Population });
                }
                else
                {
                    MessageBox.Show("City not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getAllCityFromCountryCode_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ServiceReference1.WebService1SoapClient(ServiceReference1.WebService1SoapClient.EndpointConfiguration.WebService1Soap);

                string countryCode = txb_CountryCode.Text.Trim();

                if (string.IsNullOrEmpty(countryCode))
                {
                    MessageBox.Show("Please enter a valid country code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var response = await client.GetAllCitiesByCountryCodeAsync(countryCode);
                var cities = response.Body.GetAllCitiesByCountryCodeResult;

                if (cities != null && cities.Length > 0)
                {
                    dgvResults.DataSource = null;
                    dgvResults.DataSource = ConvertToDataTable(cities,
                        new[] { "ID", "Name", "CountryCode", "District", "Population" },
                        c => new object[] { c.ID, c.Name, c.CountryCode, c.District, c.Population });
                }
                else
                {
                    MessageBox.Show("No cities found for the given country.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getCityByDistrict_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ServiceReference1.WebService1SoapClient(ServiceReference1.WebService1SoapClient.EndpointConfiguration.WebService1Soap);

                string district = txb_District.Text.Trim();

                if (string.IsNullOrEmpty(district))
                {
                    MessageBox.Show("Please enter a valid district name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var response = await client.GetCitiesByDistrictAsync(district);
                var cities = response.Body.GetCitiesByDistrictResult;

                if (cities != null && cities.Length > 0)
                {
                    dgvResults.DataSource = null;
                    dgvResults.DataSource = ConvertToDataTable(cities,
                        new[] { "ID", "Name", "CountryCode", "District", "Population" },
                        c => new object[] { c.ID, c.Name, c.CountryCode, c.District, c.Population });
                }
                else
                {
                    MessageBox.Show("No cities found for the given district.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getAllCountry_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new ServiceReference1.WebService1SoapClient(ServiceReference1.WebService1SoapClient.EndpointConfiguration.WebService1Soap);

                var response = await client.GetAllCountriesAsync();
                var countries = response.Body.GetAllCountriesResult;

                if (countries != null && countries.Length > 0)
                {
                    dgvResults.DataSource = null;
                    dgvResults.DataSource = ConvertToDataTable(countries,
                        new[] { "Code", "Name", "Continent", "Region", "Population" },
                        c => new object[] { c.Code, c.Name, c.Continent, c.Region, c.Population });
                }
                else
                {
                    MessageBox.Show("No countries found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ConvertToDataTable<T>(T[] items, string[] columnNames, Func<T, object[]> rowValuesExtractor)
        {
            var table = new DataTable();

            foreach (var col in columnNames)
            {
                table.Columns.Add(col);
            }

            foreach (var item in items)
            {
                table.Rows.Add(rowValuesExtractor(item));
            }

            return table;
        }
    }
}
