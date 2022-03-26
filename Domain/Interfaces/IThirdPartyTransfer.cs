using MyATMMachine.Domain.Entities;
public interface IThirdPartyTransfer
{
  void PerformThirdPartyTransfer(BankAccount bankAccount, VMThirdPartyTransfer vmThirdPartyTransfer);
}