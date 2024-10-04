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

    // Constructor that takes parameters
    public Dog(string name, float age, string owner, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }

    // Override the ToString() method
    public override string ToString()
    {
        return $"Dog Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}";
    }
}
