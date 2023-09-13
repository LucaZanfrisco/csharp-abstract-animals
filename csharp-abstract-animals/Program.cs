// See https://aka.ms/new-console-template for more information

using csharp_abstract_animals;

Animale animale;
IVolante volante;
INuotante nuotante;

volante = new Aquila();
nuotante = new Delfino();

animale = new Passerotto();
animale.CosaMangia();
animale.Verso();
animale.dormi();
animale.FaiVolare(volante);
animale.StampaZampe();


animale = new Cane();
animale.CosaMangia();
animale.Verso();
animale.dormi();
animale.StampaZampe();


animale = new Delfino();
animale.CosaMangia();
animale.Verso();
animale.dormi();
animale.FaiNuotare(nuotante);
animale.StampaZampe();

animale = new Aquila();
animale.CosaMangia();
animale.Verso();
animale.dormi();
animale.StampaZampe();
