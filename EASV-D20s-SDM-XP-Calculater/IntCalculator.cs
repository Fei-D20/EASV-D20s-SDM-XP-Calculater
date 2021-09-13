namespace EASV_D20s_SDM_XP_Calculater
{
    public class IntCalculator : IFIntCalculator
    {
        public int Result { get; }

        public IntCalculator()
        {
            Result = 0;
        }
        
        public void Reset()
        {
            

        }

        public void Add(int x)
        {
            Result++;
        }

        public void Subtract(int x)
        {
            newResult = Result - x;
        }

        public void Multiply(int x)
        {
            newResult = Result * x;
        }

        public void Divide(int x)
        {
            newResult = Result / x;
        }

        public void Modulus(int x)
        {
            newResult = Result % x;
        }
    }
}