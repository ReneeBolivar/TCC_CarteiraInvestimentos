using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public static int ObterNumeroRandom(int min, int max)
        {
            Thread.Sleep(50); //Aguarda 50ms para evitar gerar valores dentro de um intervalo curto onde seja possivel ter duas ou mais saídas iguais
            return new Random().Next(min, max);
        }

        public static bool AreEquals(this Individuo individuo, Individuo individuoComparar)
        {
            foreach (var cromossomo in individuo.Cromossomos)
                if (!individuoComparar.Cromossomos.Contains(cromossomo))
                    return false;

            return true;
        }

        public static string ObterDescricaoEnum<T>(this T @enum)
        {
            var memberInfo = @enum.GetType().GetMember(@enum.ToString());
            if (memberInfo.Length > 0)
            {
                var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return @enum.ToString();
        }

        public static int RegraDeTres(int total, int parcial)
            => (int)Math.Floor( (decimal)((parcial * 100) / total) );
    }
}
