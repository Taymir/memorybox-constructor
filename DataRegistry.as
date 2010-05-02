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
		public var school_name : String = "Гимназия 1894\"23";
		public var school_photo : String = "school/school.jpg";
		
		public var school_contacts_phone : String = "+7 (495) 123-72-34";
		public var school_contacts_email : String = "school@test.com.ru";
		public var school_contacts_links : Array = new Array(
			"www.artlebedev.ru"
			);
		
		public var school_pictures_history : String = "school/history.jpg";
		public var school_pictures_director : String = "school/director.jpg";
		public var school_pictures_video : String = "school/video.jpg";
		
		/* SCHOOL: HISTORY PROPERTIES */
		public var school_history_html : String = 					
			"<P>Приказ N 165 по Новосибирскому<br> городскому отделу народного образования " + 
			"от 13.04.1950 года. Алымова Алексея Яковлевича назначить исполняющим " +  
			"обязанности директора вновь строящейся школы в Дзержинском районе. " +  
			"Заведующая Новосибирским отделом народного образования - Данилова. " +  
			"Так родилась наша школа!</P> " +  
			"<p><img src=\"http://www.school23.info/hp1.jpg\" width=\"200\" height=\"126\" alt=\"Наша Школа 1950 год\"> </p>" +  
			"<p>Средняя общеобразовательная школа N 23 города Новосибирска была " +  
			"открыта 30 августа 1950 года. Первый выпуск учащихся из 37 человек, " +  
			"состоялся уже в 1954 году. Среди первых выпускников того времени: " +  
			"Дмитриев Евгений - золотой медалист нашей школы, серебрянные " +  
			"медалисты Халимов Анатолий и Яковлев Альберт. К 2006 году (время " +  
			"открытия нашего сайта) средняя общеобразовательная школа N 23 " +  
			"выпустила 3772 учащихся, 8 золотых медалистов и 57 серебряных.  " + 
			"<b>Из воспоминаний выпускников:</b></p> " +  
			"<p><img src=\"http://www.school23.info/hp2.jpg\" width=\"200\" height=\"97\" alt=\"Первый выпуск с классным руководителем\"></p> " +  
			"<p>Новый, 1951 учебный год. Учителя и ученики так называемых кварталов на " +  
			"Богдашке начинали бурно и радостно. На улице Народной была открыта " +  
			"новая средняя школа N 23. Четырехэтажная, со специальными кабинетами " +  
			"физики, химии, биологии, со спортивным залом и уютным двориком, она " +  
			"притягивала, как мечта, всех нас, послевоенных учеников, четырнадцати " +  
			"летних подростков, светом новой послевоенной жизни. Мы выплеснулись " +  
			"из переполненных старых, где-то барачных школ в округе на новый в " +  
			"Дзержинском районе проспект Богдана Хмельницкого. И он навсегда стал " +  
			"нашим. Школа стала местом, куда мы приходили не просто за знаниями, " +  
			"а за общением между собой, которое вынужденно прерывалось занятиями. " +  
			"Учить нас было трудно. Мешали огромные пробелы в начальном образовании " +  
			"за годы войны. И вся эта тяжесть легла на плечи новых для школы и новых " +  
			"и новых для нас учителей. Но они стали для нас, учеников нового набора " +  
			"1951 года и затем первого выпуска 1954 года, первооткрывателями нашего " +  
			"нашего осознания жизненных ценностей страны, семьи, школы, друзей... " +  
			"(По поручению выпускников 1954 года школы N 23, Юрий Куратченко)</p> ";
			
		/* SCHOOL: DIRECTOR PROPERTIES */
		public var school_director_photo : String = "school/director/director.jpg";
		public var school_director_name : String = "Коновалов Владимир Николаевич";
		public var school_director_video : String = "school/director/director.flv";
		
		/* SCHOOL: VIDEO PROPERTIES */
		public var school_video : String = "school/video.flv";
		
		/* SCHOOLMATES PROPERTIES */
		public var schoolmates : Array = new Array(
		
			/* АЛЁХИНА ЮЛИЯ */
			new User(
				"Алёхина Юлия",
				"schoolmates/Алёхина Юлия/photo.jpg",
				"schoolmates/Алёхина Юлия/photo_thumbnail.jpg",
				"31 февраля 1991",
				"+7 955 123-56-78",
				"+7 499 256-78-89",
				new Array(
					"vkontakte.ru/id12345"
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
		);
		
		/* TEACHERS PROPERTIES */
		public var teachers : Array = new Array(
			new User(
				"Бабенкова Марина Валентиновна",
				"teachers/Бабенкова Марина Валентиновна/photo.jpg",
				"teachers/Бабенкова Марина Валентиновна/photo_thumbnail.jpg",
				"Английский язык",
				"+7 123 4567899",
				"+1 234 5678901",
				new Array (
				),
				new Array (
					"teachers/Бабенкова Марина Валентиновна/photos/img.jpg"
				),
				new Array (
					"teachers/Бабенкова Марина Валентиновна/photos/thumbnails/img.jpg"
				),
				new Array (
					"teachers/Бабенкова Марина Валентиновна/videos/1.flv"
				),
				new Array (
					"teachers/Бабенкова Марина Валентиновна/videos/thumbnails/1.flv.jpg"
				),
				true
			)
		);
		
		/* ARCHIVE PROPERTIES */
		public var archive : Array = new Array(
			new ArchiveSection(
				"Выпускной",
				new Array(
					"archive/Выпускной/DSC00704.JPG",
					"archive/Выпускной/DSC00705.JPG",
					"archive/Выпускной/DSC00707.JPG",
					"archive/Выпускной/DSC00708.JPG",
					"archive/Выпускной/DSC00709.JPG",
					"archive/Выпускной/DSC00712.JPG",
					"archive/Выпускной/DSC07218.JPG",
					"archive/Выпускной/DSC07219.JPG",
					"archive/Выпускной/DSC07223.JPG",
					"archive/Выпускной/DSC07226.JPG",
					"archive/Выпускной/DSC07228.JPG",
					"archive/Выпускной/DSC07229.JPG",
					"archive/Выпускной/DSC07231.JPG",
					"archive/Выпускной/DSC07237.JPG",
					"archive/Выпускной/DSC07238.JPG",
					"archive/Выпускной/DSC07243.JPG",
					"archive/Выпускной/DSC07250.JPG",
					"archive/Выпускной/DSC07253.JPG",
					"archive/Выпускной/DSC07258.JPG",
					"archive/Выпускной/DSC07261.JPG",
					"archive/Выпускной/DSC07265.JPG",
					"archive/Выпускной/DSC07269.JPG",
					"archive/Выпускной/DSC07270.JPG"
				),
				new Array(
					"archive/Выпускной/thumbnails/DSC00704.JPG",
					"archive/Выпускной/thumbnails/DSC00705.JPG",
					"archive/Выпускной/thumbnails/DSC00707.JPG",
					"archive/Выпускной/thumbnails/DSC00708.JPG",
					"archive/Выпускной/thumbnails/DSC00709.JPG",
					"archive/Выпускной/thumbnails/DSC00712.JPG",
					"archive/Выпускной/thumbnails/DSC07218.JPG",
					"archive/Выпускной/thumbnails/DSC07219.JPG",
					"archive/Выпускной/thumbnails/DSC07223.JPG",
					"archive/Выпускной/thumbnails/DSC07226.JPG",
					"archive/Выпускной/thumbnails/DSC07228.JPG",
					"archive/Выпускной/thumbnails/DSC07229.JPG",
					"archive/Выпускной/thumbnails/DSC07231.JPG",
					"archive/Выпускной/thumbnails/DSC07237.JPG",
					"archive/Выпускной/thumbnails/DSC07238.JPG",
					"archive/Выпускной/thumbnails/DSC07243.JPG",
					"archive/Выпускной/thumbnails/DSC07250.JPG",
					"archive/Выпускной/thumbnails/DSC07253.JPG",
					"archive/Выпускной/thumbnails/DSC07258.JPG",
					"archive/Выпускной/thumbnails/DSC07261.JPG",
					"archive/Выпускной/thumbnails/DSC07265.JPG",
					"archive/Выпускной/thumbnails/DSC07269.JPG",
					"archive/Выпускной/thumbnails/DSC07270.JPG"
				)
			)
			
			,
			
			new ArchiveSection(
				"Тест",
				new Array(
					"archive/Выпускной/DSC07265.JPG",
					"archive/Выпускной/DSC07269.JPG",
					"archive/Выпускной/DSC07270.JPG"
				),
				new Array(
					"archive/Выпускной/thumbnails/DSC07265.JPG",
					"archive/Выпускной/thumbnails/DSC07269.JPG",
					"archive/Выпускной/thumbnails/DSC07270.JPG"
				)
			)
		);
		
		/* INFO PROPERTIES */
		public var info_html : String = 
			"<P>Приказ N 165 по Новосибирскому<br> городскому отделу народного образования " + 
			"от 13.04.1950 года. Алымова Алексея Яковлевича назначить исполняющим " +  
			"обязанности директора вновь строящейся школы в Дзержинском районе. " +  
			"Заведующая Новосибирским отделом народного образования - Данилова. " +  
			"Так родилась наша школа!</P> " +  
			"<p><img src=\"http://www.school23.info/hp1.jpg\" width=\"200\" height=\"126\" alt=\"Наша Школа 1950 год\"> </p>" +  
			"<p>Средняя общеобразовательная школа N 23 города Новосибирска была " +  
			"открыта 30 августа 1950 года. Первый выпуск учащихся из 37 человек, " +  
			"состоялся уже в 1954 году. Среди первых выпускников того времени: " +  
			"Дмитриев Евгений - золотой медалист нашей школы, серебрянные " +  
			"медалисты Халимов Анатолий и Яковлев Альберт. К 2006 году (время " +  
			"открытия нашего сайта) средняя общеобразовательная школа N 23 " +  
			"выпустила 3772 учащихся, 8 золотых медалистов и 57 серебряных.  " + 
			"<b>Из воспоминаний выпускников:</b></p> " +  
			"<p><img src=\"http://www.school23.info/hp2.jpg\" width=\"200\" height=\"97\" alt=\"Первый выпуск с классным руководителем\"></p> " +  
			"<p>Новый, 1951 учебный год. Учителя и ученики так называемых кварталов на " +  
			"Богдашке начинали бурно и радостно. На улице Народной была открыта " +  
			"новая средняя школа N 23. Четырехэтажная, со специальными кабинетами " +  
			"физики, химии, биологии, со спортивным залом и уютным двориком, она " +  
			"притягивала, как мечта, всех нас, послевоенных учеников, четырнадцати " +  
			"летних подростков, светом новой послевоенной жизни. Мы выплеснулись " +  
			"из переполненных старых, где-то барачных школ в округе на новый в " +  
			"Дзержинском районе проспект Богдана Хмельницкого. И он навсегда стал " +  
			"нашим. Школа стала местом, куда мы приходили не просто за знаниями, " +  
			"а за общением между собой, которое вынужденно прерывалось занятиями. " +  
			"Учить нас было трудно. Мешали огромные пробелы в начальном образовании " +  
			"за годы войны. И вся эта тяжесть легла на плечи новых для школы и новых " +  
			"и новых для нас учителей. Но они стали для нас, учеников нового набора " +  
			"1951 года и затем первого выпуска 1954 года, первооткрывателями нашего " +  
			"нашего осознания жизненных ценностей страны, семьи, школы, друзей... " +  
			"(По поручению выпускников 1954 года школы N 23, Юрий Куратченко)</p> ";
			
		/* GENERAL PROPERTIES */
		public var general_intro_video : String = "intro.flv";
		
		public var general_start_fullscreen : Boolean = false;
		public var general_show_intro : Boolean = false;
	}
}