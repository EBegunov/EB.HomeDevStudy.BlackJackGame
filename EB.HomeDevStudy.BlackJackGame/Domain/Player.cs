using System;

namespace EB.HomeDevStudy.Main.Domain
{
    public class Player : User
    {
        public override string GetScoreInfo()
        {
            return $"Ваш счет: {Score}";
        }

        public override string GetName()
        {
            return this.Name;
        }
    }
}
