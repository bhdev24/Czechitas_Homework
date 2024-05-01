using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        // Tento ukol se opravuje sam. Kazdy priklad obsahuje kontrolni vypisy, ktere overi, ze jsi dosla k spravnemu vysledku.
        // Vsechny priklady take obsahuji nejakou predpripravenou promennou, kam ulozis vysledek svoji prace.
        
        // B: I've converted the text into a regular string, so it is easier to work with.  
        int padding = 45;
        string text = "\"Hurry up, boy!\" shouted Uncle Vernon from the kitchen. \"What are you\r\ndoing, checking for letter bombs?\" He chuckled at his own joke.\r\n\r\nHarry went back to the kitchen, still staring at his letter. He handed\r\nUncle Vernon the bill and the postcard, sat down, and slowly began to\r\nopen the yellow envelope.\r\n\r\nUncle Vernon ripped open the bill, snorted in disgust, and flipped over\r\nthe postcard.\r\n\r\n\"Marge's ill,\" he informed Aunt Petunia. \"Ate a funny whelk. --.\"\r\n\r\n\"Dad!\" said Dudley suddenly. \"Dad, Harry's got something!\"\r\n\r\nHarry was on the point of unfolding his letter, which was written on the\r\nsame heavy parchment as the envelope, when it was jerked sharply out of\r\nhis hand by Uncle Vernon.\r\n\r\n\"That's mine!\" said Harry, trying to snatch it back.\r\n\r\n\"Who'd be writing to you?\" sneered Uncle Vernon, shaking the letter open\r\nwith one hand and glancing at it. His face went from red to green faster\r\nthan a set of traffic lights. And it didn't stop there. Within seconds\r\nit was the grayish white of old porridge.";

        // Nez zacnes volat nejake stringove funkce na nejake stringove promenne, nezapomen overit, ze obsahuje smysluplnou hodnotu. Vysledek uloz do promenne 'textMaSmysl'.
        bool textMaSmysl;
        if (string.IsNullOrWhiteSpace(text) == true)
        {
            textMaSmysl = false;
        }
        else
        {
            textMaSmysl = true;
        }
        Console.WriteLine("Text dava smysl - ".PadRight(padding) + (textMaSmysl == true));

        // Do promenne 'delkaTextu' uloz celkovou delku uryvku z knizky.

        int totalDelkaTextu = text.Length;
        int mezery = text.Split(new string[] { "\r\n" }, StringSplitOptions.None).Length - 1;
        int delkaTextu = totalDelkaTextu - mezery;
        Console.WriteLine("Delka text je spravna - ".PadRight(padding) + (delkaTextu == 1001));

        // Do promenne 'oddelovac' vloz text, ktery se sklada pouze z pomlcek a jeho delka je presne 20. Pouzij k tomu konstruktor typu string.

        string oddelovac = null;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 20; i++)
        {
            sb.Append("-");
        }
        oddelovac = sb.ToString();
        Console.WriteLine("Oddelovac ma 20 pomlcek - ".PadRight(padding) + (oddelovac == "--------------------"));

        // Pozmen nasledujici porovnani textu tak, aby se do konzole vypisovalo True, aniz bys menila hodnoty promennych

        string jmeno1 = "Katka";
        string jmeno2 = "katka";
        bool jeStejne = false;
        if (String.Equals(jmeno1, jmeno2, StringComparison.OrdinalIgnoreCase))
        {
            jeStejne = true;
        }
        else
        {
            jeStejne = false;
        }
        Console.WriteLine("Obe promenne obsahuji stejne jmeno - ".PadRight(padding) + jeStejne);

        // Zjisti, jestli je v textu zminka o obtloustle "tete" Harryho. Jmenuje se Marge. Vysledek uloz do promenne 'piseSeOMarge';


        bool piseSeOMarge = false;
        if (text.Contains("Marge"))
        {
            piseSeOMarge = true;
        }
        else
        {
            piseSeOMarge = false;
        }
        Console.WriteLine("V textu se zminuje Harryho 'teticka' - ".PadRight(padding) + (piseSeOMarge == true));

        // Zjisti, jestli je text spravne ukonceny interpunkci. Vysledek uloz do promenne 'jeSpravneUkoncen'.

        bool jeSpravneUkoncen = false;
        if (text.EndsWith("."))
        {
            jeSpravneUkoncen = true;
        }
        else
        {
            jeSpravneUkoncen = false;
        }
        Console.WriteLine("Text je spravne ukoncen interpunkci - ".PadRight(padding) + (jeSpravneUkoncen == true));

        // Pomoci abecedniho porovnavani zjisti, ktery z nasledujicich textu je podle abecedy prvni a jeho hodnotu prirad do promenne 'prvni'.

        string blabol1 = "abbc";
        string blabol2 = "acbc";
        string blabol3 = "abbb";
        int comp1 = String.Compare(blabol1, blabol2);
        int comp2 = String.Compare(blabol1, blabol3);
        int comp3 = String.Compare(blabol2, blabol3);
        //Console.WriteLine(comp1);
        //Console.WriteLine(comp2);
        //Console.WriteLine(comp3);
        string prvni = null;
        if ((comp1 < 0) && (comp2 > 0) && (comp3 > 0))
        {
            prvni = blabol3;
        }
        else if ((comp1 > 0) && (comp2 > 0) && (comp3) < 0)
        {
            prvni = blabol2;
        }
        else
        {
            prvni = blabol1;
        }

        Console.WriteLine("Prvni v abecede je blabol3 - ".PadRight(padding) + (prvni == blabol3));

        // Najdi prvni rozkazovaci vetu v textu a uloz ji do promenne 'veta' bez vykricniku a uvozovek.
        string[] rozkazovaci = text.Split('!');
        string veta = rozkazovaci[0];
        veta = veta.Trim('"');
        Console.WriteLine("Prvni rozkazovaci veta je 'Hurry up, boy' - ".PadRight(padding) + (veta == "Hurry up, boy"));

        // Zjisti, kolikrat se v textu vyskytuje slovo "and" bez ohledu na velikosti prvniho pismenka a vysledek uloz do promenne 'pocetAnd'.
        // Abych vam to zjednodusil, muzete se spolehnout, ze tato anglicka spojka bude v textu vzdy obklopena mezerou na kazde strane.
        // Tim se snadno vylouci jakekoliv vyskyty "and" v ramci jinych slov.

        int pocetAnd = 0;
        string[] words = text.Split(new char[] { ' ', '.', ',', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {
            if (word.Equals("and", StringComparison.OrdinalIgnoreCase))
            {
                pocetAnd+=1;
            }
        }
        //Console.WriteLine(pocetAnd);
        Console.WriteLine("Text obsahuje slovo 'and' celkem 5x' - ".PadRight(padding) + (pocetAnd == 5));

        Console.ReadLine();
    }
}