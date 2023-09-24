using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using TouristСenterLibrary.Entity;

namespace TouristСenterLibrary
{
    public static class EntityConfigure
    {
        public static void SchoolConfigure(EntityTypeBuilder<School> builder)
        {
            using var file1 = File.Open("schools.json", FileMode.Open);
           
            var schools = JsonSerializer.Deserialize<TmpJsonClass>(file1);
            for (int i = 0; i < schools.features.Count; i++)
            {
                builder.HasData(new School()
                {
                    ID = i + 1, 
                    Name = schools.features[i].properties.CompanyMetaData.name,
                    Address = schools.features[i].properties.CompanyMetaData.address,
                    IsSchool = true
                });
            }

            using var file2 = File.Open("kindergarten.json", FileMode.Open);

            var kindergarten = JsonSerializer.Deserialize<TmpJsonClass>(file2);
            for (int i = 0; i < kindergarten.features.Count; i++)
            {
                builder.HasData(new School()
                {
                    ID = i + 1 + schools.features.Count, 
                    Name = kindergarten.features[i].properties.CompanyMetaData.name,
                    Address = kindergarten.features[i].properties.CompanyMetaData.address,
                    IsSchool = false
                });
            }

        }

        public static void RoleConfigure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(new Role("admin") { ID = 1 });
        }

        public static void ApplicationTypeConfigure(EntityTypeBuilder<ApplicationType> builder)
        {
            builder.HasData(new ApplicationType("Семейная") { ID = 1 });
            builder.HasData(new ApplicationType("ИП") { ID = 2 });
            builder.HasData(new ApplicationType("ООО") { ID = 3 });
        }
        public static void DriverConfigure(EntityTypeBuilder<Driver> builder)
        {
            builder.HasData(new Driver("Петрашку","Сергей","Иосифович","+79229398345", "9923903185", "кат. В, С, Д", DateTime.Parse("24.02.2021"), 3)  { ID = 1 });
            builder.HasData(new Driver("Косарев","Максим","Викторович","+79229683026", "4330587108", "кат. А, В, С, Д", DateTime.Parse("05.05.2017"), 3)  { ID = 2 });
            builder.HasData(new Driver("Овсянников","Александр","Викторович","+79513557221", "6235937363", "кат. В, С, Д", DateTime.Parse("23.03.2018"), 3)  { ID = 3 });
            builder.HasData(new Driver("Зайченко","Александр","Сергеевич","+79536783108", "4325987190", "кат. А, В, С, Д", DateTime.Parse("03.11.2015"), 3)  { ID = 4 });
        }
        public static void TransportConfigure(EntityTypeBuilder<Transport> builder)
        {
            builder.HasIndex(s => s.CarNumber).IsUnique();
            builder.HasData(new Transport("Higer KLQ 6885 Q", "H 233 XA 43 RUS","126681052200980", DateTime.Parse("14.06.2023"),35)  { ID = 1 });
            builder.HasData(new Transport("Zhong tong LCK", "В 197 СР 43 RUS","056571012201376", DateTime.Parse("20.04.2023"),53)  { ID = 2 });
            builder.HasData(new Transport("Mersedes-Benz O 510 Tour", "А 375 ХО 43 RUS","126681052200365", DateTime.Parse("17.02.2023"),34)  { ID = 3 });
            builder.HasData(new Transport("Higer KLQ 6122 B", "В 503 ТВ 43 RUS","126681052200723", DateTime.Parse("26.10.2023"),51)  { ID = 4 });
            }

        public static void TypeEventConfigure(EntityTypeBuilder<TypeEvent> builder)
        {
            builder.HasData(new TypeEvent() { ID = 1, Name = "Новогодье", Description = "Новый год", ShortName = "ДДМ", Shablon = "ddm"});
            builder.HasData(new TypeEvent() { ID = 2, Name = "Встреча весны", Description = "Масленица",ShortName = "ВМ", Shablon = "vm"});
            builder.HasData(new TypeEvent() { ID = 3, Name = "Выпускные", Description = "Выпускной", ShortName = "ВЫП", Shablon = "vip"});
            builder.HasData(new TypeEvent() { ID = 4, Name = "Ночные выпускные", Description = "Ночной Выпускной", ShortName = "НВЫП", Shablon = "nv"});
            builder.HasData(new TypeEvent() { ID = 5, Name = "Выпускные,г.Сыктывкар", Description = "Выпускные,г.Сыктывкар", ShortName = "ВЫП", Shablon = "vip"});
        }

