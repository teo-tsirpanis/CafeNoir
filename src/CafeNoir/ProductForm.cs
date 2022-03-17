using CafeNoir.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeNoir
{
    public partial class ProductForm : Form
    {
        public CoffeeShop CoffeeShop { get; set; }
        private string FILE_NAME;
        public ProductForm(string file_name)
        {
            FILE_NAME = file_name;
            InitializeComponent();
        }
    }
}
