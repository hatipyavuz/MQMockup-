# MQMockup
Trendyol - Sick Mq Form Mockup

Resim 1 : 
![alt text](https://image.prntscr.com/image/RrTr7PLZS-2FjeC-iW8C9g.png)

# Kurulum
Program başlatıldığında App.config file içinde belirtilen 2 adet Exchange Mq serverda otomatik olarak ayağa(Resim 2) kalkar. İstenildiği taktirde bu Queue isimleri Server vb. Değerler Sol üst köşede belirtilen “Ayarlar” sekmesinden değiştirilebilir.

Resim 2: 

![alt text](https://image.prntscr.com/image/rbfUd1c_TrOGWADFAMWPLw.png)


# Section 1 ( LA -> Konveyor)
 
Buradaki sectionda 2 adet veri girilmesi beklenir ve bu veriler “Ekle” butonuna basılırsa Ayarlarda belirtilen exhange e veriler yazılır. Bu Exchangeler ile Queue isimleri aynı olmak zorundadır. Exchangeler ise verileri Queue’lara aktarır. 
Not : 2 textbox’ında dolu olması beklenmez. Test süreçleri için bu alanlara validasyon koyulmadı

Queue Message Interface’i aşağıdaki şablondadır.
DateTime CreateDateTime { get; set; }
       string Barcode { get; set; }
       string Chute { get; set; }
Gönderilen mesaj Queue de aşağıdaki gibi görüntülenir.
Resim 3: 

![alt text](https://image.prntscr.com/image/d-pDbNhzQuGr_PVQ7klChA.png)

Consumer bölümünde bulunan start butonuna basıldığı taktirde queue üzerinde bir consumer açılır ve queuedeki mesajlar işlenmeye başlar

![alt text](https://image.prntscr.com/image/OTyyf4EwTEmU23LFRlyozQ.png)

Stop butonuna basıldığı taktirde ise bağlanmış olan Consumerın queue ile olan ilişkisi kesilir. 

![alt text](https://image.prntscr.com/image/Ke-iIbr7QJWFvu_-RjnHDw.png)


# Section 2 (Konveyor -> LA)

Buradaki sectionda 4 adet veri girilmesi beklenir ve bu veriler “Ekle” butonuna basılırsa Ayarlarda belirtilen exhange e veriler yazılır. Bu Exchangeler ile Queue isimleri aynı olmak zorundadır. Exchangeler ise verileri Queue’lara aktarır.

Not : 4 textbox’ında dolu olması beklenmez. Test süreçleri için bu alanlara validasyon koyulmadı
Queue Message Interface’i 

DateTime CreateDateTime { get; set; }
        string Barcode { get; set; }
        string Chute { get; set; }
        string ErrorCode { get; set; }
        string Error { get; set; }



# Section 3 

Hangi serverlara bağlanıldığını ve state bilgileri gösterilir. 


# Ayarlar

Herhangi bir yeni değer girilmez ise default olarak Trendyol Dev ortamlarına bağlanır. Bu uygulama Trendyol Dev sunucunda kuruludur.

![alt text](https://image.prntscr.com/image/mneYdK9-QHSo7FdotxdP_Q.png)

