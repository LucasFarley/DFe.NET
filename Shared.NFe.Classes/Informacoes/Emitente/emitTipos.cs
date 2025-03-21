﻿/********************************************************************************/
/* Projeto: Biblioteca ZeusNFe                                                  */
/* Biblioteca C# para emissão de Nota Fiscal Eletrônica - NFe e Nota Fiscal de  */
/* Consumidor Eletrônica - NFC-e (http://www.nfe.fazenda.gov.br)                */
/*                                                                              */
/* Direitos Autorais Reservados (c) 2014 Adenilton Batista da Silva             */
/*                                       Zeusdev Tecnologia LTDA ME             */
/*                                                                              */
/*  Você pode obter a última versão desse arquivo no GitHub                     */
/* localizado em https://github.com/adeniltonbs/Zeus.Net.NFe.NFCe               */
/*                                                                              */
/*                                                                              */
/*  Esta biblioteca é software livre; você pode redistribuí-la e/ou modificá-la */
/* sob os termos da Licença Pública Geral Menor do GNU conforme publicada pela  */
/* Free Software Foundation; tanto a versão 2.1 da Licença, ou (a seu critério) */
/* qualquer versão posterior.                                                   */
/*                                                                              */
/*  Esta biblioteca é distribuída na expectativa de que seja útil, porém, SEM   */
/* NENHUMA GARANTIA; nem mesmo a garantia implícita de COMERCIABILIDADE OU      */
/* ADEQUAÇÃO A UMA FINALIDADE ESPECÍFICA. Consulte a Licença Pública Geral Menor*/
/* do GNU para mais detalhes. (Arquivo LICENÇA.TXT ou LICENSE.TXT)              */
/*                                                                              */
/*  Você deve ter recebido uma cópia da Licença Pública Geral Menor do GNU junto*/
/* com esta biblioteca; se não, escreva para a Free Software Foundation, Inc.,  */
/* no endereço 59 Temple Street, Suite 330, Boston, MA 02111-1307 USA.          */
/* Você também pode obter uma copia da licença em:                              */
/* http://www.opensource.org/licenses/lgpl-license.php                          */
/*                                                                              */
/* Zeusdev Tecnologia LTDA ME - adenilton@zeusautomacao.com.br                  */
/* http://www.zeusautomacao.com.br/                                             */
/* Rua Comendador Francisco josé da Cunha, 111 - Itabaiana - SE - 49500-000     */
/********************************************************************************/
using System.ComponentModel;
using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Emitente
{
    /// <summary>
    ///     <para>1 – Simples Nacional;</para>
    ///     <para>2 – Simples Nacional – excesso de sublimite de receita bruta;</para>
    ///     <para>3 – Regime Normal. (v2.0).</para>
    /// </summary>
    public enum CRT
    {
        /// <summary>
        /// 1 – Simples Nacional
        /// </summary>
        [Description("Simples Nacional")]
        [XmlEnum("1")]
        SimplesNacional = 1,

        /// <summary>
        /// 2 – Simples Nacional – excesso de sublimite de receita bruta
        /// </summary>
        [Description("Simples Nacional – excesso de sublimite de receita bruta")]
        [XmlEnum("2")]
        SimplesNacionalExcessoSublimite = 2,

        /// <summary>
        /// 3 – Regime Normal
        /// </summary>
        [Description("Regime Normal")]
        [XmlEnum("3")]
        RegimeNormal = 3,

        /// <summary>
        /// 4 – Microempreendedor Individual (MEI)
        /// </summary>
        [Description("Microempreendedor Individual (MEI)")] //FIO-I1530
        [XmlEnum("4")]
        MicroempreendedorIndividual = 4
    }
}