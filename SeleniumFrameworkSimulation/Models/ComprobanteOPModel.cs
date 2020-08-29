using SeleniumFrameworkSimulation.Common;

namespace SeleniumFrameworkSimulation.Models
{
    public class ComprobanteOPModel : Prototype
    {
        public ComprobanteModel Comprobante { get; set; } = new ComprobanteModel();
        public int Tipo_Pago { get; set; }

        public string Observaciones { get; set; }

        public override Prototype DeepCopy()
        {
            var op = (ComprobanteOPModel)this.MemberwiseClone();
            op.Comprobante = new ComprobanteModel();
            op.Comprobante = (ComprobanteModel) this.Comprobante.ShallowCopy();
            return (Prototype)op;
        }

        public override Prototype ShallowCopy()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}

