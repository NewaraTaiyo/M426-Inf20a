namespace Payroll
{
    public interface IEmployable
    {
        string GetFullName();
        float GetSalary();
        void AddNote(string type, string note);
        string GetNote(string type);
    }
}