Günümüzde birçoğumuz C#, Java gibi nesne yönelimli programlama dilleri kullanıyoruz. Object Oriented Programlamanın 5 temel ve önemli Prensibi vardır.
SOLİD prensibi denilen bu kavramlar düzgün hatasız temiz bir kod yazmayı amaçlar.

1. (S)ingle Responsibility Principle

2. (O)pen/Closed Principle

3. (L)iskov ‘s Substitution Principle

4. (I)nterface Segregation Principle

5. (D)ependency Inversion Principle


1.Single Responsibility Principle

Projenin içerisindeki her bir yapı, diğer yapılara o kadar bağımlıdır ve yapılan işler o kadar iç içe geçmiştir ki; küçük bir değişikliğin neleri etkileyeceğini kestirmeniz çok zordur ve genelde böyle projeler çöp proje olarak görülür. İçerisindeki class’ları methodları alıp başka bir projede kullanamazsınız.

Eğer tek sorumluluk prensibine uyarsanız bu şekilde binlerce satırlık class’larınız methodlarınız olmaz. Her class’ın, her mothodun sadece tek bir yaptığı iş vardır, böylece bir değişiklik yapmak için sadece bir nedeniniz olmuş olur. Genişleyebilir, tekrar kullanılabilir ve test edilebilir yapılar kurmak için tek sorumlulukilkesini dikkate almamız gerekir.


2.Open/Closed Principle

Açık kapalı prensibi, yazılım geliştirirken kullandığımız varlıkların (class, method vs.) gelişime açık, kodların ise değişime kapalı olması ilkesidir. Örneğin; bir loglama altyapısı oluşturduğunuzu düşünün, Veritabanına ve XML’e kayıt tutuyorsunuz. Daha sonradan Eventloglara da log tutma ihtiyacı hissettiğinizde, sadece Eventloglara kayıt tutan kodları yazmanız yetecek, kodunuzda hiçbir değişiklik yapmadan bu yapı sisteme entegre olacak. Bunun için uygulayacağımız çözüm şu şekilde olabilir:
