using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Toy : IToyOutline
    {
        private string clothes;
        private string head;
        private string legs;
        private string name;
        private string torso;
        private string hat;

        public Toy()
        {
        }

        public void ChooseClothes(string clothes)
        {
            this.clothes = clothes;
        }
        public void ChooseHead(string head)
        {
            this.head = head;
        }
        public void ChooseHat(string hat)
        {
            this.hat = hat;
        }
        public void ChooseLegs(string legs)
        {
            this.legs = legs;
        }
        public void ChooseTorso(string torso)
        {
            this.torso = torso;
        }
        public void GiveName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"{name}:\n\tHead: {this.head}\n\tTorso: {this.torso}\n\tLegs: {this.legs}\n\tClothes: {this.clothes}\n\tHat: {this.hat}\n";
        }
    }
}
