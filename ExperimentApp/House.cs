﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ExperimentApp
{
    public class House
    {
        private List<Room> Rooms = new List<Room>();
        public int NumberOfClosedWindows
        {
            get
            {
               /* int numberOfClosedWindows = 0;
                foreach (var room in Rooms)
                {
                    numberOfClosedWindows += room.NumberOfClosedWindows;
                } */
                return Rooms.Sum(room => room.NumberOfClosedWindows);
            }
        }

        public void AddRoom(Room room1)
        {
            Rooms.Add(room1);
        }
    }
}