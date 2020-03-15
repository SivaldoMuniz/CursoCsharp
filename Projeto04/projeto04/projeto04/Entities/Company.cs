namespace projeto04.Entities
{
    class Company :TaxPayer
    {
        public int NumerosDeFuncionarios { get; set; }
    
        /*Contrustor sem argumentos*/
        public Company()
        {
        }

        public Company(string nome, double rendaAnual, int numerosDeEmpregados)
            : base (nome, rendaAnual)
        {
            NumerosDeFuncionarios = numerosDeEmpregados;
        }

        public override double Tax()
        {
            if (NumerosDeFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }

            else
            {
                return RendaAnual * 0.16;
            }
        }
    }




}
