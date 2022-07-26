using System.Text.Json;

namespace Resposta_Questoes
{
    public static class questao3
    {
        public static void start(){

            Console.WriteLine("==========| Faturamento |==========");

            var data = Deserialize();
            var orderedData = data.OrderBy(a => a.valor).ToList();

            var sum = 0f;
            foreach(dadosModel dados in orderedData){
                sum += dados.valor;
            }
            var average = sum / data.Count;

            var daysCount = 0;

            foreach(dadosModel dados in orderedData){
                if(dados.valor > average) daysCount++;
            }

            Console.WriteLine($"O menor valor de faturamento foi {orderedData[0].valor}R$ no dia {orderedData[0].dia}");
            Console.WriteLine($"O maior valor de faturamento foi {orderedData[orderedData.Count - 1].valor}R$ no dia {orderedData[orderedData.Count - 1].dia}");
            Console.WriteLine($"Durante o mês o faturamento diário superou a média mensal em {daysCount} dias");
        }

        public static List<dadosModel> Deserialize()
        {
            var filePath = "Questao 3 - adicional/dados.json";
            var text = JsonDocument.Parse(File.ReadAllText(filePath));
            var list = JsonSerializer.Deserialize<List<dadosModel>>(text);
            return list;
        }
    }
}