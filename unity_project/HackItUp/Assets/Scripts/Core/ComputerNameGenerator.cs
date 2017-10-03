using System;
using System.Collections.Generic;

public class ComputerNameGenerator
{
    private static ComputerNameGenerator instance;

    public static ComputerNameGenerator Instance
    {
        get
        {
            if (instance == null) instance = new ComputerNameGenerator();

            return instance;
        }
    }

    private Random generator;
    private List<string> generatedCodes;

    private ComputerNameGenerator()
    {
        generator = new Random();
        generatedCodes = new List<string>();
    }

    //generates the second part of the name, a string with 7 random generated chars, can be numbers or lower case chars
    private string getNameCode()
    {
        string ret = "";
        char c;
        int code;

        //numbers = 48-57
        //chars = 97-122

        for (int i = 0; i < 7; i++)
        {
            code = generator.Next(1, 37);

            if (code <= 10)     //char will be a number
            {
                c = (char)(47 + code);
            }
            else                //char will be a letter
            {
                //removing the number offset
                code -= 10;

                c = (char)(96 + code);
            }

            ret += c;
        }

        generatedCodes.Add(ret);

        return ret;
    }

    public string getName(ComputerKind kind)
    {
        string ret = "";
        string code = getNameCode();

        if (kind == ComputerKind.Desktop) ret = "desktop-";
        else if (kind == ComputerKind.Laptop) ret = "laptop-";

        ret += code;

        return ret;
    }

    //remove from generated list if the computer dies for some reason
    public bool deleteGeneratedCodeFromName(string name)
    {
        char[] s = { ' ' };
        string code = name.Split(s)[1];

        return generatedCodes.Remove(code);
    }
}
