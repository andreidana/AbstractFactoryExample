namespace AbstractFactoryExample.Fields
{
    public class RugbyField: IField
    {
        public int GetFieldLength()
        {
            return 105;
        }

        public int GetFieldWidth()
        {
            return 40;
        }
    }
}