namespace Resposta_Questoes
{
    public static class questao4
    {
        public static void start(){

             Console.WriteLine("==========| Faturamento de uma distribuidora |==========");

            var data = new State[]{
                new State{
                    Name = "SP",
                    Earnings = 67836.43f
                },
                new State{
                    Name = "RJ",
                    Earnings = 36678.66f
                },
                new State{
                    Name = "MG",
                    Earnings = 29229.88f
                },
                new State{
                    Name = "ES",
                    Earnings = 27165.48f
                },
                new State{
                    Name = "Outros",
                    Earnings = 19849.53f
                }
            };

            float total = 0;
            foreach(State s in data){
                total += s.Earnings;
            }

            foreach(State s in data){
                var percentual = s.Earnings  * 100 / total;
                Console.WriteLine($"Em {s.Name} foi alcançada uma participação de {percentual}%");
            }
            
        } 

        private class State{
            public string Name { get; set; }
            public float Earnings { get; set; }
            
        }
    }
}