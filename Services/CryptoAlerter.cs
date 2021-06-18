using System;
using System.Net;
using System.Web;
using CryptoNotification.Services;
using CryptoNotification.Controllers;
using CoinMarketCap.Core;

class CryptoAlerter
{
    private static string API_KEY = "1e7c7370-ab46-4d4d-a935-6e30d8b341c9";

    public static string makeAPICall(string price, string email)
    {
        var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

        var queryString = HttpUtility.ParseQueryString(string.Empty);
        queryString["price"] = price;

        URL.Query = queryString.ToString();

        var client = new WebClient();
        client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
        client.Headers.Add("Accepts", "application/json");

        return client.DownloadString(URL.ToString());

    }

}