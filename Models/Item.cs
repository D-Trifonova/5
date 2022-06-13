namespace A_Work_5_API.Models
{
    public class Item
    {
        public long Id { get; set; }

        public string? CurrencyMark { get; set; }

        public double Currency { get; set; }

        public byte TimePeriod { get; set; }

        public double FinalIncome { get => Currency; }
    }
}