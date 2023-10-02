using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Currency
    {
        protected double amount_value;
        protected string currency_value;
        public double AmountValue
        { get; set; }
        public string CurrencyValue
        { get; set; }
        public Currency(double AmountValue, string CurrencyValue)
        {
            this.amount_value = AmountValue;
            this.currency_value = CurrencyValue;
        }

        public virtual double Amount_Definition() { return AmountValue; }
    }
    class CurrencyUSD : Currency
    {
        public CurrencyUSD(double amount_value, string currency_value) : base(amount_value, currency_value) { }
        public override double Amount_Definition()
        {
            if (currency_value == "RUB")
            {
                return amount_value * 0.00968992; // курс на 2 октября
            }
            else if (CurrencyValue == "EUR")
            {
                return AmountValue * 1.02326;
            }
            else { return AmountValue; }
        }
    }
    class CurrencyEUR : Currency
    {
        public CurrencyEUR(double amount_value, string currency_value) : base(amount_value, currency_value) { }
        public override double Amount_Definition()
        {
            if (this.currency_value == "USD")
            {
                return this.amount_value * 0.97727;
            }
            else if (this.currency_value == "RUB")
            {
                return this.amount_value * 0.0094697;
            }
            else { return this.amount_value; }
        }
    }
    class CurrencyRUB : Currency
    {
        public CurrencyRUB(double amount_value, string currency_value) : base(amount_value, currency_value) { }
        public override double Amount_Definition()
        {
            if (this.currency_value == "USD")
            {
                return this.amount_value * 103.2;
            }
            else if (this.currency_value == "EUR")
            {
                return this.amount_value * 105.6;
            }
            else { return this.amount_value; }
        }
    }
}
