using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BlzMON.Models;

namespace BlzMON.Data
{
    public class DataSeeder
    {
        public static void Seed(ApplicationDbContext db)
        {
            try
            {

                // Areas. But where districts?
                if (!db.Areaq.Any())
                {
                    db.Areaq.Add(new Areass() { Id = 1, AreaName = "Ысык-Куль" });
                    db.Areaq.Add(new Areass() { Id = 2, AreaName = "Джалал-Абад" });
                    db.Areaq.Add(new Areass() { Id = 3, AreaName = "Нарын" });
                    db.Areaq.Add(new Areass() { Id = 4, AreaName = "Баткен" });
                    db.Areaq.Add(new Areass() { Id = 5, AreaName = "Ош" });
                    db.Areaq.Add(new Areass() { Id = 6, AreaName = "Талас" });
                    db.Areaq.Add(new Areass() { Id = 7, AreaName = "Чуй" });
                    db.Areaq.Add(new Areass() { Id = 8, AreaName = "г.Бишкек" });
                    db.SaveChanges();
                }
                // Aloha, regions here
                if (!db.Region.Any())
                {
                    db.Region.Add(new Regions() { AreassId = 1, RegName = "АК-СУЙСКИЙ" });
                    db.Region.Add(new Regions() { AreassId = 1, RegName = "ЖЕТИ-ОГУЗСКИЙ" });
                    db.Region.Add(new Regions() { AreassId = 1, RegName = "ИССЫК-КУЛЬСКИЙ" });
                    db.Region.Add(new Regions() { AreassId = 1, RegName = "ТОНСКИЙ" });
                    db.Region.Add(new Regions() { AreassId = 1, RegName = "ТЮПСКИЙ" });
                    db.SaveChanges();

                    db.Region.Add(new Regions() { AreassId = 2, RegName = "АЛА-БУКИНСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 2, RegName = "БАЗАР-КОРГОНСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 2, RegName = "АКСЫЙСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 2, RegName = "НООКЕНСКИЙ" });
                    db.Region.Add(new Regions() { AreassId = 2, RegName = "СУЗАКСКИЙ" });
                    db.Region.Add(new Regions() { AreassId = 2, RegName = "ТОГУЗ-ТОРОУСКИЙ" });
                    db.Region.Add(new Regions() { AreassId = 2, RegName = "ТОКТОГУЛЬСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 2, RegName = "ЧАТКАЛЬСКИЙ " });
                    db.SaveChanges();

                    db.Region.Add(new Regions() { AreassId = 3, RegName = "АК-ТАЛИНСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 3, RegName = "АТ-БАШЫНСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 3, RegName = "ДЖУМГАЛЬСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 3, RegName = "КОЧКОРСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 3, RegName = "НАРЫНСКИЙ " });
                    db.SaveChanges();

                    db.Region.Add(new Regions() { AreassId = 4, RegName = "БАТКЕНСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 4, RegName = "ЛЕЙЛЕКСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 4, RegName = "КАДАМЖАЙСКИЙ " });
                    db.SaveChanges();

                    db.Region.Add(new Regions() { AreassId = 5, RegName = "АЛАЙСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 5, RegName = "АРАВАНСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 5, RegName = "КАРА-СУУСКИЙ" });
                    db.Region.Add(new Regions() { AreassId = 5, RegName = "НООКАТСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 5, RegName = "КАРА-КУЛЖИНСКИЙ" });
                    db.Region.Add(new Regions() { AreassId = 5, RegName = "УЗГЕНСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 5, RegName = "ЧОН-АЛАЙСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 5, RegName = "г.ОШ " });
                    db.SaveChanges();

                    db.Region.Add(new Regions() { AreassId = 6, RegName = "КАРА-БУУРИНСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 6, RegName = "БАКАЙ-АТИНСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 6, RegName = "МАНАССКИЙ" });
                    db.Region.Add(new Regions() { AreassId = 6, RegName = "ТАЛАССКИЙ " });
                    db.SaveChanges();

                    db.Region.Add(new Regions() { AreassId = 7, RegName = "АЛАМУДУНСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 7, RegName = "ЫСЫК-АТИНСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 7, RegName = "ЖАЙЫЛСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 7, RegName = "КЕМИНСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 7, RegName = "МОСКОВСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 7, RegName = "ПАНФИЛОВСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 7, RegName = "СОКУЛУКСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 7, RegName = "ЧУЙСКИЙ " });
                    db.SaveChanges();

                    db.Region.Add(new Regions() { AreassId = 8, RegName = "ЛЕНИНСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 8, RegName = "ОКТЯБРЬСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 8, RegName = "ПЕРВОМАЙСКИЙ " });
                    db.Region.Add(new Regions() { AreassId = 8, RegName = "СВЕРДЛОВСКИЙ " });
                    db.SaveChanges();
                }
                //
                if (!db.Possition.Any())
                {
                    db.Possition.Add(new Possitions() { PossName = "Учитель" });
                    db.Possition.Add(new Possitions() { PossName = "Преподаватель" });
                    db.Possition.Add(new Possitions() { PossName = "Педагог - организатор" });
                    db.Possition.Add(new Possitions() { PossName = "Социальный педагог" });
                    db.Possition.Add(new Possitions() { PossName = "Учитель - дефектолог, учитель - логопед(логопед)" });
                    db.Possition.Add(new Possitions() { PossName = "Педагог - психолог" });
                    db.Possition.Add(new Possitions() { PossName = "Воспитатель(включая старшего)" });
                    db.Possition.Add(new Possitions() { PossName = "Тьютор" });
                    db.Possition.Add(new Possitions() { PossName = "Педагог - библиотекарь" });
                    db.Possition.Add(new Possitions() { PossName = "Старший вожатый" });
                    db.Possition.Add(new Possitions() { PossName = "Педагог дополнительного образования(включая старшего)" });
                    db.Possition.Add(new Possitions() { PossName = "Музыкальный руководитель" });
                    db.Possition.Add(new Possitions() { PossName = "Концертмейстер" });
                    db.Possition.Add(new Possitions() { PossName = "Руководитель физического воспитания" });
                    db.Possition.Add(new Possitions() { PossName = "Инструктор по физической культуре" });
                    db.Possition.Add(new Possitions() { PossName = "Методист(включая старшего)" });
                    db.Possition.Add(new Possitions() { PossName = "Инструктор - методист(включая старшего)" });
                    db.Possition.Add(new Possitions() { PossName = "Инструктор по труду" });
                    db.Possition.Add(new Possitions() { PossName = "Преподаватель - организатор основ безопасности жизнедеятельности" });
                    db.Possition.Add(new Possitions() { PossName = "Тренер - преподаватель(включая старшего)" });
                    db.Possition.Add(new Possitions() { PossName = "Мастер производственного обучения" });
                    db.SaveChanges();
                }
                //
                if (!db.Education.Any())
                {
                    db.Education.Add(new Educations() { EduName = "Ошский гуманитарно-педагогический институт им. А.Мырсабекова" });
                    db.Education.Add(new Educations() { EduName = "Институт социального развития и предпринимательства" });
                    db.Education.Add(new Educations() { EduName = "Международная Высшая Школа Медицины" });
                    db.Education.Add(new Educations() { EduName = "Кыргызская государственная медицинская академия, КГМА имени И.К. Ахунбаева" });
                    db.Education.Add(new Educations() { EduName = "Кыргызско-Российско Славянский университет им.Б.Ельцина, КРСУ" });
                    db.Education.Add(new Educations() { EduName = "Международный университет инновационных технологий" });
                    db.Education.Add(new Educations() { EduName = "Дипломатическая академия Министерства иностранных дел Кыргызской Республики им.К. Дикамбаева, ДА МИД КР" });
                    db.SaveChanges();

                    db.Education.Add(new Educations() { EduName = "Ошский государственный юридический институт" });
                    db.Education.Add(new Educations() { EduName = "Международный университет в Центральной Азии, МУЦА" });
                    db.Education.Add(new Educations() { EduName = "Международный университет 'Ала - Тоо'" });
                    db.Education.Add(new Educations() { EduName = "Кыргызско-Узбекский университет" });
                    db.Education.Add(new Educations() { EduName = "Таласский государственный универстет, ТГУ" });
                    db.Education.Add(new Educations() { EduName = "Ошский технологический университет им.М.Адышева" });
                    db.Education.Add(new Educations() { EduName = "Университет Центральной Азии (УЦА)" });
                    db.Education.Add(new Educations() { EduName = "Кыргызский национальный университет им. Ж. Баласагына, КНУ" });
                    db.Education.Add(new Educations() { EduName = "Ошский государственный университет, ОшГУ" });
                    db.Education.Add(new Educations() { EduName = "Кыргызский государственный технический университет им.И.Раззакова, КГТУ" });
                    db.Education.Add(new Educations() { EduName = "Кыргызско-Турецкий университет “Манас”" });
                    db.Education.Add(new Educations() { EduName = "Кыргызский государственный университет им.И.Арабаева, КГУ" });
                    db.Education.Add(new Educations() { EduName = "Институт электроники и телекоммуникаций при Кыргызском государственном техническом университете (ИЭТ при КГТУ) им.И.Раззакова" });
                    db.Education.Add(new Educations() { EduName = "Кыргызская государственная юридическая академия, КГЮА" });
                    db.Education.Add(new Educations() { EduName = "Кыргызский экономический университет, КЭУ" });
                    db.SaveChanges();

                    db.Education.Add(new Educations() { EduName = "Бишкекский гуманитарный университет им. К.Карасаева, БГУ" });
                    db.Education.Add(new Educations() { EduName = "Нарынский государственный университет имени С. Нааматова, НГУ" });
                    db.Education.Add(new Educations() { EduName = "Институт стратегических информационных технологий в образовании" });
                    db.Education.Add(new Educations() { EduName = "Азиатский медицинский институт, АЗМИ, Asian Medical Institute, ASMI" });
                    db.Education.Add(new Educations() { EduName = "Бишкекская финансово-экономическая академия" });
                    db.Education.Add(new Educations() { EduName = "Университет экономики и предпринимательства" });
                    db.Education.Add(new Educations() { EduName = "Ошский сельскохозяйственный институт" });
                    db.Education.Add(new Educations() { EduName = "Национальная академия художеств КР им.Т.Садыкова" });
                    db.Education.Add(new Educations() { EduName = "Международный университет науки и бизнеса" });
                    db.Education.Add(new Educations() { EduName = "Международная академия управления, права, финансов и бизнеса" });
                    db.Education.Add(new Educations() { EduName = "Кыргызско-Казахский университет" });
                    db.Education.Add(new Educations() { EduName = "Кыргызско-Российская Академия образования" });
                    db.Education.Add(new Educations() { EduName = "Кыргызский государственный университет искусств им.Б.Бейшеналиевой" });
                    db.Education.Add(new Educations() { EduName = "Кыргызская национальная консерватория" });
                    db.Education.Add(new Educations() { EduName = "Иссык-Кульский институт кооперации им.Алышбаева" });
                    db.Education.Add(new Educations() { EduName = "Институт экономики и финансов" });
                    db.Education.Add(new Educations() { EduName = "Институт инновационных технологий (Каракол)" });
                    db.Education.Add(new Educations() { EduName = "Евразийский университет" });
                    db.Education.Add(new Educations() { EduName = "Военный институт ВС КР им.К.Усенбекова" });
                    db.Education.Add(new Educations() { EduName = "Академия туризма и сервиса" });
                    db.Education.Add(new Educations() { EduName = "Бишкекский филиал Российского экономического университета" });
                    db.Education.Add(new Educations() { EduName = "Каракольский филиал негосударственного образовательного учреждения высшего профессионального образования 'Московский институт предпринимательства и права'" });
                    db.Education.Add(new Educations() { EduName = "Международный университет Кыргызстана, МУК" });
                    db.Education.Add(new Educations() { EduName = "Академия государственного управления при Президенте КР, АГУПКР" });
                    db.Education.Add(new Educations() { EduName = "Академия права, бизнеса и образования" });
                    db.Education.Add(new Educations() { EduName = "Академия ОБСЕ" });
                    db.Education.Add(new Educations() { EduName = "Чуйский университет" });
                    db.Education.Add(new Educations() { EduName = "Кыргызская государственная академия физической культуры и спорта, КГАФКиС" });
                    db.Education.Add(new Educations() { EduName = "Иссык-Кульский государственный университет им.К.Тыныстанова, ИГУ" });
                    db.Education.Add(new Educations() { EduName = "Восточный университет им.Махмуда Кашгари-Барскани" });
                    db.SaveChanges();

                    db.Education.Add(new Educations() { EduName = "Академия МВД КР им.генерал-майора милиции Э.Алиева" });
                    db.Education.Add(new Educations() { EduName = "Американский университет в Центральной Азии, АУЦА" });
                    db.Education.Add(new Educations() { EduName = "Кыргызский государственный университет строительства, транспорта и архитектуры им. Н.ИСАНОВА , КГУСТА" });
                    db.Education.Add(new Educations() { EduName = "Баткенский государственный университет, БатГУ" });
                    db.Education.Add(new Educations() { EduName = "Жалал-Абадский государственный университет, ЖАГУ" });
                    db.Education.Add(new Educations() { EduName = "Кыргызский национальный аграрный университет им. К.И.Скрябина, КНАУ" });
                    db.Education.Add(new Educations() { EduName = "Кыргызский национальный аграрный университет им. К.И.Скрябина, КНАУ" });
                    db.Education.Add(new Educations() { EduName = "Академия труда и социальных отношений" });
                    db.Education.Add(new Educations() { EduName = "Бишкекский филиал образовательной автономной некоммерческой организации высшего образования Международный славянский институт" });
                    db.Education.Add(new Educations() { EduName = "Бишкекский филиал негосударственного образовательного учреждения высшего профессионального образования 'Московский институт предпринимательства и права'" });
                    db.Education.Add(new Educations() { EduName = "Филиал Российского государственного социального университета в г.Ош" });
                    db.SaveChanges();
                }

                if (!db.Award.Any())
                {
                    db.Award.Add(new Awards() { AwardName = "Нагрудный знак «Билим берүүнүн мыктысы» Министерства образования и науки Кыргызской Республики" });
                    db.Award.Add(new Awards() { AwardName = "Почетная грамота Министерства образования и науки Кыргызской Республики" });
                    db.SaveChanges();
                }

            }
            catch (Exception exp)
            {



            }
        }

    }
}
