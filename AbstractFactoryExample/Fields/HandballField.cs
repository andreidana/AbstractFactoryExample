namespace AbstractFactoryExample.Fields
{
    public class HandballField: IField
    {
        public int GetFieldLength()
        {
            return 30;
        }

        public int GetFieldWidth()
        {
            return 15;
        }
    }
}