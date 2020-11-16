

Interface Segration Principle

“Ara yüzlerin ayrılması prensibi”

Ara yüzler içinde sadece metotların imzaları bulunur. Bir ara yüz bir sınıfa implemente edildiği zaman, 
ara yüz’ün barındırdığı metotları barındırmak veya oluşturmak zorundadır. 
Zaten bu durumun aksi olduğundan hata alırız.

Eğer class içerisinde gerçekten ihtiyaç duyulmayan ve kullanılmayan metotlar ara yüz aracılığı ile 
implemente edilmiş ise bu kodlar dummy kod olur, bu yüzden ara yüzler ayrılmalı ve classlar açısından 
işlevsel olmayan metotlar barındırması engellenmelidir.