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
        public courselist()
        {
            InitializeComponent();

            Person _person = new Person()
            {
                Name = "Jamie",
                Email = "Jamie@1234.net",
                Address = "Wall Street",
                Number = 123124332,
            };

            this.DataContext = _person;
        }

        private void courselist_Load(object sender, EventArgs e)
        {

        }
    }

    class Person
    {
        public Person()
        {

        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }

    }
}
