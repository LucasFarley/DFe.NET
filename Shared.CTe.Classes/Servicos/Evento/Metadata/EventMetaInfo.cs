using CTe.Classes.Servicos.Evento.Flags;


namespace CTe.Classes.Servicos.Evento.Metadata
{
    /// <summary>
    /// Classe responsável pelos dados de eventos
    /// </summary>
    public class EventMetaInfo
    {
        /// <summary>
        /// Nome do Evento
        /// </summary>
        public string Name { get; set; }

        private string _shortName { get; set; }
        /// <summary>
        /// Nome do Evento abreviado
        /// </summary>
        public string ShortName { get => _shortName ?? Name?.ToLower(); protected set => _shortName = value; }

        /// <summary>
        /// Nome do evento em caixa alta
        /// </summary>
        public string UpperCaseName { get => Name?.ToUpper(); }
        /// <summary>
        /// Se o nme do evento é um nome feminino ou não. Serve para incluir corretamente conectivos relacionados ao sexo (da, do).
        /// </summary>
        private bool FemaleName { get; set; } = true;
        /// <summary>
        /// Se o evento é de uma nota fiscal
        /// </summary>
        public bool IsNfe { get; } = false;

        public EventMetaInfo(CTeTipoEvento tipoEvt)
        {
            SetEventNames(tipoEvt);
        }
        
        public EventMetaInfo(CTeTipoEvento tipoEvt, bool isNfe)
        {
            IsNfe = isNfe;
            SetEventNames(tipoEvt);
        }

        /// <summary>
        /// Atribui os dados de eventos baseado no seu tipo
        /// </summary>
        /// <param name="tipoEvt">Tipo do evento</param>
        private void SetEventNames(CTeTipoEvento tipoEvt)
        {
            switch (tipoEvt)
            {
                case CTeTipoEvento.Cancelamento:
                    Name = IsNfe ? "Cancelamento de NF-e" : "Cancelamento de CT-e";
                    FemaleName = false;
                    break;
                case CTeTipoEvento.EPEC:
                    Name = "EPEC";
                    break;
                case CTeTipoEvento.RegistrosdoMultimodal:
                    Name = "Registros do Multimodal";
                    break;
                case CTeTipoEvento.InformacoesdaGTV:
                    Name = "Informações da GTV";
                    break;
                case CTeTipoEvento.ComprovantedeEntrega:
                    Name = "Comprovante de Entrega";
                    break;
                case CTeTipoEvento.CancelamentodoComprovantedeEntrega:
                    Name = "Cancelamento do Comprovante de Entrega";
                    break;
                case CTeTipoEvento.RegistrodePassagem:
                    Name = "Registro de Passagem";
                    break;
                case CTeTipoEvento.RegistrodePassagemAutomatico:
                    Name = "Registro de Passagem Automático";
                    break;
                case CTeTipoEvento.AutorizadoCTecomplementar:
                    Name = "Autorização de CT-e complementar";
                    break;

                case CTeTipoEvento.CanceladoCTecomplementar:
                    Name = "Cancelamento de CT-e complementar";
                    break;
                case CTeTipoEvento.LiberacaodeEPEC:
                    Name = "Liberação de EPEC";
                    break;
                case CTeTipoEvento.LiberacaoPrazoCancelamento:
                    Name = "Liberação do Prazo de Cancelamento";
                    break;
                case CTeTipoEvento.AutorizadoRedespacho:
                    Name = "Autorização de Redespacho";
                    break;
                case CTeTipoEvento.AutorizadoRedespachointermediario:
                    Name = "Autorização de Redespacho";
                    break;

                case CTeTipoEvento.AutorizadoSubcontratacao:
                    Name = "Autorização de Subcontraração";
                    break;

                case CTeTipoEvento.AutorizadoServicoVinculadoMultimodal:
                    Name = "Autorização de Serviço Vinculado Multimodal";
                    break;
                case CTeTipoEvento.Desacordo:
                    Name = "Prestação de Serviço em Desacordo";
                    break;
                case CTeTipoEvento.MDFeCancelado:
                    Name = "Cancelamento de MDF-e";
                    FemaleName = false;
                    break;
                case CTeTipoEvento.MDFeAutorizado:
                    Name = "Autorização de MDF-e";
                    break;
                default: // se não bater com as anteriores seta como carta de correção
                    Name = "Carta de Correção Eletrônica";
                    ShortName = "CC-e";
                    break;
            }
        }
        /// <summary>
        /// Gera uma mensagem referente a checagem de autenticidade dos dados no site da Sefaz
        /// </summary>
        /// <returns>Retorna a mensagem de checagem de autenticidade com o nome do evento gerador.</returns>
        public string GetCheckAuthenticityMessage()
        {
            string message = "CONSULTE A AUTENTICIDADE DO ";


            message = ChangeMessageToMaleOrFemale(message);
            message += $"{UpperCaseName} NO SITE DA SEFAZ AUTORIZADORA";

            return message;
        }

        /// <summary>
        /// Gera uma mensagem referente a falta de valor fiscal do documento
        /// </summary>
        /// <returns>Retorna a mensagem referente a falta de valor fiscal do documento com o nome do evento gerador.</returns>
        public string GetNoTaxValueMessage()
        {
            string message = "Não possui valor fiscal, simples representação do ";

            message = ChangeMessageToMaleOrFemale(message);
            message += $"{ShortName} indicado abaixo.";
            
            return message;
        }

        /// <summary>
        /// Modifica a mensagem alterando as preposições baseadas no nome do evento, se feminino ou masculino
        /// </summary>
        /// <param name="message">Mensagem com pronomes a serem alterados, ou não.</param>
        /// <returns>Retorna a mensagem corrigida com pronomes no feminino ou masculino, baseado no nome do evento.</returns>
        private string ChangeMessageToMaleOrFemale(string message)
        {
            if (FemaleName)
            {
                message = message.Replace("DO ", "DA ");
                message = message.Replace("do ", "da ");
            }

            return message;
        }
    }
}
