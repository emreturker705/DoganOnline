Projeyi çalýþtýrabilmek için local bilgisayarda redis yüklü olmasý ve default olan 6379 portundan yayýn yapmasý gerekir.
çalýþtýrýlacak local PC üzerine Sql server 2008 ve üzerine, Database klasöründeki backup dosyasýný "NewsDatabase" ismi ile 
database oluþturup attach edilmelidir.
Proje ayaða kalkarken tüm nesneler, redis'e yazýlacak þekilde ayarlandý.
Ayrýca uygulama yine baþlarken timer ile son güncellenmiþ son 10 haber çekilerek cache yine güncelleniyor.
Tek tek key, value þeklinde de update edilebilirdi, ancak bunun için bir admin panel olmasý gerektiðini ve bu panel üzerinden ilgili key (haber)
yeni value ile güncllenebilirdi, ama böyle bir ortam olmadýðý için son güncellenmiþ 10 haber'e bakýp toplu olarak tutuldu.
Log katmaný eklenmedi, ama normalde olmasý gerekir. TODO olarak yazýlabilir.
UI katmaný ile zamaným olmadýðý için ilgilenemedim. Paging yapýlarak Updated date'e göre bir gösterim yapýlabilirdi. Ben cache'ten dönen nesnenin tamamýný yazdýrdým.