        public static void CheckpointRouteConfigure(EntityTypeBuilder<CheckpointRoute> builder)
        {
            List<CheckpointRoute> checkpointRoutes = new List<CheckpointRoute>();
            checkpointRoutes.Add(new CheckpointRoute("Советский р-он, д. Фокино", "Старт") { ID = 1 });
            checkpointRoutes.Add(new CheckpointRoute("Советский р-он, д. Долбилово", "Финиш") { ID = 2 });
            checkpointRoutes.Add(new CheckpointRoute("Нагорский р-он, Летский рейд", "Старт") { ID = 3 });
            checkpointRoutes.Add(new CheckpointRoute("Белохолуницкий р-он, п.Стеклофилины", "Финиш") { ID = 4 });
            checkpointRoutes.Add(new CheckpointRoute("Юрьянский р-он, устье р. Великая", "Старт") { ID = 5 });
            checkpointRoutes.Add(new CheckpointRoute("Орловский р-он, г. Орлов", "Финиш") { ID = 6 });
            checkpointRoutes.Add(new CheckpointRoute("Советский р-он, п. Петропавловское", "Старт") { ID = 7 });
            checkpointRoutes.Add(new CheckpointRoute("Лебяжский р-он, д. Приверх", "Финиш") { ID = 8 });
            checkpointRoutes.Add(new CheckpointRoute("Оричевский р-он, д. Решетники", "Старт") { ID = 9 });
            checkpointRoutes.Add(new CheckpointRoute("Слободской р-он, д. Бошарово", "Финиш") { ID = 10 });
            checkpointRoutes.Add(new CheckpointRoute("г. Нововятск, Набережная", "Старт") { ID = 11 });
            checkpointRoutes.Add(new CheckpointRoute("г. Киров, Заречный парк", "Финиш") { ID = 12 });
            checkpointRoutes.Add(new CheckpointRoute("г. Киров, Новый мост", "Старт") { ID = 13 });
            checkpointRoutes.Add(new CheckpointRoute("Юрьянский р-он, п. Мурыгино", "Финиш") { ID = 14 });
            checkpointRoutes.Add(new CheckpointRoute("Слободской-р-он, п. Боровица", "Старт") { ID = 15 });
            checkpointRoutes.Add(new CheckpointRoute("Слободской р-он, Сидоровка", "Финиш") { ID = 16 });
            checkpointRoutes.Add(new CheckpointRoute("Оричевский р-он, п Стрижи", "Старт") { ID = 17 });
            checkpointRoutes.Add(new CheckpointRoute("г. Слободской", "Старт") { ID = 18 });
            checkpointRoutes.Add(new CheckpointRoute("Слободской р-он, д Бабичи", "Финиш") { ID = 19 });
            checkpointRoutes.Add(new CheckpointRoute("г. Кирово-Чепецк", "Финиш") { ID = 20 });
            builder.HasData(checkpointRoutes);
        }

