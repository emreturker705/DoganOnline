Projeyi �al��t�rabilmek i�in local bilgisayarda redis y�kl� olmas� ve default olan 6379 portundan yay�n yapmas� gerekir.
�al��t�r�lacak local PC �zerine Sql server 2008 ve �zerine, Database klas�r�ndeki backup dosyas�n� "NewsDatabase" ismi ile 
database olu�turup attach edilmelidir.
Proje aya�a kalkarken t�m nesneler, redis'e yaz�lacak �ekilde ayarland�.
Ayr�ca uygulama yine ba�larken timer ile son g�ncellenmi� son 10 haber �ekilerek cache yine g�ncelleniyor.
Tek tek key, value �eklinde de update edilebilirdi, ancak bunun i�in bir admin panel olmas� gerekti�ini ve bu panel �zerinden ilgili key (haber)
yeni value ile g�ncllenebilirdi, ama b�yle bir ortam olmad��� i�in son g�ncellenmi� 10 haber'e bak�p toplu olarak tutuldu.
Log katman� eklenmedi, ama normalde olmas� gerekir. TODO olarak yaz�labilir.
UI katman� ile zaman�m olmad��� i�in ilgilenemedim. Paging yap�larak Updated date'e g�re bir g�sterim yap�labilirdi. Ben cache'ten d�nen nesnenin tamam�n� yazd�rd�m.