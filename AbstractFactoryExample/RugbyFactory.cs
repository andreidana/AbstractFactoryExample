using AbstractFactoryExample.Fields;
using AbstractFactoryExample.Rules;
using AbstractFactoryExample.Teams;

namespace AbstractFactoryExample
{
    public class RugbyFactory: IAbstractSportsFactory
    {
        public IField CreateField()
        {
            return new RugbyField();
        }

        public ITeam CreateTeam()
        {
            return new RugbyTeam();
        }

        public IRules CreateRules()
        {
            return new RugbyRules();
        }
    }
}