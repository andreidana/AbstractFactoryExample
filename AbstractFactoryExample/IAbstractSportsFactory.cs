using AbstractFactoryExample.Fields;
using AbstractFactoryExample.Rules;
using AbstractFactoryExample.Teams;

namespace AbstractFactoryExample
{
    public interface IAbstractSportsFactory
    {
        IField CreateField();
        ITeam CreateTeam();
        IRules CreateRules();
    }
}