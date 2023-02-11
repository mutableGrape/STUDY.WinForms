using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm2
{
    public class Startup
    {
        
        public static void Main(string[] args)
        {
            var form = new AreaCalculator();
            Application.Run(form);
        }
    }
}
