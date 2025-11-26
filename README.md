# StoreApp – .NET 8 Clean Architecture

**StoreApp**, .NET 8 ile geliştirilen;**ASP.NET MVC**, **Web API**, **Class Library** ve **Entity Framework Core 8** bileşenlerini ayrı katmanlar olarak kullanılan modüler bir uygulamadır. 
Bu yapı; yönetilebilir, genişletilebilir ve test edilebilir bir proje mimarisi sağlar.

---

## 🧱 Mimari Yapı

.NET 8.0
│
├── ASP.NET MVC (UI Layer)
│
├── WEB API (Service Layer)
│
├── Class Library (Business & Data Layer)
│ └── Entity Framework Core 8.0
│
└── Database


## 🔍 Katmanların Açıklaması

### **ASP.NET MVC (UI Layer)**  
- Kullanıcı arayüzü katmanıdır.  
- Veriyi Web API üzerinden çeker.  
- Kullanıcı işlemlerinin görsel tarafını yönetir.  

---

### **WEB API (Service Layer)**  
- Uygulamanın servis katmanıdır.  
- MVC arayüzüne JSON formatında veri sağlar.  
- **Controller → Service → Repository** akışına göre tasarlanmıştır.

---

### **Class Library (Business & Data Layer)**  
- Domain modelleri, business servisler, repository yapısı ve `DbContext` burada bulunur.  
- Hem MVC hem Web API tarafından ortak olarak kullanılır.  
- Kod tekrarını azaltır ve temiz bir mimari oluşturur.

---

### **Entity Framework Core 8**  
- Veritabanı işlemleri (CRUD, Migrations, Fluent API) burada yönetilir.  
- EF Core konfigurasyonları tamamen **Class Library** içerisinde tutulur.

---
