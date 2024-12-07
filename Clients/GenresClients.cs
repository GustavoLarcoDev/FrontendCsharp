using System;
using GameStore.FrontEnd.Models;

namespace GameStore.FrontEnd.Clients;

public class GenresClients
{
    private readonly Genre[] genres =
    [
      new(){
        Id= 1,
        Name = "Fighting"
      },
      new(){
        Id= 2,
        Name = "Racing"
      },
      new(){
        Id= 3,
        Name = "Flying"
      },
      new(){
        Id= 4,
        Name = "Shooter"
      },
      new(){
        Id= 5,
        Name = "Kids and family"
      },
    ];
    public Genre[] GetGenres() => genres;
}
