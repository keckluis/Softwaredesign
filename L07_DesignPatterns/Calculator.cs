namespace L07_DesignPatterns
{
    public delegate void ReportProgressMethod(int progress);
    
    class Calculator
    {
        public event ReportProgressMethod ProgressMethod;
        public void CalculateSomething()
        {
            int i = 0;

            for(int j = 0; j < 100; j++)
            {
                for(int z = 0; z < 100; z++)
                {
                    i += j + z;
                }
                ProgressMethod(j);
            }
        }
    }
}