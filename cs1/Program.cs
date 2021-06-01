using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace cs1
{
    public class CSLib
    {
        //import console.
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        //ムダムダムダムダムダムダ
        public static void Main(string[] args)
        {
            var read = Console.ReadLine();
        }
        //
        //初期化
        public void init()
        {
            AllocConsole();
        }
        public void tt()
        {
            AllocConsole();
            Console.WriteLine("a");
            var read = Console.ReadLine();
        }
    }
}
