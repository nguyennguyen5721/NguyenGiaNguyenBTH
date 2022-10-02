namespace NguyenGiaNguyenBTH.Models
{
 public class Stringprocess
    {
        public string RemoveRemainingWhiteSpace (string strInput)
        {
            string result = "";
            strInput = strInput.Trim();
            int index = strInput.IndexOf("  ");
            while(strInput.IndexOf("  ")>0){
                strInput = strInput.Replace("  "," ");
            }
            result = strInput;
            return result;
        }
        public string LowerToUpper (string strInput)
        {
            string strResult = "";
            strResult = strInput.ToUpper();
            return strResult;
        }

        public string UpperToLower(string strInput)
        {
            string strResult = "";
            strResult = strInput.ToLower();
            return strResult;
        }

        public String CapitalizeOneFirstCharacter (string strInput)
        {
            string strResult = "";
            string fistCharater = strInput.Substring(0,1).ToUpper();
            strResult = fistCharater + strInput.Substring(1);
            return strResult;
        }

        //Viết hoa ký tự đầu tiên của các từ trong chuỗi
        public string CapitalizeFirstCharacter (string strInput)
        {
            string strResult = "";
 
            //khai báo một mảng kiểu char sau đó sử dụng phuonge thức ToCharArray() để chuyển đổi chuỗi message thành kiểu mảng char
            char[] charArray = strInput.ToCharArray();
            bool foundSpace = true;
            //sử dụng vòng lặp for lặp từng phần tử trong mảng
            for (int i = 0; i < charArray.Length; i++)
            {
                //sử dụng phương thức IsLetter() để kiểm tra từng phần tử có phải là một chữ cái
                if (Char.IsLetter(charArray[i]))
                {
                    if (foundSpace)
                    {
                        //nếu phải thì sử dụng phương thức ToUpper() để in hoa ký tự đầu
                        charArray[i] = Char.ToUpper(charArray[i]);
                        foundSpace = false;
                    }
                }
                else
                {
                    foundSpace = true;
                }
            }
            strResult = new String(charArray);
            return strResult;
        }

        //bỏ dấu tiếng việt
        public static string RemoveUnicode(string text)  
        {  
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",  
            "đ",  
            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",  
            "í","ì","ỉ","ĩ","ị",  
            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",  
            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",  
            "ý","ỳ","ỷ","ỹ","ỵ",};  
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",  
            "d",  
            "e","e","e","e","e","e","e","e","e","e","e",  
            "i","i","i","i","i",  
            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",  
            "u","u","u","u","u","u","u","u","u","u","u",  
            "y","y","y","y","y",};  
            for (int i = 0; i < arr1.Length; i++)  
            {  
                text = text.Replace(arr1[i], arr2[i]);  
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());  
            }  
            return text;  
        }
    }
}