using System;
using System.Collections.Generic;

namespace Aula10
{
    class Personagem
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Hp { get; set; }

        public Personagem(string nome, int nivel, int hp)
        {
            Nome = nome;
            Nivel = nivel;
            Hp = hp;
        }

        public virtual void Atacar()
        {
            Console.WriteLine($"{Nome} atacou!");
        }

        public void Defender()
        {
            Console.WriteLine($"{Nome} se defendeu.");
        }

        public void SubirNivel()
        {
            Nivel++;
            Hp += 10;
            Console.WriteLine($"{Nome} subiu para o nível {Nivel}!");
        }
    }

    class Pokemon : Personagem
    {
        public string Tipo { get; set; }
        public string PoderEspecial { get; set; }

        public Pokemon(string nome, int nivel, int hp, string tipo, string poder)
            : base(nome, nivel, hp)
        {
            Tipo = tipo;
            PoderEspecial = poder;
        }

        public void UsarPoderEspecial()
        {
            Console.WriteLine($"{Nome} usou {PoderEspecial}!");
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nome} ({Tipo}) atacou com força!");
        }
    }

    class Item
    {
        public string Nome { get; set; }
        public string Efeito { get; set; }

        public Item(string nome, string efeito)
        {
            Nome = nome;
            Efeito = efeito;
        }

        public void Usar(Personagem p)
        {
            Console.WriteLine($"Usou {Nome} em {p.Nome}. Efeito: {Efeito}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pikachu = new Pokemon("Pikachu", 5, 80, "Elétrico", "Choque do Trovão");
            Item potion = new Item("Poção", "Recupera 20 de HP");

            pikachu.Atacar();
            pikachu.UsarPoderEspecial();
            potion.Usar(pikachu);
            pikachu.SubirNivel();
        }
    }
}