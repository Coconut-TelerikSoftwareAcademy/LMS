//
//  Presentation.cs
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
	public enum Licenses
	{
		AgainstDRM="Against DRM",
		CC0PublicDomain="CC0 Public Domain",
		CreativeCommons="Creative Commons",
		DesignScienceLicense="Design Science License",
		FreeArtLicense="Free Art License",
		FreeBSDDocumentationLicense="FreeBSD Documentation License",
		GNUFreeDocumentationLicense="GNU Free Documentation License",
		GNULesserGeneralPublicLicense="GNU Lesser General Public License",
		GNUGeneralPublicLicense="GNU General Public License",
		MirOS="MirOS Licence",
		MIT="MIT License",
		Unlicensed="Unlicensed"
	}
	public class Presentation
	{
		public readonly url URL;
		public readonly string Author;
		public readonly string Webpage;
		public readonly string Organization;
		public readonly string Title;
		public readonly Licenses License;

		public Presentation (url URL, Licenses License = Licenses.Unlicensed, string Author = "No Author", string Webpage = "", string Organization = "No Organization", string Title = "Untitled")
		{
			this.URL = URL;
			this.Author = Author;
			this.Webpage = Webpage;
			this.Organization = Organization;
			this.Title = Title;
			this.License = License;
		}
	}
}

