namespace AbstractFactoryExample.Fields
{
    public class FootballField: IField
    {
        public int GetFieldLength()
        {
            return 100;
        }

        public int GetFieldWidth()
        {
            return 45;
        }
    }
}