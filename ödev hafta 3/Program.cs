
using Acun_Medya_Odev_Hafta_3;

Mercedes mercedes = new Mercedes();
Audi audi = new Audi(); 
Togg togg = new Togg();
Nissan nissan = new Nissan();

mercedes.brand = "Mercedes";
mercedes.gear = "Düz";

audi.brand = "Audi";
audi.gear = "Otomatik";

togg.brand = "TOOG";
togg.gear = "Otomatik";

nissan.brand = "Nissan";
nissan.gear = "Düz";


mercedes.whriteFeatures();
audi.whriteFeatures();
togg.whriteFeatures();
nissan.whriteFeatures();

/*
 
 Abstract Class (Soyut Sınıf)

Soyut sınıf, bir nevi "şablon" gibidir. Kendi başına çalışmaz ama
ondan türeyen sınıflara rehberlik eder. Örneğin, bir "Taşıt" soyut
sınıfı düşünelim. "Git" gibi bir metodu olabilir ama bunun nasıl
çalışacağını belirlemez. Arabalar, bisikletler veya trenler bu sınıftan
türeyerek kendi "Git" yöntemlerini kendileri belirler.

Abstraction (Soyutlama)

Soyutlama, karmaşık sistemleri daha anlaşılır hale getirmek için
ayrıntıları gizleme işlemidir. Arabayı kullanırken motorun nasıl
çalıştığını bilmek zorunda değiliz, sadece gaz pedalına basarız. 
İşte bu, soyutlamadır! Kullanıcıya sadece gerekli olan kısmı 
gösteririz, geri kalan karmaşıklığı saklarız.

Polymorphism (Çok Biçimlilik)

Çok biçimlilik, aynı işlemi farklı şekillerde yapabilmek anlamına
gelir. Mesela, "Konuş" diye bir fonksiyon olsun. İnsan konuşunca
kelimeler çıkar, köpek konuşunca havlar, kedi miyavlar. Yani aynı
komut (Konuş) her tür için farklı bir sonuç üretir. İşte bu, çok
biçimliliğin en basit örneğidir.
 */