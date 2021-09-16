#Liskov substitution principle
##Zasada podstawienia Liskov

Klasa bazowa powinna rozszerzać możliwości klasy potomnej i nie wpływać na funkcjonalności które były już tam wcześniej.

```c#
var Penguin = new Penguin();
var Seagull = new Seagull();
var Pigeon = new Pigeon();

Penguin.Fly();
Seagull.Fly();

Pigeon.Fly();//<-- Błąd. wiemy że pingwiny nie latają

```

Jak możemy sobie z tym poradzić? Wydzielić funkcjonalność do interface i dodać tylko do ptaków które latają
```c#
var penguin = new Penguin();
var seagull = new Seagull();
var pigeon = new Pigeon();

pigeon.Fly();
seagull.Fly();

penguin.Eat(); //<-- dostępna tylko jedna metoda
```