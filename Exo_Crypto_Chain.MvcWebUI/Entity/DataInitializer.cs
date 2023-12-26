using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exo_Crypto_Chain.MvcWebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="Solana",Description="Kripto para ürünleri"},
                new Category(){Name="Bitcoin",Description="Kripto para ürünleri"},
                new Category(){Name="Ethereum",Description="Kripto para ürünleri"},
                new Category(){Name="Tether USDt",Description="Kripto para ürünleri"},
                new Category(){Name="BNB",Description="Kripto para ürünleri"},
                new Category(){Name="Polygon",Description="Kripto para ürünleri"},
                new Category(){Name="XRP",Description="Kripto para ürünleri"},
                new Category(){Name="Cardano",Description="Kripto para ürünleri"},
                new Category(){Name="Avalanche",Description="Kripto para ürünleri"},
                new Category(){Name="Dogecoin",Description="Kripto para ürünleri"},
                new Category(){Name="TRON",Description="Kripto para ürünleri"},
                new Category(){Name="Dai",Description="Kripto para ürünleri"}


            };

            foreach (var kategori in kategoriler) 
            {
            
            context.Categories.Add(kategori);
            
            }
            context.SaveChanges();

            var urunler = new List<Product>() 
            {
             new Product(){Name="Solana",Description="Solana, merkeziyetsiz finans (DeFi) çözümleri sağlamak üzere blockchain teknolojisinin izne ihtiyaç duymayan yapısına dayanan, " +
             "işlevsel bir açık kaynak projesidir.Solana protokolü, merkeziyetsiz uygulama (DApp) geliştirmeyi kolaylaştırmak üzere tasarlandı. " +
             "Blockchain altyapısı üzerine inşa edilen Hisse İspatı (Proof-of-Stake, PoS) konsensüs algoritmasıyla birleştirilmiş Geçmiş İspatı (Proof-of-History, PoH) algoritması tercih edilerek ölçeklenebilirliğin iyileştirilmesi amaçlanmaktadır." +
             "Yenilikçi melez fikir birliği modeli sayesinde Solana, hem küçük çaplı yatırımcıların hem de kurumsal ölçekteki trader'ların ilgisini çekiyor.",Price= 1.10607 ,Stock=19004 , IsApproved=true ,CategoryId=1,IsHome=true ,Image="img4.jpg"},
             new Product(){Name="Bitcoin",Description="Bitcoin; değişmez, dağıtılmış bir işlem veritabanı olan, blok zinciri üzerinde çalışan, dijital olarak şifrelenmiş bir para birimidir.Dünyanın ilk kripto para birimi olan Bitcoin, hâla en üretken kripto para birimidir. Aynı zamanda, altcoin olarak bilinen, sonradan gelişen diğer tüm kripto para birimleri için bir bağlayıcı görevi görmektedir.İlk çıkan kripto varlık olan Bitcoin’nin avantajları oldukça fazladır.Enflasyon oranının düşük olması, güvenilir bir ödeme sistemi olması, gizliliğin ön planda olması gibi başlıca unsurlar Bitcoin’in Avantajları arasındadır. ",Price= 24.98401 ,Stock=2905 , IsApproved=true ,CategoryId=2,IsHome=true,Image="img1.jpg" },
             new Product(){Name="Ethereum",Description="Ethereum, ERC-20 kod sistemi sayesinde birçok kripto para biriminin altyapısını oluşturan merkeziyetsiz ve açık kaynak kodlu bir blok zinciridir. Ethereum blok zincirinin kurumsal kripto para birimi ise Ether'dir. Ether, Bitcoin'den sonra en büyük piyasa değerine sahip sanal paradır",Price= 7.80723 ,Stock=5089 , IsApproved=true ,CategoryId=3,IsHome=true,Image="img2.jpg"},
             new Product(){Name="Tether USDt",Description="Tether, (USDT) kripto para birimi ERC-20 protokolüne bağlı blockchain üzerinden işlem yapmaktadır. Tether (USDT) kripto para birimi Tether Limited şirketi tarafından piyasaya 2015 yılında sürülmüştür.Tether (USDT), ABD dolarının sanal versiyonu olan bir stabil coindir. Değeri her zaman 1 USDT = 1 $ olarak sabit işlem görmektedir. Şirket piyasada bulunan her bir Tether (USDT) kripto para karşılığında kasasında 1 ABD doları olduğunu iddia etmektedir.",Price= 2.65432 ,Stock=729004 , IsApproved=true ,CategoryId=4 ,IsHome=true,Image="img5.jpg"},
             new Product(){Name="BNB",Description="BNB, BNB Chain ekosistemine güç veren kripto paradır. Dünyanın en popüler hizmet tokenlerinden biri olan BNB'yi, diğer kripto paralar gibi alıp satmanın yanı sıra oldukça geniş uygulama ve kullanım alanlarında da kullanabilirsiniz.Ethereum Sanal Makinesini destekleyen BNB Smart Chain üzerinde kolayca merkeziyetsiz uygulama oluşturulabilmektedir. BSC ağı Proof of Stake konsensüs algoritmasını kullanmaktadır.",Price= 1.20599 ,Stock=5603201 , IsApproved=true ,CategoryId=5,IsHome=true,Image="img3.jpg" },
             new Product(){Name="Polygon",Description="Polygon’un esas hedeflerinden biri ağ üzerinde gerçekleşen ve etkileşimde bulunan işlemler arasındaki karmaşıklığı azaltmaktır. Polygon (MATIC), kullanıcılar, merkeziyetsiz finans yani DeFi uygulamaları ve ekosistemler arasındaki etkileşimi kolaylaştırmak üzere tasarlanmıştır. Polygon bu amaçla İş Kanıtı Taahhüt Zinciri (Proof-of-Stake Commit Chain) mekanizmasını ve onun Plasma adlı ölçeklendirme çözümünü kullanır.Plasma, Ethereum ağına önemli ölçüde ölçeklendirmeyi sağlayan bir çözümdür. Bu çözüm ile Polygon (MATIC), temel blok zincir üzerinde küresel çapta merkeziyetsiz finansal uygulamaların inşa edilebilmesine olanak sağlar.",Price= 2.1899 ,Stock=20349 , IsApproved=true ,CategoryId=6,IsHome=true ,Image="img6.jpg"},
             new Product(){Name="XRP",Description="XRP coin, XRP Ledger'ın (XRP Defteri) yerel kripto para birimidir. XRP Ledger, madencilik ve çoklu onay mekanizması gerektirmez. Bu durum, XRP Ledger'ı işleme süreçlerinde Bitcoin ve diğer çoğu kripto para biriminden daha hızlı ve daha verimli kılar. Ripple ağında, saniyede yaklaşık bin 500 işlem gerçekleşmektedir.XRP, diğer kripto para birimlerinin aksine, Ripple adında tek bir şirket tarafından kontrol edilmektedir.Ripple ağının yerel kripto para birimi XRP, Ripple şirketi tarafından geliştirilmekte ve düzenlenmektedir.Ripple’ın açık kaynak protokolü ve ağı, bankalar ve diğer kurumlar tarafından halihazırda kullanılmaktadır.Ripple ağı kendisini, kripto para birimlerine doğrudan bir rakip olarak değil, bankalar tarafından kullanılan SWIFT sisteminin güncellenmiş bir versiyonu olarak konumlandırıyor.Yeni XRP birimlerini basmak için bir madencilik süreci bulunmuyor.Önceden çıkarılmış 100 milyar birim XRP’nin sadece bir kısmı dolaşımdadır",Price= 9.7935 ,Stock=10823 , IsApproved=true ,CategoryId=7,IsHome=true,Image="img7.jpg"},
             new Product(){Name="Cardano",Description="Cardano, kripto para göndermek ve almak için kullanılabilecek ADA kripto sistemine sahip bir platformdur. Bu kripto para, paranın geleceğini temsil eder ve kriptografi ile güvenli olması garanti edilen hızlı, doğrudan transferleri mümkün kılar.Cardano yalnızca bir kripto para birimi değildir, her gün dünyadaki bireyler, kuruluşlar ve hükümetler tarafından kullanılan finansal uygulamaları yürütebilecek teknolojik bir platformdur. Platform, sistemde daha kolay güncelleme yapabilme ve yumuşak çatallanmalarla yükseltme yapılabilmesini kolaylaştıracak bloklar halinde inşa edilmiştir. ADA’yı yönetecek olan temel katmanının tamamlanmasının ardından, akıllı sözleşmeleri, ileride yapılacak ticaret ve işleri destekleyecek dijital yasal anlaşmaları ele almak için ayrı bir hesaplama katmanı yaratılacaktır.Cardano’nun sunduğu yenilik, kullanıcıların ihtiyaçlarını düzenleyicilerin talepleriyle dengeleyecek ve mahremiyeti düzenleme ile birleştirecek şekilde olmasıdır. Cardano’nun vizyonu, yeni düzenlenmiş bilgi işlem tarzının, herkese adil finansal hizmetlere açık erişim sağlayarak daha fazla finansal katılımı sağlayacağıdır.",Price= 6.3442,Stock=7869012 , IsApproved=true ,CategoryId=8,IsHome=true,Image="img8.jpg"},
             new Product(){Name="Avalanche",Description="Avalanche (AVAX), kripto para dünyasında daha hızlı ve ucuz bir şekilde çalışan ve ölçeklenebilir yapıya sahip bir kripto para ve blok zincir projesidir. Kurucuları arasında Emin Gün Sirer’de bulunan proje, 2020 yılının eylül ayında kullanıma açılmış, kısa süre içerisinde ciddi bir büyüklüğe ulaşmış ve birçok kullanıcı kazanmıştır.Avalanche projesi çoklu zincir yapısı ile üzerinde farklı amaçlar için inşa edilmiş birden fazla blok zincir bulundurabilmektedir. Projeler için özelleşmiş yapılara sahip olan alt ağlar Avalanche ekosisteminin en önemli ölçeklenme çözümü olarak karşımıza çıkmaktadır.Avalanche blok zinciri EVM destekli zincir yapısı ile yayınlanmasından kısa süre sonra birçok geliştirici tarafından tercih edilen bir blok zincir olmuştur. Ağ işlem ücretlerinin düşük ve Ethereum ile benzer altyapıyı kullanması birçok uygulamanın blok zincire kolayca entegre olmasına olanak sağlamıştır. Bu anlamda Avalanche, hem kullanıcı hem de geliştiriciler için kolay ve kullanımı kolay bir ekosistem sunmaktadır. Avalanche, DeFi, NFT, Metaverse gibi birçok yenilikçi alanda elverişli bir yapıya sahiptir.",Price= 4.7519  ,Stock=69012 , IsApproved=true ,CategoryId=9,IsHome=true,Image="img9.jpg"},
             new Product(){Name="Dogecoin",Description="Geleneksel bankacılık işlem ücretlerinin olmadığı ve aynı zamanda eğlenceli bir ödeme sistemi oluşturmak amacıyla tasarlanan Dogecoin (DOGE) Jackson Palmer ve Billy Markus tarafından üretilmiştir.Dogecoin (DOGE), blockchain teknolojisinde bir yenilik çıkarma amacı olmadığı için transferleri, Litecoin kripto para biriminin kurduğu blockchain ağı üzerinden gerçekleştirilmektedir. Litecoin ağında yapılan güncellemeler Dogecoin (DOGE) ağı için de geçerlidir.Dogecoin (DOGE)’i diğer kripto para birimlerinden ayıran en önemli özellik deflasyonist değil enflasyonist olmasıdır. Yani dolaşımdaki Dogecoin (DOGE) ile ilgili herhangi bir sınırlama yoktur. Bitcoin ve benzeri para birimleri sınıra ulaştığında madenciliğe devam etmek bir süre sonra karlı hale gelmeyecektir. Bu nedenle Dogecoin (DOGE) uzun vade işlemleri açısından da avantajlıdır.",Price= 3.9072  ,Stock=910130 , IsApproved=true ,CategoryId=10,IsHome=true,Image="img10.jpg"},
             new Product(){Name="TRON",Description="Tron, izinsiz araçlar, platformlar ve protokollerden oluşan bünyesiyle içerik dağıtım endüstrisini merkeziyetsiz hale getirmek ve demokratikleştirmek için oluşturulmuş gelişmiş bir blok zinciri (Blockchain) platformudur.Akıllı sözleşme özellikli bir blok zinciri olan Tron, geliştiricilerin çevrimiçi oyunlar, merkeziyetsiz borsalar, verim çiftlikleri, borç verme-borç alma platformları ve daha birçok amaç için tasarlanabilen merkeziyetsiz uygulamalar (dApp) oluşturmasına ve dağıtmasına olanak tanır.TRX, Tron Dao tarafından yayımlanan Tron protokolünün yerel ana ağ kripto para birimidir. TRX, Tron blok zincirindeki temel hesap birimidir. TRX ile tüm TRC tabanlı tokenler arasında işlemler yapılabilmektedir. TRX, blok zincirdeki işlemleri ve uygulamaları güçlendirerek tüm Tron ekosistemini arasında bir aracı olarak görev görür.Tron, kullanıcıların coğrafya, sansür veya herhangi bir sınırlama olmaksızın içeriklere erişebildiği merkeziyetsiz internete güç sağlamak için ve işleri kolaylaştırmak için ortaya çıkarılmıştır. Bu hedefe ulaşmak için benzersiz birkaç özellik barındırır.",Price= 2.6974 ,Stock=67083 , IsApproved=true ,CategoryId=11,IsHome=true,Image="img11.jpg"},
             new Product(){Name="Dai",Description="Dai, ödeme yöntemi olarak kullanımlarını ele alırken, tipik kripto paraların karşılaştığı en büyük engel olan fiyat dalgalanmalarını çözmeyi amaçlamaktadır. 1 DAI, 1 USD’ye yakın bir şekilde sabitlenerek “stablecoin” (sabit koin) olarak yerini almıştır.Dai (DAI) ile ilgileniyor, ama bunun ne olduğundan veya nereden başlayacağınızdan emin değil misiniz? Telaşa gerek yok. Bu kılavuz, bu proje hakkında bilmeniz gereken her şeyi size sunmak ve sizi piyasadaki en kullanıcı dostu yatırım deneyimine hazır hale getirmek için tasarlanmıştırDai, dünyanın ilk merkeziyetsiz, teminat destekli sabit kripto parasıdır.DAI, akıllı sözleşmelerdeki diğer kripto varlıklarını kilitleyerek ABD dolarına sabitlenmiş 1:1 değerini korumaya çalışan bir ERC-20 tokenidir.Merkezi bir otorite tarafından verilen ve kontrol edilen diğer stablelcoinlerin aksine, DAI, Ethereum blok zincirinde çalışan, merkeziyetsiz, özerk bir akıllı sözleşme ekosistemi olan Maker Protocol’ün yerel tokenidir.Teminatlı krediler, borç verenin sahip olduğu varlıkları kilitleyerek bir krediyi almasının bir yolunu sağlar.Geleneksel olarak, bu kredilerin faiz oranları teminatsız kredilerden daha düşüktür, çünkü kilitli varlıklar kredinin bir kısmını ödemek için tasfiye edilebilir.",Price= 1.5635  ,Stock=714601, IsApproved=true ,CategoryId=12,IsHome=true,Image="img12.jpg"}
            };

            foreach(var urun in urunler)
            {
                context.Products.Add(urun);


            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}