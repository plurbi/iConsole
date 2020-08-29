using SeleniumFrameworkSimulation.Common.Prototype;

namespace SeleniumFrameworkSimulation.Models
{
    public class ComprobanteModel : Prototype
    {
        public int Numero_Comprobante { get; set; }
        public int ID_Comprobantes { get; set; }

        public override Prototype GetClon()
        {
            return (Prototype)this.MemberwiseClone();
        }


    }
}
