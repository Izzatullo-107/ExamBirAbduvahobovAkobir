namespace ImtihonUchun;

internal class Program
{
    static void Main(string[] args)
    {
        var list = new List<int>() {2,3,5,6,41,7,8,9 };
        var listText = new List<string>() {"salomm","qannia" };
        var listText2 = new List<string>() {"salom","qannia","PDP" };
        


        CW("M: 1 \n"+JuftSonlar(list));

        Console.WriteLine();

        CW("M: 2\n"+BeshdanUzunlika(listText));
        CW(BeshdanUzunlika(listText2));

        Console.WriteLine();

        CW("M: 3 \n"+ BoshidagiUchta("Salom"));

        Console.WriteLine();

        CW("M: 4\n"+PDP("PDP Salom G13 PDP"));

        Console.WriteLine();

        CW("M: 5\n " + G13("ghsxsghxjhbxjkkjqG13 bxjhsaxjh"));

        Console.WriteLine();

        CW("M: 6 \n"+BirVaIkki(list));

        
    }

    // M: 1
    static int JuftSonlar(List<int> sonlar)
    {
        var juftCount = 0;
        foreach(var son in sonlar)
        {
            if(son %2 == 0)
            {
                juftCount++;
            }
        }
        return juftCount;
    }

    // M: 2
    static bool BeshdanUzunlika(List<string > elementlar)
    {
        foreach(var element in elementlar)
        {
            if(element.Length <= 5)
            {
                return false;
            }
        }
        return true;
    }

    // M: 3
    static string BoshidagiUchta(string text)
    {
        return text.Substring(0,3);
    }

    // M: 4
    static bool PDP(string text)
    {
        return text.Substring(0, 3) == "PDP";
    }

    // M: 5
    static bool G13(string text)
    {
        return text.Contains("G13");
    }

    // M: 6 
    static int BirVaIkki(List<int> intlist)
    {
        return intlist[0] + intlist[1];
    }

    // Consol.Writ int,string, bool
    static void CW(int a)
    {
        Console.WriteLine(a);
    }
    static void CW(string a)
    {
        Console.WriteLine(a);
    }
    static void CW(bool a)
    {
        Console.WriteLine(a);
    }

}
