using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar toyota = new Honda();

            Console.WriteLine(toyota.CarMake());
            Console.WriteLine(toyota.Drive());

        }
    }

    abstract class CarBase : ICar
    {

        public CarBase(string firstname, string lastname)
        {
            Firstname = firstname;
            this.lastname = lastname;
        }

        protected int x = 10;
        private readonly string lastname;

        public string Firstname { get; }

        public string Drive()
        {
            x = x + 1;
            return Firstname + " " + lastname + " HAS DRIVEN:";
        }

        public virtual string CarMake()
        {
            return "";
        }

        public abstract string ServiceInterval();



    }

    class Toyota : CarBase
    {
        public Toyota() : base("Mohamed","Mohamed")
        {

        }

        public override string ServiceInterval()
        {
            return "Every 10000k";
        }

        public override string CarMake()
        {
            
            return "Toyota " + x.ToString();
        }
    }

    class Honda : CarBase
    {

        public Honda() 
            : base ("Fatima", "Fatima")
        {

        }
        public override string CarMake()
        {
            x++;
            return "Honda " + x.ToString();
        }

        public override string ServiceInterval()
        {
            return "Every 15000";
        }
    }

    interface ICar
    {
        string CarMake();
        string ServiceInterval();
        string Drive();

    }


}
