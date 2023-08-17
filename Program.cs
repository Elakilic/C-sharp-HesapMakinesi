// Basit Hesap Makinesi

Console.Write("1.Sayı : ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2.değeri girin : ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Toplama İşlemi İçin: +");
Console.WriteLine("Çıkarma İşlemi İçin: -");
Console.WriteLine("Çarpma İşlemi İçin: *");
Console.WriteLine("Bölme İşlemi İçin: /");

Console.WriteLine("İşlem seçin: + , - , * , /");
string? islem =Console.ReadLine();

double sonuc= 0;

if( islem == "+"){
    sonuc = sayi1 + sayi2;
    Console.WriteLine("Sonuç: " + sonuc);
}else if(islem == "-"){
    sonuc = sayi1 - sayi2;
    Console.WriteLine("Sonuç: " + sonuc);
}