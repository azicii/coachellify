using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoachellaLineup : MonoBehaviour
{
    public List<string> coachellaArtists = new List<string>();

    void Start()
    {
        coachellaArtists.Add("A Boogie Wit da Hoodie");
        coachellaArtists.Add("Adam Beyer");
        coachellaArtists.Add("AG Club");
        coachellaArtists.Add("Airrica");
        coachellaArtists.Add("Alex G");
        coachellaArtists.Add("Ali Sethi");
        coachellaArtists.Add("Ang�le");
        coachellaArtists.Add("Ashnikko");
        coachellaArtists.Add("Bad Bunny");
        coachellaArtists.Add("Bakar");
        coachellaArtists.Add("Becky G");
        coachellaArtists.Add("Benee");
        coachellaArtists.Add("Big Wild");
        coachellaArtists.Add("Bj�rk");
        coachellaArtists.Add("Blackpink");
        coachellaArtists.Add("The Blaze");
        coachellaArtists.Add("Blondie");
        coachellaArtists.Add("Boris Brejcha");
        coachellaArtists.Add("Boygenius");
        coachellaArtists.Add("Bratty");
        coachellaArtists.Add("The Breeders");
        coachellaArtists.Add("Burna Boy");
        coachellaArtists.Add("Calvin Harris");
        coachellaArtists.Add("Camelphat");
        coachellaArtists.Add("Cannons");
        coachellaArtists.Add("Cassian");
        coachellaArtists.Add("Charli XCX");
        coachellaArtists.Add("The Chemical Brothers");
        coachellaArtists.Add("Chlo� Caillet");
        coachellaArtists.Add("Chris Stussy");
        coachellaArtists.Add("Christine and the Queens");
        coachellaArtists.Add("Chromeo");
        coachellaArtists.Add("Colyn");
        coachellaArtists.Add("The Comet Is Coming");
        coachellaArtists.Add("Conexi�n Divina");
        coachellaArtists.Add("DannyLux");
        coachellaArtists.Add("Dennis Cruz + Pawsa");
        coachellaArtists.Add("Despacio ");
        coachellaArtists.Add("Destroy Boys");
        coachellaArtists.Add("Diljit Dosanjh");
        coachellaArtists.Add("Dinner Party");
        coachellaArtists.Add("DJ Tennis");
        coachellaArtists.Add("Doechii");
        coachellaArtists.Add("Dombresky");
        coachellaArtists.Add("Terrace Martin");
        coachellaArtists.Add("Robert Glasper");
        coachellaArtists.Add("Kamasi Washington");
        coachellaArtists.Add("Carlita");
        coachellaArtists.Add("Domi & JD Beck");
        coachellaArtists.Add("Dinner Party ft. Terrace Martin, Robert Glasper, Kamasi Washington");
        coachellaArtists.Add("DJ Tennis + Carlita");
        coachellaArtists.Add("Dominic Fike");
        coachellaArtists.Add("Donavan�s Yard");
        coachellaArtists.Add("DPR Live");
        coachellaArtists.Add("DPR Ian");
        coachellaArtists.Add("DPR Live + DPR Ian");
        coachellaArtists.Add("Drama");
        coachellaArtists.Add("EarthGang");
        coachellaArtists.Add("El Michels Affair");
        coachellaArtists.Add("Eladio Carri�n");
        coachellaArtists.Add("Elderbrook");
        coachellaArtists.Add("Elyanna");
        coachellaArtists.Add("Eric Prydz Presents HOLO");
        coachellaArtists.Add("Ethel Cain");
        coachellaArtists.Add("Fisher + Chris Lake");
        coachellaArtists.Add("Fisher");
        coachellaArtists.Add("Chris Lake");
        coachellaArtists.Add("FKJ");
        coachellaArtists.Add("Flo Milli");
        coachellaArtists.Add("Foushe�");
        coachellaArtists.Add("Francis Mercier");
        coachellaArtists.Add("Frank Ocean");
        coachellaArtists.Add("Gabriels");
        coachellaArtists.Add("The Garden");
        coachellaArtists.Add("Glorilla");
        coachellaArtists.Add("Gordo");
        coachellaArtists.Add("Gorillaz");
        coachellaArtists.Add("Hiatus Kaiyote");
        coachellaArtists.Add("Horsegirl");
        coachellaArtists.Add("Hot Since 82");
        coachellaArtists.Add("IDK");
        coachellaArtists.Add("Idris Elba");
        coachellaArtists.Add("Jackson Wang");
        coachellaArtists.Add("Jai Paul");
        coachellaArtists.Add("Jai Wolf");
        coachellaArtists.Add("Jamie Jones");
        coachellaArtists.Add("Jan Blomqvist");
        coachellaArtists.Add("Joy Crookes");
        coachellaArtists.Add("Juliet Mendoza");
        coachellaArtists.Add("Jupiter & Okwess");
        coachellaArtists.Add("Jupiter");
        coachellaArtists.Add("Okwess");
        coachellaArtists.Add("Kali Uchis");
        coachellaArtists.Add("Kaytranada");
        coachellaArtists.Add("Keinemusik");
        coachellaArtists.Add("Kenny Beats");
        coachellaArtists.Add("The Kid Laroi");
        coachellaArtists.Add("Knocked Loose");
        coachellaArtists.Add("Kyle Watson");
        coachellaArtists.Add("Labrinth");
        coachellaArtists.Add("Latto");
        coachellaArtists.Add("Lava La Rue");
        coachellaArtists.Add("Lewis OfMan");
        coachellaArtists.Add("The Linda Lindas");
        coachellaArtists.Add("Los Bitchos");
        coachellaArtists.Add("Los Fabulosos Cadillacs");
        coachellaArtists.Add("LP Giobbi");
        coachellaArtists.Add("Maceo Plex");
        coachellaArtists.Add("Magdalena Bay");
        coachellaArtists.Add("Malaa");
        coachellaArtists.Add("Marc Rebillet");
        coachellaArtists.Add("Mareux");
        coachellaArtists.Add("Mathame");
        coachellaArtists.Add("Metro Boomin");
        coachellaArtists.Add("Minus the Light");
        coachellaArtists.Add("MK");
        coachellaArtists.Add("Mochakk");
        coachellaArtists.Add("Momma");
        coachellaArtists.Add("Monolink");
        coachellaArtists.Add("Muna");
        coachellaArtists.Add("Mura Masa");
        coachellaArtists.Add("The Murder Capital");
        coachellaArtists.Add("Nia Archives");
        coachellaArtists.Add("Noname");
        coachellaArtists.Add("Nora En Pure");
        coachellaArtists.Add("Oliver Koletzki");
        coachellaArtists.Add("Overmono");
        coachellaArtists.Add("Paris Texas");
        coachellaArtists.Add("Pi�erre Bourne");
        coachellaArtists.Add("Porter Robinson");
        coachellaArtists.Add("Pusha T");
        coachellaArtists.Add("Rae Sremmurd");
        coachellaArtists.Add("Rebelution");
        coachellaArtists.Add("Remi Wolf");
        coachellaArtists.Add("Romy");
        coachellaArtists.Add("Rosal�a");
        coachellaArtists.Add("Saba");
        coachellaArtists.Add("Sasha & John Digweed");
        coachellaArtists.Add("Sasha Alex Sloan");
        coachellaArtists.Add("Scowl");
        coachellaArtists.Add("SG Lewis");
        coachellaArtists.Add("Shenseea");
        coachellaArtists.Add("Sleaford Mods");
        coachellaArtists.Add("Snail Mail");
        coachellaArtists.Add("Sofi Tukker");
        coachellaArtists.Add("Soul Glo");
        coachellaArtists.Add("Stick Figure");
        coachellaArtists.Add("Sudan Archives");
        coachellaArtists.Add("$uicideboy$");
        coachellaArtists.Add("Sunset Rollercoaster");
        coachellaArtists.Add("Tale of Us");
        coachellaArtists.Add("�T�o?");
        coachellaArtists.Add("Testpilot");
        coachellaArtists.Add("Tobe Nwigwe");
        coachellaArtists.Add("TSHA");
        coachellaArtists.Add("TV Girl");
        coachellaArtists.Add("Two Friends");
        coachellaArtists.Add("UMI");
        coachellaArtists.Add("Uncle Waffles");
        coachellaArtists.Add("Underworld");
        coachellaArtists.Add("Vintage Culture");
        coachellaArtists.Add("Wet Leg");
        coachellaArtists.Add("Weyes Blood");
        coachellaArtists.Add("WhoMadeWho");
        coachellaArtists.Add("Whyte Fang");
        coachellaArtists.Add("Willow");
        coachellaArtists.Add("Yaeji");
        coachellaArtists.Add("Yung Lean");
        coachellaArtists.Add("Yungblud");
        coachellaArtists.Add("Yves Tumor");
        coachellaArtists.Add("070 Shake");
        coachellaArtists.Add("1999.ODDS");
        coachellaArtists.Add("2ManyDJs");
    }
}