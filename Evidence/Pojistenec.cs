using System;

public class Pojistenec
{
	public Pojistenec()
	{

	}

    public string jmeno { get; set; }
    public string prijmeni { get; set; }
    public int telefon { get; set; }
    public int vek { get; set; }

    public override string ToString()
    {
        return jmeno + " " + prijmeni + " " + telefon + " " + vek;
    }

}
