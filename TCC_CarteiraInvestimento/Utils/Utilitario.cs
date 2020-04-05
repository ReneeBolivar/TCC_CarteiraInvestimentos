using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TCC_CarteiraInvestimento.Entidades;

namespace TCC_CarteiraInvestimento.Utils
{
    public static class Utilitario
    {
        public static T Clonar<T>(this T @object)
        {
            var deserializeSettings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace };

            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(@object), deserializeSettings);
        }

        public static int ObterNumeroRandom(int max, int min)
        {
            Thread.Sleep(100);
            return new Random().Next(min, max);
        }

        public static bool Equals(this Individuo individuo, Individuo individuoComparar)
        {
            foreach (var cromossomo in individuo.Cromossomos)
                if (!individuoComparar.Cromossomos.Contains(cromossomo))
                    return false;

            return true;
        }

        public static int RegraDeTres(int total, int parcial)
        {
            return (parcial * 100) / total;
        }
    }
}
