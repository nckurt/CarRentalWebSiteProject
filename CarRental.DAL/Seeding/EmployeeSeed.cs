using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class EmployeeSeed  {
        public static void EmployeeSeedData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Employee>().HasData(
                new Employee {
                    EmployeeID = 1,
                    FirstName = "Cengiz",
                    LastName = "Ilhan",
                    Gender = 'M',
                    BloodType= "ARh(+)",
                    Email = "cengizilhan@gmail.com",
                    Education = "İstanbul Teknik Üniversitesi",
                    BirthDate = DateTime.ParseExact("1956/05/11", "yyyy/MM/dd", null),
                    Phone = "05308563214",
                    Address = "ÇANKAYA MH SOGUKSU CD NO 20/A Istanbul",
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                },
                new Employee {
                    EmployeeID = 2,
                    FirstName = "Yeliz",
                    LastName = "Budak",
                    Gender = 'F',
                    BloodType = "BRh(+)",
                    Email = "yelizbudak@gmail.com",
                    Education = "İstanbul Üniversitesi",
                    BirthDate = DateTime.ParseExact("1991/06/08", "yyyy/MM/dd", null),
                    Phone = "05308563201",
                    Address = "ÇANKAYA MH SOGUKSU CD NO 20/A Istanbul",
                    ReportsToID = 1,
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                },
                new Employee {
                    EmployeeID = 3,
                    FirstName = "Serkan",
                    LastName = "Okat",
                    Gender = 'M',
                    BloodType = "ABRh(+)",
                    Email = "serkanokat@gmail.com",
                    Education = "Koç Üniversitesi",
                    BirthDate = DateTime.ParseExact("1985/03/30", "yyyy/MM/dd", null),
                    Phone = "05308563202",
                    Address = "BAGLARBASI MH EDEN CD NO 2/b Istanbul",
                    ReportsToID = 1,
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                },
                new Employee {
                    EmployeeID = 4,
                    FirstName = "Osman",
                    LastName = "Büyük",
                    Gender = 'M',
                    BloodType = "ARh(+)",
                    Email = "büyükosman@gmail.com",
                    Education = "Ege Üniversitesi",
                    BirthDate = DateTime.ParseExact("1985/04/01", "yyyy/MM/dd", null),
                    Phone = "05308563203",
                    Address = "CENNET MH EVREN CD NO 14/5 Istanbul",
                    ReportsToID = 1,
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                },
                new Employee {
                    EmployeeID = 5,
                    FirstName = "Seren",
                    LastName = "Serengil",
                    Gender = 'F',
                    BloodType = "0Rh(-)",
                    Email = "serenserengiller@gmail.com",
                    Education = "Bahçeşehir Üniversitesi",
                    BirthDate = DateTime.ParseExact("1991/09/03", "yyyy/MM/dd", null),
                    Phone = "05308563204",
                    Address = "DURAK MH TERSHANE CD NO 8/5 Istanbul",
                    ReportsToID = 4,
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                },
                new Employee {
                    EmployeeID = 6,
                    FirstName = "Cenk",
                    LastName = "Tasyürek",
                    Gender = 'M',
                    BloodType = "ARh(-)",
                    Email = "cenktasyurek.com",
                    Education = "İstanbul Teknik Üniversitesi",
                    BirthDate = DateTime.ParseExact("1991/05/08", "yyyy/MM/dd", null),
                    Phone = "05308563205",
                    Address = "Bostan MH TALAT CD NO 2/5 Istanbul",
                    ReportsToID = 4,
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                },
                new Employee {
                    EmployeeID = 7,
                    FirstName = "Melis",
                    LastName = "Sal",
                    Gender = 'F',
                    BloodType = "ABRh(+)",
                    Email = "cerensal@gmail.com",
                    Education = "Yeditepe Üniversitesi",
                    BirthDate = DateTime.ParseExact("1991/12/04", "yyyy/MM/dd", null),
                    Phone = "05308563206",
                    Address = "Atatürk MH Cumhuriyet CD NO 2/5 Istanbul",
                    ReportsToID = 4,
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                },
                new Employee {
                    EmployeeID = 8,
                    FirstName = "Hande",
                    LastName = "Süslü",
                    Gender = 'F',
                    BloodType = "ARh(+)",
                    Email = "handesüslü@gmail.com",
                    Education = "İstanbul Teknik Üniversitesi",
                    BirthDate = DateTime.ParseExact("1992/11/13", "yyyy/MM/dd", null),
                    Phone = "05308563207",
                    Address = "Karabulut MH Inönü CD NO 7/2 Istanbul",
                    ReportsToID = 4,
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                },
                new Employee {
                    EmployeeID = 9,
                    FirstName = "Dursun",
                    LastName = "Candan",
                    Gender = 'M',
                    BloodType = "ARh(+)",
                    Email = "dursunusta@gmail.com",
                    Education = "Oxford",
                    BirthDate = DateTime.ParseExact("1960/05/13", "yyyy/MM/dd", null),
                    Phone = "05308563208",
                    Address = "Halil MH Dershane CD NO 3/5 Istanbul",
                    ReportsToID = 1,
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                },
                new Employee {
                    EmployeeID = 10,
                    FirstName = "Ekrem",
                    LastName = "Polat",
                    Gender = 'M',
                    BloodType = "0Rh(+)",
                    Email = "ekrempolat@gmail.com",
                    Education = "Bilkent Üniversitesi",
                    BirthDate = DateTime.ParseExact("1986/08/03", "yyyy/MM/dd", null),
                    Phone = "05308563209",
                    Address = "Halil MH Dershane CD NO 3/5 Istanbul",
                    ReportsToID = 9,
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                },
                new Employee {
                    EmployeeID = 11,
                    FirstName = "Esin",
                    LastName = "Kürek",
                    Gender = 'F',
                    BloodType = "ARh(-)",
                    Email = "esinkürek@gmail.com",
                    Education = "İstanbul Teknik Üniversitesi",
                    BirthDate = DateTime.ParseExact("1991/07/04", "yyyy/MM/dd", null),
                    Phone = "05308563210",
                    Address = "Kennedy MH Halici CD NO 3/5 Istanbul",
                    ReportsToID = 9,
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                },
                new Employee {
                    EmployeeID = 12,
                    FirstName = "Elif",
                    LastName = "Uygur",
                    Gender = 'F',
                    BloodType = "ARh(+)",
                    Email = "elifuygur@gmail.com",
                    Education = "Maltepe Teknik Üniversitesi",
                    BirthDate = DateTime.ParseExact("1991/02/27", "yyyy/MM/dd", null),
                    Phone = "05308563211",
                    Address = "Mumcu MH Gazi Mustafa Kemal CD NO 3/5 Istanbul",
                    ReportsToID = 9,
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                },
                new Employee {
                    EmployeeID = 13,
                    FirstName = "Yeliz",
                    LastName = "Yesilmen",
                    Gender = 'F',
                    BloodType = "ARh(+)",
                    Email = "yelizyesilmen@gmail.com",
                    Education = "Yıldız Teknik Üniversitesi",
                    BirthDate = DateTime.ParseExact("1983/07/04", "yyyy/MM/dd", null),
                    Phone = "05308563212",
                    Address = "Mali MH Erbil CD NO 10/5 Istanbul",
                    ReportsToID = 9,
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                },
                new Employee {
                    EmployeeID = 14,
                    FirstName = "Deniz",
                    LastName = "Akkaya",
                    Gender = 'F',
                    BloodType = "ARh(+)",
                    Email = "denizakkaya@gmail.com",
                    Education = "İzmir Ekonomi Üniversitesi",
                    BirthDate = DateTime.ParseExact("1982/07/04", "yyyy/MM/dd", null),
                    Phone = "05308563213",
                    Address = "Tatlises MH Türkü CD NO 45/5 Istanbul",
                    ReportsToID = 9,
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                },
                new Employee {
                    EmployeeID = 15,
                    FirstName = "Kuzey",
                    LastName = "Bati",
                    Gender = 'M',
                    BloodType = "ARh(+)",
                    Email = "kuzeybati@gmail.com",
                    Education = "Eskişehir Üniversitesi",
                    BirthDate = DateTime.ParseExact("1985/10/02", "yyyy/MM/dd", null),
                    Phone = "05308563215",
                    Address = "Giresunlular MH Sirma CD NO 02/5 Istanbul",
                    ReportsToID = 9,
                    Summary = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                });
        }
    }
}
