////////////////////////////////////////////////////////////////////////////////
//
//  Copyright (c) 2008 Doug Arthur - dougarthur@gmail.com
//  
//  Permission is hereby granted, free of charge, to any person
//  obtaining a copy of this software and associated documentation
//  files (the "Software"), to deal in the Software without
//  restriction, including without limitation the rights to use,
//  copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the
//  Software is furnished to do so, subject to the following
//  conditions:
//  
//  The above copyright notice and this permission notice shall be
//  included in all copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//  EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//  OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//  HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//  WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//  FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//  OTHER DEALINGS IN THE SOFTWARE.
//
////////////////////////////////////////////////////////////////////////////////

package components
{
	import flash.events.MouseEvent;
	import flash.net.URLRequest;
	import flash.net.navigateToURL;
	
	import mx.controls.Label;
	import mx.utils.ArrayUtil;
	import mx.utils.ObjectUtil;
	
	//--------------------------------------------------------------------------
	//  Styles
	//--------------------------------------------------------------------------
	/**
	 *  Color of the link.
	 *  
	 *  @default 0x0000FF
	 */
	[Style(name="linkColor", type="uint", format="Color", inherit="no")]
	/**
	 *  The text-decoration of the link.
	 *  
	 *  @default "underline"
	 */
	[Style(name="linkDecoration", type="String", inherit="no")]
	/**
	 *  Color of the link when hovering over it.
	 *  
	 *  @default 0x0
	 */
	[Style(name="hoverColor", type="uint", format="Color", inherit="no")]
	/**
	 *  The text-decoration of the link when hovering over it.
	 *  
	 *  @default "normal"
	 */
	[Style(name="hoverDecoration", type="String", inherit="no")]
	
	public class LinkLabel extends Label
	{
		
		//--------------------------------------------------------------------------
		//
		//  Constant Variables
		//
		//--------------------------------------------------------------------------
		
		private const DEFAULT_TEXT_DECORATION:String = "underline";
		private const DEFAULT_COLOR:Number = 0x0000FF;
		private const DEFAULT_HOVER_COLOR:Number = 0x0;
		private const DEFAULT_HOVER_TEXT_DECORATION:String = "normal";
		private const DEFAULT_TARGET:String = "_self";
		private const TARGETS:Array = [
			"_self",
			"_blank",
			"_parent",
			"_top"
		]
		
		//--------------------------------------------------------------------------
		//
		//  Variables
		//
		//--------------------------------------------------------------------------
		
		// PRIVATE
		private var _url:String;
		private var _target:String;
		
		// PUBLIC
		// function to execute from the caller.
		public var callBackFunction:Function;
		
		//--------------------------------------------------------------------------
		//
		//  Constructor
		//
		//--------------------------------------------------------------------------
		
		public function LinkLabel()
		{
			super();
			
			// set the styles for the links 
			setStyle("color", linkColor);
			setStyle("textDecoration", linkDecoration);
			
			// Listener's to simulate a link
			addEventListener(MouseEvent.CLICK, clickEventListener);
			addEventListener(MouseEvent.MOUSE_OVER, mouseOverHandler);
			addEventListener(MouseEvent.MOUSE_OUT, mouseOutHandler);
		}
		
		//--------------------------------------------------------------------------
		//
		//  Overridden methods: Label
		//
		//--------------------------------------------------------------------------
		
		override protected function commitProperties():void
		{
			super.commitProperties();
			
			// make the label simulate a link by adding a hand cursor when hovering.
			useHandCursor = true;
			buttonMode = true;
			mouseChildren = false;
		}
		
		//--------------------------------------------------------------------------
		//
		//  Methods
		//
		//--------------------------------------------------------------------------
		
		public function set url(value:String):void
		{
			if(_url == value)
				return;
			
			_url = value;
			// set a toolTip to show where the link is to.
			toolTip = value;
		}
		
		public function get url():String
		{
			return _url;
		}
		
		public function set target(value:String):void
		{
			if(_target == value)
				return;
			// make sure we have a valud target
			if(ArrayUtil.getItemIndex(value, TARGETS) == -1)
			{
				_target = DEFAULT_TARGET;
				return;
			}
			
			_target = value;
		}
		public function get target():String
		{
			if(_target == null)
				_target = DEFAULT_TARGET;
			
			return _target;
		}
		
		private function get linkDecoration():String
		{
			var result:String = getStyle("linkDecoration");
			if(result == null)
				result = DEFAULT_TEXT_DECORATION;
			
			return result;
		}
		
		private function get linkColor():Number
		{
			var result:Number = getStyle("linkColor");
			if(isNaN(result))
				result = DEFAULT_COLOR;

			return result;
		}
		
		private function get hoverColor():Number
		{
			var result:Number = getStyle("hoverColor");
			if(isNaN(result))
				result = DEFAULT_HOVER_COLOR;
			
			return result;
		}
		
		private function get hoverDecoration():String
		{
			var result:String = getStyle("hoverDecoration");
			if(result == null)
				result = DEFAULT_HOVER_TEXT_DECORATION;
			
			return result;
		}
		
		protected function clickEventListener(event:MouseEvent):void
		{
			if(callBackFunction == null)
				callBackFunction = navigateURL;
			// execute the callback function, passing url/target in an object.
			callBackFunction({url: url, target: target});
		}
		
		private function navigateURL(value:Object):void
		{
			var urlRequest:URLRequest = new URLRequest(value.url);
			navigateToURL(urlRequest, value.target);
		}
		
		//--------------------------------------------------------------------------
		//
		//  Event handlers
		//
		//--------------------------------------------------------------------------
		
		private function mouseOverHandler(event:MouseEvent):void
		{
			setStyle("color", hoverColor);
			setStyle("textDecoration", hoverDecoration);
		}
		
		private function mouseOutHandler(event:MouseEvent):void
		{
			setStyle("color", linkColor);
			setStyle("textDecoration", linkDecoration);
		}
	}
}