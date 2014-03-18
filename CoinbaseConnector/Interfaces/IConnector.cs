using System;

namespace CoinbaseConnector.Interfaces
{
    public interface IConnector
    {
        string GetAccountChanges(int page = 1);
        string GetAccountBalance();
        string GetCurrentReceiveAddress();
        string GenerateReceiveAddress();
        string GenerateReceiveAddress(String callbackURL, String label);
        string GetAddressList(int page = 1, int limit = 25, String query = "");
        string GetOAuthApplicationsList(int page = 1);
        string GetOauthApplicationByID(String ID);
        string CreateOAuthApplication(String name, String redirectURI);
        string GetApplicationAccountAccessInfo();

        string CreatePaymentButton(String name, Decimal price, String currency, String type = "buy_now",
            String repeat = "never", String style = "buy_now_large", String text = "Pay With Bitcoin",
            String description = "", String custom = "", Boolean custom_secure = false,
            String callback_url = "", String success_url = "", String cancel_url = "",
            String info_url = "", Boolean auto_redirect = true, Boolean variable_price = false,
            Boolean choose_price = false, Boolean include_address = true, Boolean include_email = true,
            String price1 = "", String price2 = "", String price3 = "", String price4 = "",
            String price5 = "");

        string CreateOrderForButton(String code);
        string PurchaseBitcoin(float qty, Boolean agree_btc_amount_varies = false, String payment_method_id = "");
        string GetEmailContactsList(int page = 1, int limit = 25, String query = "");
        string GetSupportedCurrenciesList();
        string GetBTCExchangeRate();
        string GetReceivedMerchantOrdersList(int page = 1);

        string CreateNewOrder(String name, Decimal price, String currency, String type = "buy_now",
            String repeat = "never", String style = "buy_now_large", String text = "Pay With Bitcoin",
            String description = "", String custom = "", Boolean custom_secure = false,
            String callback_url = "", String success_url = "", String cancel_url = "",
            String info_url = "", Boolean auto_redirect = true, Boolean variable_price = false,
            Boolean choose_price = false, Boolean include_address = true, Boolean include_email = true,
            String price1 = "", String price2 = "", String price3 = "", String price4 = "",
            String price5 = "");

        string GetMerchantOrderByID(string ID = "");
        string GetAssociatedPaymentMethods();
        string GetTotalBuyPriceForBitcoin(float qty = 1, String currency = "USD");
        string GetTotalSellPriceForBitcoin(float qty = 1, String currency = "USD");
        string GetSpotPriceForBitcoin(String currency = "USD");
        string GetHistoricalSpotPriceForBitcoin(int page = 1);
        string GetRecurringPaymentsList(String ID = "", int page = 1, int limit = 25);
        string SellBitcoin(float qty, String payment_method_id = "");
        string GetSubscribersList(String ID = "", int page = 1, int limit = 25);
        string CreateToken();
        string RedeemToken(String tokenID = "");
        string GetTransactionsList(String ID = "", int page = 1, int limit = 25);

        string SendMoney(String email, String amount = "", String amountString = "", String amountCurrencyISO = "",
            String notes = "", String userFee = "", String referrerID = "", String idem = "",
            Boolean instantBuy = false);

        string SendInvoice(String from, String amount = "", String amountString = "", String amountCurrencyISO = "",
            String notes = "");

        string ResendInvoice(String ID);
        string CancelMoneyRequest(String ID);
        string CompleteMoneyRequest(String ID);
        string GetTransfersList(int page = 1, int limit = 25);
        string CreateNewUser(String email, String password, String referrerID = "", String clientID = "");
        string GetAccountSettings();

        string UpdateAccountSettings(String id, String name = "", String email = "", String pin = "",
            String nativeCurrency = "", String timeZone = "");
    }
}
