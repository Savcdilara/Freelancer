namespace Freelancer.Abstract
{
    public interface ICsvConvertible
    {
        string GetValuesCSV();
        void SetValuesCSV(string valuesCSV);
    }
}