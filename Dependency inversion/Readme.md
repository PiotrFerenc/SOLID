#Interface segregatrion
##Segregacja interfejsów

Klient nie powinien zostać zmuszony do korzystania z metod których nie potrzebuje. Tworzymy małe interface co pomoże w łatwiejszej refaktoryzacji.

Na ogół drukarki mają możliwość drukawania, skanowania i wysyłania faxów. Na rynku dostępne są różne konfiguracje tych sprzętów.
Wszystkie funkcje tych urządzeń zostały podzielone na  osobne interface:
```c#
IFax
IPrinter
IScanner
```
Nasza drukarka która wysyła fax i drukuje potrzebuje tylko tych dwóch interfaców. 

```c#
HpPrinter : IPrinter, IFax 
```
