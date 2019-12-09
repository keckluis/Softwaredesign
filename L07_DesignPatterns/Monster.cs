using System;

namespace L07_DesignPatterns
{
    public abstract class Spielfigur
    {
        public abstract void Drohe();
    }

    public class Monster : Spielfigur
    {
        public override void Drohe()
        {
            Console.WriteLine("Grrrrrrrrrr.");
        }
    }

    public abstract class Dekorierer : Spielfigur
    {
        private Spielfigur meineFigur;

        public Dekorierer(Spielfigur s)
        {
            meineFigur = s;
        }

        public override void Drohe()
        {
            meineFigur.Drohe();
        }
    }

    public class HustenDekorierer : Dekorierer
    {
        public HustenDekorierer(Spielfigur s)
            : base(s)
        { }

        public override void Drohe()
        {
            Console.Write("Hust, hust. ");
            base.Drohe();
        }
    }

    public class SchnupfenDekorierer : Dekorierer
    {
        public SchnupfenDekorierer(Spielfigur s)
            : base(s)
        { }

        public override void Drohe()
        {
            Console.Write("Schniff. ");
            base.Drohe();
        }
    }
}