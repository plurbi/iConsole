using SeleniumFrameworkSimulation.Common;

namespace SeleniumFrameworkSimulation.Models
{
    public class ComprobanteModel : Prototype
    {
        public int Numero_Comprobante { get; set; }
        public int ID_Comprobantes { get; set; }

        public override Prototype DeepCopy()
        {
            throw new System.NotImplementedException();
        }

        public override Prototype ShallowCopy()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
