using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IToyOutline
    {
        void ChooseClothes(string clothes);
        void ChooseHat(string hat);
        void ChooseHead(string head);
        void ChooseLegs(string legs);
        void ChooseTorso(string torso);
        void GiveName(string name);
    }
}
