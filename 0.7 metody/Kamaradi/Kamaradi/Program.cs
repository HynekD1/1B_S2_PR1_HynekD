namespace Kamaradi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            KamaradiI("Anička");
            KamaradiII("Karel");
            
        }

        //sem přijde váš kód
        public static string KamaradiI(string jmeno)
        {
            string jmeno1 = "";
            return $"Moji kamarádi jsou {jmeno1} a.";
        }


        public static string KamaradiII(string jmeno)
        {
            string jmeno1 = "";
            return $"Moji kamarádi jsou {jmeno1}.";
        }
    }
}
