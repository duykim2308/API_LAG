using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Utilities
{
    public class Utilities
    {
        public static string ViewMore(string str, int index, string attr = "")
        {
            if (str.Length > index)
            {
                int i = str.IndexOf(" ", index);

                if (i > -1)
                {
                    str = str.Substring(0, i) + (attr == "" ? "" : attr);
                }
            }
            return str;
        }

        public static string[] GetTableName(string[] s)
        {
            string str = "";
            bool isInsert = false;
            foreach (string s1 in s)
            {
                if (isInsert)
                {
                    if (s1[0] == '[')
                        break;
                    else
                        str += s1;
                }
                else
                    isInsert = s1 == "[TableName]";
            }
            return str.Split(';');
        }

        public static string GetSQL(string[] s)
        {
            string str = "";
            bool isInsert = false;
            foreach (string s1 in s)
            {
                if (isInsert)
                {
                    if (s1[0] == '[')
                        break;
                    else
                        str += s1 + Environment.NewLine;
                }
                else
                    isInsert = s1 == "[SQL]";
            }
            return str;
        }
         
        public static string ConvertToUnsign(string str)
        {
            string[] signs = new string[] {
                    "aAeEoOuUiIdDyY",
                    "áàạảãâấầậẩẫăắằặẳẵ",
                    "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
                    "éèẹẻẽêếềệểễ",
                    "ÉÈẸẺẼÊẾỀỆỂỄ",
                    "óòọỏõôốồộổỗơớờợởỡ",
                    "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
                    "úùụủũưứừựửữ",
                    "ÚÙỤỦŨƯỨỪỰỬỮ",
                    "íìịỉĩ",
                    "ÍÌỊỈĨ",
                    "đ",
                    "Đ",
                    "ýỳỵỷỹ",
                    "ÝỲỴỶỸ"};
            for (int i = 1; i < signs.Length; i++)
            {
                for (int j = 0; j < signs[i].Length; j++)
                {
                    str = str.Replace(signs[i][j], signs[0][i - 1]);
                }
            }
            return str;
        }
  
        public static string ToAscii(string unicode)
        {
            if (unicode != null)
            {
                unicode = Regex.Replace(unicode, "[áàảãạăắằẳẵặâấầẩẫậ]", "a");
                unicode = Regex.Replace(unicode, "[óòỏõọôồốổỗộơớờởỡợ]", "o");
                unicode = Regex.Replace(unicode, "[éèẻẽẹêếềểễệ]", "e");
                unicode = Regex.Replace(unicode, "[íìỉĩị]", "i");
                unicode = Regex.Replace(unicode, "[úùủũụưứừửữự]", "u");
                unicode = Regex.Replace(unicode, "[ýỳỷỹỵ]", "y");
                unicode = Regex.Replace(unicode, "[đ]", "d");
                unicode = Regex.Replace(unicode, "[ÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬ]", "A");
                unicode = Regex.Replace(unicode, "[ÓÒỎÕỌÔỒỐỔỖỘƠỚỜỞỠỢ]", "O");
                unicode = Regex.Replace(unicode, "[ÉÈẺẼẸÊẾỀỂỄỆ]", "E");
                unicode = Regex.Replace(unicode, "[ÍÌỈĨỊ]", "I");
                unicode = Regex.Replace(unicode, "[ÚÙỦŨỤƯỨỪỬỮỰ]", "U");
                unicode = Regex.Replace(unicode, "[ÝỲỶỸỴ]", "Y");
                unicode = Regex.Replace(unicode, "[Đ]", "D");
                //unicode = Regex.Replace(unicode, "[-\\s+/]+", "-");
                unicode = Regex.Replace(unicode, "\\W+", " "); //Nếu bạn muốn thay dấu khoảng trắng thành dấu "_" hoặc dấu cách " " thì thay kí tự bạn muốn vào đấu "-"
            }
            return unicode;
        }

    }
}
