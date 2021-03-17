using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardValidator
{
    public partial class CardValidator : Form
    {
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string CsvCode { get; set; }
        public string ValidationError { get; set; }
        public CardValidator()
        {
            InitializeComponent();
        }

        private void CardValidator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidationError = IsCreditCardInfoValid(CardNumber, ExpirationDate, CsvCode);
            if (ValidationError.Contains("is incorrect"))
            {
                MessageBox.Show($"{ValidationError}", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ValidationError == "")
            {
                MessageBox.Show("The values are correct", "Validation Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                CardValidator form = new CardValidator();
                form.Refresh();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CardNumberText_TextChanged(object sender, EventArgs e)
        {
            CardNumber = CardNumberText.Text;
        }
        private void ExpiryDateText_TextChanged(object sender, EventArgs e)
        {
            ExpirationDate = ExpiryDateText.Text;
        }

        private void CVVText_TextChanged(object sender, EventArgs e)
        {
            CsvCode = CVVText.Text;
        }

        public static string IsCreditCardInfoValid(string cardNo, string expiryDate, string cvv)
        {
            var cardCheck = new Regex(@"^(1298|1267|4512|4567|8901|8933)([\-\s]?[0-9]{4}){3}$");
            var monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
            var yearCheck = new Regex(@"^20[0-9]{2}$");
            var cvvCheck = new Regex(@"^\d{3}$");
            var dateParts = expiryDate.Split('/'); //expiry date in from MM/yyyy
            var year = int.Parse(dateParts[1]);
            var month = int.Parse(dateParts[0]);
            var lastDateOfExpiryMonth = DateTime.DaysInMonth(year, month); //get actual expiry date
            var cardExpiry = new DateTime(year, month, lastDateOfExpiryMonth, 23, 59, 59);
            var validationError = "";

            if (!cardCheck.IsMatch(cardNo)) // <1>check card number is valid
            {

                return validationError = "Card number is incorrect";

            }
            if (!cvvCheck.IsMatch(cvv))// <2>check cvv is valid as "999"
            {

                return validationError = "CVV number is incorrect";
            }
            if (!monthCheck.IsMatch(dateParts[0]) || !yearCheck.IsMatch(dateParts[1])) // <3 - 6> // ^ check date format is valid as "MM/yyyy"
            {

                return validationError = "Date format is incorrect";
            }
            if (!(cardExpiry > DateTime.Now && cardExpiry < DateTime.Now.AddYears(6)))  //check expiry greater than today & within next 6 years <7, 8>>
            {

                return validationError = "Expiry Date is incorrect";
            }

            return validationError;

        }

    }
}
