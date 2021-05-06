using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
namespace VaccineInfo
{
    public partial class VaccineDashboard : Form
    {
        public VaccineDashboard()
        {
            InitializeComponent();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                //
                Result.Clear();
                //save entered details 
                string pincode = this.pincode.Text;
                string date = dateTimePicker.Text;
                

                // Hit the API with query params
                string url = "https://cdn-api.co-vin.in/api/v2/appointment/sessions/public/calendarByPin?pincode=" + pincode + "&date=" + date;
                WebRequest request = HttpWebRequest.Create(url);

                //Add Headers
                ((HttpWebRequest)request).UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";

                //store the response
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string urlText = reader.ReadToEnd(); // it takes the response from your url. now you can use as your need  

                //convert the response to a JSON Object 
                var details = JObject.Parse(urlText);


                //Iterate through the centers and display each center details
                var centers = details["centers"];
                int count = centers.Count();
                if (details.Count > 0 && count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        var first = centers[i];
                        var name = first["name"];
                        var statename = first["state_name"];
                        var districtname = first["district_name"];
                        var sessions = first["sessions"];
                        var sessionsfirst = sessions[0];
                        var availablecapacity = sessionsfirst["available_capacity"];
                        var minimumage = sessionsfirst["min_age_limit"];
                        var vaccinename = sessionsfirst["vaccine"];
                        var slots = sessionsfirst["slots"];

                        Result.Text += "Name: " + name + Environment.NewLine +
                        "State Name: " + statename + Environment.NewLine +
                        "District Name: " + districtname + Environment.NewLine +
                        "Available Capacity: " + availablecapacity + Environment.NewLine +
                        "Minimum Age Limit: " + minimumage + Environment.NewLine +
                        "Vaccine Name: " + vaccinename + Environment.NewLine +
                        "Slots: " + slots + Environment.NewLine + Environment.NewLine + "--------------------------------------------------------------" +
                        Environment.NewLine;

                    }
                }
                else
                {
                    Result.Text = "No Vaccine Information Found";
                }

            }
            catch (Exception ex)
            {
                Result.Text = "Exception in your Code, Please Restart the Application" + Environment.NewLine + ex;
                MessageBox.Show("Please Enter Valid Pincode and Date");
            }
        }
        private void pincode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatePincode();
            
        }
       
        private bool ValidatePincode()
        {
            bool bStatus = true;
            if (pincode.Text.Length != '6' && pincode.Text == "")
            {
                errorProvider1.SetError(pincode, "Please enter valid pincode");
                bStatus = false;
            }
            else
                errorProvider1.SetError(pincode, "");
            return bStatus;
        }

        private void ValidateForm()
        {
            bool bValidName = ValidatePincode();
            
            if (bValidName)
                MessageBox.Show("Appointment will be created now");
            else
                MessageBox.Show("Please enter valid data");
        }

        private void pincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ;
        }

    }
}
