using System.ComponentModel;

namespace TCC_CarteiraInvestimento.Entidades
{
    public class Empresa
    {
        public string Nome { get; set; }
        public Setor Setor { get; set; }
        public string Codigo { get; set; }
    }

    public enum Setor
    {
        [Description("Agropecuária")] Agropecuaria,
        [Description("Água e Saneamento")] AguaSaneamento,
        [Description("Alimentos")] Alimentos,
        [Description("Bebidas")] Bebidas,
        [Description("Comércio")] Comercio,
        [Description("Comércio e Distribuição")] ComercioDistribuicao,
        [Description("Computadores e Equipamento")] ComputadoresEquipamento,
        [Description("Construção e Engenharia")] ConstrucaoEngenharia,
        [Description("Diversos")] Diversos,
        [Description("Embalagens")] Embalagens,
        [Description("Energia Elétrica")] EnergiaEletrica,
        [Description("Equipamentos Elétricos")] EquipamentosEletricos,
        [Description("Financeiros")] Financeiros,
        [Description("Fumo")] Fumo,
        [Description("Gás")] Gas,
        [Description("Holdings Diversificadas")] HoldingsDiversificadas,
        [Description("Hoteis e Restaurantes")] HoteisRestaurantes,
        [Description("Madeira e Papel")] MadeiraPapel,
        [Description("Máquinas e Equipamentos")] MaquinasEquipamentos,
        [Description("Materiais Diversos")] MateriaisDiversos,
        [Description("Material de Transporte")] MaterialTransporte,
        [Description("Mídia")] Midia,
        [Description("Mineração")] Mineracao,
        [Description("Outros")] Outros,
        [Description("Petróleo, Gás e Biocombustíveis")] PetroleoGasBiocombustiveis,
        [Description("Previdência e Seguros")] PrevidenciaSeguros,
        [Description("Prods. de Uso Pessoal e de Limpeza")] ProdsUsoPessoalLimpeza,
        [Description("Programas e Serviços")] ProgramasServicos,
        [Description("Químicos")] Quimicos,
        [Description("Saúde")] Saude,
        [Description("Securitizadoras de Recebíveis")] SecuritizadorasRecebiveis,
        [Description("Serviços")] Servicos,
        [Description("Serviços Financeiros Diversos")] ServicosFinanceirosDiversos,
        [Description("Siderurgia e Metalurgia")] SiderurgiaMetalurgia,
        [Description("Tecidos, Vestuário e Calçados")] TecidosVestuarioCalcados,
        [Description("Telefonia Fixa")] TelefoniaFixa,
        [Description("Telefonia Móvel")] TelefoniaMovel,
        [Description("Transporte")] Transporte,
        [Description("Utilidades Domésticas")] UtilidadesDomesticas,
        [Description("Viagens e Lazer")] ViagensLazer,
        [Description("Exploração de Imóveis")] ExploracaoImoveis
    }
}
