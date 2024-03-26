public class EmployeeBenefits
{
    int days = 30;
    //Later this property can be modified as per the requirement.
    public virtual int dayPay { get; set; } = 1500;
    public virtual int Salary()
    {
        return days * dayPay;
    }

}