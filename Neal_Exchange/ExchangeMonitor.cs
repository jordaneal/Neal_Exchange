namespace Neal_Exchange
{
    class ExchangeMonitor
    {
        private int _counter;
        private decimal _totalAmount;

        public string PrintOut()
        {
            return $"\n\n\tNumber of successful exchanges: {_counter}" +
                $"\n\n\tTotal Amount exchanged (USD):  {_totalAmount.ToString("C")}";
        }
        public string Run(int selection, decimal amount)
        {
            _counter++;
            UpdateTotal(selection, amount);
            return CurrencyConverter(selection, amount);
        }
        private void UpdateTotal(int selection, decimal amount)
        {
            if (selection < 4)
            {
                _totalAmount = _totalAmount + amount;
            }
            else if (selection > 3 && selection < 7)
            {
                _totalAmount = _totalAmount + Exchanger.GBPtoUSD(amount);
            }
            else if (selection > 6 && selection < 11)
            {
                _totalAmount = _totalAmount + Exchanger.CANtoUSD(amount);
            }
            else
            {
                _totalAmount = _totalAmount + Exchanger.EURtoUSD(amount);
            }
        }
        private string CurrencyConverter(int selection, decimal amount)
        {
            if (selection == 1)
            {
                return $"{amount.ToString("C")} USD " +
                        $"converted to {Exchanger.USDtoGBP(amount).ToString("C")} GBP";
            }
            else if (selection == 2)
            {
                return $"{amount.ToString("C")} USD " +
                        $"converted to {Exchanger.USDtoCAN(amount).ToString("C")} CAN";
            }
            else if (selection == 3)
            {
                return $"{amount.ToString("C")} USD " +
                        $"converted to {Exchanger.USDtoEUR(amount).ToString("C")} EUR";
            }
            else if (selection == 4)
            {
                return $"{amount.ToString("C")} GBP " +
                        $"converted to {Exchanger.GBPtoUSD(amount).ToString("C")} USD";
            }
            else if (selection == 5)
            {
                return $"{amount.ToString("C")} GBP " +
                        $"converted to {Exchanger.GBPtoCAN(amount).ToString("C")} CAN";
            }
            else if (selection == 6)
            {
                return $"{amount.ToString("C")} GBP " +
                        $"converted to {Exchanger.GBPtoEUR(amount).ToString("C")} EUR";
            }
            else if (selection == 7)
            {
                return $"{amount.ToString("C")} CAN " +
                        $"converted to {Exchanger.CANtoUSD(amount).ToString("C")} USD";
            }
            else if (selection == 8)
            {
                return $"{amount.ToString("C")} CAN " +
                        $"converted to {Exchanger.CANtoGBP(amount).ToString("C")} GBP";
            }
            else if (selection == 9)
            {
                return $"{amount.ToString("C")} CAN " +
                        $"converted to {Exchanger.CANtoEUR(amount).ToString("C")} EUR";
            }
            else if (selection == 10)
            {
                return $"{amount.ToString("C")} EUR " +
                        $"converted to {Exchanger.EURtoUSD(amount).ToString("C")} USD";
            }
            else if (selection == 11)
            {
                return $"{amount.ToString("C")} EUR " +
                        $"converted to {Exchanger.EURtoGBP(amount).ToString("C")} GBP";
            }
            else if (selection == 12)
            {
                return $"{amount.ToString("C")} EUR " +
                        $"converted to {Exchanger.EURtoCAN(amount).ToString("C")} CAN";
            }
            else
                return null;
        }
    }
}
