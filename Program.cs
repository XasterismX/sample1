
using System; 
using System.Text.RegularExpressions;
using System.Text;
public class Test {
     static bool IsBinary(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] != '0' && s[i] != '1')
                    return false;
            }
            return true;
        }
    public static void Main() 
    { 
        Console.WriteLine("Введите слово");
        String? str = Console.ReadLine();
        String ascstr = "";
        String binstr2 = "";
        if (str == null)
        {
            Console.WriteLine ("Введите значение");
            Console.ReadKey ();
        }
        else{
            char[] arr = str.ToCharArray();
            foreach (char i in arr) {
                ascstr += (int)i;
                String tmp = Convert.ToString (i, 2);
                while (tmp.Length < 8) //выравниваем по 8 бит
                    tmp = '0' + tmp;
                    binstr2 += tmp;
                }
                Console.WriteLine ("Введенное значение: "+str);
                Console.WriteLine ("Значение в байт коде: "+ascstr);
                Console.WriteLine ("Значение в двоичном коде: "+binstr2);
                int p=0;
                while (p < binstr2.Length){
                    Char ch = (char)Convert.ToByte(binstr2.Substring(p,8),2);
                    Console.Write(ch);
                    p += 8;
                }
            Console.ReadKey ();
        }
    }
}