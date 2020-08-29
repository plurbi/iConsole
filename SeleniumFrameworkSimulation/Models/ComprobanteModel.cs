using SeleniumFrameworkSimulation.Common.Prototype;

namespace SeleniumFrameworkSimulation.Models
{
    public class ComprobanteModel : AlborQaPrototype
    {
        public int Numero_Comprobante { get; set; }
        public int ID_Comprobantes { get; set; }

        public override AlborQaPrototype GetClon()
        {
            return (AlborQaPrototype)this.MemberwiseClone();
        }


    }
}
