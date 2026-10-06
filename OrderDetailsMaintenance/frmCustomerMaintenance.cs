using Microsoft.EntityFrameworkCore;
using OrderDetailsMaintenance.Models.DataLayer;
using System.Diagnostics;

namespace OrderDetailsMaintenance
{
    public partial class frmCustomerMaintenance : Form
    {
        NorthwindContext _context = new NorthwindContext();

        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        // Hudson DeGrace
        private void btnFind_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            var customer = _context.Customers.Find(id);

            txtContact.Text = customer.ContactName;
            txtAddress.Text = customer.Address;
            txtCity.Text = customer.City;
            txtCountry.Text = customer.Country;
        }
        // Hudson DeGrace
        private void btnExit_Click(object sender, EventArgs e) => this.Close();
        // Hudson DeGrace
        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtCustomerId.Text;
            var customer = _context.Customers.Find(id);

            customer.ContactName = txtContact.Text;
            customer.Address = txtAddress.Text;
            customer.City = txtCity.Text;
            customer.Country = txtCountry.Text;
            _context.SaveChanges();
        }
    }
}