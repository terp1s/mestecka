using System;
using System.Collections.Generic;

namespace testik
{
    class Node
    {
        public int Hodnota { get; set; }

        public enum Stav { N,O,U}
        public Stav stav = Stav.N;  

        public Node(int hodnota)
        {
            Hodnota = hodnota;
        }

        
    }
    class Edge
    {
        public int Delka { get; set; }
        public List<Node> Nody { get; set; }

        public Edge(int delka, List<Node> nody)
        {
            Delka = delka;
            Nody = nody;
        }
        
    }
    class Graph
    {
        public List<Edge> Hrany = new List<Edge>();
        public List<Node> Nody = new List<Node>();

        public void Navsteva(List<Node> list)
        {

        }

        public void Prochazeni(Node start, Node cil)
        {
            List<Node> fauxFronta = new List<Node>();
            
            while(fauxFronta.Count != 0)
            {

            }
        }

        public void NejkratsiCesta()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
