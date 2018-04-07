namespace AbstractFactoryExample.Teams
{
    public class FootballTeam: ITeam
    {
        public int GetNumberOfPeopleInTeam()
        {
            return 11;
        }
    }
}