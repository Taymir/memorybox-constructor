package
{
	public class ArchiveSection implements IPhotos, IVideos
	{
		public static const PHOTOS_SECTION : int = 0;
		public static const VIDEOS_SECTION : int = 1;
		
		public function ArchiveSection(
			name : String,
			
			large : Array,
			thumbnails : Array,
			
			type : int = PHOTOS_SECTION
		)
		{
			this.name = name;
			
			this.large = large;
			this.thumbnails = thumbnails;
			
			this.type = type;
		}
		
		public var name : String;
		
		public var type : int;
		
		public var large : Array;
		public var thumbnails : Array;
		
		// IPHOTOS IMPLEMENTATION
		public function get photosLarge() : Array
		{
			return this.large;
		}
		public function get photosThumbnails() : Array
		{
			return this.thumbnails;
		}
		
		// IVIDEOS IMPLEMENTATION
		public function get videosLarge() : Array
		{
			return this.large;
		}
		public function get videosThumbnails() : Array
		{
			return this.thumbnails;
		}
	}
}