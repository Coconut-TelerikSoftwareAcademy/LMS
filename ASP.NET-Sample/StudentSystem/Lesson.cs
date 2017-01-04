//
//  Lesson.cs
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
	public class Lesson
	{
		private Video _video;
		public readonly int bonus_points;
		public Video video
		{
			get {
				return this,_video;
			}
			private set {
				if (!url.isValid (value.URL))
					throw new ArgumentNullException ("Video's url is not valid");
				this._video = value;
			}
		}
		public Lesson (int bonus)
		{
			this.bonus_points = bonus;
		}
	}
}

