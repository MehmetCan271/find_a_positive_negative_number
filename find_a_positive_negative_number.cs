using System;


class Program
{
  static void Main (string[]args)
  {
    int[] pozitifSayilar = new int[0];

    int[] negatifSayilar = new int[0];


    while (true)
      {
	Console.Write
	  ("'E' girerek Çıkabilirsiniz, 'H' girerek Şimdiye kadar girilen sayıları yazdırabilirsiniz, ya da\nbir sayı girin:");


	string input = Console.ReadLine ();


	if (input == "E")
	  {
	    break;
	  }

	else if (input == "H")
	  {
	    Console.WriteLine ("Pozitif sayılar:");

	    foreach (int sayi in pozitifSayilar)
	    {
	      Console.WriteLine (sayi);

	    }

	    Console.WriteLine ("Negatif sayılar:");

	    foreach (int sayi in negatifSayilar)
	    {
	      Console.WriteLine (sayi);
	    }
	  }
	else
	  {

	    int sayi = int.Parse (input);


	    if (sayi >= 0)
	      {
		Array.Resize (ref pozitifSayilar, pozitifSayilar.Length + 1);

		pozitifSayilar[pozitifSayilar.Length - 1] = sayi;
	      }

	    else
	      {

		Array.Resize (ref negatifSayilar, negatifSayilar.Length + 1);

		negatifSayilar[negatifSayilar.Length - 1] = sayi;
	      }

	  }

      }

  }

}
