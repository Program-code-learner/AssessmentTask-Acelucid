using System;

public class StringDate
{
    public static void Main(string[] args)
    {
        string str = "Hdjsh asd2324234jghjsd hjsdg sdhk 12212021 idf32432 32423 d34234jh dfh";
        int n = 8;
        string ans = "";

        for (int i = 0; i <= str.Length - n; i++)
        {
            bool isValid = true;
            for (int j = 0; j < n; j++)
            {
                if (str[i + j] < '0' || str[i + j] > '9')
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                for (int j = 0; j < n; j++)
                {
                    ans += str[i + j];
                }
                break;
            }
        }

        Console.WriteLine(ans);
    }
}
