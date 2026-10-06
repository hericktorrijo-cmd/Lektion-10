


Console.WriteLine(TextVerktyg.RensaText("     Hej fddddd gsdgDF        "));





class TextVerktyg
{




    public static string RensaText (string indata)
    {
        indata = indata.Trim().ToLower();
        return indata;
    }
}