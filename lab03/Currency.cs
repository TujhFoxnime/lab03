using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Currency
    {
        public double Value { get; set; }
        public Currency(double value)
        {
            Value = value;
        }
    }
    class CurrencyUSD : Currency
    {
        public double ExchangeRate { get; set; }
        public CurrencyUSD(double value, double exchange_rate) : base(value) { ExchangeRate = exchange_rate; }

        public static implicit operator CurrencyEUR(CurrencyUSD usd)
        {
            return new CurrencyEUR(usd.Value * usd.ExchangeRate / CurrencyConverter.EURtoUSD, CurrencyConverter.EURtoUSD);
        }

        public static implicit operator CurrencyRUB(CurrencyUSD usd)
        {
            return new CurrencyRUB(usd.Value * usd.ExchangeRate / CurrencyConverter.RUBtoUSD, CurrencyConverter.RUBtoUSD);
        }
    }
    class CurrencyEUR : Currency
    {
        public double ExchangeRate { get; set; }
        public CurrencyEUR(double value, double exchange_rate) : base(value) { ExchangeRate = exchange_rate; }

        public static implicit operator CurrencyUSD(CurrencyEUR eur)
        {
            return new CurrencyUSD(eur.Value * eur.ExchangeRate / CurrencyConverter.USDtoEUR, CurrencyConverter.USDtoEUR);
        }

        public static implicit operator CurrencyRUB(CurrencyEUR eur)
        {
            return new CurrencyRUB(eur.Value * eur.ExchangeRate / CurrencyConverter.RUBtoEUR, CurrencyConverter.RUBtoEUR);
        }
    }
    class CurrencyRUB : Currency
    {
        public double ExchangeRate { get; set; }
        public CurrencyRUB(double value, double exchange_rate) : base(value) { ExchangeRate = exchange_rate; }
        
        public static implicit operator CurrencyEUR(CurrencyRUB rub)
        {
            return new CurrencyEUR(rub.Value * rub.ExchangeRate / CurrencyConverter.EURtoRUB, CurrencyConverter.EURtoRUB);
        }

        public static implicit operator CurrencyUSD(CurrencyRUB rub)
        {
            return new CurrencyUSD(rub.Value * rub.ExchangeRate / CurrencyConverter.USDtoRUB, CurrencyConverter.USDtoRUB);
        }
    }
    public static class CurrencyConverter
    {
        public static double USDtoEUR { get; set; } = 0.85;
        public static double EURtoUSD { get; set; } = 1.18;
        public static double USDtoRUB { get; set; } = 74.21;
        public static double RUBtoUSD { get; set; } = 0.013;
        public static double EURtoRUB { get; set; } = 87.37;
        public static double RUBtoEUR { get; set; } = 0.011;

        public static void SetExchangeRates(double usdToEur, double eurToUsd, double usdToRub, double rubToUsd, double eurToRub, double rubToEur)
        {
            USDtoEUR = usdToEur;
            EURtoUSD = eurToUsd;
            USDtoRUB = usdToRub;
            RUBtoUSD = rubToUsd;
            EURtoRUB = eurToRub;
            RUBtoEUR = rubToEur;
        }
    }
}
