﻿using System;

namespace TCC_CarteiraInvestimento.Gestores
{
    public static class GestorConfiguracao
    {
        #region Configuração de população

        /// <summary>
        /// Representa quantos individuos terá em uma população
        /// </summary>
        public static int IndividuosNaPopulacao = 250;

        /// <summary>
        /// Representa quantos cromossomos terá em um indivíduo
        /// </summary>
        public static int CromossomosPorIndividuos = 5;

        /// <summary>
        /// Representa quantos individuos serão mutados
        /// </summary>
        public static int IndividuosASeremMutados = 3;

        #endregion

        #region Configuração de filtro

        /// <summary>
        /// Representa qual o ano a ser utilizado para o treinamento
        /// </summary>
        public static int AnoTreinamento = 2017;

        /// <summary>
        /// Representa qual o trimestre a ser utilicado para o treinamento
        /// </summary>
        public static int TrimestreTreinamento = 4;

        #endregion

        #region Configuração de seleção

        /// <summary>
        /// Representa a quantidade de individuos escolhidos via elitismo
        /// </summary>
        public static int Elitismo = (int)Math.Floor(IndividuosNaPopulacao * 0.05f);

        /// <summary>
        /// Representa a quantidade de individuos escolhidos via torneio
        /// </summary>
        public static int Torneio = (int)Math.Floor(IndividuosNaPopulacao * 0.90f);

        /// <summary>
        /// Representa a quantidade de individuos dizimados
        /// </summary>
        public static int Dizimacao = (int)Math.Floor(IndividuosNaPopulacao * 0.05f);

        #endregion
    }
}
