namespace AbstractFactoryExample.Teams
{
    public class RugbyTeam: ITeam
    {
        public int GetNumberOfPeopleInTeam()
        {
            return 15;
        }
    }
}