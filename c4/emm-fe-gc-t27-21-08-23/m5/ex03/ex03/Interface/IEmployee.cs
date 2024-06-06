namespace ex03.Interface
{
    interface IEmployee
    {
        string Name { get; }
        double CalculateGrossMonthly();
        double CalculateNetMonthly();
        double CalculateGrossAnnual();
        double CalculateNetAnnual();
        void EmitBonus();
    }
}

