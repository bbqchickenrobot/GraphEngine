using System;
using Trinity;
using Trinity.TSL.Lib;
using System.Runtime.CompilerServices;

namespace GraphEngine.Test
{
    class Program
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        static void Main(string[] args)
        {
            TrinityConfig.StorageRoot  = Environment.CurrentDirectory;
            using (var c1 = Global.LocalStorage.UseC1(0, CellAccessOptions.CreateNewOnCellNotFound))
            {
                Console.WriteLine(c1.ToString());
            }
        }
    }
}
