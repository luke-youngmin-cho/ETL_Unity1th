namespace FirstProject
{
    public class Human
    {
        public static Human instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Human();
                return _instance;
            }
        }
        private static Human _instance;

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        string _name;
        float _height;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value;
        }

        public Human()
        {

        }

        ~Human() { }

        public void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }

    public class Luke : Human
    {
        public float weight;

        public void SayHi()
        {
            Console.WriteLine("Hi, I'm Luke");
        }
    }

    public class A { }


    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            Luke luke = new Luke();
            human = luke;
            human.SayHi();

            Human human2 = new Luke();
        }
    }
}