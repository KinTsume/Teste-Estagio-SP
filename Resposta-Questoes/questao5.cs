namespace Resposta_Questoes
{
    public static class questao5
    {
       public static void start(){
            Console.WriteLine("==========| Inversor de strings |==========");
            Console.WriteLine("Escreva um texto para ser invertido: ");
            var text = Console.ReadLine();
            var invertedText = invertString(text);
            Console.WriteLine($"Seu text invertido é:");
            Console.WriteLine(invertedText);
       }  

       private static string invertString(string text){

            string invertedString = "";

            for(int i = text.Length - 1; i >= 0; i--){
                invertedString += text[i];
            }

            return invertedString;

       }
    }
}