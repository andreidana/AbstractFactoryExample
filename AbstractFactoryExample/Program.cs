using AbstractFactoryExample.Fields;
using AbstractFactoryExample.Rules;
using AbstractFactoryExample.Teams;
using System;

namespace AbstractFactoryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select your favourite sport(F - Football, H - Handball, R - Rugby)");
            var inputCharacter = Convert.ToChar(Console.Read());

            IAbstractSportsFactory abstractFactory = CreateFactoryForChosenSport(inputCharacter);
            PrintCreatedSportDetails(abstractFactory);
        }

        private static IAbstractSportsFactory CreateFactoryForChosenSport(char inputCharacter)
        {
            IAbstractSportsFactory abstractFactory;
            if (inputCharacter == 'F')
                abstractFactory = new FootballFactory();
            else if (inputCharacter == 'H')
                abstractFactory = new HandballFactory();
            else if (inputCharacter == 'R')
                abstractFactory = new RugbyFactory();
            else
                abstractFactory = new FootballFactory();
            return abstractFactory;
        }

        private static void PrintCreatedSportDetails(IAbstractSportsFactory abstractFactory)
        {
            IField createdField = abstractFactory.CreateField();
            IRules createdRules = abstractFactory.CreateRules();
            ITeam createdTeam = abstractFactory.CreateTeam();

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
