//
//  SudentSystemClient.cs
//
//  Author:
//       Alex Tsvetanov <alex@tsalex.tk>
//
//  Copyright (c) 2016 Alex Tsvetanov
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
using System.Collections.Generic;

namespace StudentSystem
{
	class Client
	{
		static public Dictionary <string, User> Users = new Dictionary<string, User> ();
		static public List <Track> Tracks = new List<Track> ();
		static Client ()
		{
			Tracks.Add (new Track (
									"C#", 
									"./courses/cs.aspx",
									new List<Course> () {
										new Course ("Intro", "./cs/intro.aspx")
									}
			                      )
			           );
		}
	}
}