using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CowboyMaker cowboyMaker = new CowboyMaker();
            Assembler assembler = new Assembler(cowboyMaker);
            assembler.AssembleToy();
            Toy toy = assembler.GetToy();

            SpacemanMaker spacemanMaker = new SpacemanMaker();
            assembler = new Assembler(spacemanMaker);
            assembler.AssembleToy();
            Toy toy2 = assembler.GetToy();


            Console.WriteLine(toy.ToString());
            Console.WriteLine(toy2.ToString());
            Console.Read();
        }
    }
}
