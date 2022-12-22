# .Net Core ile Web API

| Özellik | Hedef | Metod |
|   ---   |  ---  | --- |
| Kullanıcılar ürünleri rengine göre seçebilir|  localhost:portno/api/boats/colors/{color} localhost:portno/api/cars/colors/{color} localhost:portno/api/buses/colors/{color}| [GET] |
|Kullanıcı aracın farlarını araç kimliğine göre açıp kapatabilir|  localhost:portno/api/boats/{id} localhost:portno/api/cars/{id} localhost:portno/api/buses/{id}|[POST] | 
|Kullanıcı araçları silebilir| localhost:portno/api/boats/{id} localhost:portno/api/cars/{id} localhost:portno/api/buses/{id}|[DELETE]| 
|Kullanıcı araçların tamamını görüntüleyebilir| localhost:portno/api/boats localhost:portno/api/cars localhost:portno/api/buses|[GET]| 
|Kullanıcı araçları id'sine göre getirebilir|localhost:portno/api/boats/id/{id} localhost:portno/api/cars/id/{id} localhost:portno/api/buses/id/{id}|[GET]|
|Kullanıcı araç ekleyebilir|localhost:portno/api/boats localhost:portno/api/cars localhost:portno/api/buses|[POST]

**Not:** Veritabanı olarak olarak SQL server 2019 ve SSMS 2019 kullanılmıştır bu yüzden kurulumları yapılmalıdır.  ConnectionString'i appsettings.json dosyasına ekledikten sonra `dotnet ef database update` kodunu terminale işleyerek ilgili tablolar oluşturulur. Sonra tablolara verileri ekleyerek denemeler gerçekleştirilebilir.

**Not:** Bazı kontroller gerçekleştirilmemiştir. Bu kontroller gerçekleştirilerek güvenlik önlemi alınabilir. Ayrıca repository katmanında generic yapı kullanılarak her model için ayrı repository katmanı oluşturmaya gerek kalmaz. 

