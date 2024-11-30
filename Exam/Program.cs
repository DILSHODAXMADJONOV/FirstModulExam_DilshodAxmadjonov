namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        //1
        public static int CountElemnt(List<int> numberElements)
        {
            var count = 0;
            foreach (var numberElement in numberElements)
            {
                if (numberElement > 10 && numberElement < 100)
                {
                    count++;
                }
            }
            return count;
        }
        //2
        public static string TextSecontDelete(string text)
        {
            text = text.Substring(0, text.Length - 2);
            return text;
        }
        //3
        public static bool Check(string texts)
        {
            foreach (var text in texts)
            {
                if (char.IsLower(text))
                {
                    return false;
                    break;
                }
            }
            return true;
        }
        //4
        public static bool CheckText(string text)
        {
            if (text.StartsWith("qovun") && text.EndsWith("qovun") is true)
            {
                return true;
            }
            return false;
        }
    }
}

