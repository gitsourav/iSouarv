using iSourav.Domain.Interfaces;

namespace iSourav.Business
{
    public class Test : ITest
    {
        public string SayHello(string name)
        {
            return "Hello  " + name;
        }
    }
}
