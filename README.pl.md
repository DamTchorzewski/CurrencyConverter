# Kalkulator Walut

**Kalkulator Walut** to aplikacja Windows Forms s³u¿¹ca jako kalkulator konwersji walut. Projekt zosta³ opracowany zgodnie z wymogami specyfikacji, oferuj¹c intuicyjny interfejs u¿ytkownika oraz funkcjonalnoœci takie jak dynamiczne etykiety walut, obs³uga niestandardowej waluty i przeliczanie wartoœci na podstawie predefiniowanych kursów wymiany.

---

## Funkcje aplikacji

1. **Wprowadzanie wartoœci waluty:**
   - U¿ytkownicy mog¹ wprowadzaæ kwotê waluty Ÿród³owej w polu tekstowym.

2. **Sterowanie za pomoc¹ paska przewijania:**
   - Wartoœæ waluty Ÿród³owej mo¿na ustawiæ równie¿ za pomoc¹ poziomego paska przewijania (hScrollBar).

3. **Przeliczanie walut:**
   - Aplikacja konwertuje wartoœæ waluty Ÿród³owej na docelow¹, wykorzystuj¹c zdefiniowane kursy wymiany.
   - Wybór waluty Ÿród³owej i docelowej odbywa siê za pomoc¹ przycisków radiowych (RadioButton).

4. **Waluta niestandardowa:**
   - Niestandardowa waluta o nazwie "DT" (pochodz¹cej od inicja³ów autora), której kurs wymiany wynosi 722,06 (zgodnie z numerem indeksu autora).

5. **Dynamiczne etykiety:**
   - Nazwy walut w etykietach zmieniaj¹ siê dynamicznie na podstawie wyboru u¿ytkownika.

6. **Obs³uga b³êdów:**
   - Walidacja danych liczbowych w polu tekstowym, aby unikn¹æ b³êdów.
   - Wyœwietlanie komunikatów o b³êdach w przypadku nieprawid³owego wprowadzenia danych.

7. **Predefiniowane kursy wymiany:**
   - Kursy walut s¹ zapisane w tablicy, co zapewnia szybkie przeliczanie i ³atw¹ modyfikacjê.

---

## Zaimplementowane zdarzenia

1. **Zmiana tekstu w polu wejœciowym (`TextBox.TextChanged`):**
   - Waliduje wprowadzone dane i wywo³uje funkcjê przeliczania waluty docelowej.

2. **Zmiana wartoœci paska przewijania (`HScrollBar.ValueChanged`):**
   - Synchronizuje wartoœæ paska przewijania z polem tekstowym.

3. **Zmiana waluty (`RadioButton.CheckedChanged`):**
   - Aktualizuje etykiety waluty Ÿród³owej i docelowej oraz ponownie przelicza wartoœci walut.

4. **Automatyczne przeliczanie waluty:**
   - Wywo³ywane przy ka¿dej zmianie wartoœci Ÿród³owej lub wyborze innej waluty.

---

## Ograniczenia i mo¿liwe usprawnienia

- **Interfejs u¿ytkownika:**
  - Interfejs graficzny móg³by zostaæ unowoczeœniony w celu poprawy estetyki i lepszej u¿ytecznoœci.

- **Brak obs³ugi jêzyków:**
  - Obecnie aplikacja obs³uguje jedynie etykiety i komunikaty w jêzyku angielskim.

- **Dynamiczne kursy wymiany:**
  - Kursy s¹ statycznie zakodowane i nie s¹ aktualizowane w czasie rzeczywistym.

---

## Samoocena projektu

Projekt w pe³ni realizuje za³o¿enia specyfikacji, a wszystkie wymagane funkcjonalnoœci zosta³y zaimplementowane. Dodatkowo aplikacja zawiera obs³ugê b³êdów, integracjê z paskiem przewijania oraz dynamicznie zmieniaj¹ce siê etykiety walut. Wprowadzenie waluty niestandardowej równie¿ zosta³o zrealizowane zgodnie z za³o¿eniami.

### **Sugerowana ocena: 5/5**  
Projekt spe³nia wszystkie wymagania i dzia³a zgodnie z oczekiwaniami, co uzasadnia najwy¿sz¹ ocenê.

---

## Instrukcja uruchomienia

1. Otwórz projekt w œrodowisku Visual Studio.
2. Wybierz opcjê „Build” i uruchom aplikacjê.
3. Korzystaj z interfejsu graficznego do testowania funkcjonalnoœci konwersji walut.

---

## Autor
[Damian Tchorzewski 72206]
