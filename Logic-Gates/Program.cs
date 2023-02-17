using System;

namespace Program
{
    class LogicGate
    {
        private bool value1 { get; set; }
        private bool value2 { get; set; }

        public LogicGate(int value1, int value2)
        {
            if (value1 == 0)
            {
                this.value1 = false;
            }
            else
            {
                this.value1 = true;
            }
            if (value2 == 0)
            {
                this.value2 = false;
            }
            else
            {
                this.value2 = true;
            }
        }
        public bool Or()
        {
            if (this.value1 || this.value2)
            {
                return true;
            }
            return false;

        }
        public bool And()
        {
            if (this.value1 && this.value2)
            {
                return true;
            }
            return false;
        }
        public bool Xor()
        {
            if (this.value1 == false && this.value2 == false)
            {
                return false;
            }
            if ((this.value1 && this.value2) && (this.value1 || this.value2))
            {
                return false;
            }
            return true;
        }
        public bool Nand()
        {
            if (this.value1 && this.value2)
            {
                return false;
            }
            return true;
        }
        public bool Nor()
        {
            if (this.value1 == false && this.value2 == false)
            {
                return true;
            }
            return false;
        }

    }
}