
namespace projeto04.Entities
{
    class Individual : TaxPayer
    {
        public double GastoSaude { get; set; }

        public Individual()
        {
        }

        public Individual(string nome, double rendaAnual, double gastoSaude)
            :base (nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double Tax()
        {
            if( RendaAnual < 20000.0)
            {
                return RendaAnual * 15 - GastoSaude * 0.5;
            }
            else
            {
                return RendaAnual * 0.25 - GastoSaude * 0.5;
            }
        }
    }
}
