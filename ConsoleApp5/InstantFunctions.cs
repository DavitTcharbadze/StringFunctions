namespace StringFunctions
{
    public class InstanceFunctions
    {
        public string _str;
        public int Length;
        public InstanceFunctions(string str)
        {
            _str = str;
            SetLength();
        }
        private void SetLength()
        {
            Length = 0;
            foreach (char item in _str)
            {
                Length++;
            }
        }
        public string Substring(int startInd, int length)
        {
            string result = "";
            int lastIndex = startInd + length;
            for (int i = startInd; i < lastIndex; i++)
            {
                result += _str[i];
            }
            return result;
        }
        public int IndexOf(string subText)
        {
            int firstIndex = -1;
            for (int i = 0; i < _str.Length; i++)
            {
                int subTextIndex = 0;
                string testText = "";
                if (_str[i] == subText[subTextIndex])
                {
                    firstIndex = i;
                    for (int j = 0; j < subText.Length; j++)
                    {
                        testText += _str[i];
                        i++;
                    }
                }
                if (testText.ToString().Trim() == subText.ToString().Trim())
                {
                    return firstIndex;
                }
                else
                {
                    firstIndex = -1;
                }
            }
            return firstIndex;
        }
        public int LastIndexOf(string subText)
        {
            int firstIndex = -1;
            for (int i = 0; i < _str.Length; i++)
            {
                int subTextIndex = 0;
                string testText = "";
                if (_str[i] == subText[subTextIndex])
                {
                    firstIndex = i;
                    for (int j = 0; j < subText.Length; j++)
                    {
                        testText += _str[i];
                        i++;
                    }
                }
            }
            return firstIndex;
        }
        public string Replace(string oldValue, string newValue)
        {
            int startIndex = IndexOf(oldValue);
            string preText = Substring(0, startIndex);
            string postText = Substring(startIndex + oldValue.Length, _str.Length - 1);

            _str = preText + newValue + postText;
            return _str;
        }
        public string ToUpper()
        {
            char[] result = new char[_str.Length];

            for (int i = 0; i < _str.Length; i++)
            {
                char c = _str[i];
                if (c >= 'a' && c <= 'z')
                {
                    result[i] = (char)(c - 32);
                }
                else
                {
                    result[i] = c;
                }
            }

            return new string(result);
        }
        public string ToLower()
        {
            char[] result = new char[_str.Length];

            for (int i = 0; i < _str.Length; i++)
            {
                char c = _str[i];
                if (c >= 'A' && c <= 'Z')
                {
                    result[i] = (char)(c + 32);
                }
                else
                {
                    result[i] = c;
                }
            }

            return new string(result);
        }
        public string Trim()
        {
            string newText = _str;

            while (newText.Substring(0, 1) == " ")
            {
                string newNewText = newText.Substring(1, newText.Length - 1);
                newText = newNewText;
            }
            while (newText.Substring(_str.Length - 1, 1) == " ")
            {
                string newNewText = newText.Substring(0, newText.Length - 1);
                newText = newNewText;
            }
            return newText;
        }
        public string[] Split(char separator)
        {
            string str = _str;
            int separatorCounter = 0;
            foreach (char ch in str)
            {
                if (ch == separator) separatorCounter++;
            }

            string[] strArr = new string[separatorCounter + 1];
            int strArrIndex = 0;
            int currentSeparatorIndex = 0;

            for (int i = 0; i < str.Length + 1; i++)
            {
                if (i == str.Length || str[i] == separator)
                {
                    strArr[strArrIndex] = Substring(currentSeparatorIndex, i - currentSeparatorIndex);
                    currentSeparatorIndex = i + 1;
                    strArrIndex++;
                }
            }
            return strArr;
        }
        public bool Contains(string value)
        {
            int valueLength = value.Length;
            foreach (char ch in _str)
            {
                int currCharIndex = _str.IndexOf(ch);
                if (currCharIndex + valueLength <= Length)
                {
                    string currValue = Substring(currCharIndex, valueLength);
                    if (currValue == value)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool StartsWith(string value)
        {
            int valueLength = value.Length;

            if (valueLength <= Length
                && Substring(0, valueLength) == value)
                return true;
            return false;
        }
        public bool EndsWith(string value)
        {
            int valueLength = value.Length;

            if (valueLength <= Length
                && Substring(Length - valueLength, valueLength) == value)
                return true;
            return false;
        }
    }
}