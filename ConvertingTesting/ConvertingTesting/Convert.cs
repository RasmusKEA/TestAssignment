namespace ConvertingTesting
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class Convert
    {
        public string ConvertLengthTo(double amount, string metric)
        {
         var cmToIn = amount * 0.393701;
         var inToCm = amount * 2.54;

         return metric switch
            {
                "i" => cmToIn.ToString("#.##"),
                "c" => inToCm.ToString("#.##"),
                _ => throw new Exception("Invalid input")
            };
        }

        public string ConvertWeightTo(double amount, string metric)
        {
            var kgToP = amount * 2.2046;
            var PToKg = amount * 0.453592;
            
            return metric switch
            {
                "p" => kgToP.ToString("#.##"),
                "k" => PToKg.ToString("#.##"),
                _ => throw new Exception("Invalid input")
            };
        }

        public string ConvertTemps(double temp, string fromTemp, string toTemp)
        {
            var CtoK = temp + 273.15;
            var CtoF = temp * (9/5) + 32;
            
            var KtoC = temp - 273.15;
            var KtoF = (temp - 273.15) * 9/5 + 32;

            var FtoC = (temp - 32) * 5/9;
            var FtoK = (temp - 32) * 5/9 + 273.15;
            
            switch (fromTemp.ToLower())
            {
                case "c" when toTemp.Equals("k"):
                    return CtoK.ToString("#.##");
                case "c" when toTemp.Equals("f"):
                    return CtoF.ToString("#.##");
                case "k" when toTemp.Equals("c"):
                    return KtoC.ToString("#.##");
                case "k" when toTemp.Equals("f"):
                    return KtoF.ToString("#.##");
                case "f" when toTemp.Equals("c"):
                    return FtoC.ToString("#.##");
                case "f" when toTemp.Equals("k"):
                    return FtoK.ToString("#.##");
                default: throw new Exception("Invalid input");
            }
        }

        public static void Main()
        {
            var convert = new Convert();
            Console.WriteLine(convert.ConvertLengthTo(100, "i"));
            Console.WriteLine(convert.ConvertLengthTo(100, "c"));
            
            Console.WriteLine(convert.ConvertWeightTo(100, "k"));
            Console.WriteLine(convert.ConvertWeightTo(100, "p"));
            
            Console.WriteLine(convert.ConvertTemps(100, "c", "k"));
            Console.WriteLine(convert.ConvertTemps(100, "c", "f"));
            Console.WriteLine(convert.ConvertTemps(100, "k", "c"));
            Console.WriteLine(convert.ConvertTemps(100, "k", "f"));
            Console.WriteLine(convert.ConvertTemps(100, "f", "c"));
            Console.WriteLine(convert.ConvertTemps(100, "f", "k"));
        }
    }
}