        public static void RouteConfigure(EntityTypeBuilder<Route> builder)
        {
            List<Route> routes = new List<Route>();
            routes.Add(new Route("Любимая Немда", 3, "Красавица река НЕМДА является жемчужиной Вятского края")
            {
                ID = 1,
                FullDescription =
                    "Красавица река НЕМДА является жемчужиной Вятского края. Природа этих мест уникальна: выходы известняковых скал, рельефные берега, бурлящие перекаты, самый высокий водопад Кировской области, чистая родниковая вода, отсутствие комаров, живописные пейзажи",
                CheckpointStartID = 1, CheckpointFinishID = 2, River = "Nemda"
            });
            routes.Add(new Route("Любимая Немда(4 дня)", 4, "Красавица река НЕМДА является жемчужиной Вятского края")
            {
                ID = 2,
                FullDescription =
                    "Красавица река НЕМДА является жемчужиной Вятского края. Природа этих мест уникальна: выходы известняковых скал, рельефные берега, бурлящие перекаты, самый высокий водопад Кировской области, чистая родниковая вода, отсутствие комаров, живописные пейзажи",
                CheckpointStartID = 1, CheckpointFinishID = 2, River = "Nemda"
            });
            routes.Add(new Route("Затерянный мир", 3, "Затерянный мир На Вятке")
            {
                ID = 3,
                FullDescription =
                    "Затерянный мир На Вятке. Маршрут, где можно насладиться по настоящему дикой природой, редкими расстениями и ощутить настоящее единение с природой. ",
                CheckpointStartID = 3, CheckpointFinishID = 4, River = "Vyatka"
            });
            routes.Add(new Route("Родные просторы", 3, "Великолепный маршрут Родные просторы по берегам реки Вятки")
            {
                ID = 4,
                FullDescription =
                    "Великолепный маршрут Родные просторы по берегам реки Вятки подарит огромное количество позитивных эмоций и незабываемых впечатлений.",
                CheckpointStartID = 5, CheckpointFinishID = 6, River = "Vyatka}"
            });
            routes.Add(new Route("Поющие пески", 3, "Поющие пески Вятки ")
            {
                ID = 5,
                FullDescription =
                    "У заброшенной деревни Атары в Кировской области, где Вятка делает крутой поворот, находится трехкилометровая отмель с белым песком из горного хрусталя и молочного кварца. ",
                CheckpointStartID = 7, CheckpointFinishID = 8, River = "Vyatka"
            });
            routes.Add(
                new Route("Быстрая вода", 2,
                    "Очень красивые и живописные места, на очень быстрой и стремительной реке Быстрице")
                {
                    ID = 6,
                    FullDescription =
                        "Очень красивые и живописные места, на очень быстрой и стремительной реке Быстрице откроются перед вами если вы посетите этот маршрут",
                    CheckpointStartID = 9, CheckpointFinishID = 10, River = "Bystrica"
                });
            routes.Add(
                new Route("Быстрая вода(3 дня)", 3,
                    "Очень красивые и живописные места, на очень быстрой и стремительной реке Быстрице")
                {
                    ID = 7,
                    FullDescription =
                        "Очень красивые и живописные места, на очень быстрой и стремительной реке Быстрице откроются перед вами если вы посетите этот маршрут",
                    CheckpointStartID = 9, CheckpointFinishID = 10, River = "Bystrica"
                });
            routes.Add(new Route("Город с воды", 1, "С воды раскрываются все красоты города Кирова")
            {
                ID = 8,
                FullDescription =
                    "С воды раскрываются все красоты города Кирова. Появляется возможность насладиться ими прямо с водной глаяди реки Вятки.",
                CheckpointStartID = 11, CheckpointFinishID = 12, River = "Vyatka"
            });
            routes.Add(new Route("Мосты вятки", 1, "Мосты вятки")
            {
                ID = 9, FullDescription = "Мосты вятки", CheckpointStartID = 13, CheckpointFinishID = 14,
                River = "Vyatka"
            });
            routes.Add(new Route("Путь ушкуйников", 1, "Путь ушкуйников")
            {
                ID = 10, FullDescription = "Путь ушкуйников", CheckpointStartID = 15, CheckpointFinishID = 16,
                River = "Vyatka"
            });
            routes.Add(new Route("Фестивальный", 1, "Фестивальный")
            {
                ID = 11, FullDescription = "Фестивальный", CheckpointStartID = 17, CheckpointFinishID = 10,
                River = "Bystrica"
            });
            routes.Add(new Route("Слободская регата PRO", 1, "Слободская регата PRO")
            {
                ID = 12, FullDescription = "Слободская регата PRO", CheckpointStartID = 18, CheckpointFinishID = 19,
                River = "Vyatka"
            });
            routes.Add(new Route("Слободская регата LITE", 1, "Слободская регата LITE")
            {
                ID = 13, FullDescription = "Слободская регата LITE", CheckpointStartID = 18, CheckpointFinishID = 20,
                River = "Vyatka"
            });
            builder.HasData(routes);
        }

