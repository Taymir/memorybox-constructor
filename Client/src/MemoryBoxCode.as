import components.LinkLabel;
import components.standaloneVideoView;

import flash.display.StageScaleMode;
import flash.events.Event;
import flash.system.fscommand;

import mx.containers.Canvas;
import mx.controls.Text;
import mx.core.UIComponent;
import mx.events.VideoEvent;

private const DEBUG : Boolean = false; //@DEBUG

public static var musicPlayer: SimpleMP3Player = new SimpleMP3Player();

public function init() : void
{	
	stage.scaleMode = StageScaleMode.SHOW_ALL;
	stage.align = StageAlign.TOP;
	fscommand("showmenu", "false");
	
	if(DataRegistry.instance.general_start_fullscreen)
		if(!DEBUG)
			stage.displayState = StageDisplayState.FULL_SCREEN;
}

private static var PopupContainer:Canvas;
public static function addPopup(wnd: Canvas) : void
{
	MemoryBox.PopupContainer.addChild(wnd);
	MemoryBox.PopupContainer.visible = true;
}
public static function removePopup() : void
{
	PopupContainer.removeAllChildren();
	PopupContainer.visible = false;
}
private function initPopupCanvas() : void
{
	MemoryBox.PopupContainer = this.PopupCanvas;
}

private static var lastVideoView:standaloneVideoView;
public static function setLastVideoView(video: standaloneVideoView) : void
{
	lastVideoView = video;
}
public static function stopVideoView() : void
{
	if(lastVideoView)
		lastVideoView.stop();
}

private var wnd:Canvas;
private var vid:SmoothVideoDisplay;
private function showIntro(src:String) : void
{
	if(!DEBUG)
		if(DataRegistry.instance.general_show_intro)
		{
				
			wnd = new Canvas();
			vid = new SmoothVideoDisplay();
			
			vid.smoothing = true;
			
			MemoryBox.addPopup(wnd);
			
			
			vid.source = src;
			wnd.addChild(vid);
			
			vid.width = 1000;
			vid.height = 700;
			
			vid.play();
			
			vid.addEventListener(VideoEvent.COMPLETE, video_Complete);
		}
}



private function video_Complete(event: Event) : void
{
	vid.close();
	MemoryBox.removePopup();
}

public static function fillLinks(container: UIComponent, links: Array) : void
{
	for(var ii: int = 0; i < container.numChildren; ++ii)
		container.removeChildAt(ii);	
	
	for(var i: int = 0; i < links.length; ++i)
	{
		if((links[i] as String).substr(0, 4) == "http")
		{
			var link:LinkLabel = new LinkLabel();
			link.styleName = "linkLabel";
			link.width = 130;
			link.text = links[i];
		
			link.url = links[i];
			container.addChild(link);
		}
		else if((links[i] as String).substr(0, 3) == "www")
		{
			var link2:LinkLabel = new LinkLabel();
			link2.styleName = "linkLabel";
			link2.width = 130;
			link2.text = links[i];
			
			link2.url = "http://" + (links[i] as String);
			container.addChild(link2);
		}
		else
		{
			var label:Text = new Text();
			label.styleName = "dynamicText";
			label.text = links[i];
			label.width = 130;
			
			container.addChild(label);
		}
	}
}