9//
//  URL.cs
//
//  Author:
//       Alex Tsvetanov <alex@tsalex.tk>
//
//  Copyright (c) 2017 Alex Tsvetanov
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;

namespace StudentSystem
{
	public class url
	{
		private string _url;
		public string URL
		{
			get {
				if (!IsValid (this._url))
					throw new Exception ("StudenSystem::url::_url is not valid");
				return this._url;
			}
			set {
				if (!IsValid (value))
					throw new Exception ("StudenSystem::url::URL::set is not valid");
				this._url = value;
			}
		}
		public url (string url)
		{
			this.URL = url;
		}
		public bool IsValid ()
		{
			return IsValid (this._url);
		}
		private bool IsValid ()
		{
			return Uri.IsWellFormedUriString (this._url, UriKind.Absolute);
		}
	}
}

