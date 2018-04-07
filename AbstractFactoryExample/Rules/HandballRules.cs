namespace AbstractFactoryExample.Rules
{
    public class HandballRules: IRules
    {
        public string GetEliminatePlayerRule()
        {
            return "Serious foul means two minutes on the bench";
        }
    }
}