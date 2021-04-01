# E_Ticaret_Project
Bu proje sadece admin yetkisi olan kişilerin Crud işlemlerini yapabildiği, diğer kullanıcıların tüm listeyi görüp değişiklik yapamadığı projedir.
.net core platformunda genellikle jquery ajax kullanılarak geliştirildi.
Çalıştırmak için connectionstring i değiştirdikten sonra migrations ekleyerek önce ürünler sonrada identity için database oluşturun.

enable-migrations
add-migration myMigration
update-database

add-migration Identity
update-database
