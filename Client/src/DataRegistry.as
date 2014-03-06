package
{	
	[Bindable]
	public final class DataRegistry
	{		
		private static var _instance:DataRegistry = new DataRegistry();
		
		public function DataRegistry()
		{
			if(_instance != null)
			{
				throw new Error("DataRegistry can only be accessed through DataRegistry.instance since it is a Singleton class");
			}
		}
		
		public static function get instance() : DataRegistry
		{
			return _instance;
		}
		
		/*  SCHOOL PROPERTIES   */
		public var school_name : String = "Гимназия №7";
		public var school_photo : String = "school/photo.jpg";
		
		public var school_contacts_phone : String = "8 (495) 573-83-01";
		public var school_contacts_email : String = "";
		public var school_contacts_links : Array = new Array(
			"www.liceum7.ru",
			"Химки, ул. Ватутина д.2"
			);
		
		public var school_pictures_history : String = "school/history.jpg";
		public var school_pictures_director : String = "school/director.jpg";
		public var school_pictures_video : String = "school/video.jpg";
		
		/* SCHOOL: HISTORY PROPERTIES */
		public var school_history_html : String = 					
			"<p align=\"center\"><img alt=\"\" src=\"html/Untitled-1.jpg\" width=\"600\" height=\"300\" align=\"center\" /></p>" +
			"<p align=\"center\"><b><font>Историческая справка</font></b></p>" + 
			"<div align=\"justify\"><br />" + 
			"Средняя общеобразовательная школа №7 г. Химки была построена и сдана в эксплуатацию в августе 1966 года. <br />" + 
			"С момента образования учреждение работало как школа с углубленным изучением математики и физики. <br />" + 
			"Первым директором школы был <strong>Уланов Дмитрий Петрович</strong>, заслуженный учитель России, почетный гражданин г. Химки, ветеран Великой Отечественной войны.<br></div>" + 
			"<div align=\"justify\"><br />" + 
			"С 1975 по 1987 год школой руководила отличник народного образования <b>Самоделова Галина Ивановна</b>. <br />" + 
			"С 1987 по 1996 год директором гимназии была отличник народного образования Державина Галина Дмитриевна, дочь Уланова Дмитрия Петровича.<br></div>" + 
			"<div align=\"justify\"><br />" + 
			"С 1996 года по настоящее время гимназией руководит выпускник 7 школы, золотой медалист, кандидат физико-математических наук, Соросовский учитель 1997, 1999 и 2001 годов <b>Березин Виктор Вениаминович</b>.<br></div>" + 
			"<div align=\"justify\"><br />" + 
			"Учреждение лицензировано на право ведения образовательной деятельности.<br></div>" + 
			"<div align=\"justify\"><br />" + 
			"<b>1992 год.</b> Постановлением Главы Администрации Химкинского района Московской области № 3275 от 11.12.1992 г. средняя общеобразовательная школа №7 г. Химки была переименована в <strong>многопрофильную муниципальную гимназию №7</strong> и был утвержден ее Устав. Свидетельство о государственной регистрации № 1481 от 22.12.1992 г.<br></div>" + 
			"<div align=\"justify\"><br />" + 
			"<b>1996 год.</b> Постановлением Главы Администрации Химкинского района Московской области № 566 от 13.03.1996 г. Устав был перерегистрирован в новой редакции с новым наименованием учреждения: муниципальное общеобразовательное учреждение - многопрофильная гимназия №7 г. Химки.<br></div>" + 
			"<div align=\"justify\"><br />" + 
			"<b>1998 год.</b> Постановлением Главы Администрации Химкинского района Московской области № 1054 от 13.03.1998 г. Утверждена очередная редакция Устава, и учреждение получило следующее наименование: <b>муниципальное общеобразовательное учреждение - гимназия №7 г. Химки. </b><br></div>" + 
			"<div align=\"justify\"><br />" + 
			"<b>2006 год.</b> Последняя редакция Устава утверждена Постановлением Главы городского округа Химки Московской области № 415 от 20.04.2006г. Постановлением определено следующее полное наименование учреждения <b>муниципальное общеобразовательное учреждение Гимназия №7 г. Химки. </b><br></div>" + 
			"<div align=\"justify\"><br />" + 
			"Действующая лицензия на право ведения образовательной деятельности &ndash; серия А № 229925 от 12.02.2007 г., действительна до 22.11.2010г. <br />" + 
			"Распоряжением Комитета по управлению имуществом Химкинского района Московской области № 106 от 05.05.1999г. за гимназией закреплено муниципальное имущество на праве оперативного управления. Действующий договор о порядке использования закрепленного за гимназией муниципального имущества на праве оперативного управления № 63 от 27.03.2002г.<br></div>" + 
			"<div align=\"justify\"><br />" + 
			"18.09.1998г. гимназии Московской областной регистрационной палатой было выдано Свидетельство о государственной регистрации юридического лица № 1481 с внесением в реестр под № 50:10:00514.<br></div>" + 
			"<div align=\"justify\"><br />" + 
			"Гимназии выдано Свидетельство о постановке на учет в налоговом органе серия 50 № 009736749 с 17.04.1994г. и присвоены ИНН юридического лица 5047010194 и КПП 504701001.<br></div>" + 
			"<div align=\"justify\"><br />" + 
			"17.07.2006г. гимназии выдано Свидетельство серия 50 № 009736677 о внесении в Единый государственный реестр юридического лица с основным государственным регистрационным номером (ОГРН) 1035009553974 за государственным регистрационным номером 2065047203373.</div>" + 
			"<p align=\"center\"><img alt=\"\" src=\"html/Untitled-2.jpg\" width=\"600\" height=\"300\" align=\"center\" /></p>";

						
		/* SCHOOL: DIRECTOR PROPERTIES */
		public var school_director_photo : String = "school/director/photo.jpg";
		public var school_director_name : String = "Березин Виктор Вениаминович";
		public var school_director_video : String = "school/director/video.flv";
		
		/* SCHOOL: VIDEO PROPERTIES */
		public var school_video : String = "school/video.flv";
		
		/* SCHOOLMATES PROPERTIES */
		public var schoolmates : Array = new Array(
            
            /* Алёхина Юлия */
            new User(
				"Алёхина Юлия",
				"schoolmates/Алёхина Юлия/photo.jpg",
				"schoolmates/Алёхина Юлия/photo_thumbnail.jpg",
				"19/02/1993",
				"",
				"",
				new Array(
					"icq: 418824563"
				),
				new Array (
					"schoolmates/Алёхина Юлия/photos/DSC00688.JPG",
					"schoolmates/Алёхина Юлия/photos/DSC00689.JPG",
					"schoolmates/Алёхина Юлия/photos/DSC00690.JPG",
					"schoolmates/Алёхина Юлия/photos/DSC00693.JPG",
					"schoolmates/Алёхина Юлия/photos/DSC00694.JPG",
					"schoolmates/Алёхина Юлия/photos/DSC00695.JPG",
					"schoolmates/Алёхина Юлия/photos/DSC00696.JPG",
					"schoolmates/Алёхина Юлия/photos/DSC00697.JPG",
					"schoolmates/Алёхина Юлия/photos/DSC00698.JPG"
				),
				new Array (
					"schoolmates/Алёхина Юлия/photos/thumbnails/DSC00688.JPG",
					"schoolmates/Алёхина Юлия/photos/thumbnails/DSC00689.JPG",
					"schoolmates/Алёхина Юлия/photos/thumbnails/DSC00690.JPG",
					"schoolmates/Алёхина Юлия/photos/thumbnails/DSC00693.JPG",
					"schoolmates/Алёхина Юлия/photos/thumbnails/DSC00694.JPG",
					"schoolmates/Алёхина Юлия/photos/thumbnails/DSC00695.JPG",
					"schoolmates/Алёхина Юлия/photos/thumbnails/DSC00696.JPG",
					"schoolmates/Алёхина Юлия/photos/thumbnails/DSC00697.JPG",
					"schoolmates/Алёхина Юлия/photos/thumbnails/DSC00698.JPG"
				),
				new Array (
					"schoolmates/Алёхина Юлия/videos/1.flv",
					"schoolmates/Алёхина Юлия/videos/2.flv"
				),
				new Array (
					"schoolmates/Алёхина Юлия/videos/thumbnails/1.flv.jpg",
					"schoolmates/Алёхина Юлия/videos/thumbnails/2.flv.jpg"
				)
			)
            
            ,
            /* Баязцян Ирина */
            new User(
				"Баязцян Ирина",
				"schoolmates/Баязцян Ирина/photo.jpg",
				"schoolmates/Баязцян Ирина/photo_thumbnail.jpg",
				"05/02/1993",
				"",
				"",
				new Array(
					"icq: 369995692"
				),
				new Array (
    				"schoolmates/Баязцян Ирина/photos/DSC07141.JPG",
    				"schoolmates/Баязцян Ирина/photos/DSC07145.JPG",
    				"schoolmates/Баязцян Ирина/photos/DSC07146.JPG",
    				"schoolmates/Баязцян Ирина/photos/DSC07147.JPG",
    				"schoolmates/Баязцян Ирина/photos/DSC07149.JPG",
    				"schoolmates/Баязцян Ирина/photos/DSC07150.JPG",
    				"schoolmates/Баязцян Ирина/photos/DSC07151.JPG",
    				"schoolmates/Баязцян Ирина/photos/DSC07152.JPG",
    				"schoolmates/Баязцян Ирина/photos/DSC07153.JPG",
    				"schoolmates/Баязцян Ирина/photos/DSC07154.JPG",
    				"schoolmates/Баязцян Ирина/photos/20090913_8.jpg",
    				"schoolmates/Баязцян Ирина/photos/x_dab2058f.jpg",
    				"schoolmates/Баязцян Ирина/photos/x_eb7ff47b.jpg",
    				"schoolmates/Баязцян Ирина/photos/x_22a54d13.jpg",
    				"schoolmates/Баязцян Ирина/photos/x_6d136bca.jpg",
    				"schoolmates/Баязцян Ирина/photos/mishka.jpg",
    				"schoolmates/Баязцян Ирина/photos/x_1b4f3902.jpg",
    				"schoolmates/Баязцян Ирина/photos/I.jpg",
    				"schoolmates/Баязцян Ирина/photos/pozitiv.jpg",
    				"schoolmates/Баязцян Ирина/photos/i 3.jpg"
				),
				new Array (
    				"schoolmates/Баязцян Ирина/photos/thumbnails/DSC07141.JPG",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/DSC07145.JPG",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/DSC07146.JPG",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/DSC07147.JPG",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/DSC07149.JPG",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/DSC07150.JPG",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/DSC07151.JPG",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/DSC07152.JPG",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/DSC07153.JPG",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/DSC07154.JPG",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/20090913_8.jpg",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/x_dab2058f.jpg",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/x_eb7ff47b.jpg",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/x_22a54d13.jpg",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/x_6d136bca.jpg",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/mishka.jpg",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/x_1b4f3902.jpg",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/I.jpg",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/pozitiv.jpg",
    				"schoolmates/Баязцян Ирина/photos/thumbnails/i 3.jpg"
				),
				new Array (
					"schoolmates/Баязцян Ирина/videos/1.flv",
					"schoolmates/Баязцян Ирина/videos/2.flv"
				),
				new Array (
					"schoolmates/Баязцян Ирина/videos/thumbnails/1.flv.jpg",
					"schoolmates/Баязцян Ирина/videos/thumbnails/2.flv.jpg"
				)
			)
            
            ,
            /* Давыгора Александра */
            new User(
				"Давыгора Александра",
				"schoolmates/Давыгора Александра/photo.jpg",
				"schoolmates/Давыгора Александра/photo_thumbnail.jpg",
				"19/09/1992",
				"",
				"",
				new Array(
					"icq: 448088760"
				),
				new Array (
                    "schoolmates/Давыгора Александра/photos/DSC07156.JPG",
    				"schoolmates/Давыгора Александра/photos/DSC07161.JPG",
    				"schoolmates/Давыгора Александра/photos/DSC07167.JPG",
    				"schoolmates/Давыгора Александра/photos/DSC07155.JPG",
    				"schoolmates/Давыгора Александра/photos/DSC07158.JPG",
    				"schoolmates/Давыгора Александра/photos/DSC07160.JPG",
    				"schoolmates/Давыгора Александра/photos/DSC07163.JPG",
    				"schoolmates/Давыгора Александра/photos/DSC07164.JPG",
    				"schoolmates/Давыгора Александра/photos/DSC07165.JPG",
    				"schoolmates/Давыгора Александра/photos/DSC07166.JPG",
    				"schoolmates/Давыгора Александра/photos/DSC07168.JPG",
    				"schoolmates/Давыгора Александра/photos/SCAN0002_01.jpg",
    				"schoolmates/Давыгора Александра/photos/SCAN0002_03.jpg",
    				"schoolmates/Давыгора Александра/photos/SCAN0003_06.jpg",
    				"schoolmates/Давыгора Александра/photos/SCAN0003_03.jpg",
    				"schoolmates/Давыгора Александра/photos/SCAN0003_01.jpg",
    				"schoolmates/Давыгора Александра/photos/SCAN0002_09.jpg",
    				"schoolmates/Давыгора Александра/photos/SCAN0002_11.jpg"
				),
				new Array (
                    "schoolmates/Давыгора Александра/photos/thumbnails/DSC07156.JPG",
    				"schoolmates/Давыгора Александра/photos/thumbnails/DSC07161.JPG",
    				"schoolmates/Давыгора Александра/photos/thumbnails/DSC07167.JPG",
    				"schoolmates/Давыгора Александра/photos/thumbnails/DSC07155.JPG",
    				"schoolmates/Давыгора Александра/photos/thumbnails/DSC07158.JPG",
    				"schoolmates/Давыгора Александра/photos/thumbnails/DSC07160.JPG",
    				"schoolmates/Давыгора Александра/photos/thumbnails/DSC07163.JPG",
    				"schoolmates/Давыгора Александра/photos/thumbnails/DSC07164.JPG",
    				"schoolmates/Давыгора Александра/photos/thumbnails/DSC07165.JPG",
    				"schoolmates/Давыгора Александра/photos/thumbnails/DSC07166.JPG",
    				"schoolmates/Давыгора Александра/photos/thumbnails/DSC07168.JPG",
    				"schoolmates/Давыгора Александра/photos/thumbnails/SCAN0002_01.jpg",
    				"schoolmates/Давыгора Александра/photos/thumbnails/SCAN0002_03.jpg",
    				"schoolmates/Давыгора Александра/photos/thumbnails/SCAN0003_06.jpg",
    				"schoolmates/Давыгора Александра/photos/thumbnails/SCAN0003_03.jpg",
    				"schoolmates/Давыгора Александра/photos/thumbnails/SCAN0003_01.jpg",
    				"schoolmates/Давыгора Александра/photos/thumbnails/SCAN0002_09.jpg",
    				"schoolmates/Давыгора Александра/photos/thumbnails/SCAN0002_11.jpg"
				),
				new Array (
					"schoolmates/Давыгора Александра/videos/1.flv",
					"schoolmates/Давыгора Александра/videos/2.flv"
				),
				new Array (
					"schoolmates/Давыгора Александра/videos/thumbnails/1.flv.jpg",
					"schoolmates/Давыгора Александра/videos/thumbnails/2.flv.jpg"
				)
			)
            
            ,
            /* Дмитриев Андрей */
            new User(
				"Дмитриев Андрей",
				"schoolmates/Дмитриев Андрей/photo.jpg",
				"schoolmates/Дмитриев Андрей/photo_thumbnail.jpg",
				"26/06/1993",
				"",
				"",
				new Array(
					"icq: 576248552"
				),
				new Array (
    				"schoolmates/Дмитриев Андрей/photos/DSC07072.JPG",
    				"schoolmates/Дмитриев Андрей/photos/DSC07071.JPG",
    				"schoolmates/Дмитриев Андрей/photos/DSC07070.JPG",
    				"schoolmates/Дмитриев Андрей/photos/DSC07069.JPG",
    				"schoolmates/Дмитриев Андрей/photos/DSC07068.JPG",
    				"schoolmates/Дмитриев Андрей/photos/DSC07066.JPG",
    				"schoolmates/Дмитриев Андрей/photos/DSC07064.JPG",
    				"schoolmates/Дмитриев Андрей/photos/DSC07063.JPG",
    				"schoolmates/Дмитриев Андрей/photos/DSC07061.JPG",
    				"schoolmates/Дмитриев Андрей/photos/SCAN0007_01.jpg",
					"schoolmates/Дмитриев Андрей/photos/SCAN0007_03.jpg",
					"schoolmates/Дмитриев Андрей/photos/SCAN0007_07.jpg"
				),
				new Array (
    				"schoolmates/Дмитриев Андрей/photos/thumbnails/DSC07072.JPG",
    				"schoolmates/Дмитриев Андрей/photos/thumbnails/DSC07071.JPG",
    				"schoolmates/Дмитриев Андрей/photos/thumbnails/DSC07070.JPG",
    				"schoolmates/Дмитриев Андрей/photos/thumbnails/DSC07069.JPG",
    				"schoolmates/Дмитриев Андрей/photos/thumbnails/DSC07068.JPG",
    				"schoolmates/Дмитриев Андрей/photos/thumbnails/DSC07066.JPG",
    				"schoolmates/Дмитриев Андрей/photos/thumbnails/DSC07064.JPG",
    				"schoolmates/Дмитриев Андрей/photos/thumbnails/DSC07063.JPG",
    				"schoolmates/Дмитриев Андрей/photos/thumbnails/DSC07061.JPG",
    				"schoolmates/Дмитриев Андрей/photos/thumbnails/SCAN0007_01.jpg",
					"schoolmates/Дмитриев Андрей/photos/thumbnails/SCAN0007_03.jpg",
					"schoolmates/Дмитриев Андрей/photos/thumbnails/SCAN0007_07.jpg"
				),
				new Array (
					"schoolmates/Дмитриев Андрей/videos/1.flv",
					"schoolmates/Дмитриев Андрей/videos/2.flv"
				),
				new Array (
					"schoolmates/Дмитриев Андрей/videos/thumbnails/1.flv.jpg",
					"schoolmates/Дмитриев Андрей/videos/thumbnails/2.flv.jpg"
				)
			)
            
            ,
            /* Евдоченко Ксения */
            new User(
				"Евдоченко Ксения",
				"schoolmates/Евдоченко Ксения/photo.jpg",
				"schoolmates/Евдоченко Ксения/photo_thumbnail.jpg",
				"19/04/1993",
				"",
				"",
				new Array(
					"icq: 447160599"
				),
				new Array (
    				"schoolmates/Евдоченко Ксения/photos/DSC07139.JPG",
    				"schoolmates/Евдоченко Ксения/photos/DSC07138.JPG",
    				"schoolmates/Евдоченко Ксения/photos/DSC07134.JPG",
    				"schoolmates/Евдоченко Ксения/photos/DSC07132.JPG",
    				"schoolmates/Евдоченко Ксения/photos/DSC07127.JPG",
    				"schoolmates/Евдоченко Ксения/photos/SCAN0005_07.jpg",
    				"schoolmates/Евдоченко Ксения/photos/SCAN0005_05.jpg",
    				"schoolmates/Евдоченко Ксения/photos/SCAN0005_02.jpg",
    				"schoolmates/Евдоченко Ксения/photos/SCAN0004_03.jpg",
    				"schoolmates/Евдоченко Ксения/photos/SCAN0004_01.jpg"
				),
				new Array (
    				"schoolmates/Евдоченко Ксения/photos/thumbnails/DSC07139.JPG",
    				"schoolmates/Евдоченко Ксения/photos/thumbnails/DSC07138.JPG",
    				"schoolmates/Евдоченко Ксения/photos/thumbnails/DSC07134.JPG",
    				"schoolmates/Евдоченко Ксения/photos/thumbnails/DSC07132.JPG",
    				"schoolmates/Евдоченко Ксения/photos/thumbnails/DSC07127.JPG",
    				"schoolmates/Евдоченко Ксения/photos/thumbnails/SCAN0005_07.jpg",
    				"schoolmates/Евдоченко Ксения/photos/thumbnails/SCAN0005_05.jpg",
    				"schoolmates/Евдоченко Ксения/photos/thumbnails/SCAN0005_02.jpg",
    				"schoolmates/Евдоченко Ксения/photos/thumbnails/SCAN0004_03.jpg",
    				"schoolmates/Евдоченко Ксения/photos/thumbnails/SCAN0004_01.jpg"
				),
				new Array (
					"schoolmates/Евдоченко Ксения/videos/1.flv",
					"schoolmates/Евдоченко Ксения/videos/2.flv"
				),
				new Array (
					"schoolmates/Евдоченко Ксения/videos/thumbnails/1.flv.jpg",
					"schoolmates/Евдоченко Ксения/videos/thumbnails/2.flv.jpg"
				)
			)
            
            ,
            /* Каменева Анастасия */
            new User(
				"Каменева Анастасия",
				"schoolmates/Каменева Анастасия/photo.jpg",
				"schoolmates/Каменева Анастасия/photo_thumbnail.jpg",
				"27/04/1992",
				"",
				"",
				new Array(
					"icq: 459841784"
				),
				new Array (
    				"schoolmates/Каменева Анастасия/photos/DSC07185.JPG",
    				"schoolmates/Каменева Анастасия/photos/DSC07176.JPG",
    				"schoolmates/Каменева Анастасия/photos/DSC07184.JPG",
    				"schoolmates/Каменева Анастасия/photos/DSC07183.JPG",
    				"schoolmates/Каменева Анастасия/photos/DSC07182.JPG",
    				"schoolmates/Каменева Анастасия/photos/DSC07181.JPG",
    				"schoolmates/Каменева Анастасия/photos/DSC07180.JPG",
    				"schoolmates/Каменева Анастасия/photos/DSC07179.JPG",
    				"schoolmates/Каменева Анастасия/photos/DSC07174.JPG",
    				"schoolmates/Каменева Анастасия/photos/DSC07173.JPG"
				),
				new Array (
    				"schoolmates/Каменева Анастасия/photos/thumbnails/DSC07185.JPG",
    				"schoolmates/Каменева Анастасия/photos/thumbnails/DSC07176.JPG",
    				"schoolmates/Каменева Анастасия/photos/thumbnails/DSC07184.JPG",
    				"schoolmates/Каменева Анастасия/photos/thumbnails/DSC07183.JPG",
    				"schoolmates/Каменева Анастасия/photos/thumbnails/DSC07182.JPG",
    				"schoolmates/Каменева Анастасия/photos/thumbnails/DSC07181.JPG",
    				"schoolmates/Каменева Анастасия/photos/thumbnails/DSC07180.JPG",
    				"schoolmates/Каменева Анастасия/photos/thumbnails/DSC07179.JPG",
    				"schoolmates/Каменева Анастасия/photos/thumbnails/DSC07174.JPG",
    				"schoolmates/Каменева Анастасия/photos/thumbnails/DSC07173.JPG"
				),
				new Array (
					"schoolmates/Каменева Анастасия/videos/1.flv",
					"schoolmates/Каменева Анастасия/videos/2.flv"
				),
				new Array (
					"schoolmates/Каменева Анастасия/videos/thumbnails/1.flv.jpg",
					"schoolmates/Каменева Анастасия/videos/thumbnails/2.flv.jpg"
				)
			)
            
            ,
            /* Карпухина Александра */
            new User(
				"Карпухина Александра",
				"schoolmates/Карпухина Александра/photo.jpg",
				"schoolmates/Карпухина Александра/photo_thumbnail.jpg",
				"19/01/1993",
				"",
				"",
				new Array(
					"icq: 553848956"
				),
				new Array (
    				"schoolmates/Карпухина Александра/photos/DSC07201.JPG",
    				"schoolmates/Карпухина Александра/photos/DSC07207.JPG",
    				"schoolmates/Карпухина Александра/photos/DSC07208.JPG",
    				"schoolmates/Карпухина Александра/photos/DSC07210.JPG",
    				"schoolmates/Карпухина Александра/photos/DSC07203.JPG",
    				"schoolmates/Карпухина Александра/photos/DSC07204.JPG",
    				"schoolmates/Карпухина Александра/photos/DSC07212.JPG",
    				"schoolmates/Карпухина Александра/photos/DSC07214.JPG",
    				"schoolmates/Карпухина Александра/photos/SCAN0006_08.jpg",
    				"schoolmates/Карпухина Александра/photos/SCAN0006_05.jpg",
    				"schoolmates/Карпухина Александра/photos/SCAN0006_03.jpg",
    				"schoolmates/Карпухина Александра/photos/SCAN0006_01.jpg"
				),
				new Array (
    				"schoolmates/Карпухина Александра/photos/thumbnails/DSC07201.JPG",
    				"schoolmates/Карпухина Александра/photos/thumbnails/DSC07207.JPG",
    				"schoolmates/Карпухина Александра/photos/thumbnails/DSC07208.JPG",
    				"schoolmates/Карпухина Александра/photos/thumbnails/DSC07210.JPG",
    				"schoolmates/Карпухина Александра/photos/thumbnails/DSC07203.JPG",
    				"schoolmates/Карпухина Александра/photos/thumbnails/DSC07204.JPG",
    				"schoolmates/Карпухина Александра/photos/thumbnails/DSC07212.JPG",
    				"schoolmates/Карпухина Александра/photos/thumbnails/DSC07214.JPG",
    				"schoolmates/Карпухина Александра/photos/thumbnails/SCAN0006_08.jpg",
    				"schoolmates/Карпухина Александра/photos/thumbnails/SCAN0006_05.jpg",
    				"schoolmates/Карпухина Александра/photos/thumbnails/SCAN0006_03.jpg",
    				"schoolmates/Карпухина Александра/photos/thumbnails/SCAN0006_01.jpg"
				),
				new Array (
					"schoolmates/Карпухина Александра/videos/1.flv",
					"schoolmates/Карпухина Александра/videos/3.flv"
				),
				new Array (
					"schoolmates/Карпухина Александра/videos/thumbnails/1.flv.jpg",
					"schoolmates/Карпухина Александра/videos/thumbnails/3.flv.jpg"
				)
			)
            
            ,
            /* Кузьмина Татьяна */
            new User(
				"Кузьмина Татьяна",
				"schoolmates/Кузьмина Татьяна/photo.jpg",
				"schoolmates/Кузьмина Татьяна/photo_thumbnail.jpg",
				"23/07/1992",
				"",
				"",
				new Array(
					"icq: 418584205"
				),
				new Array (
    				"schoolmates/Кузьмина Татьяна/photos/DSC00680.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/DSC00683.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/DSC00676.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/DSC00681.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/DSC00684.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/DSC00678.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/DSC00682.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/DSC00677.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/DSC00685.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/photo0773.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/x_fc1f7057.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/x_9f8f6670.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/x_a1b404c3.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/photo0298.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/x_5ebfac0a.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/x_c065dc3f.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/x_f356ebcc.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/x_eace0514.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/x_46ff40ae.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/DSC_0029.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/x_189d17eb.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/26-12-07_0001.jpg"
				),
				new Array (
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/DSC00680.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/DSC00683.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/DSC00676.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/DSC00681.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/DSC00684.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/DSC00678.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/DSC00682.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/DSC00677.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/DSC00685.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/photo0773.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/x_fc1f7057.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/x_9f8f6670.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/x_a1b404c3.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/photo0298.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/x_5ebfac0a.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/x_c065dc3f.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/x_f356ebcc.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/x_eace0514.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/x_46ff40ae.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/DSC_0029.JPG",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/x_189d17eb.jpg",
    				"schoolmates/Кузьмина Татьяна/photos/thumbnails/26-12-07_0001.jpg"
				),
				new Array (
					"schoolmates/Кузьмина Татьяна/videos/1.flv",
					"schoolmates/Кузьмина Татьяна/videos/2.flv"
				),
				new Array (
					"schoolmates/Кузьмина Татьяна/videos/thumbnails/1.flv.jpg",
					"schoolmates/Кузьмина Татьяна/videos/thumbnails/2.flv.jpg"
				)
			)
            
            ,
            /* Михальчук Ольга */
            new User(
				"Михальчук Ольга",
				"schoolmates/Михальчук Ольга/photo.jpg",
				"schoolmates/Михальчук Ольга/photo_thumbnail.jpg",
				"13/05/1993",
				"",
				"",
				new Array(
					"icq: 408380726"
				),
				new Array (
    				"schoolmates/Михальчук Ольга/photos/DSC07108.JPG",
    				"schoolmates/Михальчук Ольга/photos/DSC07111.JPG",
    				"schoolmates/Михальчук Ольга/photos/DSC07109.JPG",
    				"schoolmates/Михальчук Ольга/photos/DSC07103.JPG",
    				"schoolmates/Михальчук Ольга/photos/DSC07106.JPG",
    				"schoolmates/Михальчук Ольга/photos/DSC07101.JPG",
    				"schoolmates/Михальчук Ольга/photos/DSC07100.JPG",
    				"schoolmates/Михальчук Ольга/photos/1.jpg",
    				"schoolmates/Михальчук Ольга/photos/SCAN00011.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_fc1f7057.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_3049ecea.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_0a580080.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_dd1ebf2b.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_6168ea18.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_b7b4fb52.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_cc540f24.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_386867ab.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_2fcb6a95.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_0bda3596.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_44641de4.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_dd8ba52a.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_65c43a33.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_2a76fbf1.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_68f37105.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_d8823b19.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_51b8da42.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_870fcb36.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_296a5fa2.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_0fb7161f.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_6913af4e.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_6535d575.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_de3d7a40.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_0eba2c2e.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_892e5f9e.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_5f04b748.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_67873dc0.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_8a3a921e.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_d4cdd913.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_f0027327.jpg",
    				"schoolmates/Михальчук Ольга/photos/x_0b9b79ab.jpg"
				),
				new Array (
    				"schoolmates/Михальчук Ольга/photos/thumbnails/DSC07108.JPG",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/DSC07111.JPG",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/DSC07109.JPG",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/DSC07103.JPG",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/DSC07106.JPG",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/DSC07101.JPG",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/DSC07100.JPG",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/1.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/SCAN00011.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_fc1f7057.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_3049ecea.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_0a580080.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_dd1ebf2b.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_6168ea18.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_b7b4fb52.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_cc540f24.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_386867ab.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_2fcb6a95.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_0bda3596.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_44641de4.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_dd8ba52a.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_65c43a33.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_2a76fbf1.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_68f37105.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_d8823b19.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_51b8da42.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_870fcb36.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_296a5fa2.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_0fb7161f.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_6913af4e.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_6535d575.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_de3d7a40.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_0eba2c2e.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_892e5f9e.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_5f04b748.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_67873dc0.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_8a3a921e.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_d4cdd913.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_f0027327.jpg",
    				"schoolmates/Михальчук Ольга/photos/thumbnails/x_0b9b79ab.jpg"
				),
				new Array (
					"schoolmates/Михальчук Ольга/videos/1.flv",
					"schoolmates/Михальчук Ольга/videos/2.flv"
				),
				new Array (
					"schoolmates/Михальчук Ольга/videos/thumbnails/1.flv.jpg",
					"schoolmates/Михальчук Ольга/videos/thumbnails/2.flv.jpg"
				)
			)
            
            ,
            /* Нечаева Ольга */
            new User(
				"Нечаева Ольга",
				"schoolmates/Нечаева Ольга/photo.jpg",
				"schoolmates/Нечаева Ольга/photo_thumbnail.jpg",
				"25/09/1993",
				"",
				"",
				new Array(
					"icq: 464053244"
				),
				new Array (
    				"schoolmates/Нечаева Ольга/photos/DSC07092.JPG",
    				"schoolmates/Нечаева Ольга/photos/DSC07088.JPG",
    				"schoolmates/Нечаева Ольга/photos/DSC07090.JPG",
    				"schoolmates/Нечаева Ольга/photos/DSC07091.JPG",
    				"schoolmates/Нечаева Ольга/photos/DSC07093.JPG",
    				"schoolmates/Нечаева Ольга/photos/DSC07099.JPG",
    				"schoolmates/Нечаева Ольга/photos/DSC07097.JPG",
    				"schoolmates/Нечаева Ольга/photos/DSC07096.JPG",
    				"schoolmates/Нечаева Ольга/photos/DSC07095.JPG",
    				"schoolmates/Нечаева Ольга/photos/DSC07094.JPG",
    				"schoolmates/Нечаева Ольга/photos/DSC07089.JPG",
    				"schoolmates/Нечаева Ольга/photos/x_44641de4.jpg",
    				"schoolmates/Нечаева Ольга/photos/x_083f79a2.jpg",
    				"schoolmates/Нечаева Ольга/photos/x_720ef2d4.jpg",
    				"schoolmates/Нечаева Ольга/photos/bal 107.jpg",
    				"schoolmates/Нечаева Ольга/photos/vipusknoy 9 16.07.08 054.jpg",
    				"schoolmates/Нечаева Ольга/photos/IMG_1927.jpg"
				),
				new Array (
    				"schoolmates/Нечаева Ольга/photos/thumbnails/DSC07092.JPG",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/DSC07088.JPG",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/DSC07090.JPG",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/DSC07091.JPG",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/DSC07093.JPG",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/DSC07099.JPG",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/DSC07097.JPG",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/DSC07096.JPG",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/DSC07095.JPG",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/DSC07094.JPG",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/DSC07089.JPG",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/x_44641de4.jpg",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/x_083f79a2.jpg",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/x_720ef2d4.jpg",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/bal 107.jpg",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/vipusknoy 9 16.07.08 054.jpg",
    				"schoolmates/Нечаева Ольга/photos/thumbnails/IMG_1927.jpg"
				),
				new Array (
					"schoolmates/Нечаева Ольга/videos/1.flv",
					"schoolmates/Нечаева Ольга/videos/2.flv"
				),
				new Array (
					"schoolmates/Нечаева Ольга/videos/thumbnails/1.flv.jpg",
					"schoolmates/Нечаева Ольга/videos/thumbnails/2.flv.jpg"
				)
			)
            
            ,
            /* Ромайкина Анна */
            new User(
				"Ромайкина Анна",
				"schoolmates/Ромайкина Анна/photo.jpg",
				"schoolmates/Ромайкина Анна/photo_thumbnail.jpg",
				"10/03/1993",
				"",
				"",
				new Array(
					"icq: 363496016"
				),
				new Array (
    				"schoolmates/Ромайкина Анна/photos/DSC07081.JPG",
    				"schoolmates/Ромайкина Анна/photos/DSC07082.JPG",
    				"schoolmates/Ромайкина Анна/photos/DSC07084.JPG",
    				"schoolmates/Ромайкина Анна/photos/DSC07086.JPG",
    				"schoolmates/Ромайкина Анна/photos/DSC07087.JPG",
    				"schoolmates/Ромайкина Анна/photos/DSC07076.JPG",
    				"schoolmates/Ромайкина Анна/photos/DSC07075.JPG",
    				"schoolmates/Ромайкина Анна/photos/DSC07085.JPG",
    				"schoolmates/Ромайкина Анна/photos/x_8ff9b635.jpg",
    				"schoolmates/Ромайкина Анна/photos/prazdnik 9 05 043.jpg",
    				"schoolmates/Ромайкина Анна/photos/lager 25.jpg",
    				"schoolmates/Ромайкина Анна/photos/prazdnik 9 05 060.jpg",
    				"schoolmates/Ромайкина Анна/photos/na rechnom 6.jpg",
    				"schoolmates/Ромайкина Анна/photos/hhh.jpg",
    				"schoolmates/Ромайкина Анна/photos/bal.jpg"
				),
				new Array (
    				"schoolmates/Ромайкина Анна/photos/thumbnails/DSC07081.JPG",
    				"schoolmates/Ромайкина Анна/photos/thumbnails/DSC07082.JPG",
    				"schoolmates/Ромайкина Анна/photos/thumbnails/DSC07084.JPG",
    				"schoolmates/Ромайкина Анна/photos/thumbnails/DSC07086.JPG",
    				"schoolmates/Ромайкина Анна/photos/thumbnails/DSC07087.JPG",
    				"schoolmates/Ромайкина Анна/photos/thumbnails/DSC07076.JPG",
    				"schoolmates/Ромайкина Анна/photos/thumbnails/DSC07075.JPG",
    				"schoolmates/Ромайкина Анна/photos/thumbnails/DSC07085.JPG",
    				"schoolmates/Ромайкина Анна/photos/thumbnails/x_8ff9b635.jpg",
    				"schoolmates/Ромайкина Анна/photos/thumbnails/prazdnik 9 05 043.jpg",
    				"schoolmates/Ромайкина Анна/photos/thumbnails/lager 25.jpg",
    				"schoolmates/Ромайкина Анна/photos/thumbnails/prazdnik 9 05 060.jpg",
    				"schoolmates/Ромайкина Анна/photos/thumbnails/na rechnom 6.jpg",
    				"schoolmates/Ромайкина Анна/photos/thumbnails/hhh.jpg",
    				"schoolmates/Ромайкина Анна/photos/thumbnails/bal.jpg"
				),
				new Array (
					"schoolmates/Ромайкина Анна/videos/1.flv",
					"schoolmates/Ромайкина Анна/videos/2.flv"
				),
				new Array (
					"schoolmates/Ромайкина Анна/videos/thumbnails/1.flv.jpg",
					"schoolmates/Ромайкина Анна/videos/thumbnails/2.flv.jpg"
				)
			)
            
            ,
            /* Чижикова Татьяна */
            new User(
				"Чижикова Татьяна",
				"schoolmates/Чижикова Татьяна/photo.jpg",
				"schoolmates/Чижикова Татьяна/photo_thumbnail.jpg",
				"20/09/1992",
				"",
				"",
				new Array(
					"icq: 464921347"
				),
				new Array (
    				"schoolmates/Чижикова Татьяна/photos/DSC07189.JPG",
    				"schoolmates/Чижикова Татьяна/photos/DSC07191.JPG",
    				"schoolmates/Чижикова Татьяна/photos/DSC07198.JPG",
    				"schoolmates/Чижикова Татьяна/photos/DSC07186.JPG",
    				"schoolmates/Чижикова Татьяна/photos/DSC07187.JPG",
    				"schoolmates/Чижикова Татьяна/photos/DSC07188.JPG",
    				"schoolmates/Чижикова Татьяна/photos/DSC07192.JPG",
    				"schoolmates/Чижикова Татьяна/photos/DSC07193.JPG"
				),
				new Array (
    				"schoolmates/Чижикова Татьяна/photos/thumbnails/DSC07189.JPG",
    				"schoolmates/Чижикова Татьяна/photos/thumbnails/DSC07191.JPG",
    				"schoolmates/Чижикова Татьяна/photos/thumbnails/DSC07198.JPG",
    				"schoolmates/Чижикова Татьяна/photos/thumbnails/DSC07186.JPG",
    				"schoolmates/Чижикова Татьяна/photos/thumbnails/DSC07187.JPG",
    				"schoolmates/Чижикова Татьяна/photos/thumbnails/DSC07188.JPG",
    				"schoolmates/Чижикова Татьяна/photos/thumbnails/DSC07192.JPG",
    				"schoolmates/Чижикова Татьяна/photos/thumbnails/DSC07193.JPG"
				),
				new Array (
					"schoolmates/Чижикова Татьяна/videos/1.flv",
					"schoolmates/Чижикова Татьяна/videos/2.flv"
				),
				new Array (
					"schoolmates/Чижикова Татьяна/videos/thumbnails/1.flv.jpg",
					"schoolmates/Чижикова Татьяна/videos/thumbnails/2.flv.jpg"
				)
			)
            
            ,
            /* Шелестова Алеся */
            new User(
				"Шелестова Алеся",
				"schoolmates/Шелестова Алеся/photo.jpg",
				"schoolmates/Шелестова Алеся/photo_thumbnail.jpg",
				"27/08/1992",
				"",
				"",
				new Array(
					"icq: 337321368"
				),
				new Array (
    				"schoolmates/Шелестова Алеся/photos/DSC07113.JPG",
    				"schoolmates/Шелестова Алеся/photos/DSC07114.JPG",
    				"schoolmates/Шелестова Алеся/photos/DSC07115.JPG",
    				"schoolmates/Шелестова Алеся/photos/DSC07117.JPG",
    				"schoolmates/Шелестова Алеся/photos/DSC07118.JPG",
    				"schoolmates/Шелестова Алеся/photos/DSC07120.JPG",
    				"schoolmates/Шелестова Алеся/photos/DSC07121.JPG",
    				"schoolmates/Шелестова Алеся/photos/DSC07122.JPG",
    				"schoolmates/Шелестова Алеся/photos/DSC07123.JPG",
    				"schoolmates/Шелестова Алеся/photos/DSC07119.JPG",
    				"schoolmates/Шелестова Алеся/photos/DSC07124.JPG",
    				"schoolmates/Шелестова Алеся/photos/DSC07125.JPG",
    				"schoolmates/Шелестова Алеся/photos/2.jpg",
    				"schoolmates/Шелестова Алеся/photos/4.jpg",
    				"schoolmates/Шелестова Алеся/photos/5.jpg",
    				"schoolmates/Шелестова Алеся/photos/1.jpg",
    				"schoolmates/Шелестова Алеся/photos/3.jpg"
				),
				new Array (
    				"schoolmates/Шелестова Алеся/photos/thumbnails/DSC07113.JPG",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/DSC07114.JPG",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/DSC07115.JPG",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/DSC07117.JPG",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/DSC07118.JPG",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/DSC07120.JPG",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/DSC07121.JPG",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/DSC07122.JPG",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/DSC07123.JPG",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/DSC07119.JPG",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/DSC07124.JPG",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/DSC07125.JPG",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/2.jpg",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/4.jpg",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/5.jpg",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/1.jpg",
    				"schoolmates/Шелестова Алеся/photos/thumbnails/3.jpg"
				),
				new Array (
					"schoolmates/Шелестова Алеся/videos/1.flv",
					"schoolmates/Шелестова Алеся/videos/2.flv"
				),
				new Array (
					"schoolmates/Шелестова Алеся/videos/thumbnails/1.flv.jpg",
					"schoolmates/Шелестова Алеся/videos/thumbnails/2.flv.jpg"
				)
			)
            
            ,
            /* Юдин Андрей */
            new User(
				"Юдин Андрей",
				"schoolmates/Юдин Андрей/photo.jpg",
				"schoolmates/Юдин Андрей/photo_thumbnail.jpg",
				"07/08/1992",
				"",
				"",
				new Array(
					"icq: 639388776"
				),
				new Array (
    				"schoolmates/Юдин Андрей/photos/DSC07053.JPG",
    				"schoolmates/Юдин Андрей/photos/DSC07060.JPG",
    				"schoolmates/Юдин Андрей/photos/DSC07059.JPG",
    				"schoolmates/Юдин Андрей/photos/DSC07056.JPG",
    				"schoolmates/Юдин Андрей/photos/DSC07055.JPG",
    				"schoolmates/Юдин Андрей/photos/DSC07054.JPG",
    				"schoolmates/Юдин Андрей/photos/DSC07052.JPG",
    				"schoolmates/Юдин Андрей/photos/DSC07057.JPG",
    				"schoolmates/Юдин Андрей/photos/IMGP2536.jpg",
    				"schoolmates/Юдин Андрей/photos/x_1fcb442c.jpg",
    				"schoolmates/Юдин Андрей/photos/DSC01506.JPG",
    				"schoolmates/Юдин Андрей/photos/DSC01069.JPG",
    				"schoolmates/Юдин Андрей/photos/DSC00643.JPG"
				),
				new Array (
    				"schoolmates/Юдин Андрей/photos/thumbnails/DSC07053.JPG",
    				"schoolmates/Юдин Андрей/photos/thumbnails/DSC07060.JPG",
    				"schoolmates/Юдин Андрей/photos/thumbnails/DSC07059.JPG",
    				"schoolmates/Юдин Андрей/photos/thumbnails/DSC07056.JPG",
    				"schoolmates/Юдин Андрей/photos/thumbnails/DSC07055.JPG",
    				"schoolmates/Юдин Андрей/photos/thumbnails/DSC07054.JPG",
    				"schoolmates/Юдин Андрей/photos/thumbnails/DSC07052.JPG",
    				"schoolmates/Юдин Андрей/photos/thumbnails/DSC07057.JPG",
    				"schoolmates/Юдин Андрей/photos/thumbnails/IMGP2536.jpg",
    				"schoolmates/Юдин Андрей/photos/thumbnails/x_1fcb442c.jpg",
    				"schoolmates/Юдин Андрей/photos/thumbnails/DSC01506.JPG",
    				"schoolmates/Юдин Андрей/photos/thumbnails/DSC01069.JPG",
    				"schoolmates/Юдин Андрей/photos/thumbnails/DSC00643.JPG"
				),
				new Array (
					"schoolmates/Юдин Андрей/videos/1.flv",
					"schoolmates/Юдин Андрей/videos/2.flv"
				),
				new Array (
					"schoolmates/Юдин Андрей/videos/thumbnails/1.flv.jpg",
					"schoolmates/Юдин Андрей/videos/thumbnails/2.flv.jpg"
				)
			)
		);
		
		/* TEACHERS PROPERTIES */
		public var teachers : Array = new Array(
            /* Бабенкова Марина Валентиновна */
            new User(
				"Бабенкова Марина Валентиновна",
				"teachers/Бабенкова Марина Валентиновна/photo.jpg",
				"teachers/Бабенкова Марина Валентиновна/photo_thumbnail.jpg",
				"Английский",
				"",
				"",
				new Array (
				),
				new Array (
					"teachers/Бабенкова Марина Валентиновна/photos/1.jpg"
				),
				new Array (
					"teachers/Бабенкова Марина Валентиновна/photos/thumbnails/1.jpg"
				),
				new Array (
					"teachers/Бабенкова Марина Валентиновна/videos/1.flv"
				),
				new Array (
					"teachers/Бабенкова Марина Валентиновна/videos/thumbnails/1.flv.jpg"
				),
				true
			)
            ,
            /* Бартепь Ирина Валерьевна */
            new User(
				"Бартепь Ирина Валерьевна",
				"teachers/Бартепь Ирина Валерьевна/photo.jpg",
				"teachers/Бартепь Ирина Валерьевна/photo_thumbnail.jpg",
				"Нач. школа",
				"",
				"",
				new Array (
				),
				new Array (
					"teachers/Бартепь Ирина Валерьевна/photos/1.jpg"
				),
				new Array (
					"teachers/Бартепь Ирина Валерьевна/photos/thumbnails/1.jpg"
				),
				new Array (
					"teachers/Бартепь Ирина Валерьевна/videos/1.flv"
				),
				new Array (
					"teachers/Бартепь Ирина Валерьевна/videos/thumbnails/1.flv.jpg"
				),
				true
			)
            ,
            /* Березин Виктор Вениаминович */
            new User(
				"Березин Виктор Вениаминович",
				"teachers/Березин Виктор Вениаминович/photo.jpg",
				"teachers/Березин Виктор Вениаминович/photo_thumbnail.jpg",
				"Директор",
				"",
				"",
				new Array (
				),
				new Array (
					"teachers/Березин Виктор Вениаминович/photos/1.jpg"
				),
				new Array (
					"teachers/Березин Виктор Вениаминович/photos/thumbnails/1.jpg"
				),
				new Array (
					"teachers/Березин Виктор Вениаминович/videos/1.flv"
				),
				new Array (
					"teachers/Березин Виктор Вениаминович/videos/thumbnails/1.flv.jpg"
				),
				true
			)
            ,
            /* Василенко Елена Сергеевна */
            new User(
				"Василенко Елена Сергеевна",
				"teachers/Василенко Елена Сергеевна/photo.jpg",
				"teachers/Василенко Елена Сергеевна/photo_thumbnail.jpg",
				"Химия",
				"",
				"",
				new Array (
				),
				new Array (
					"teachers/Василенко Елена Сергеевна/photos/1.jpg"
				),
				new Array (
					"teachers/Василенко Елена Сергеевна/photos/thumbnails/1.jpg"
				),
				new Array (
					"teachers/Василенко Елена Сергеевна/videos/1.flv"
				),
				new Array (
					"teachers/Василенко Елена Сергеевна/videos/thumbnails/1.flv.jpg"
				),
				true
			)
            ,
            /* Васюнина Антонина Михайловна */
            new User(
				"Васюнина Антонина Михайловна",
				"teachers/Васюнина Антонина Михайловна/photo.jpg",
				"teachers/Васюнина Антонина Михайловна/photo_thumbnail.jpg",
				"География",
				"",
				"",
				new Array (
				),
				new Array (
					"teachers/Васюнина Антонина Михайловна/photos/1.jpg"
				),
				new Array (
					"teachers/Васюнина Антонина Михайловна/photos/thumbnails/1.jpg"
				),
				new Array (
					"teachers/Васюнина Антонина Михайловна/videos/1.flv"
				),
				new Array (
					"teachers/Васюнина Антонина Михайловна/videos/thumbnails/1.flv.jpg"
				),
				true
			)
            ,
            /* Данилин Владимир Викторович */
            new User(
				"Данилин Владимир Викторович",
				"teachers/Классный Руководитель/photo.jpg",
				"teachers/Классный Руководитель/photo_thumbnail.jpg",
				"История",
				"",
				"",
				new Array (
				),
				new Array (
					"teachers/Классный Руководитель/photos/DSC07283.JPG",
					"teachers/Классный Руководитель/photos/DSC07284.JPG",
					"teachers/Классный Руководитель/photos/DSC07285.JPG",
					"teachers/Классный Руководитель/photos/DSC07288.JPG",
					"teachers/Классный Руководитель/photos/DSC07289.JPG",
					"teachers/Классный Руководитель/photos/DSC07292.JPG"
				),
				new Array (
					"teachers/Классный Руководитель/photos/thumbnails/DSC07283.JPG",
					"teachers/Классный Руководитель/photos/thumbnails/DSC07284.JPG",
					"teachers/Классный Руководитель/photos/thumbnails/DSC07285.JPG",
					"teachers/Классный Руководитель/photos/thumbnails/DSC07288.JPG",
					"teachers/Классный Руководитель/photos/thumbnails/DSC07289.JPG",
					"teachers/Классный Руководитель/photos/thumbnails/DSC07292.JPG"
				),
				new Array (
					"teachers/Данилин Владимир Викторович/videos/1.flv"
				),
				new Array (
					"teachers/Данилин Владимир Викторович/videos/thumbnails/1.flv.jpg"
				),
				true
			)
            ,
            /* Долгов Сергей Борисович */
            new User(
				"Долгов Сергей Борисович",
				"teachers/Долгов Сергей Борисович/photo.jpg",
				"teachers/Долгов Сергей Борисович/photo_thumbnail.jpg",
				"Физкультура",
				"",
				"",
				new Array (
				),
				new Array (
					"teachers/Долгов Сергей Борисович/photos/1.jpg"
				),
				new Array (
					"teachers/Долгов Сергей Борисович/photos/thumbnails/1.jpg"
				),
				new Array (
					"teachers/Долгов Сергей Борисович/videos/1.flv"
				),
				new Array (
					"teachers/Долгов Сергей Борисович/videos/thumbnails/1.flv.jpg"
				),
				true
			)
            ,
            /* Куликов Николай Николаевич */
            new User(
				"Куликов Николай Николаевич",
				"teachers/Куликов Николай Николаевич/photo.jpg",
				"teachers/Куликов Николай Николаевич/photo_thumbnail.jpg",
				"ОБЖ",
				"",
				"",
				new Array (
				),
				new Array (
					"teachers/Куликов Николай Николаевич/photos/1.jpg"
				),
				new Array (
					"teachers/Куликов Николай Николаевич/photos/thumbnails/1.jpg"
				),
				new Array (
					"teachers/Куликов Николай Николаевич/videos/1.flv"
				),
				new Array (
					"teachers/Куликов Николай Николаевич/videos/thumbnails/1.flv.jpg"
				),
				true
			)
            ,
            /* Лютц Илона Владимировна */
            new User(
				"Лютц Илона Владимировна",
				"teachers/Лютц Илона Владимировна/photo.jpg",
				"teachers/Лютц Илона Владимировна/photo_thumbnail.jpg",
				"Обществознание",
				"",
				"",
				new Array (
				),
				new Array (
					"teachers/Лютц Илона Владимировна/photos/1.jpg"
				),
				new Array (
					"teachers/Лютц Илона Владимировна/photos/thumbnails/1.jpg"
				),
				new Array (
					"teachers/Лютц Илона Владимировна/videos/1.flv"
				),
				new Array (
					"teachers/Лютц Илона Владимировна/videos/thumbnails/1.flv.jpg"
				),
				true
			)
            ,
            /* Нагаева Любовь Николаевна */
            new User(
				"Нагаева Любовь Николаевна",
				"teachers/Нагаева Любовь Николаевна/photo.jpg",
				"teachers/Нагаева Любовь Николаевна/photo_thumbnail.jpg",
				"Русский",
				"",
				"",
				new Array (
				),
				new Array (
					"teachers/Нагаева Любовь Николаевна/photos/1.jpg"
				),
				new Array (
					"teachers/Нагаева Любовь Николаевна/photos/thumbnails/1.jpg"
				),
				new Array (
					"teachers/Нагаева Любовь Николаевна/videos/1.flv"
				),
				new Array (
					"teachers/Нагаева Любовь Николаевна/videos/thumbnails/1.flv.jpg"
				),
				true
			)
            ,
            /* Скиперекая Наталья Владиславовна */
            new User(
				"Скиперекая Наталья Владиславовна",
				"teachers/Скиперекая Наталья Владиславовна/photo.jpg",
				"teachers/Скиперекая Наталья Владиславовна/photo_thumbnail.jpg",
				"Немецкий",
				"",
				"",
				new Array (
				),
				new Array (
					"teachers/Скиперекая Наталья Владиславовна/photos/1.jpg"
				),
				new Array (
					"teachers/Скиперекая Наталья Владиславовна/photos/thumbnails/1.jpg"
				),
				new Array (
					"teachers/Скиперекая Наталья Владиславовна/videos/1.flv"
				),
				new Array (
					"teachers/Скиперекая Наталья Владиславовна/videos/thumbnails/1.flv.jpg"
				),
				true
			)
            ,
            /* Терещенко Елена Генадьевна */
            new User(
				"Терещенко Елена Генадьевна",
				"teachers/Терещенко Елена Генадьевна/photo.jpg",
				"teachers/Терещенко Елена Генадьевна/photo_thumbnail.jpg",
				"Ритмика",
				"",
				"",
				new Array (
				),
				new Array (
					"teachers/Терещенко Елена Генадьевна/photos/1.jpg"
				),
				new Array (
					"teachers/Терещенко Елена Генадьевна/photos/thumbnails/1.jpg"
				),
				new Array (
					"teachers/Терещенко Елена Генадьевна/videos/1.flv"
				),
				new Array (
					"teachers/Терещенко Елена Генадьевна/videos/thumbnails/1.flv.jpg"
				),
				true
			)
		);
		
		/* ARCHIVE PROPERTIES */
		public var archive : Array = new Array(
			new ArchiveSection(
				"Общие фото",
				new Array(
					"archive/Общие фото/DSC00704.JPG",
					"archive/Общие фото/DSC00707.JPG",
					"archive/Общие фото/DSC00708.JPG",
					"archive/Общие фото/DSC00712.JPG",
					"archive/Общие фото/DSC07218.JPG",
					"archive/Общие фото/DSC07223.JPG",
					"archive/Общие фото/DSC07226.JPG",
					"archive/Общие фото/DSC07228.JPG",
					"archive/Общие фото/DSC07229.JPG",
					"archive/Общие фото/DSC07237.JPG",
					"archive/Общие фото/DSC07219.JPG",
					"archive/Общие фото/DSC07231.JPG",
					"archive/Общие фото/DSC07238.JPG",
					"archive/Общие фото/DSC07258.JPG",
					"archive/Общие фото/DSC07269.JPG",
					"archive/Общие фото/DSC00705.JPG",
					"archive/Общие фото/DSC00709.JPG",
					"archive/Общие фото/DSC07243.JPG",
					"archive/Общие фото/DSC07250.JPG",
					"archive/Общие фото/DSC07270.JPG",
					"archive/Общие фото/DSC07261.JPG",
					"archive/Общие фото/DSC07265.JPG",
					"archive/Общие фото/DSC07253.JPG"
				),
				new Array(
					"archive/Общие фото/thumbnails/DSC00704.JPG",
					"archive/Общие фото/thumbnails/DSC00707.JPG",
					"archive/Общие фото/thumbnails/DSC00708.JPG",
					"archive/Общие фото/thumbnails/DSC00712.JPG",
					"archive/Общие фото/thumbnails/DSC07218.JPG",
					"archive/Общие фото/thumbnails/DSC07223.JPG",
					"archive/Общие фото/thumbnails/DSC07226.JPG",
					"archive/Общие фото/thumbnails/DSC07228.JPG",
					"archive/Общие фото/thumbnails/DSC07229.JPG",
					"archive/Общие фото/thumbnails/DSC07237.JPG",
					"archive/Общие фото/thumbnails/DSC07219.JPG",
					"archive/Общие фото/thumbnails/DSC07231.JPG",
					"archive/Общие фото/thumbnails/DSC07238.JPG",
					"archive/Общие фото/thumbnails/DSC07258.JPG",
					"archive/Общие фото/thumbnails/DSC07269.JPG",
					"archive/Общие фото/thumbnails/DSC00705.JPG",
					"archive/Общие фото/thumbnails/DSC00709.JPG",
					"archive/Общие фото/thumbnails/DSC07243.JPG",
					"archive/Общие фото/thumbnails/DSC07250.JPG",
					"archive/Общие фото/thumbnails/DSC07270.JPG",
					"archive/Общие фото/thumbnails/DSC07261.JPG",
					"archive/Общие фото/thumbnails/DSC07265.JPG",
					"archive/Общие фото/thumbnails/DSC07253.JPG"
				)
			)
			
            ,
			
			new ArchiveSection(
				"3 вопрос",
				new Array(
					"archive/3 вопрос/1.flv",
					"archive/3 вопрос/2.flv",
					"archive/3 вопрос/3.flv",
					"archive/3 вопрос/4.flv",
					"archive/3 вопрос/5.flv"
				),
				new Array(
					"archive/3 вопрос/thumbnails/1.flv.jpg",
					"archive/3 вопрос/thumbnails/2.flv.jpg",
					"archive/3 вопрос/thumbnails/3.flv.jpg",
					"archive/3 вопрос/thumbnails/4.flv.jpg",
					"archive/3 вопрос/thumbnails/5.flv.jpg"
				),
				ArchiveSection.VIDEOS_SECTION
			)
            
            ,
            
            new ArchiveSection(
				"4 вопрос",
				new Array(
					"archive/4 вопрос/1.flv"
				),
				new Array(
					"archive/4 вопрос/thumbnails/1.flv.jpg"
				),
				ArchiveSection.VIDEOS_SECTION
			)
		);
		
		/* INFO PROPERTIES */
		public var info_html : String = 
			"<p></p><p></p><p></p><p></p><p></p>" + 
			"<img src=\"html/logo.gif\"><br><br><br><p></p>" +
			"<p><font size=\"16\">MemoryBOXstudio - Упакованная память!<br><br>" + 
			"по вопросам видеосъемок, а также заказ диска, обращайтесь по телефонам:<br><br>" +  
			"менеджер: 8-916-581-58-86 Александр<br><br>" +
			"фото-видео оператор: 8-926-233-777-1 Александр<br><br>" + 
			"Свяжитесь с нами, и мы познакомим Вас с нашей продукцией, и сервисами!<br><br>" +
			"Мы рады работать для Вас!</font></p>";

			
		/* GENERAL PROPERTIES */
		public var general_intro_video : String = "intro.flv";
		
		public var general_start_fullscreen : Boolean = false;
		public var general_show_intro : Boolean = true;
		
		public var general_music_school : String = "music/school.mp3";
		public var general_music_schoolmates : String = "music/school.mp3";
		public var general_music_teachers : String = "music/school.mp3";
		public var general_music_archive : String = "music/school.mp3";
		public var general_music_info : String = "music/school.mp3";
		
	}
}