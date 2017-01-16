
//
//  DataBase.cs
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

using MySql.Data.MySqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Data;

namespace ASP.NETSample
{	
	public class DataBase
	{
		MySqlConnection connection;
		public DataBase ()
		{
			connection = new MySqlConnection ();
			connection.ConnectionString = 
				"Data Source = localhost;" +
				"Initial Catalog=fair;" +
				"User id=root;" +
				"Password=tts2002;";
			connection.Open ();
		}
		//TODO:
	}
}

