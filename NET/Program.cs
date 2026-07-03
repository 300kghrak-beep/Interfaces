class Money
{
    public int dollars { get; private set; }
    public int cents { get; private set; }

    public Money(int dollars, int cents)
    {
        if (dollars < 0 || cents < 0)
        {
            throw new ArgumentException("Dollars and cents must be non-negative.");
        }
        if (cents >= 100)
        {
            throw new ArgumentException("Cents must be less than 100.");
        }
        this.dollars = dollars;
        this.cents = cents;
    }

    public static Money operator +(Money money_1, Money money_2)
    {
        if (money_1 == null || money_2 == null)
        {
            return null;
        }

        if (money_1.cents + money_2.cents >= 100)
        {
            return new Money(money_1.dollars + 1 + money_2.dollars, money_1.cents - 100 + money_2.cents);
        }

        return new Money(money_1.dollars + money_2.dollars, money_1.cents + money_2.cents);
    }

    public static Money operator -(Money money_1, Money money_2)
    {
        if (money_1 == null || money_2 == null)
        {
            return null;
        }

        if (money_1.dollars * 100 + money_1.cents < money_2.dollars * 100 + money_2.cents)
        {
            throw new ArgumentException("Resulting money cannot be negative.");
        }

        if (money_1.cents - money_2.cents < 0)
        {
            return new Money(money_1.dollars - money_2.dollars - 1, money_1.cents - money_2.cents + 100);
        }

        return new Money(money_1.dollars - money_2.dollars, money_1.cents - money_2.cents);
    }

    public static bool operator <(Money money_1, Money money_2)
    {
        if (money_1 == null || money_2 == null)
        {
            return false;
        }

        return money_1.dollars * 100 + money_1.cents < money_2.dollars * 100 + money_2.cents;
    }

    public static bool operator <(Money money, int amount)
    {
        if (money == null || amount < 0) return false;

        return money.dollars < amount ? true : false;
    }

    public static bool operator >(Money money, int amount)
    {
        if (money == null || amount < 0) return false;

        return money.dollars > amount
            ? true
            : (money.dollars == amount ? (money.cents > 0 ? true : false) : false);
    }

    public static bool operator >(Money money_1, Money money_2)
    {
        if (money_1 == null || money_2 == null)
        {
            return false;
        }

        return money_1.dollars * 100 + money_1.cents > money_2.dollars * 100 + money_2.cents;
    }

    public static bool operator ==(Money money_1, Money money_2)
    {
        if (money_1 == null && money_2 == null)
        {
            return true;
        }

        if (money_1 == null || money_2 == null)
        {
            return false;
        }

        return money_1.dollars * 100 + money_1.cents == money_2.dollars * 100 + money_2.cents;
    }

    public static bool operator !=(Money money_1, Money money_2)
    {
        if (money_1 == null && money_2 == null)
        {
            return false;
        }

        if (money_1 == null || money_2 == null)
        {
            return true;
        }

        return money_1.dollars * 100 + money_1.cents != money_2.dollars * 100 + money_2.cents;
    }

    public static Money operator ++(Money money)
    {
        if (money == null)
        {
            return null;
        }

        Money newMoney = new Money(
            money.cents + 1 == 100 ? money.dollars + 1 : money.dollars,
            money.cents + 1 == 100 ? money.cents - 100 : money.cents + 1);

        return newMoney;
    }

    public static Money operator --(Money money)
    {
        if (money == null)
        {
            return null;
        }

        if (money.dollars == 0 && money.cents == 0)
        {
            throw new ArgumentException("Resulting money cannot be negative.");
        }

        if (money.dollars == 0 && money.cents == 1)
        {
            return new Money(0, 0);
        }

        Money newMoney = new Money(
            money.cents - 1 < 0 ? money.dollars - 1 : money.dollars,
            money.cents - 1 < 0 ? money.cents + 99 : money.cents - 1);

        return newMoney;
    }

    public override string ToString()
    {
        return $"{dollars}.{cents:D2}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Money money)
        {
            return false;
        }

        return dollars == money.dollars && cents == money.cents;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(dollars, cents);
    }
}

class Program
{
    static void Main()
    {
    }
}