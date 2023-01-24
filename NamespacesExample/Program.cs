using m = HR.Mgr;   //using alias
using FrontOffice;
class Program
{
    static void Main()
    {
        //using alias
        m.IManager manager;
        manager = new m.Manager();

        CustomerEnquiry customerEnquiry = new CustomerEnquiry();

    }
}

