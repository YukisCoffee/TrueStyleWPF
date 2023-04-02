using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YukisCoffee.TrueStyleWPF;

public class TestInsertionPoint
{
    [STAThread]
    public static void Main(string[] args)
    {
        TestWindow app = new();
        app.ShowDialog();
    }
}
