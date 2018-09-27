/*
* Copyright © 2017 Cloudveil Technology Inc.
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v. 2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at http://mozilla.org/MPL/2.0/.
*/

﻿using CloudVeilGUI.CustomFormElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CloudVeilGUI.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopupPage : ModalPage
	{
		public PopupPage ()
		{
			InitializeComponent ();
		}
	}
}