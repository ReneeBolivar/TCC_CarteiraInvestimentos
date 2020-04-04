namespace TCC_CarteiraInvestimento.Entidades
{
    public class AnaliseFundamentalista
    {
        /// <summary>
        /// Representa o número de anos que o investidor levaria para recuperar um investimento. Ou seja, uma empresa que apresenta um P/L de 12, significa que em 12 anos você recuperaria todo o seu capital investido, caso o lucro anual da empresa se mantiver estável
        /// </summary>
        public float? PL { get; set; }

        /// <summary>
        /// Representa a relação do preço da ação ao valor patrimonial proporcional a ela. Indica quanto os acionistas estão dispostos a pagar pelo patrimônio líquido da companhia. Fórmula(Preço / Valor Patrimonial da Ação)
        /// </summary>
        public float? PVPA { get; set; }

        /// <summary>
        /// Relação entre o preço com o fluxo de caixa operacional. Representa o quanto o acionista está pagando, por ação, pelo caixa gerado pela empresa.
        /// </summary>
        public float? PFCO { get; set; }

        /// <summary>
        /// Representa o quanto em porcentagem o acionista recebeu de dividendos no ano, sobre a cotação de uma ação.
        /// </summary>
        public float? DY { get; set; }

        /// <summary>
        /// O índice Preço/Vendas, quanto menor for o PSR, à partida mais atrativo é o investimento. É um indicador simples que mostra como o mercado valoriza cada unidade monetária do volume de negócios da empresa.
        /// </summary>
        public float? PSR { get; set; }

        /// <summary>
        /// Indicador que ajuda a retornar a medida de valorização de cada empresa. É utilizado com frequência na comparação dos níveis de valorização dentro de uma mesma empresa.
        /// </summary>
        public float? EVEBIT { get; set; }

        /// <summary>
        /// Representa o Retorno sobre o Patrimônio Líquido, informa a porcentagem de lucros que a empresa está gerando sobre o seu patrimônio. Fórmula (Lucro Liquido / Patrimônio Liquido)
        /// </summary>
        public float? ROE { get; set; }

        /// <summary>
        /// Retorne no Capital Investido (ROIC) mede o retorno sobre o capital investido pelo investidor.
        /// </summary>
        public float? ROIC { get; set; }

        /// <summary>
        /// Liquidez corrente, Este indicador mostra a capacidade de pagamento das obrigações de curto prazo da empresa. Por exemplo, uma empresa com liquidez corrente igual a 3, significa que para cada 1 real que a empresa terá que pagar no curto prazo, ela possui em caixa 3 reais.
        /// </summary>
        public float? LC { get; set; }

        /// <summary>
        /// Este indicador mostra o quanto o endividamento da empresa está alavancado sobre o patrimônio da empresa. Um indicador igual a 3 por exemplo, significa que a empresa possui um endividamento 3x superior ao patrimônio da empresa.
        /// </summary>
        public float? DBPL { get; set; }

        /// <summary>
        /// Representa a parcela do lucro líquido pertencente a cada ação, sendo que sua distribuição aos acionistas é definida pela política de dividendos adotada pela companhia
        /// </summary>
        public float? LPA { get; set; }

        /// <summary>
        /// Representa o valor patrimonial por ação, ou seja, o valor da empresa do ponto de vista dos acionistas dividido pelo número de ações emitidas.
        /// </summary>
        public float? VPA { get; set; }

        /// <summary>
        /// Representa o total de dividendos pagos por ação a todos acionista de uma determinada empresa.
        /// </summary>
        public float? DPA { get; set; }
    }
}
