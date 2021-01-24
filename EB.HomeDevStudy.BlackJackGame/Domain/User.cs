

namespace EB.HomeDevStudy.Main.Domain
{
    public abstract class User
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public abstract string GetScoreInfo();

        public abstract string GetName();


    }
}
