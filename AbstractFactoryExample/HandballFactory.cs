using AbstractFactoryExample.Fields;
using AbstractFactoryExample.Rules;
using AbstractFactoryExample.Teams;

namespace AbstractFactoryExample
{
    public class HandballFactory: IAbstractSportsFactory
    {
        public IField CreateField()
        {
            return new HandballField();
        }

        public ITeam CreateTeam()
        {
            return new HandballTeam();
        }

        public IRules CreateRules()
        {
            return new HandballRules();
        }
    }
}