using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 展示用名前プレート
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form2 f = new Form2();
            f.ShowDialog();
            Form1 f1 = new Form1();
            f1.label2.Text = f.textBox1.Text;
            f1.label1.Text = f.textBox2.Text;
            
            Application.Run(f1);
        }
    }
}
