namespace IkProjemCore3dot1.Areas.Admin.Data
{
    public class SingletonTest
    {

        private SingletonTest()
        {
            
        }

        static SingletonTest()
        {
            _nesne = new SingletonTest();
        }

        private static SingletonTest _nesne;

        public static SingletonTest singletonTest { get { return _nesne; }   }

    }
}
/*      
 *      private SingletonTest()
        {
            
        }

        private static SingletonTest _singletonTest;

        public static SingletonTest singletonTestNesnesiVer()
        {
            if (_singletonTest == null)
            {
                _singletonTest = new SingletonTest();
            }
            return _singletonTest;
        }*/