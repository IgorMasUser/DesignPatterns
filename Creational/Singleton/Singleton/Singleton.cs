namespace SingletonPattern
{
    class Singleton
    {
        static Singleton singleton = null;

        protected Singleton()
        {
        }

        public static Singleton getInstance()
        {
            if (singleton == null)
            {
                singleton = new Singleton();
            }
            return singleton;
        }


    }
}
