﻿using Common;

namespace MatchAnimals;

public static class Emojis
{
    public static Emoji[] Animals =>
    [
        new("Dog", "🐶"),
        new("Cat", "🐱"),
        new("Mouse", "🐭"),
        new("Hamster", "🐹"),
        new("Rabbit", "🐰"),
        new("Frog", "🐸"),
        new("Tiger", "🐯"),
        new("Koala", "🐨"),
        new("Bear", "🐻"),
        new("Panda", "🐼"),
        new("Pig", "🐷"),
        new("Monkey", "🐵"),
        new("Chicken", "🐔"),
        new("Penguin", "🐧"),
        new("Bird", "🐦"),
        new("Chick", "🐤"),
        new("Hatching Chick", "🐣"),
        new("Duck", "🦆"),
        new("Swan", "🦢"),
        new("Owl", "🦉"),
        new("Bat", "🦇"),
        new("Unicorn", "🦄"),
        new("Horse", "🐴"),
        new("Kangaroo", "🦘"),
        new("Badger", "🦡"),
        new("Squid", "🦑"),
        new("Octopus", "🐙"),
        new("Spiral Shell", "🐚"),
        new("Tropical Fish", "🐠"),
        new("Fish", "🐟"),
        new("Blowfish", "🐡"),
        new("Shark", "🦈"),
        new("Dolphin", "🐬"),
        new("Spouting Whale", "🐳"),
        new("Whale", "🐋"),
        new("Zebra", "🦓"),
        new("Giraffe", "🦒"),
        new("Elephant", "🐘"),
        new("Mammoth", "🦣"),
        new("Rhinoceros", "🦏"),
        new("Hippopotamus", "🦛"),
        new("Gorilla", "🦍"),
        new("Orangutan", "🦧"),
        new("Camel", "🐪"),
        new("Two-Hump Camel", "🐫"),
        new("Llama", "🦙"),
        new("Lobster", "🦞"),
        new("Shrimp", "🦐"),
        new("Snake", "🐍"),
        new("Lizard", "🦎"),
        new("Turtle", "🐢"),
        new("Sauropod", "🦕"),
        new("T-Rex", "🦖"),
        new("Dragon", "🐉")
    ];

    public static Emoji[] GetAnimalEmojis(int count)
        => Randomizer<Emoji>.GetRandomItems(Animals, count);
}