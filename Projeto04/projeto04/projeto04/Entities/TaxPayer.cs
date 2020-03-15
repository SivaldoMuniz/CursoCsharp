
namespace projeto04.Entities
{
    abstract class TaxPayer
    {
        public string Nome { get; set; }
        public double RendaAnual{ get; set; }

        public TaxPayer()
        {
        }

        protected TaxPayer(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Tax();
    }
}
