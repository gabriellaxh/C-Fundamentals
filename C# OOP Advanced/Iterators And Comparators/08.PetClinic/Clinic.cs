using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.PetClinic
{
    public class Clinic : IEnumerable<Pet>
    {
        public string Name { get; set; }
        public Pet[] pets { get; set; }
        private int rooms { get; set; }

        public Clinic(string name, int rooms)
        {
            this.Name = name;
            this.Rooms = rooms;
            this.pets = new Pet[this.Rooms];
        }

        public int Rooms
        {
            get => this.rooms;
            private set
            {
                if (value % 2 != 0)
                    this.rooms = value;
                else
                    throw new InvalidOperationException("Invalid Operation!");
            }
        }

        public bool AddPet(Pet pet)
        {
            int roomNum = this.Rooms / 2;

            if (this.pets[roomNum] == null)
            {
                this.pets[roomNum] = pet;
                return true;
            }

            for (int i = 1; i < roomNum; i++)
            {
                roomNum -= i;
                if (this.pets[roomNum] == null)
                {
                    this.pets[roomNum] = pet;
                    return true;
                }

                roomNum += 2 * i;
                if (this.pets[roomNum] == null)
                {
                    this.pets[roomNum] = pet;
                    return true;
                }

                roomNum = this.Rooms / 2;
            }

            return false;
        }

        public bool ReleasePet()
        {
            int roomNum = this.Rooms / 2;

            if (this.pets.Any(x => x != null))
            {
                for (int i = roomNum; i < this.Rooms - 1; i++)
                {
                    if (this.pets[roomNum] != null)
                    {
                        this.pets[roomNum] = null;
                        return true;
                    }
                }

                for (int i = 0; i < roomNum; i++)
                {
                    if (this.pets[roomNum] != null)
                    {
                        this.pets[roomNum] = null;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool HasEmptyRooms()
        {
            return this.pets.Any(x => x == null);
        }

        public void Print()
        {
            foreach (var room in this.pets)
            {
                if (room == null)
                    Console.WriteLine("Room empty");
                else
                    Console.WriteLine(room.ToString());
            }
        }

        public void Print(int room)
        {
            if (this.pets[room-1] == null)
                Console.WriteLine("Room empty");
            else
                Console.WriteLine(this.pets[room-1].ToString());
        }

        public IEnumerator<Pet> GetEnumerator()
        {
            foreach (var room in this.pets)
            {
               yield return room;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
