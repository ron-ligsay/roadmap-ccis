using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccis_roadmap
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            //InitializeComponent();

            Person _person = new Person()
            {
                Name = "Jamie",
                Email = "Jamie@1234.net",
                Address = "Wall Street",
                Number = 123124332,
            };

            this.DataContext = _person;

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
        public int  Number { get; set; }

    }
}


