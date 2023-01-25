namespace Testing.Bakery
{
    public interface ICakeLogger
    {
        void Error(DateTime logTime, string message);
        void Info(DateTime logTime, string message);
    }
}