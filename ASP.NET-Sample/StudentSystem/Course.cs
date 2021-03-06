﻿//
//  Course.cs
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
using System;
using System.Collections.Generic;

namespace StudentSystem
{
	public class Course
	{
		private string _link;
		private string _name;
		public string link 
		{ 
			get {
				return _link;
			}
			private set {
				_link = value;
			}
		}
		public string name 
		{ 
			get {
				return _name;
			} 
			private set {
				_name = value;
			}
		}
		public List < Lesson > Lessons = new List < Lesson > ();
		public List < Presentation > Presentations = new List < Presentation > ();
		public List < Exam > Exams = new List<Exam> ();
		public Course (string Name, string Link, List < Exam > Exams = null, List < Lesson > Lessons = null, List < Presentation > Presentations = null)
		{
			this.name = Name;
			this.Exams = Exams;
			this.Lessons = Lessons;
			this.Presentations = Presentations;
			this.link = Link;
		}
	}
}

