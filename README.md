# CarBook Araç Kiralama Projesi
Bu proje Murat Yücedağ ile birlikte yürüttüğümüz bootcampin ödev projesidir.
## Projeye Genel Bakış
Projede N Katmanlı mimari kullanılmıştır.

* Entity Layer
* DataAccess Layer
* Business Layer
* Dto Layer
* Presentation Layer
## Kullanılan Teknolojiler
* ASP.Net FrameWork
* ASP.Net Core API
* ASP.Net Core MVC
* SQL Server
* Entity FrameWork
* İdentity
* N Tier Architecture
* Fluent Validation
* PagedList
* ViewComponent

## Öne Çıkan Özellikler
* Kullanıcının ihtiyacı olduğu araç detaylarını girerek filtreleme yapması.
* Kullanıcı kiralayacağı aracın detayına yorumunu incelemesi.
* İdentity kullanarak kayıt ve giriş işlemlerinin yapılması.

## Admin Paneli
* Dashboard Sayfasında istatistikler
* Araç  ile ilgili CRUD işlemleri
* Marka,Model ile ilgilş CRUD işlemleri
* Gelen Mesajları Görüntüleme
* Araç Kategorileri CRUD işlemleri
* İdentity ile Login ve Register işlemleri

## Katmanlı Mimari Yapısı
* Projede, n katmanlı mimari kullanılmıştır. Her katmanın belirli bir sorumluluğu vardır:

* Entity Layer: Bu katmanda, uygulama içinde kullanılan entity sınıfları bulunmaktadır. Veritabanındaki tabloları temsil eder.

* Data Access Layer: Veritabanı işlemleri bu katmanda gerçekleştirilir. Entity Framework Code First yaklaşımı kullanılarak, veritabanı otomatik olarak oluşturulur ve güncellenir.

* Business Layer: İş kuralları bu katmanda uygulanır. Bu katman, veritabanı işlemlerini kullanarak iş mantığını yönetir.

* Presentation Layer: Bu katmanda, kullanıcı arayüzü ve yönlendirme işlemleri bulunur. Sayfalamak için PagedList, hata yönetimi için Fluent Validation kullanılmıştır.
## Veritabanı Diyagramı
![Ekran görüntüsü 2023-12-30 032756](https://github.com/Aydinmfatih/CarBook/assets/46519508/2a92af3a-30ce-45a0-aff4-f071d7553233)
![Ekran görüntüsü 2023-12-30 033035](https://github.com/Aydinmfatih/CarBook/assets/46519508/54600fab-1836-4b20-a924-24fdd2f52c41)
![Ekran görüntüsü 2023-12-30 033113](https://github.com/Aydinmfatih/CarBook/assets/46519508/c561b73e-6718-41a8-badc-129346c8d618)
![Ekran görüntüsü 2023-12-30 033130](https://github.com/Aydinmfatih/CarBook/assets/46519508/ce23c4ec-7729-41cf-a70a-a9ec22caa185)
![Ekran görüntüsü 2023-12-30 033159](https://github.com/Aydinmfatih/CarBook/assets/46519508/db981d31-689c-4816-af1d-8fb09bef7022)
![Ekran görüntüsü 2023-12-30 033237](https://github.com/Aydinmfatih/CarBook/assets/46519508/ac5a36a1-98b1-4e5b-b770-3cbb8e6def98)
![Ekran görüntüsü 2023-12-30 033304](https://github.com/Aydinmfatih/CarBook/assets/46519508/3dbeca0f-03cc-49bf-8d3b-8936f356520f)
![Ekran görüntüsü 2023-12-30 032829](https://github.com/Aydinmfatih/CarBook/assets/46519508/9b522cb2-1592-4744-bdf7-be65605a5992)
![Ekran görüntüsü 2023-12-30 033016](https://github.com/Aydinmfatih/CarBook/assets/46519508/f72022e6-7498-4f79-a47f-90094b432487)
![Ekran görüntüsü 2023-12-30 032409](https://github.com/Aydinmfatih/CarBook/assets/46519508/d13d72b3-aebd-4e4d-b234-bba1d79237f3)
![Ekran görüntüsü 2023-12-30 032426](https://github.com/Aydinmfatih/CarBook/assets/46519508/c7eba239-404c-410e-9b14-e00f954c13ff)
![Ekran görüntüsü 2023-12-30 032542](https://github.com/Aydinmfatih/CarBook/assets/46519508/60391a05-2117-4659-8d87-1f37cc743433)
![Ekran görüntüsü 2023-12-30 032631](https://github.com/Aydinmfatih/CarBook/assets/46519508/8100fee5-775c-4016-8748-4cdccd90d706)
![Ekran görüntüsü 2023-12-30 032603](https://github.com/Aydinmfatih/CarBook/assets/46519508/e1901318-d042-4b4f-a864-dba6f93e0286)



