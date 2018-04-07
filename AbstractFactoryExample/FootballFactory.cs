using AbstractFactoryExample.Fields;
using AbstractFactoryExample.Rules;
using AbstractFactoryExample.Teams;

namespace AbstractFactoryExample
{
    public class FootballFactory : IAbstractSportsFactory
    {
        public IField CreateField()
        {
            return new FootballField();
        }

        public ITeam CreateTeam()
        {
            return new FootballTeam();
        }

        public IRules CreateRules()
        {
            return new FootballRules();
        }
    }
}