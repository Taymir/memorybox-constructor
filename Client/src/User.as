package
{
	[Bindable]
	public class User implements IPhotos, IVideos
	{	
		public function User(
			name : String,
			photo_large : String,
			photo_thumbnail : String,
			birthdayOrDiscipline : String,
			
			contacts_cellphone : String,
			contacts_phone : String,
			contacts_links : Array,
			
			photos_large : Array,
			photos_thumbnails : Array,
			
			videos_large : Array,
			videos_thumbnails : Array,
			
			isTeacher : Boolean = false
		)
		{
			this.name = name;
			this.photo_large = photo_large;
			this.photo_thumbnail = photo_thumbnail;
			
			if(!isTeacher)
				this.birthday = birthdayOrDiscipline;
			else
				this.discipline = birthdayOrDiscipline;
				
			this.contacts_cellphone = contacts_cellphone;
			this.contacts_phone = contacts_phone;
			this.contacts_links = contacts_links;
			
			this.photos_large = photos_large;
			this.photos_thumbnails = photos_thumbnails;
			
			this.videos_large = videos_large;
			this.videos_thumbnails = videos_thumbnails;	
				
			this.isTeacher = isTeacher;
		}
		
		public var name : String;
		public var photo_large : String;
		public var photo_thumbnail : String;
		
		public var isTeacher : Boolean = false;
		public var birthday : String;
		public var discipline : String;
		
		public var contacts_cellphone : String;
		public var contacts_phone : String;
		public var contacts_links : Array;
		
		public var photos_large : Array;
		public var photos_thumbnails : Array;
		
		public var videos_large : Array;
		public var videos_thumbnails : Array;
		
		// IPHOTOS IMPLEMENTATION
		public function get photosLarge() : Array
		{
			return this.photos_large;
		}
		public function get photosThumbnails() : Array
		{
			return this.photos_thumbnails;
		}
		
		// IVIDEOS IMPLEMENTATION
		public function get videosLarge() : Array
		{
			return this.videos_large;
		}
		public function get videosThumbnails() : Array
		{
			return this.videos_thumbnails;
		}
		
		public function getFirstPhotoThumb() : String
		{
			if(this.photos_thumbnails.length > 0)
				return this.photos_thumbnails[0];
			
			return "";
		}
		
		public function getFirstVideoThumb() : String
		{
			if(this.videos_thumbnails.length > 0)
				return this.videos_thumbnails[0];
			
			return "";
		}
	}
}