package
{
	import mx.containers.VBox;
	import mx.controls.Image;
	import mx.controls.Label;
	import mx.controls.List;
	import mx.controls.listClasses.*;
	public class VideoThumbnailsListItemRenderer extends VBox implements IDropInListItemRenderer
	{
		private var image:Image;
		private var caption:Label;
		
		private var _listData:BaseListData;
		
		public function VideoThumbnailsListItemRenderer()
		{
			super();
			
			this.setStyle("paddingLeft", -3);
			this.setStyle("horizontalAlign", "center");
			this.width = 150;
			this.height = 150;
		}
		
		override protected function createChildren():void 
		{			
			// create image
			image = new Image();
			image.width = 150;
			image.height = 120;
			addChild(image);

			// create label
			caption = new Label();
			caption.width = 150;
			caption.setStyle("textAlign", "center");
			addChild(caption);

			super.createChildren();
		}
		
		override public function validateNow():void {
		  
			if (data && parent && !(data as BaseListData)) {
				var lst:List = List(listData.owner);
			    if (lst.isItemSelected(listData.uid) ) {
			    	caption.styleName = "ListSelected";
			    	
			    } else {
			    	caption.styleName = "ListUnselected";
			    }
		  	}	
		  
			super.validateNow();
		}
		
		override public function set data(value:Object):void {
            super.data = value;
            
			if (value != null && image != null && caption != null) {
				image.source = value;
				caption.text = getFilename(value as String);
			}
            
            super.invalidateDisplayList();
  		}
  		
  		private function getFilename(fullPath: String) : String
  		{
  			
		    var fSlash: int = fullPath.lastIndexOf("/");
		    var bSlash: int = fullPath.lastIndexOf("\\"); // reason for the double slash is just to escape the slash so it doesn't escape the quote!!!
		    var slashIndex: int = fSlash > bSlash ? fSlash : bSlash;
		    return fullPath.substr(slashIndex + 1).replace(".flv", "").replace(".jpg", "");
  		}
		
		[Bindable("dataChange")]
		public function get listData():BaseListData
		{
			return _listData;
		}
		
		public function set listData(value:BaseListData):void
		{
			_listData = value;
		}

	}
}