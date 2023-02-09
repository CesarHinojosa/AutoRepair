namespace CH.AutoRepair.UI
{
    //OOP Pillars 
    //1. Encapsulation -- Package up related data and methods (MultiVitimum)
    //2. Inheritance -- Getting stuff for free
    //3. Polymorphism --
    //**4. Abstraction -- Don't need to know how
    public partial class Form1 : Form
    {
        //fields

        //a list is just a spot in memory
        //"<>" are "of type" Customer 
        private CustomerCollection customers = new CustomerCollection();



        //constructor
        public Form1()
        {
            InitializeComponent();
            customers.LoadTestCustomers();
            RebindCustomers();
        }

        //methods
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //this is creating a new customer
            //this is an object
            Customer customer = new Customer();

            //with the new customer whatever the user inputs in the text box will be applied to the new customer
            //properties
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.PhoneNumber= txtPhoneNumber.Text;

            //adds the customers add to the list 
            this.customers.Add(customer);

            RebindCustomers();
            
        }

        private void RebindCustomers()
        {
            lstCustomers.DataSource = null; //unbind (Allowing it to refresh)
            //The list box on the form (lstCustomer) will get the data from the List<Customer>
            lstCustomers.DataSource = this.customers; // re-binding 
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Customer? selectedCustomer = lstCustomers.SelectedItem as Customer;

            if (selectedCustomer != null)
            {
                txtFirstName.Text = selectedCustomer.FirstName;
                txtLastName.Text = selectedCustomer.LastName;
                txtPhoneNumber.Text = selectedCustomer.PhoneNumber;
            }
            
        }
    }
}