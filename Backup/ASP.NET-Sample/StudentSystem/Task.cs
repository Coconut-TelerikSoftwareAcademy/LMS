//
//  Task.cs
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
	public class ITask
	{
		public string name { get; private set; }
		public string description { get; private set; }
		public string author { get; private set; }
	}

	public interface ITest
	{
		float Points (string program_output);
	}

	public class PracticalTask : ITask
	{
		List < Test > Tests = new List<Test> ();

		class Test : ITest
		{
			string stdin;
			string stdout;
			Func<string, string, float> CurrentComparer = null;
			public float Points (string program_output)
			{
				return CurrentComparer (stdout, program_output) * 1.0f;
			}
		}

		public PracticalTask ()
		{
		}
	}

	public class TheoryTask : ITask
	{
		Test Tests;

		class Test : ITest
		{
			string correct_answers;

			public float Points (string program_output)
			{
				bool comparison = (correct_answers == program_output);
				int intc = (comparison == true)?1:0;
				return (float)(intc);
			}
		}

		public TheoryTask ()
		{
		}
	}
}

