using SeleniumFrameworkSimulation.Common.Prototype;

namespace SeleniumFrameworkSimulation.Models
{
    public class ComprobanteOPModel : AlborQaPrototype
    {
        public ComprobanteModel Comprobante { get; set; } = new ComprobanteModel();
        public int Tipo_Pago { get; set; }

        public string Observaciones { get; set; }

       

        public override AlborQaPrototype GetClon()
        {
            ComprobanteOPModel op = (ComprobanteOPModel)this.MemberwiseClone();
            op.Comprobante = new ComprobanteModel();
            op.Comprobante = (ComprobanteModel) this.Comprobante.GetClon();
            return (AlborQaPrototype)op;
        }

       
    }
}

