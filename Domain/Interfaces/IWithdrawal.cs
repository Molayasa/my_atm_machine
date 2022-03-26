using MyATMMachine.Domain.Entities;
public interface IWithdrawal
{
  void MakeWithdrawal(BankAccount bankAccount);
}