namespace LoquatMegaStore
{
    using System;

    public class NegativeValueException : ApplicationException
    {
        public bool ZeroValueOk { get; set; }
        
        public NegativeValueException(string message)
            : base(message)
        {
        }

        public NegativeValueException(string message, bool zeroOk)
            : base(message)
        {
            this.ZeroValueOk = zeroOk;
        }
    }
}
