////////////////////////////////////////////////////////////////////////////////
//
//  ADOBE SYSTEMS INCORPORATED
//  Copyright 2003-2006 Adobe Systems Incorporated
//  All Rights Reserved.
//
//  NOTICE: Adobe permits you to use, modify, and distribute this file
//  in accordance with the terms of the license agreement accompanying it.
//
////////////////////////////////////////////////////////////////////////////////

package mx.accessibility
{

import mx.controls.LinkButton;
import mx.core.UIComponent;
import mx.core.mx_internal;

use namespace mx_internal;

/**
 *  LinkButtonAccImpl is a subclass of AccessibilityImplementation
 *  which implements accessibility for the LinkButton class.
 */
public class LinkButtonAccImpl extends ButtonAccImpl
{
    include "../core/Version.as";

	//--------------------------------------------------------------------------
	//
	//  Class methods
	//
	//--------------------------------------------------------------------------

	/**
	 *  Enables accessibility in the LinkButton class.
	 * 
	 *  <p>This method is called by application startup code
	 *  that is autogenerated by the MXML compiler.
	 *  Afterwards, when instances of LinkButton are initialized,
	 *  their <code>accessibilityImplementation</code> property
	 *  will be set to an instance of this class.</p>
	 */
	public static function enableAccessibility():void
	{
		LinkButton.createAccessibilityImplementation =
			createAccessibilityImplementation;
	}

	/**
	 *  @private
	 *  Creates a LinkButton's AccessibilityImplementation object.
	 *  This method is called from UIComponent's
	 *  initializeAccessibility() method.
	 */
	mx_internal static function createAccessibilityImplementation(
								component:UIComponent):void
	{
		component.accessibilityImplementation =
			new LinkButtonAccImpl(component);
	}

	//--------------------------------------------------------------------------
	//
	//  Constructor
	//
	//--------------------------------------------------------------------------

	/**
	 *  Constructor.
	 *
	 *  @param master The UIComponent instance that this AccImpl instance
	 *  is making accessible.
	 */
	public function LinkButtonAccImpl(master:UIComponent)
	{
		super(master);
		
		role = 0x1E; // ROLE_SYSTEM_LINK
	}
	
	//--------------------------------------------------------------------------
	//
	//  Overridden methods: AccessibilityImplementation
	//
	//--------------------------------------------------------------------------

	/**
	 *  @private
	 *  IAccessible method for returning the default action
	 *  of the LinkButton, which is Jump.
	 *
	 *  @param childID uint
	 *
	 *  @return DefaultAction String
	 */
	override public function get_accDefaultAction(childID:uint):String
	{
		return "Jump";
	}
}

}
