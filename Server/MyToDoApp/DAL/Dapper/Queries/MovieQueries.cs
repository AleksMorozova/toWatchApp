﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.DAL.Dapper.Queries
{
    public static class MovieQueries
    {
        public static string getAll = "SELECT * FROM Movies;";
        public static string getSingle = "SELECT * FROM Movies WHERE ID = @ID;";
        public static string getAllActive = "SELECT * FROM Movies WHERE IsWatched = 0;";
        public static string insertQuery = @"INSERT INTO [Movies]([Title], [Description], [Link], [IsWatched], [ID]) VALUES (@Title, @Description, @Link, @isWatched, @ID)";
        public static string updateQuery = @"UPDATE Movies set Title = @Title, Description = @Description, Link = @Link, IsWatched = @IsWatched where ID = @ID";
    }
}
