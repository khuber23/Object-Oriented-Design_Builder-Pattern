using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class CowboyMaker : IToyMaker
    {
        private Toy toy;

        public CowboyMaker()
        {
            this.toy = new Toy();
        }

        public Toy GetToy()
        {
            return toy;
        }

        public void MakeHat()
        {
            toy.ChooseHat("Bucket Hat");
        }

        public void NameToy()
        {
            toy.GiveName("Woody");
        }

        public void PaintHead()
        {
            toy.ChooseHead("Rugged");
        }

        public void PaintLegs()
        {
            toy.ChooseLegs("Jeans");
        }

        public void PaintTorso()
        {
            toy.ChooseTorso("Cowboy");
        }

        public void StitchClothes()
        {
            toy.ChooseClothes("Western");
        }
    }
}
