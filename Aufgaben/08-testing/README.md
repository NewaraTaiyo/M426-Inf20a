# Testing

## Aufgaben

### Bakery

In der Klasse `CakeShop` (`Bakery/CakeShop.cs`) gibt es eine Methode
namens `Create()` mit einem entsprechenden Testfall
(`Testing.Tests/Bakery/CakeShopTest.cs`). 

Im `CakeShop` wird anhand der Benutzereingabe Zutaten für den gewählten Kuchen auf eine
externe Schnittstelle geschrieben. Hierfür wird entsprechend ein Zeitstempel und die 
Message geschrieben. 

1. Um diese Methode zu Testen, benötigen sie einen Fake.
2. Implementieren sie eine Klasse `FakeCakeLogger.cs`, welche das Interface `ICakeLogger` implementiert.
3. Überlegen sie sich einen Weg, wie die korrekte Reihenfolge geloggt werden könnte. (Tipp: Sie können die
Zeitstempel bei der Überprüfung ignorieren) 
4. Zusatz: Überlegen sie sich einen Weg, wie sie auch den Zeitstempel testen könnten.

### Lotto 
In dieser Aufgabe ist ein Teilausschnitt aus unserem Lott-Projekt implementiert. Die Berechnung für 
die Gewinne ist hier etwas anders als im Projekt. Im Fokus liegt hier die Klasse `LottoCalculator.cs`.
Diese Klasse hat verschiedene externe Abhängigkeiten, welche teilweise wiederum Abhängigkeiten haben.
Wir wollen aber nur unsere Klasse `LottoCalculator` testen.

1. Installieren sie das Nuget-Packet `Moq`. Anleitung: https://learn.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-in-visual-studio
2. Bekommen sie einen Überblick über das Installierte Packet. https://docs.educationsmediagroup.com/unit-testing-csharp/moq/quick-glance-at-moq
3. Instanzieren sie die Mocks und geben sie diese im Konstruktor für die Klasse `LottoCalculator` im Test mit.
4. Überlegen sie sich Valide Testfälle, setzten sie die Mocks auf und verifizieren sie.