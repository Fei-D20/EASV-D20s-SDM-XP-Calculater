using System;

namespace EASV_D20s_SDM_XP_Calculater
{
    public class IntCalculator : IFIntCalculator
    {
        public int Result { get; private set; }
        
        
        public void Reset()
        {
            Result = 0;
        }

        public void Add(int x)
        {
            if (x >= 0 && (Result + x) < Result)
            {
                throw new InvalidOperationException("OverFlow Boy");
            }
            
            if (x < 0 && (Result + x) > Result)
            {
                throw new InvalidOperationException("UnderFlow Boy");
            }
            
            Result += x;
        }

        public void Subtract(int x)
        {
           Result -= x;
        }

        public void Multiply(int x)
        {
            Result = Result * x;
        }

        public void Divide(int x)
        {
            if (x == 0)
            {
                throw new InvalidOperationException("Value Can not be 0");
            }

            Result = Result / x;
        }

        public void Modulus(int x)
        {
            
        }
    }
}