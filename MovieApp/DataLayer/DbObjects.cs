using DataLayer.Entities.ActorMovieRelations;
using DataLayer.Entities.Actors;
using DataLayer.Entities.Directors;
using DataLayer.Entities.Genres;
using DataLayer.Entities.MovieGenreRelations;
using DataLayer.Entities.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public static class DbObjects
    {
        public static void Initialize(ApplicationContext context)
        {
            if (context.Actors.Count() == 0 && context.Directors.Count() == 0
                && context.Genres.Count() == 0 && context.Movies.Count() == 0)
            {
                Actor dicaprio = new Actor
                {
                    Name = "Леонардо",
                    LastName = "ДиКаприо",
                    ImageUrl = "/images/actors/dicaprio.jpg",
                    BirthDate = new DateTime(1974, 11, 11),
                    Country = "США",
                    Description = "американский актёр, продюсер и общественный деятель. Лауреат многочисленных наград, включая премию «Оскар», BAFTA, " +
                    "Премию Гильдии киноактёров США, три премии «Золотой глобус», а также «Серебряного медведя» Берлинского кинофестиваля."
                };
                Actor pitt = new Actor
                {
                    Name = "Брэд",
                    LastName = "Питт",
                    ImageUrl = "/images/actors/pitt.jpg",
                    BirthDate = new DateTime(1963, 12, 18),
                    Country = "США",
                    Description = "американский актёр и кинопродюсер. Лауреат двух премий «Золотой глобус». Обладатель премии «Оскар» как один из продюсеров фильма «12 лет рабства» — " +
                    "победителя в категории «Лучший фильм» на церемонии 2014 года — и за лучшую мужскую роль второго плана в картине «Однажды в Голливуде»."
                };
                Actor hanks = new Actor
                {
                    Name = "Том",
                    LastName = "Хэнкс",
                    ImageUrl = "/images/actors/hanks.jpg",
                    BirthDate = new DateTime(1956, 7, 9),
                    Country = "США",
                    Description = "Американский актёр, продюсер, режиссёр, сценарист и писатель."
                };
                Actor phoenix = new Actor
                {
                    Name = "Хоакин",
                    LastName = "Феникс",
                    ImageUrl = "/images/actors/phoenix.jpg",
                    BirthDate = new DateTime(1974, 10, 28),
                    Country = "США",
                    Description = "Американский актёр, продюсер, музыкант и клипмейкер."
                };
                Actor waltz = new Actor
                {
                    Name = "Кристоф",
                    LastName = "Вальц",
                    ImageUrl = "/images/actors/waltz.jpg",
                    BirthDate = new DateTime(1956, 10, 4),
                    Country = "Австрия",
                    Description = "Австрийский актёр, получивший широкую известность благодаря роли штандартенфюрера СС Ганса Ланды в фильме Квентина Тарантино " +
                    "«Бесславные ублюдки». За эту же роль был удостоен всевозможных кинопремий, включая «Оскар», «Золотой глобус», BAFTA и приз Каннского кинофестиваля."
                };
                Actor schwarzenegger = new Actor
                {
                    Name = "Арнольд",
                    LastName = "Шварценеггер",
                    ImageUrl = "/images/actors/schwarzenegger.jpg",
                    BirthDate = new DateTime(1947, 7, 30),
                    Country = "Австрия",
                    Description = "американский культурист, предприниматель, актёр, продюсер и политический деятель австрийского происхождения. 38-й губернатор Калифорнии. " +
                    "Обладатель ряда премий по бодибилдингу, в том числе семикратный обладатель титула «Мистер Олимпия». Организатор конкурса «Арнольд Классик»."
                };
                Actor dayLewis = new Actor
                {
                    Name = "Дэниэл",
                    LastName = "Дэй-Льюис",
                    ImageUrl = "/images/actors/dayLewis.jpg",
                    BirthDate = new DateTime(1957, 4, 29),
                    Country = "Англия",
                    Description = " британо-ирландский актёр. Единственный трёхкратный обладатель премии «Оскар» в категории «Лучший актёр» " +
                    "в истории Американской киноакадемии. Сын писателя и поэта-лауреата Великобритании Сесила Дэй-Льюиса и актрисы Джилл Бэлкон."
                };
                Actor mcconaughey = new Actor
                {
                    Name = "Мэттью",
                    LastName = "Макконахи",
                    ImageUrl = "/images/actors/mcconaughey.jpg",
                    BirthDate = new DateTime(1969, 11, 4),
                    Country = "США",
                    Description = "Американский актёр и продюсер."
                };
                Actor bale = new Actor
                {
                    Name = "Кристиан",
                    LastName = "Бэйл",
                    ImageUrl = "/images/actors/bale.jpg",
                    BirthDate = new DateTime(1974, 1, 30),
                    Country = "Англия",
                    Description = "Британо-американский актёр. Лауреат премий «Золотой глобус» и «Оскар» в номинации " +
                    "«Лучшая мужская роль второго плана» за фильм «Боец»."
                };
                Actor willis = new Actor
                {
                    Name = "Брюс",
                    LastName = "Уиллис",
                    ImageUrl = "/images/actors/willis.jpg",
                    BirthDate = new DateTime(1955, 3, 19),
                    Country = "США",
                    Description = "Американский актёр, продюсер и музыкант. Один из самых высокооплачиваемых актёров Голливуда."
                };
                Actor friman = new Actor
                {
                    Name = "Морган",
                    LastName = "Фримен",
                    ImageUrl = "/images/actors/friman.jpg",
                    BirthDate = new DateTime(1937, 6, 1),
                    Country = "США",
                    Description = "американский актёр кино и озвучивания, режиссёр. Лауреат премии «Оскар», премии «Серебряный медведь» и двух «Золотых глобусов». " +
                    "Также Фримен известен своим характерным спокойным глубоким голосом и мастерством рассказчика."
                };
                Actor crowe = new Actor
                {
                    Name = "Рассел",
                    LastName = "Кроу",
                    ImageUrl = "/images/actors/crowe.jpg",
                    BirthDate = new DateTime(1964, 4, 7),
                    Country = "Австралия",
                    Description = "Австралийский и американский киноактёр и режиссёр новозеландского происхождения. " +
                    "Лауреат премии «Оскар» 2001 года."
                };
                context.Actors.AddRange(dicaprio, pitt, hanks, phoenix,
                    waltz, schwarzenegger, dayLewis, mcconaughey, bale,
                    willis, friman, crowe);
                context.SaveChanges();

                Director tarantino = new Director
                {
                    Name = "Квентин",
                    LastName = "Тарантино",
                    ImageUrl = "/images/directors/tarantino.jpg",
                    BirthDate = new DateTime(1963, 3, 27),
                    Country = "США",
                    Description = "американский кинорежиссёр, сценарист, актёр, кинопродюсер и кинооператор. " +
                    "Один из наиболее ярких представителей постмодернизма в кинематографе."
                };
                Director scorsese = new Director
                {
                    Name = "Мартин",
                    LastName = "Скорсезе",
                    ImageUrl = "/images/directors/scorsese.jpg",
                    BirthDate = new DateTime(1942, 11, 17),
                    Country = "США",
                    Description = "американский кинорежиссёр, продюсер, сценарист и актёр. Фильмам Скорсезе присущи " +
                    "выразительная жестокость и насилие, в кинематографических кругах он известен как мастер гангстерских лент."
                };
                Director spilberg = new Director
                {
                    Name = "Стивен",
                    LastName = "Спилберг",
                    ImageUrl = "/images/directors/spilberg.jpg",
                    BirthDate = new DateTime(1946, 12, 18),
                    Country = "США",
                    Description = "американский кинорежиссёр, продюсер и сценарист. Один из самых коммерчески успешных режиссёров в истории. " +
                    "Лауреат многих премий, в частности Центра Кеннеди, Сесиля Б. Де Милля и двух «Оскаров» за лучшую режиссуру. Спилберг родился в Цинциннати и вырос в Финиксе."
                };
                Director nolan = new Director
                {
                    Name = "Кристофер",
                    LastName = "Нолан",
                    ImageUrl = "/images/directors/nolan.jpg",
                    BirthDate = new DateTime(1970, 7, 30),
                    Country = "Англия",
                    Description = "Британский и американский кинорежиссёр, сценарист и продюсер. Является одним из самых кассовых режиссёров в истории, " +
                    "а также одним из самых известных и влиятельных кинематографистов своего времени."
                };
                Director cameron = new Director
                {
                    Name = "Джеймс",
                    LastName = "Кэмерон",
                    ImageUrl = "/images/directors/cameron.jpg",
                    BirthDate = new DateTime(1954, 8, 16),
                    Country = "Канада",
                    Description = "Канадский кинорежиссёр, наиболее известный по созданию научно-фантастических и эпических фильмов. Кэмерон " +
                    "впервые добился признания за режиссуру фильма «Терминатор»"
                };
                Director darabont = new Director
                {
                    Name = "Фрэнк",
                    LastName = "Дарабонт",
                    ImageUrl = "/images/directors/darabont.jpg",
                    BirthDate = new DateTime(1959, 1, 28),
                    Country = "Венгрия",
                    Description = "Американский кинорежиссёр, сценарист и продюсер венгерского происхождения. Был трижды номинирован на «Оскар». " +
                    "Известен своими удачными экранизациями романов Стивена Кинга: «Побег из Шоушенка», «Зелёная миля», «Мгла» и другие."
                };
                Director zimeckis = new Director
                {
                    Name = "Роберт",
                    LastName = "Земекис",
                    ImageUrl = "/images/directors/zimeckis.jpg",
                    BirthDate = new DateTime(1952, 5, 14),
                    Country = "США",
                    Description = "Аримериканский кинорежиссёр, сценарист и продюсер. Лауреат премий «Оскар» и «Золотой глобус» в категории «Лучший режиссёр». Постановщик знаковых картин: " +
                    "«Назад в будущее», «Кто подставил кролика Роджера» и «Форрест Гамп»."
                };
                Director scott = new Director
                {
                    Name = "Ридли",
                    LastName = "Скотт",
                    ImageUrl = "/images/directors/scott.jpg",
                    BirthDate = new DateTime(1937, 11, 30),
                    Country = "Англия",
                    Description = "Британский кинорежиссёр и продюсер. Создатель многих прославленных исторических и фантастических фильмов, " +
                    "таких как «Чужой», «Гладиатор», «Царство небесное», «Бегущий по лезвию», «Гангстер», «Совокупность лжи», «Чёрный ястреб», «Марсианин»."
                };
                Director fincher = new Director
                {
                    Name = "Дэвид",
                    LastName = "Финчер",
                    ImageUrl = "/images/directors/fincher.jpg",
                    BirthDate = new DateTime(1962, 8, 28),
                    Country = "США",
                    Description = "американский кинорежиссёр, продюсер и клипмейкер. Наиболее известен по созданию психологических триллеров, " +
                    "его работы удостоились многочисленных номинаций на премию «Оскар» и «Золотой глобус»."
                };
                context.Directors.AddRange(tarantino, scorsese, spilberg, nolan,
                    cameron, darabont, zimeckis, scott, fincher);
                context.SaveChanges();

                Genre thriller = new Genre
                {
                    Name = "Боевик",
                    Description = "Жанр кинематографа, в котором основное " +
                    "внимание уделяется перестрелкам, дракам, погоням и т. д."
                };
                Genre western = new Genre
                {
                    Name = "Вестерн",
                    Description = "Лекательный приключенческий жанр кинематографа, который рассказывает " +
                    "о событиях, происходящих на Диком Западе, где главными героями становятся брутальные ковбои."
                };
                Genre detective = new Genre
                {
                    Name = "Детектив",
                    Description = "Преимущественно литературный и кинематографический жанр, произведения которого описывают " +
                    "процесс исследования загадочного происшествия с целью выяснения его обстоятельств и раскрытия загадки."
                };
                Genre drama = new Genre
                {
                    Name = "Драма",
                    Description = "Очень популярный жанр кинематографа, который показывает наличие какой-то проблемы у человека, " +
                    "которую он старается решить или найти выход из сложившейся ситуации, по мере развития сюжета."
                };
                Genre gangster = new Genre
                {
                    Name = "Гангстерский фильм",
                    Description = "Поджанр боевика, криминального фильма, рассказывающий об организованной преступности."
                };
                Genre historic = new Genre
                {
                    Name = "Исторический фильм",
                    Description = "Жанр игрового кино, изображающий конкретные исторические эпохи, события и личности прошлого."
                };
                Genre comedy = new Genre
                {
                    Name = "Комедия",
                    Description = "Жанр художественного произведения, характеризующийся юмористическим или сатирическим подходами, " +
                    "и также вид драмы, в котором специфически разрешается момент действенного конфликта или борьбы."
                };
                Genre melodrama = new Genre
                {
                    Name = "Мелодрама",
                    Description = "Жанр художественной литературы, театрального искусства и кинематографа, произведения которого раскрывают духовный и " +
                    "чувственный мир героев в особенно ярких эмоциональных обстоятельствах на основе контрастов: добро и зло, любовь и ненависть и пр."
                };
                context.Genres.AddRange(thriller, western, detective, drama,
                    gangster, historic, comedy, melodrama);
                context.SaveChanges();

                Movie titanic = new Movie
                {
                    Name = "Титаник",
                    Country = "США",
                    Year = 1997,
                    Director = cameron,
                    Url = "/movies/titanic.mp4",
                    ImageUrl = "/images/posters/titanic.jpg",
                    Description = "Молодые влюбленные Джек и Роза находят друг друга в первом и последнем плавании «непотопляемого» Титаника"
                };
                Movie shawshank = new Movie
                {
                    Name = "Побег из Шоушенка",
                    Country = "США",
                    Year = 1994,
                    Director = darabont,
                    Url = "/movies/shawshank.mp4",
                    ImageUrl = "/images/posters/shawshank.jpg",
                    Description = "Бухгалтер Энди Дюфрейн обвинён в убийстве собственной жены и её любовника. Оказавшись в тюрьме под названием Шоушенк, " +
                    "он сталкивается с жестокостью и беззаконием, царящими по обе стороны решётки"
                };
                Movie greenMile = new Movie
                {
                    Name = "Зеленая миля",
                    Country = "США",
                    Year = 1999,
                    Director = darabont,
                    Url = "/movies/greenMile.mp4",
                    ImageUrl = "/images/posters/greenMile.jpg",
                    Description = "Обвиненный в страшном преступлении, Джон Коффи оказывается в блоке смертников тюрьмы «Холодная гора»."
                };
                Movie forrestGump = new Movie
                {
                    Name = "Форрест Гамп",
                    Country = "США",
                    Year = 1994,
                    Director = zimeckis,
                    Url = "/movies/forrestGump.mp4",
                    ImageUrl = "/images/posters/forrestGump.jpg",
                    Description = "От лица главного героя Форреста Гампа, слабоумного безобидного человека с благородным и открытым сердцем, " +
                    "рассказывается история его необыкновенной жизни."
                };
                Movie pulpFiction = new Movie
                {
                    Name = "Криминальное чтиво",
                    Country = "США",
                    Year = 1994,
                    Director = tarantino,
                    Url = "/movies/pulpFiction.mp4",
                    ImageUrl = "/images/posters/pulpFiction.jpg",
                    Description = "Двое бандитов Винсент Вега и Джулс Винфилд проводят время в философских беседах в перерыве между разборками и " +
                    "«решением проблем» с должниками своего криминального босса Марселласа Уоллеса."
                };
                Movie gladiator = new Movie
                {
                    Name = "Гладиатор",
                    Country = "США",
                    Year = 2000,
                    Director = scott,
                    Url = "/movies/gladiator.mp4",
                    ImageUrl = "/images/posters/gladiator.jpg",
                    Description = "В великой Римской империи не было военачальника, равного генералу Максимусу. " +
                    "Непобедимые легионы, которыми командовал этот благородный воин, боготворили его и могли последовать за ним даже в ад."
                };
                Movie fightClub = new Movie
                {
                    Name = "Бойцовский клуб",
                    Country = "США",
                    Year = 1999,
                    Director = fincher,
                    Url = "/movies/fightClub.mp4",
                    ImageUrl = "/images/posters/fightClub.jpg",
                    Description = "Терзаемый хронической бессонницей и отчаянно пытающийся вырваться из мучительно скучной жизни клерк встречает некоего Тайлера Дардена, " +
                    "харизматического торговца мылом с извращенной философией. Тайлер уверен, что самосовершенствование — удел слабых, а саморазрушение — единственное, ради чего стоит жить."
                };
                Movie ingloriousBastards = new Movie
                {
                    Name = "Бесславные ублюдки",
                    Country = "США",
                    Year = 2009,
                    Director = tarantino,
                    Url = "/movies/ingloriousBastards.mp4",
                    ImageUrl = "/images/posters/ingloriousBastards.jpg",
                    Description = "Вторая мировая война, в оккупированной немцами Франции группа американских солдат-евреев наводит страх на нацистов, " +
                    "жестоко убивая и скальпируя солдат."
                };
                Movie darkKnight = new Movie
                {
                    Name = "Темный рыцарь",
                    Country = "США",
                    Year = 2008,
                    Director = nolan,
                    Url = "/movies/darkKnight.mp4",
                    ImageUrl = "/images/posters/darkKnight.jpg",
                    Description = "Бэтмен поднимает ставки в войне с криминалом. С помощью лейтенанта Джима Гордона и прокурора Харви Дента он намерен очистить улицы от преступности, отравляющей город. " +
                    "Сотрудничество оказывается эффективным, но скоро они обнаружат себя посреди хаоса, развязанного восходящим криминальным гением, известным испуганным горожанам под именем Джокер."
                };
                Movie terminator = new Movie
                {
                    Name = "Терминатор",
                    Country = "США",
                    Year = 1984,
                    Director = cameron,
                    Url = "/movies/terminator.mp4",
                    ImageUrl = "/images/posters/terminator.jpg",
                    Description = "История противостояния солдата Кайла Риза и киборга-терминатора, прибывших в 1984-й год из пост-апокалиптического будущего, " +
                    "где миром правят машины-убийцы, а человечество находится на грани вымирания. Цель киборга: убить девушку по имени Сара Коннор, чей ещё нерождённый сын к 2029 году выиграет войну."
                };
                context.Movies.AddRange(titanic, shawshank, greenMile, forrestGump,
                    pulpFiction, gladiator, fightClub, ingloriousBastards, darkKnight, terminator);
                context.SaveChanges();

                MovieGenreRelation mgRelation1 = new MovieGenreRelation
                {
                    MovieId = titanic.Id,
                    GenreId = drama.Id
                };
                MovieGenreRelation mgRelation2 = new MovieGenreRelation
                {
                    MovieId = titanic.Id,
                    GenreId = historic.Id
                };
                MovieGenreRelation mgRelation3 = new MovieGenreRelation
                {
                    MovieId = shawshank.Id,
                    GenreId = drama.Id
                };
                MovieGenreRelation mgRelation4 = new MovieGenreRelation
                {
                    MovieId = greenMile.Id,
                    GenreId = detective.Id
                };
                MovieGenreRelation mgRelation5 = new MovieGenreRelation
                {
                    MovieId = greenMile.Id,
                    GenreId = drama.Id
                };
                MovieGenreRelation mgRelation6 = new MovieGenreRelation
                {
                    MovieId = forrestGump.Id,
                    GenreId = drama.Id
                };
                MovieGenreRelation mgRelation7 = new MovieGenreRelation
                {
                    MovieId = forrestGump.Id,
                    GenreId = comedy.Id
                };
                MovieGenreRelation mgRelation8 = new MovieGenreRelation
                {
                    MovieId = pulpFiction.Id,
                    GenreId = thriller.Id
                };
                MovieGenreRelation mgRelation9 = new MovieGenreRelation
                {
                    MovieId = pulpFiction.Id,
                    GenreId = drama.Id
                };
                MovieGenreRelation mgRelation10 = new MovieGenreRelation
                {
                    MovieId = pulpFiction.Id,
                    GenreId = comedy.Id
                };
                MovieGenreRelation mgRelation11 = new MovieGenreRelation
                {
                    MovieId = gladiator.Id,
                    GenreId = thriller.Id
                };
                MovieGenreRelation mgRelation12 = new MovieGenreRelation
                {
                    MovieId = gladiator.Id,
                    GenreId = drama.Id
                };
                MovieGenreRelation mgRelation13 = new MovieGenreRelation
                {
                    MovieId = gladiator.Id,
                    GenreId = historic.Id
                };
                MovieGenreRelation mgRelation14 = new MovieGenreRelation
                {
                    MovieId = fightClub.Id,
                    GenreId = thriller.Id
                };
                MovieGenreRelation mgRelation15 = new MovieGenreRelation
                {
                    MovieId = fightClub.Id,
                    GenreId = drama.Id
                };
                MovieGenreRelation mgRelation16 = new MovieGenreRelation
                {
                    MovieId = ingloriousBastards.Id,
                    GenreId = thriller.Id
                };
                MovieGenreRelation mgRelation17 = new MovieGenreRelation
                {
                    MovieId = ingloriousBastards.Id,
                    GenreId = drama.Id
                };
                MovieGenreRelation mgRelation18 = new MovieGenreRelation
                {
                    MovieId = ingloriousBastards.Id,
                    GenreId = comedy.Id
                };
                MovieGenreRelation mgRelation19 = new MovieGenreRelation
                {
                    MovieId = darkKnight.Id,
                    GenreId = thriller.Id
                };
                MovieGenreRelation mgRelation20 = new MovieGenreRelation
                {
                    MovieId = darkKnight.Id,
                    GenreId = detective.Id
                };
                MovieGenreRelation mgRelation21 = new MovieGenreRelation
                {
                    MovieId = darkKnight.Id,
                    GenreId = drama.Id
                };
                MovieGenreRelation mgRelation22 = new MovieGenreRelation
                {
                    MovieId = terminator.Id,
                    GenreId = thriller.Id
                };
                context.MovieGenreRelations.AddRange(mgRelation1, mgRelation2, mgRelation3,
                    mgRelation4, mgRelation5, mgRelation6, mgRelation7, mgRelation8,
                    mgRelation9, mgRelation10, mgRelation11, mgRelation12, mgRelation13,
                    mgRelation14, mgRelation15, mgRelation16, mgRelation17, mgRelation18,
                    mgRelation19, mgRelation20, mgRelation21, mgRelation22);
                context.SaveChanges();

                ActorMovieRelation amRelation1 = new ActorMovieRelation
                {
                    MovieId = titanic.Id,
                    ActorId = dicaprio.Id
                };
                ActorMovieRelation amRelation2 = new ActorMovieRelation
                {
                    MovieId = shawshank.Id,
                    ActorId = friman.Id
                };
                ActorMovieRelation amRelation3 = new ActorMovieRelation
                {
                    MovieId = greenMile.Id,
                    ActorId = hanks.Id
                };
                ActorMovieRelation amRelation4 = new ActorMovieRelation
                {
                    MovieId = forrestGump.Id,
                    ActorId = hanks.Id
                };
                ActorMovieRelation amRelation5 = new ActorMovieRelation
                {
                    MovieId = pulpFiction.Id,
                    ActorId = willis.Id
                };
                ActorMovieRelation amRelation6 = new ActorMovieRelation
                {
                    MovieId = gladiator.Id,
                    ActorId = phoenix.Id
                };
                ActorMovieRelation amRelation7 = new ActorMovieRelation
                {
                    MovieId = gladiator.Id,
                    ActorId = crowe.Id
                };
                ActorMovieRelation amRelation8 = new ActorMovieRelation
                {
                    MovieId = fightClub.Id,
                    ActorId = pitt.Id
                };
                ActorMovieRelation amRelation9 = new ActorMovieRelation
                {
                    MovieId = ingloriousBastards.Id,
                    ActorId = pitt.Id
                };
                ActorMovieRelation amRelation10 = new ActorMovieRelation
                {
                    MovieId = ingloriousBastards.Id,
                    ActorId = waltz.Id
                };
                ActorMovieRelation amRelation11 = new ActorMovieRelation
                {
                    MovieId = darkKnight.Id,
                    ActorId = bale.Id
                };
                ActorMovieRelation amRelation12 = new ActorMovieRelation
                {
                    MovieId = darkKnight.Id,
                    ActorId = friman.Id
                };
                ActorMovieRelation amRelation13 = new ActorMovieRelation
                {
                    MovieId = terminator.Id,
                    ActorId = schwarzenegger.Id
                };
                context.ActorMovieRelations.AddRange(amRelation1, amRelation2, amRelation3,
                    amRelation4, amRelation5, amRelation6, amRelation7, amRelation8,
                    amRelation9, amRelation10, amRelation11, amRelation12, amRelation13);
                context.SaveChanges();
            }
        }
    }
}
