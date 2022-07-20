using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Piece> pieces = new List<Piece>();

            int piecesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < piecesCount; i++)
            {
                string[] tokens = Console.ReadLine().Split("|");

                var newPiece = new Piece(tokens[0], tokens[1], tokens[2]);
                pieces.Add(newPiece);
            }

            string[] command = Console.ReadLine().Split("|");
            while (command[0] != "Stop")
            {
                switch (command[0])
                {
                    case "Add":
                        AddPiece(pieces, command);
                        break;
                    case "Remove":
                        RemovePiece(pieces, command);
                        break;
                    case "ChangeKey":
                        ChangeKey(pieces, command);
                        break;
                }
                command = Console.ReadLine().Split("|");
            }
            Console.WriteLine(string.Join(Environment.NewLine, pieces));
        }

        private static void ChangeKey(List<Piece> pieces, string[] command)
        {
            string currPieceName = command[1];
            string newKey = command[2];
            if (pieces.Any(piece => piece.Name == currPieceName))
            {
                var pieceToEdit = pieces.Find(piece => piece.Name == currPieceName);
                pieceToEdit.Key = newKey;

                Console.WriteLine($"Changed the key of {currPieceName} to {newKey}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {currPieceName} does not exist in the collection.");
            }
        }

        private static void RemovePiece(List<Piece> pieces, string[] command)
        {
            string currPieceName = command[1];
            if (pieces.Any(piece => piece.Name == currPieceName))
            {
                var pieceToRemove = pieces.Find(piece => piece.Name == currPieceName);
                pieces.Remove(pieceToRemove);
                Console.WriteLine($"Successfully removed {currPieceName}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {currPieceName} does not exist in the collection.");
            }
        }

        private static void AddPiece(List<Piece> pieces, string[] command)
        {
            string currPieceName = command[1];
            string currComposerName = command[2];
            string currKey = command[3];
            if (!pieces.Any(piece => piece.Name == currPieceName))
            {
                var newPiece = new Piece(currPieceName, currComposerName, currKey);
                pieces.Add(newPiece);
                Console.WriteLine($"{currPieceName} by {currComposerName} in {currKey} added to the collection!");
            }
            else
            {
                Console.WriteLine($"{currPieceName} is already in the collection!");
            }
        }
    }

    class Piece
    {
        public Piece(string name, string composer, string key)
        {
            Name = name;
            Composer = composer;
            Key = key;
        }

        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }

        public override string ToString()
        {
            return $"{Name} -> Composer: {Composer}, Key: {Key}";
        }
    }
}
