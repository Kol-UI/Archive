public class ContractEmployee: EmployeeBenefits
{
    public override int Salary()
    {
        return base. Salary()+500;
    }
}