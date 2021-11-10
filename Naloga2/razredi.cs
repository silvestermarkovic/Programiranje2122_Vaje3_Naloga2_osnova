using System;
using System.Collections.Generic;
using System.Text;

namespace Naloga2
{
    //TODO 10: ustvarite vrstaZivaliSeznam tipa enum
    //TODO 10: dodajte zapise Domacazival, Divjazival, Zver
   

    //TODO 20 ustvarite interface Izival
    interface IZival
    {
        //!!!!! interface cannot contain instance fields
        //!!!!! public string vrednost = "";

        // Property declaration:
        //TODO 20 ustvarite lastnosti string VrstaZivali (get),
        //int SteviloNog (get,set),
        //string NazivZivali(get,set)
      

        //TODO 25 ustvarite metode Oglasanje (vrne string), brez vhodnih parametrov
       

        //TODO 25 ustvarite metodo HitrostGibanja (vrne int), brez vhodnih parametrov
        
    }
    //TODO 30 ustvarite abstraktni razred Zival, ki implementira interface IZival
    public abstract class Zival : IZival
    {
        //TODO 35: ustvarite field _stevilonog tipa int s privzetno vrednostjo 0. ki bo dosegljiv le v tem razredu
         
        //TODO 35: ustvarite field _nazivZivali tipa string, ki bo dosegljiv tudi v dedovanih razredih
        


        //TODO 36 implementirajte property SteviloNog (vrne in določi field _stevilonog tipa int)
         
        //TODO 37 implementirajte property NazivZivali (vrne in določi field _nazivZivali tipa int)
         
        //TODO 38 dodajte abstraktni property VrstaZivali tipa string (samo get)
         


        //TODO 39dodajte abstraktno metodo Oglasanje tipa string, brez vhodnih parametrov 
          

        //TODO 40 dodajte abstraktno metodo Gibanje tipa string, brez vhodnih parametrov
        



        //TODO 41 dodajte virtualno metodo HitrostGibanja tipa int, brez vhodnih parametrov, ki vrne vrednost 0
         

    }


    //TODO 50 ustvarite razred Petelin, ki je dedovana iz razreda Zival
    public class Petelin : Zival
    {
        //TODO 52 ustvarite field _vrstaZivali tipa int in mu dodelite vrednost (int)vrstaZivaliSeznam.Domacazival
         

        //TODO 55 ustvarite konstruktor Petelin(string pNaziv, int pSteviloNog), vrednosti zapišite v ustrezne Propery
        public Petelin(string pNaziv, int pSteviloNog)
        {
           // base.SteviloNog = pSteviloNog;
           // base.NazivZivali = pNaziv;
        }

        //TODO 56ustvarite VrstaZivali, ki vrne (get) _vrstaZivali vrne string (primer: Divjazival)

        //namig return Enum.GetName(typeof(vrstaZivaliSeznam), _vrstaZivali);
       

        //TODO 60 ustvarite metodo Oglasanje, ki vrne string "Kikiriki"
        

        //TODO 61 ustvarite metodo Oglasanje, ki vrne string "Leti"
         
    }



    //TIGER 
    //TODO 70 ustvarite razred Tiger, ki je dedovana iz razreda Zival
    //TODO 72ustvarite field _vrstaZivali tipa int in mu dodelite vrednost (int)vrstaZivaliSeznam.Zver


    //TODO 74 utvarite field _steviloZob tipa int in mu dodelite vrednost 0

    //TODO 76 ustvarite konstruktor Tiger(string pNaziv, int pSteviloNog, nt pSteviloZob), vrednosti zapišite v ustrezne Propery


    //TODO 78 ustvarite VrstaZivali, ki vrne (get) _vrstaZivali vrne string (primer: Zver)

    //TODO 80 ustvarite metodo Oglasanje, ki vrne string "KikRjovenjeiriki"

    //TODO 82 ustvarite metodo Oglasanje, ki vrne string "Teče"


    //TIGER   KONEC


    //TODO:90 ustvarite razred Razsiritve
    static class razsitive
    {

        //TODO: 92 ustvarite razsiritev Opis za Tiger
        //TODO: 92 izpiše naj podatke o Tigru stevilonov, gibanje, oglasanje

        /*
        public static void Opis(this Tiger pTiger)
        {
            

        }
        */
    }


}

