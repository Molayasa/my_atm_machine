
using System;
namespace MyATMMachine.Domain.Entities
{
  public class BankAccount
  {
    public string Id { get; set; }
    public string FullName { get; set; }
    public Int64 AccountNumber { get; set; }
    public Int64 CardNumber { get; set; }
    public Int64 PinCode { get; set; }
    public decimal Balance { get; set; }

    public bool isLocked { get; set; }
  }

}

