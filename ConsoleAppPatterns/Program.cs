using ConsoleAppPatterns.Observable.Base;

namespace ConsoleAppPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            OberverType1 o11 = new OberverType1("type 1:1");
            OberverType1 o12 = new OberverType1("type 1:2");
            OberverType1 o13 = new OberverType1("type 1:3");

            OberverType2 o21 = new OberverType2("type 2:1");
            OberverType2 o22 = new OberverType2("type 2:2");
            OberverType2 o23 = new OberverType2("type 2:3");

            subject.Register(o11);
            subject.Register(o12);
            subject.Register(o13);
            subject.Register(o21);
            subject.Register(o22);
            subject.Register(o23);

            subject.Notify(1);
            subject.Notify(2);
            subject.Notify(3);
        }
    }
}