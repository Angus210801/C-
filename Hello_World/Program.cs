using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MR.Data;

namespace MR.View
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            model.GetData();
        }
    }
}


namespace MR.Data
{
    class Model
    {
        public void GetData()
        {
            Console.WriteLine("Today is meeting day!");
        }
    }
}
