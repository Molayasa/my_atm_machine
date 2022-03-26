using MyATMMachine.Domain.Entities;
public interface IBalance
{
  void CheckBalance(BankAccount bankAccount);
}