using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neal_Exchange
{
    class ExchangeMonitor
    {
        private int _counter;
        private decimal _totalAmount; 
        
        public string PrintOut()
        {
            return $"\n\n\tNumber of successful exchanges: {_counter}" +
                $"\n\tTotal Amount exchanged (USD):  {_totalAmount.ToString("C")}"; 
        }
        public decimal Run(int selection, decimal amount)
        {
            _counter++;
            TotalUpdater(selection, amount);
            return CurrencyConverter(selection, amount);
        }
        private void TotalUpdater(int selection, decimal amount)
        {
            if (selection > 0 && selection < 4)
            {
                _totalAmount = _totalAmount + amount;
            }
            else if (selection > 3 && selection < 7)
            {
                _totalAmount = _totalAmount + CurrencyConverter(4, amount);
            }
            else if (selection > 6 && selection < 11)
            {
                _totalAmount = _totalAmount + CurrencyConverter(7, amount);
            }
            else if (selection > 9 && selection < 13)
            {
                _totalAmount = _totalAmount + CurrencyConverter(10, amount);
            }
        }
        private decimal CurrencyConverter(int selection, decimal amount)
        {
            if (selection == 1)
            {
                return Exchanger.USDtoGBP(amount);
            }
            else if (selection == 2)
            {
                return Exchanger.USDtoCAN(amount);
            }
            else if (selection == 3)
            {
                return Exchanger.USDtoEUR(amount);
            }
            else if (selection == 4)
            {
                return Exchanger.GBPtoUSD(amount);
            }
            else if (selection == 5)
            {
                return Exchanger.GBPtoCAN(amount);
            }
            else if (selection == 6)
            {
                return Exchanger.GBPtoEUR(amount);
            }
            else if (selection == 7)
            {
                return Exchanger.CANtoUSD(amount);
            }
            else if (selection == 8)
            {
                return Exchanger.CANtoGBP(amount);
            }
            else if (selection == 9)
            {
                return Exchanger.CANtoEUR(amount);
            }
            else if (selection == 10)
            {
                return Exchanger.EURtoUSD(amount);
            }
            else if (selection == 11)
            {
                return Exchanger.EURtoGBP(amount);
            }
            else if (selection == 12)
            {
                return Exchanger.EURtoCAN(amount);
            }
            else
                return 0;
        }
    }
}