        public static void UserConfigure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Surname).IsRequired();
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(15);
            builder.HasIndex(e => e.PhoneNumber).IsUnique();
        }

        public static void EventUserConfigure(EntityTypeBuilder<EventUser> builder)
        {
            builder.Property(e => e.Surname).IsRequired();
            builder.Property(e => e.Name).IsRequired();
        }
        public static void EmployeeConfigure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Surname).IsRequired();
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(15);
            builder.HasIndex(s => s.PhoneNumber).IsUnique();
            builder.HasIndex(s => s.PassportData).IsUnique();
            builder.HasData(new Employee("Кондрашов", "Леонид", "Матвеевич", "3316 345677", "+79532521240",
                DateTime.Parse("12/2/2020 00:00")) { ID = 1, RoleID = 1 });
        }

        public static void TransportCompanyConfigure(EntityTypeBuilder<TransportCompany> builder)
        {
            builder.HasIndex(s => s.PhoneNumber).IsUnique();
        }

        public static void InstructorConfigure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(e => e.Surname).IsRequired();
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(15);
            builder.HasIndex(s => s.PhoneNumber).IsUnique();
        }

        public static void EquipmentConfigure(EntityTypeBuilder<Equipment> builder)
        {
            List<Equipment> equipments = new List<Equipment>();
            equipments.Add(new Equipment("Рафт A", DateTime.Parse("7/8/2019 00:00"), "raft") { ID = 1 });
            equipments.Add(new Equipment("Рафт D", DateTime.Parse("7/8/2019 00:00"), "raft") { ID = 2 });
            equipments.Add(new Equipment("Рафт K", DateTime.Parse("7/8/2019 00:00"), "raft") { ID = 3 });
            equipments.Add(new Equipment("Рафт L", DateTime.Parse("7/8/2019 00:00"), "raft") { ID = 4 });
            equipments.Add(new Equipment("Рафт M", DateTime.Parse("7/8/2019 00:00"), "raft") { ID = 5 });
            equipments.Add(new Equipment("Рафт R", DateTime.Parse("7/8/2019 00:00"), "raft") { ID = 6 });
            equipments.Add(new Equipment("Рафт S", DateTime.Parse("7/8/2019 00:00"), "raft") { ID = 8 });
            equipments.Add(new Equipment("Рафт X", DateTime.Parse("7/8/2019 00:00"), "raft") { ID = 9 });
            equipments.Add(new Equipment("Рафт Q", DateTime.Parse("7/8/2019 00:00"), "raft") { ID = 10 });
            equipments.Add(new Equipment("Байдарка2 A", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 11 });
            equipments.Add(new Equipment("Байдарка2 B", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 12 });
            equipments.Add(new Equipment("Байдарка2 C", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 13 });
            equipments.Add(new Equipment("Байдарка2 D", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 14 });
            equipments.Add(new Equipment("Байдарка2 E", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 15 });
            equipments.Add(new Equipment("Байдарка2 F", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 16 });
            equipments.Add(new Equipment("Байдарка2 G", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 17 });
            equipments.Add(new Equipment("Байдарка2 H", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 18 });
            equipments.Add(new Equipment("Байдарка2 I", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 19 });
            equipments.Add(new Equipment("Байдарка2 J", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 20 });
            equipments.Add(new Equipment("Байдарка2 K", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 21 });
            equipments.Add(new Equipment("Байдарка2 L", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 22 });
            equipments.Add(new Equipment("Байдарка2 M", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 23 });
            equipments.Add(new Equipment("Байдарка2 O", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 24 });
            equipments.Add(new Equipment("Байдарка2 P", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 25 });
            equipments.Add(new Equipment("Байдарка2 Q", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 26 });
            equipments.Add(new Equipment("Байдарка2 R", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 27 });
            equipments.Add(new Equipment("Байдарка2 S", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 28 });
            equipments.Add(new Equipment("Байдарка2 T", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 29 });
            equipments.Add(new Equipment("Байдарка2 U", DateTime.Parse("7/8/2019 00:00"), "kayak2") { ID = 30 });
            equipments.Add(new Equipment("Байдарка3 I", DateTime.Parse("7/8/2019 00:00"), "kayak3") { ID = 31 });
            equipments.Add(new Equipment("Байдарка3 J", DateTime.Parse("7/8/2019 00:00"), "kayak3") { ID = 32 });
            equipments.Add(new Equipment("Байдарка3 Q", DateTime.Parse("7/8/2019 00:00"), "kayak3") { ID = 33 });
            equipments.Add(new Equipment("Байдарка3 K", DateTime.Parse("7/8/2019 00:00"), "kayak3") { ID = 34 });
            equipments.Add(new Equipment("Байдарка3 P", DateTime.Parse("7/8/2019 00:00"), "kayak3") { ID = 35 });
            equipments.Add(new Equipment("Беседка A", DateTime.Parse("7/8/2019 00:00"), "pavilion") { ID = 36 });
            equipments.Add(new Equipment("Беседка B", DateTime.Parse("7/8/2019 00:00"), "pavilion") { ID = 37 });
            equipments.Add(new Equipment("Беседка C", DateTime.Parse("7/8/2019 00:00"), "pavilion") { ID = 38 });
            equipments.Add(new Equipment("Беседка D", DateTime.Parse("7/8/2019 00:00"), "pavilion") { ID = 39 });
            equipments.Add(new Equipment("Беседка F", DateTime.Parse("7/8/2019 00:00"), "pavilion") { ID = 40 });
            equipments.Add(new Equipment("Складной стол №1", DateTime.Parse("7/8/2019 00:00"), "table") { ID = 41 });
            equipments.Add(new Equipment("Складной стол №2", DateTime.Parse("7/8/2019 00:00"), "table") { ID = 42 });
            equipments.Add(new Equipment("Складной стол №3", DateTime.Parse("7/8/2019 00:00"), "table") { ID = 43 });
            equipments.Add(new Equipment("Складной стол №4", DateTime.Parse("7/8/2019 00:00"), "table") { ID = 44 });
            equipments.Add(new Equipment("Складной стол №5", DateTime.Parse("7/8/2019 00:00"), "table") { ID = 45 });
            equipments.Add(new Equipment("Складной стол №6", DateTime.Parse("7/8/2019 00:00"), "table") { ID = 46 });
            equipments.Add(new Equipment("Топор H", DateTime.Parse("7/8/2019 00:00"), "ax") { ID = 47 });
            equipments.Add(new Equipment("Топор N", DateTime.Parse("7/8/2019 00:00"), "ax") { ID = 48 });
            equipments.Add(new Equipment("Топор Q", DateTime.Parse("7/8/2019 00:00"), "ax") { ID = 49 });
            equipments.Add(new Equipment("Топор T", DateTime.Parse("7/8/2019 00:00"), "ax") { ID = 50 });
            equipments.Add(new Equipment("Топор Y", DateTime.Parse("7/8/2019 00:00"), "ax") { ID = 56 });
            builder.HasData(equipments);
        }

        public static void CountableEquipmentConfigure(EntityTypeBuilder<CountableEquipment> builder)
        {
            List<CountableEquipment> countableEquipments = new List<CountableEquipment>();
            countableEquipments.Add(new CountableEquipment("Коврик", 150) { ID = 1 });
            countableEquipments.Add(new CountableEquipment("Спальник", 139) { ID = 2 });
            countableEquipments.Add(new CountableEquipment("Канистра", 50) { ID = 3 });
            countableEquipments.Add(new CountableEquipment("Палатка Lair4", 40) { ID = 4 });
            countableEquipments.Add(new CountableEquipment("Палатка Lair3", 15) { ID = 5 });
            countableEquipments.Add(new CountableEquipment("Палатка Lair2", 22) { ID = 6 });
            countableEquipments.Add(new CountableEquipment("Весло", 120) { ID = 7 });
            countableEquipments.Add(new CountableEquipment("Котелок 10л", 10) { ID = 8 });
            countableEquipments.Add(new CountableEquipment("Котелок 8л", 9) { ID = 9 });
            countableEquipments.Add(new CountableEquipment("Костровые стойки", 10) { ID = 10 });
            countableEquipments.Add(new CountableEquipment("Гермомешок", 142) { ID = 11 });
            builder.HasData(countableEquipments);
        }
    }
}