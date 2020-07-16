# .netcorebackendexample

Tablo için script

CREATE TABLE Article (
    Id INT PRIMARY KEY IDENTITY (1, 1),
    Keywords VARCHAR (50),
    Name VARCHAR (50),
    AuthorId VARCHAR (50)
);

 Veriye erişimin ve yönetimin tek noktaya indirilmesini sağlayan bir tasarım desenidir. Veritabanını modüler olarak parçalara bölerek yönetmemizi kolaylaştırdığı için bu Design Pattern'i tercih ettim.

Bu tasarım düzenini ben kendi çabalarım ve araştırmalarım ile öğrendim. Şirket veya herhangi prod'da olan bir proje üzerinde bu kütüphane veya bu tasarım düzenini kullanmadım.

Daha bir çok farklı modül eklenebilir tabi ihtiyaçlar doğrultusunda. Fakat çok üst düzeyde herhangi ne eklenebilir konusunda bir fikrim yok açıkçası.
