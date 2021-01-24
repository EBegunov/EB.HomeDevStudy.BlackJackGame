using System;
using System.Collections.Generic;
using System.Text;

namespace EB.HomeDevStudy.Main.Domain
{
    public class ArtificialIntelligence : User
    {
        public override string GetScoreInfo()
        {
            return $"Cчет компьютера: {Score}";
        }
        public override string GetName()
        {
            return this.Name;
        }

    }
}
