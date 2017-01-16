//
//  Certificate.cs
//
//  Author:
//       Gizi Geneva <g.geneva94@gmail.com>
//
//  Copyright (c) 2017 Gizi Geneva
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


class Certificate
{

	//Fields

	private string person_name;
	private string course_name;
	private int score;
	private DateTime date;


	// Constructor

	public Certificate(string person_name, string Course_name, int score, DateTime date)
	{
		this.Person_Name = person_name;
		this.Course_Name = course_name;
		this.Score = score;
		this.Date = date.ToString ();
	}

	//Properties

	public string Person_Name
	{
		get
		{
			return this.person_name;
		}
		set
		{
			this.person_name = value;
		}
	}

	public string Course_Name
	{
		get
		{
			return this.person_name;
		}
		set
		{
			this.person_name = value;
		}
	}

	public int Score
	{
		get
		{
			return this.score;
		}
		set
		{
			this.score = value;
		}
	}

	public string Date
	{
		get
		{
			return date.ToString();
		}

		set
		{
			DateTime.TryParse(value, out date);
		}
	}



}

