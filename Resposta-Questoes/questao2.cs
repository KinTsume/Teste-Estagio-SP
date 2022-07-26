namespace Resposta_Questoes
{
    public static  class questao2
    {
        public static void start(){
            Console.WriteLine("==========| Sequência de Fibonacci |==========");
            Console.WriteLine("Digite um numero: ");
            var num = int.Parse(Console.ReadLine());

            var Sequence = calculateFibo(num);

            int? numberFound = Sequence.Find(a => a == num);
            bool isOnSequence = numberFound != 0 ? true : false;

            Console.WriteLine("Listando a sequência: ");
            foreach(int i in Sequence){
                Console.Write(i + " ");
            }
            Console.WriteLine();
            if(isOnSequence){
                Console.WriteLine("O número informado faz parte da sequência de Fibonacci!");
                return;
            }

            Console.WriteLine("O número informado não faz parte da sequência de Fibonacci!");

        }

        public static List<int> calculateFibo(int limiter){
            List<int> Sequence = new List<int>();
            Sequence.Add(0);
            Sequence.Add(1);

            var index = 2;
            while(limiter > Sequence[Sequence.Count - 1]){
                var sum = Sequence[index-1] + Sequence[index-2];
                Sequence.Add(sum);
                index++;

                //To prevent an infinite loop
                if(index > 500) break;
            }

            return Sequence;
        }
    }
}