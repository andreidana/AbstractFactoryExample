namespace AbstractFactoryExample.Rules
{
    public class FootballRules: IRules
    {
        public string GetEliminatePlayerRule()
        {
            return "Two yellow cards means a red card, and you're out";
        }
    }
}