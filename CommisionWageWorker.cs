using PayrolSystem;

namespace C_sharp_laba_5;

public class CommissionWageWorker : Worker
{
    public int Salary { get; init; }
    public int Percentage { get; init; }
    public override Gender Description { get; init; }
    public override string FullName { get; init; }

    public CommissionWageWorker(ref string _fullName, Gender _gender, int _salary, int _percentage)
        : base(ref _fullName, _gender) 
    {     
        Salary = _salary;
        Percentage = _percentage;
        goodsSoldSum = 0;
    }

    public override void Work(int goodsSold)
    {
        goodsSoldSum += goodsSold;
    }

    public override int CalculateWage()
    {
        var wage = 0;
        var addition = (int)((float)goodsSoldSum * (float)Percentage / 100);

        if (addition != 0)
            wage = Salary + addition;

        goodsSoldSum = 0;

        return wage;
    }
    
    private static int goodsSoldSum;

}