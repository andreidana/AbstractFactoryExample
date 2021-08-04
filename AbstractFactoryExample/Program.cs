using System;

namespace AbstractFactoryExample
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Please select your favorite sport(F - Football, H - Handball, R - Rugby)");
            var inputCharacter = Convert.ToChar(Console.Read());

            var abstractFactory = CreateFactoryForChosenSport(inputCharacter);
            PrintCreatedSportDetails(abstractFactory);
        }

        private static IAbstractSportsFactory CreateFactoryForChosenSport(char inputCharacter)
        {
            IAbstractSportsFactory abstractFactory;
            switch (inputCharacter)
            {
                case 'F':
                    abstractFactory = new FootballFactory();
                    break;
                case 'H':
                    abstractFactory = new HandballFactory();
                    break;
                case 'R':
                    abstractFactory = new RugbyFactory();
                    break;
                default:
                    abstractFactory = new FootballFactory();
                    break;
            }
            return abstractFactory;
        }

        private static void PrintCreatedSportDetails(IAbstractSportsFactory abstractFactory)
        {
            var createdField = abstractFactory.CreateField();
            var createdRules = abstractFactory.CreateRules();
            var createdTeam = abstractFactory.CreateTeam();

            Console.WriteLine("We have the following number of people in the team:");
            Console.WriteLine(createdTeam.GetNumberOfPeopleInTeam());
            Console.WriteLine("We have the following field length");
            Console.WriteLine(createdField.GetFieldLength());
            Console.WriteLine("We have the following field width");
            Console.WriteLine(createdField.GetFieldWidth());
            Console.WriteLine("A player is eliminated when");
            Console.WriteLine(createdRules.GetEliminatePlayerRule());
            Console.ReadKey();
        }
    }
}
