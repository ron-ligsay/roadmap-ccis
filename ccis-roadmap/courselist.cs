using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccis_roadmap
{
    public partial class courselist : Form
    {
        Person _person = new Person()
        {
            FName = "Jamie",
            Email = "Jamie@1234.net",
            Address = "Wall Street",
            Number = 123124332,
        };

        public courselist()
        {
            InitializeComponent();

            

            //this.DataContext = _person;
            this.FName.Text = _person.FName;
            this.Email.Text = _person.Email;
            this.Address.Text = _person.Address;
            this.Number.Text = _person.Number.ToString();

        }

        private void courselist_Load(object sender, EventArgs e)
        {
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{this._person.FName}");
        }
    }

    class Person
    {
        public Person()
        {

        }

        public string FName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }

    }
}
