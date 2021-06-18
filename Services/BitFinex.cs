using System;
using Bitfinex.Net;
namespace CryptoNotification.Services

    //For market data and buying crypto from the app
{
    public class BitFinex
    {
        public void NonAsyncMethod()
        {
            using (var client = new BitfinexClient())
            {
                var result = client.GetPlatformStatus();
            }
        }

    }
}
