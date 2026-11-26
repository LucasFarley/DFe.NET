using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.Compartilhado
{
    /// <summary>
    ///     UB01 - Imposto Seletivo do item
    /// </summary>
    public class IS
    {
        private decimal? _vBcIs;
        private decimal? _pIs;
        private decimal? _vIs;

        /// <summary>
        ///     UB05 - Base de cálculo do IS
        /// </summary>
        public decimal? vBCIS
        {
            get { return _vBcIs.Arredondar(2); }
            set { _vBcIs = value.Arredondar(2); }
        }

        public bool ShouldSerializevBCIS()
        {
            return vBCIS.HasValue;
        }

        /// <summary>
        ///     UB06 - Alíquota do IS
        /// </summary>
        public decimal? pIS
        {
            get { return _pIs; }
            set { _pIs = value; }
        }

        public bool ShouldSerializepIS()
        {
            return pIS.HasValue;
        }

        /// <summary>
        ///     UB11 - Valor do IS
        /// </summary>
        public decimal? vIS
        {
            get { return _vIs.Arredondar(2); }
            set { _vIs = value.Arredondar(2); }
        }

        public bool ShouldSerializevIS()
        {
            return vIS.HasValue;
        }
    }

    /// <summary>
    ///     UB12 - IBS e CBS do item
    /// </summary>
    public class IBSCBS
    {
        /// <summary>
        ///     UB13 - CST do IBS/CBS
        /// </summary>
        public string CST { get; set; }

        /// <summary>
        ///     UB14 - Classificação tributária do IBS/CBS
        /// </summary>
        public string cClassTrib { get; set; }

        /// <summary>
        ///     UB15 - Grupo de tributação do IBS e da CBS
        /// </summary>
        public InformacoesIbsCbs.gIBSCBS gIBSCBS { get; set; }
    }
}

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.Compartilhado.InformacoesIbsCbs
{
    public class gIBSCBS
    {
        private decimal? _vBc;

        /// <summary>
        ///     UB16 - Base de cálculo do IBS e da CBS
        /// </summary>
        public decimal? vBC
        {
            get { return _vBc.Arredondar(2); }
            set { _vBc = value.Arredondar(2); }
        }

        public bool ShouldSerializevBC()
        {
            return vBC.HasValue;
        }

        [XmlElement("gIBSUF")]
        public gIBSUF gIBSUF { get; set; }

        [XmlElement("gIBSMun")]
        public gIBSMun gIBSMun { get; set; }

        [XmlElement("gCBS")]
        public gCBS gCBS { get; set; }
    }

    public class gIBSUF
    {
        private decimal? _vIbsUf;

        /// <summary>
        ///     UB18 - Alíquota do IBS UF
        /// </summary>
        public decimal? pIBSUF { get; set; }

        public bool ShouldSerializepIBSUF()
        {
            return pIBSUF.HasValue;
        }

        public gRed gRed { get; set; }

        /// <summary>
        ///     UB35 - Valor do IBS UF
        /// </summary>
        public decimal? vIBSUF
        {
            get { return _vIbsUf.Arredondar(2); }
            set { _vIbsUf = value.Arredondar(2); }
        }

        public bool ShouldSerializevIBSUF()
        {
            return vIBSUF.HasValue;
        }
    }

    public class gIBSMun
    {
        private decimal? _vIbsMun;

        /// <summary>
        ///     UB37 - Alíquota do IBS Município
        /// </summary>
        public decimal? pIBSMun { get; set; }

        public bool ShouldSerializepIBSMun()
        {
            return pIBSMun.HasValue;
        }

        public gRed gRed { get; set; }

        /// <summary>
        ///     UB54 - Valor do IBS Município
        /// </summary>
        public decimal? vIBSMun
        {
            get { return _vIbsMun.Arredondar(2); }
            set { _vIbsMun = value.Arredondar(2); }
        }

        public bool ShouldSerializevIBSMun()
        {
            return vIBSMun.HasValue;
        }
    }

    public class gCBS
    {
        private decimal? _vCbs;

        /// <summary>
        ///     UB56 - Alíquota da CBS
        /// </summary>
        public decimal? pCBS { get; set; }

        public bool ShouldSerializepCBS()
        {
            return pCBS.HasValue;
        }

        public gRed gRed { get; set; }

        /// <summary>
        ///     UB67 - Valor da CBS
        /// </summary>
        public decimal? vCBS
        {
            get { return _vCbs.Arredondar(2); }
            set { _vCbs = value.Arredondar(2); }
        }

        public bool ShouldSerializevCBS()
        {
            return vCBS.HasValue;
        }
    }

    public class gRed
    {
        /// <summary>
        ///     Alíquota efetiva após redução
        /// </summary>
        public decimal? pAliqEfet { get; set; }

        public bool ShouldSerializepAliqEfet()
        {
            return pAliqEfet.HasValue;
        }
    }
}
