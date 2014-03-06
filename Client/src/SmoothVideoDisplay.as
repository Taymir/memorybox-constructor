package {  
   
	import mx.controls.VideoDisplay;
	import mx.core.mx_internal;
	import mx.events.FlexEvent;  
	   
	use namespace mx_internal;  
	  
	public class SmoothVideoDisplay extends VideoDisplay  
	{  
		public function SmoothVideoDisplay():void  
		{
			super();  
			addEventListener( FlexEvent.CREATION_COMPLETE, onCreationComplete );  
		}  
	   
		private function onCreationComplete( e:FlexEvent):void  
		{  
			if (videoPlayer.smoothing != smoothing)  
			videoPlayer.smoothing = smoothing;  
		}  
		  
		private var _smoothing:Boolean = false;
		
		[Bindable]  
		public function set smoothing( val:Boolean):void  
		{  
			if ( val == smoothing)  
			return;  
			_smoothing = val;  
			   
			if (videoPlayer)  
			videoPlayer.smoothing = _smoothing;  
		}  
		  
		public function get smoothing():Boolean  
		{  
			return _smoothing;  
		}
	
	}
}