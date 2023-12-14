/********************************************************************************/
/* Projeto: Biblioteca ZeusNFe                                                  */
/* Biblioteca C# para emiss�o de Nota Fiscal Eletr�nica - NFe e Nota Fiscal de  */
/* Consumidor Eletr�nica - NFC-e (http://www.nfe.fazenda.gov.br)                */
/*                                                                              */
/* Direitos Autorais Reservados (c) 2014 Adenilton Batista da Silva             */
/*                                       Zeusdev Tecnologia LTDA ME             */
/*                                                                              */
/*  Voc� pode obter a �ltima vers�o desse arquivo no GitHub                     */
/* localizado em https://github.com/adeniltonbs/Zeus.Net.NFe.NFCe               */
/*                                                                              */
/*                                                                              */
/*  Esta biblioteca � software livre; voc� pode redistribu�-la e/ou modific�-la */
/* sob os termos da Licen�a P�blica Geral Menor do GNU conforme publicada pela  */
/* Free Software Foundation; tanto a vers�o 2.1 da Licen�a, ou (a seu crit�rio) */
/* qualquer vers�o posterior.                                                   */
/*                                                                              */
/*  Esta biblioteca � distribu�da na expectativa de que seja �til, por�m, SEM   */
/* NENHUMA GARANTIA; nem mesmo a garantia impl�cita de COMERCIABILIDADE OU      */
/* ADEQUA��O A UMA FINALIDADE ESPEC�FICA. Consulte a Licen�a P�blica Geral Menor*/
/* do GNU para mais detalhes. (Arquivo LICEN�A.TXT ou LICENSE.TXT)              */
/*                                                                              */
/*  Voc� deve ter recebido uma c�pia da Licen�a P�blica Geral Menor do GNU junto*/
/* com esta biblioteca; se n�o, escreva para a Free Software Foundation, Inc.,  */
/* no endere�o 59 Temple Street, Suite 330, Boston, MA 02111-1307 USA.          */
/* Voc� tamb�m pode obter uma copia da licen�a em:                              */
/* http://www.opensource.org/licenses/lgpl-license.php                          */
/*                                                                              */
/* Zeusdev Tecnologia LTDA ME - adenilton@zeusautomacao.com.br                  */
/* http://www.zeusautomacao.com.br/                                             */
/* Rua Comendador Francisco jos� da Cunha, 111 - Itabaiana - SE - 49500-000     */
/********************************************************************************/
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual
{
    public class ICMS61 : ICMSBasico
    {
        private decimal? _qBCMonoRet;
        private decimal? _adRemICMSRet;
        private decimal? _vICMSMonoRet;

        /// <summary>
        ///     N11 - Origem da Mercadoria
        /// </summary>
        [XmlElement(Order = 1)]
        public OrigemMercadoria orig { get; set; }

        /// <summary>
        ///     N12- Situa��o Tribut�ria
        /// </summary>
        [XmlElement(Order = 2)]
        public Csticms CST { get; set; }

        /// <summary>
        ///     N43a - Quantidade tributada retida anteriormente
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal? qBCMonoRet
        {
            get { return _qBCMonoRet.Arredondar(4); }
            set { _qBCMonoRet = value.Arredondar(4); }
        }

        public bool ShouldSerializeqBCMonoRet()
        {
            return qBCMonoRet.HasValue;
        }

        /// <summary>
        ///     N44 - Al�quota ad rem do imposto retido anteriormente
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal? adRemICMSRet
        {
            get { return _adRemICMSRet.Arredondar(4); }
            set { _adRemICMSRet = value.Arredondar(4); }
        }

        /// <summary>
        ///     N45 - Valor do ICMS retido anteriormente
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal? vICMSMonoRet
        {
            get { return _vICMSMonoRet.Arredondar(2); }
            set { _vICMSMonoRet = value.Arredondar(2); }
        }

    }
}