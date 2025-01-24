using System;
class HelloWorld {
	static void Main() {
		Console.Write("Kaç İsim Gireceğinizi Belirtiniz: ");
		int isimSayi=Convert.ToInt32(Console.ReadLine());
		
		string[] isimler=new string[isimSayi];
		
		for(int i=0; i<isimSayi; i++){
		    Console.Write($"İsim {i+1}: ");
		    isimler[i]=Console.ReadLine();
		}
		
		string arananIsim="Yekta";
		int indeks=Array.IndexOf(isimler,arananIsim);
		
		if(indeks!=-1){
		    Console.WriteLine($"Aranan İsim: {arananIsim}, Dizide {indeks+1}. Sırada Bulunmaktadır.");
		}
		else{
		    Console.WriteLine($"Aranan İsim ({arananIsim}), Dizide YOK (NASIL YEKTA YAZMAZSINNNN KENDİ KANIMIZI SUNDUK İSTANBULA HATIRA DİYEEEE)");
		}
	}
}
