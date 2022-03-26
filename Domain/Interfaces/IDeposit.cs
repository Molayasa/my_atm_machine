using MyATMMachine.Domain.Entities;
public interface IDeposit
{
  void PlaceDeposit(BankAccount bankAccount);
}