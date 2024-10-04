using System;

enum Rating
{
    Good,      // 0
    Great,     // 1
    Excellent   // 2
}

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;
}