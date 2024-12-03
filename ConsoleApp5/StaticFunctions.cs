namespace StringFunctions
{
    public class StaticFunction
    {
        public static string Join(string separator, string[] values)
        {
            string result = "";
            foreach (string value in values)
            {
                result += value;
                int indexOf = Array.IndexOf(values, value);
                if (indexOf == values.Length - 1) break;
                result += separator;
            }
            // V2
            //for (int i = 0; i < values.Length; i++)
            //{
            //    result += values[i];
            //    if (i < values.Length - 1)
            //    {
            //        result += separator;
            //    }
            //}
            return result;
        }
        public static string Format(string text, string[] values)
        {
            int len = values.Length;
            for (int i = 0; i < len; i++)
            {
                //text = text.Replace("{" + i + "}", values[i]);
                text = text.Replace($"{{{i}}}", values[i]);
            }
            return text;
        }
        public static bool IsNullOrEmpty(string value)
        {
            return value == null || value.Length == 0;
        }
        public static bool IsNullOrWhiteSpace(string value)
        {
            if (value == null) return true;

            foreach (var ch in value)
            {
                if (ch != ' ') return false;
            }
            return true;

            // V2
            //foreach (char c in value)
            //{
            //    if (!char.IsWhiteSpace(c)) return false;
            //}
            //return true;
        }
    }
}