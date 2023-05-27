// See https://aka.ms/new-console-template for more information
bool ukoncit = false;

List<Pojistenec> pojistenci = new List<Pojistenec>();

while (!ukoncit)
{
    try
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Evidence pojištěných");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Vyberte si akci:");
        Console.WriteLine("1 - Přidej nového pojštěného");
        Console.WriteLine("2 - Vypsat všechny pojištěné");
        Console.WriteLine("3 - Vyhledat pojištěného");
        Console.WriteLine("4 - Konec");
        Console.WriteLine();
        int volba = int.Parse(Console.ReadLine());

        switch (volba)
        {
            case 1:
                Pojistenec pojistenec = new Pojistenec();
                Console.WriteLine("Zadejte jméno pojištěného:");
                pojistenec.jmeno = Console.ReadLine();
                Console.WriteLine("Zadejte přijmení:");
                pojistenec.prijmeni = Console.ReadLine();
                Console.WriteLine("Zadejte telefoní číslo:");
                pojistenec.telefon = int.Parse(Console.ReadLine());
                Console.WriteLine("Zadejte věk:");
                pojistenec.vek = int.Parse(Console.ReadLine());
                int telefon = 0;
                int vek = 0;
               

                pojistenci.Add(pojistenec);
                Console.WriteLine();
                Console.WriteLine("Data byla uložena.");
                break;
            case 2:
                Console.WriteLine();
                foreach (var p in pojistenci)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
                break;
            case 3:
                Console.WriteLine("Zadej jméno pojištěného:");
                string jmeno = Console.ReadLine();
                Console.WriteLine("Zadej přijmení:");
                string prijmeni = Console.ReadLine();

                Console.WriteLine();
                foreach (var p in pojistenci)
                {
                    if (prijmeni == p.prijmeni && jmeno == p.jmeno)
                    {
                        Console.WriteLine(p);

                    }
                }
                Console.WriteLine();
                break;

                
            case 4:
                ukoncit = true;
                break;
            default:
                Console.WriteLine("špatná volba");
                break;


        }
    }
    catch { 
        Console.WriteLine("chyba v zadání");
    }
    Console.WriteLine("Pokračujte libovolnou klávesou...");
    Console.ReadLine();
    Console.Clear();
}

