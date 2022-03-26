using MyATMMachine.Domain.Entities;

namespace MyATMMachine
{
  class Program
  {
    static void Main(string[] args)
    {

      Bank atm = new Bank();
      atm.Initialization();
      atm.Execute();
    }
  }
}
