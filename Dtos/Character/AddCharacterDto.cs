using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.rpg.Models;

namespace dotnet.rpg.Dtos.Character
{
    public class AddCharacterDto
    {

        public string? Name { get; set; } = "Frodo";
        // add question mark can make the nullable error go away ro assign a new new to it
        public int HitPoint { get; set; } = 100;

        public int Strength { get; set; }

        public int Defense { get; set; } = 10;

        public int Intelligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}