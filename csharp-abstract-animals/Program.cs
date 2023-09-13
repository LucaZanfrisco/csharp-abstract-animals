// See https://aka.ms/new-console-template for more information

using csharp_abstract_animals;

Animale animale = null;
IVolante volante = null;
INuotante nuotante = null;

bool selezioneOpzione = false;

while(!selezioneOpzione)
{
    Console.Write(@"1 - Cane;
2 - Passerotto;
3 - Delfino;
4 - Aquila;
Inserire il numero per selezionare:  ");
    int numeroSelezionato = int.Parse(Console.ReadLine());
    switch(numeroSelezionato)
    {
        case 1:
            animale = new Cane();
            selezioneOpzione = true;
            break;
        case 2:
            animale = new Passerotto();
            volante = new Passerotto();
            selezioneOpzione = true;
            break;
        case 3:
            animale = new Delfino();
            nuotante = new Delfino();
            selezioneOpzione = true;
            break;
        case 4:
            animale = new Aquila();
            volante = new Aquila();
            selezioneOpzione = true;
            break;
        default:
            Console.WriteLine("Il numero inserito non corrisponde a nulla. RIPROVARE!");
            break;
    }
}

bool continua = true;
while(continua)
{
    int numeroSelezionato;
    if(animale is Cane)
    {
        Console.Write(@"1 - Verso;
2 - Cosa Mangia;
3 - Numero Zampe;
4 - Dormi
Selezionare un numero per compiere un azione : ");
        numeroSelezionato = int.Parse(Console.ReadLine());
        switch(numeroSelezionato)
        {
            case 1:
                animale.Verso();
                break;
            case 2:
                animale.CosaMangia();
                break;
            case 3:
                animale.StampaZampe();
                break;
            case 4:
                animale.dormi();
                break;
            default:
                Console.WriteLine("La scelta fatta non é valida");
                break;
        }
    }
    if(animale is Passerotto || animale is Aquila)
    {
        Console.Write(@"1 - Verso;
2 - Cosa Mangia;
3 - Numero Zampe;
4 - Dormi
5 - Vola
6 - Numero Ali
Selezionare un numero per compiere un azione : ");
        numeroSelezionato = int.Parse(Console.ReadLine());
        switch(numeroSelezionato)
        {
            case 1:
                animale.Verso();
                break;
            case 2:
                animale.CosaMangia();
                break;
            case 3:
                animale.StampaZampe();
                break;
            case 4:
                animale.dormi();
                break;
            case 5:
                animale.FaiVolare(volante);
                break;
            case 6:
                Console.WriteLine(volante.NumeroAli() + " ali");
                break;
            default:
                Console.WriteLine("La scelta fatta non é valida");
                break;
        }
    }
    if(animale is Delfino)
    {
        Console.Write(@"1 - Verso;
2 - Cosa Mangia;
3 - Numero Zampe;
4 - Dormi
5 - Nuota
6 - Numero Pinne
Selezionare un numero per compiere un azione : ");
        numeroSelezionato = int.Parse(Console.ReadLine());
        switch(numeroSelezionato)
        {
            case 1:
                animale.Verso();
                break;
            case 2:
                animale.CosaMangia();
                break;
            case 3:
                animale.StampaZampe();
                break;
            case 4:
                animale.dormi();
                break;
            case 5:
                animale.FaiNuotare(nuotante);
                break;
            case 6:
                Console.WriteLine(nuotante.NumeroPinne() + " pinne");
                break;
            default:
                Console.WriteLine("La scelta fatta non é valida");
                break;
        }
    }
    Console.Write("Se si desidera ripetere l'esecuzione scrivere Y/N : ");
    string rispostaUtente = Console.ReadLine();
    if(rispostaUtente.ToLower() == "n")
    {
        continua = false;
    }

}