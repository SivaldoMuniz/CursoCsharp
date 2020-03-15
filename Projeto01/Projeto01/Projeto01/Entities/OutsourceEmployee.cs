

namespace Projeto01.Entities
{
    class OutsourceEmployee : Employee
    {
        public double AddtionalCharge { get; set; }

        public OutsourceEmployee()
        {
        }

        public OutsourceEmployee(string name, int hours, double valuePerHour, double addtionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AddtionalCharge = addtionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AddtionalCharge;
        }
    }
}
